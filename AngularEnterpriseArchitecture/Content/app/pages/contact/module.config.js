'use strict';

angular.module('page.contact')
    .config(function ($routeProvider) {

        $routeProvider
            .when('/contact', {
                templateUrl: _global.paths.pages + '/contact/page.contact.html?v=' + _global.appVersion,
                resolve: {
                    load: ['$q', function ($q) {
                        var def = $q.defer();

                        // Dependency inject components required for page to work
                        require([
                            'Components/headline/directive.headline'
                        ],
                        function () {
                            // Dependency inject the page controller
                            require(['Pages/contact/controller.contact'], function () {
                                def.resolve();
                            });
                        });

                        return def.promise;
                    }]
                }
        });
});