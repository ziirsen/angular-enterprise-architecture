/// <binding BeforeBuild='job:pre-build' AfterBuild='job:after-build' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var minify = require('gulp-minify');
var clean = require('gulp-clean');
var replace = require('gulp-replace');

gulp.task('minify:js', function () {
    gulp.src('App/dev/**/*.js')
      .pipe(minify({
          ext: {
              src: '-debug.js',
              min: '.js'
          },
          //exclude: ['tasks'],
          ignoreFiles: ['module.config.js'] // ignore files minified by .NET bundleConfig
      }))
      .pipe(gulp.dest('App/prod'));
});

gulp.task('copy:html', function () {
    gulp.src('App/dev/**/*.html')
      .pipe(gulp.dest('App/prod'));
});

gulp.task('modify:paths', function () {
    gulp.src(['App/prod/app.js'])
      .pipe(replace('App/dev/', 'App/prod/'))
      //.pipe(clean())
      .pipe(gulp.dest('App/prod'));
});

gulp.task('clean:files', function () {
    gulp.src('App/prod/**/*-debug.js', { read: false })
      .pipe(clean());
});

gulp.task('clean:outputFolder', function () {
    gulp.src('App/prod/**/*.js', { read: false })
      .pipe(clean());
});


// Combined tasts
gulp.task('job:pre-build', ['clean:outputFolder', 'minify:js', 'copy:html']);
gulp.task('job:after-build', ['clean:files', 'modify:paths']);