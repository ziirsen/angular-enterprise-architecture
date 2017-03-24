'use strict';

angular.module('page.dashboard')
    .config(function ($routeProvider) {

        $routeProvider
            .when('/dashboard', {
                templateUrl: _global.paths.pages + '/dashboard/page.dashboard.html?v=' + _global.appVersion,
                resolve: {
                    load: ['$q', function ($q) {
                        var def = $q.defer();

                        // Dependency inject modules required for page to work
                        require([
                            'Services/service.data',
                            'Components/headline/directive.headline',
                            'Components/statusFeed/directive.statusFeed'
                        ],
                        function () {
                            // Dependency inject the page controller
                            require(['Pages/dashboard/controller.dashboard'], function () {
                                def.resolve();
                            });
                        });

                        return def.promise;
                    }]
                }
            });
});