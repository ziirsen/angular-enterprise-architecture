'use strict';

var _global = {
    paths: {
        base: '/App/dev/',
        baseClasses: '/App/dev/baseClasses',
        pages: '/App/dev/pages',
        libs: '/App/dev/libs',
        components: '/App/dev/components',
        services: '/App/dev/services'
    },
    appVersion: '2017.1' // for cache busting
};

/*
    Configure requireJs
----------------------------------------*/
(function (req) {
    req.config({
        urlArgs: 'v=' + _global.appVersion,
        baseUrl: '/App/dev',
        paths: {
            BaseClasses: _global.paths.baseClasses,
            Components: _global.paths.components,
            Pages: _global.paths.pages,
            Libs: _global.paths.libs,
            Services: _global.paths.services,
        },
        //packages: ['baseClasses'],
        waitSeconds: 0
    });

    // Load all base class's
    //require(['baseClasses']);
    require(['BaseClasses/class.helper']);

})(requirejs);

/*
    Configure angularJs
----------------------------------------*/
// Define our areas
angular.module('enterpriseApp.pages', []);

// Define our main application
var app = angular.module('enterpriseApp', [
    'ngRoute',
    'angular-cache',

    'enterpriseApp.pages'
]);

(function (ag) {
    ag.config(['$controllerProvider', '$compileProvider', '$filterProvider', '$provide', '$routeProvider', '$locationProvider',
        function ($controllerProvider, $compileProvider, $filterProvider, $provide, $routeProvider, $locationProvider) {

            $locationProvider.html5Mode(true);

            ag.lazy = {
                controller: $controllerProvider.register,
                directive: $compileProvider.directive,
                filter: $filterProvider.register,
                factory: $provide.factory,
                service: $provide.service,
                //animation: $animationProvider.register
            };

            // Fallback route
            $routeProvider
                .otherwise({
                    redirectTo: '/',
                    templateUrl: _global.paths.pages + '/home/page.home.html?v=' + _global.appVersion
                });
        }]);
})(app);