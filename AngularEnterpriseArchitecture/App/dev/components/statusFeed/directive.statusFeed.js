'use strict';

(function (ag) {
    ag.directive('aeaStatusFeed', ['DataService', function (DataService) {
        return {
            scope: {},
            restrict: 'AE',
            replace: true,
            transclude: true,
            templateUrl: _global.paths.components + '/statusFeed/partial.statusFeed.html?v=' + _global.appVersion,
            link: function ($scope, $element, $attr) {

                // Scope variables
                $scope.feed = [
                    { value: 'Entry 1' },
                    { value: 'Entry 2' },
                    { value: 'Entry 3' },
                    { value: 'Entry 4' }
                ];

                // Init  
                DataService.getDataById(1);
            }
        }
    }]);
})(app.lazy);