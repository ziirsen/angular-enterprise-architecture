'use strict';

(function(ag) {
    ag.module('enterpriseApp.pages')
        .config(['$routeProvider', function ($routeProvider) {

            $routeProvider
                .when('/charts', {
                    templateUrl: _global.paths.pages + '/charts/page.chart.html?v=' + _global.appVersion,
                    //resolve: {
                    //    load: ['$q', function ($q) {
                    //        var def = $q.defer();

                    //        // Dependency inject components required for page to work
                    //        require([
                    //            'BaseClasses/baseClass.chart',
                    //            'Services/service.data',
                    //            'Components/headline/directive.headline',
                    //            'Components/miniChart/directive.miniChart'
                    //        ],
                    //        function () {
                    //            // Dependency inject the page controller
                    //            require(['Pages/charts/controller.chart'], function () {
                    //                def.resolve();
                    //            });
                    //        });

                    //        return def.promise;
                    //    }]
                    //}
                });
        }]);
})(angular);