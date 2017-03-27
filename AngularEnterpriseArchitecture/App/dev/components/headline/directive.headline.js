'use strict';

(function (ag) {
    ag.directive('aeaHeadline', [function () {
        return {
            scope: {
                headline: '@aeaHeadline',
                eventId: '@'
            },
            restrict: 'AE',
            replace: true,
            templateUrl: _global.paths.components + '/headline/partial.headline.html?v=' + _global.appVersion,
            link: function ($scope, $element, $attr) {

                // Listeners
                $scope.$on('onSetTitle', function (e, data) {
                    if (!data.id) {
                        $scope.headline = data.title;
                    }
                    else if (data.id === $scope.eventId) {
                        $scope.headline = data.title;
                    }
                });
            }
        }
    }]);
})(app);