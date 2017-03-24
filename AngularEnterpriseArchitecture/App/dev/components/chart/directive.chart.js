'use strict';

(function (ag) {
    ag.directive('aeaChart', ['DataService', 'ClassHelper', 'ChartClass', function (DataService, ClassHelper, ChartClass) {

        /*  Dependency inject third-party libs
        ------------------------------------------- */
        require(['Libs/highcharts']);
        // ....

        /*  Directive implementation
        ------------------------------------------- */
        return {
            scope: {
                delay: '=aeaChart'
            },
            restrict: 'AE',
            replace: true,
            templateUrl: _global.paths.components + '/chart/partial.chart.html?v=' + _global.appVersion,
            link: function ($scope, $element, $attr) {

                // Scope variables
                $scope.chartId = $scope.$id;

                // Class implementation
                function MiniChart(selectorId) {
                    ChartClass.Base.call(this, selectorId);
                }

                ClassHelper.Inherit(MiniChart, ChartClass.Base)

                // Private methods
                function renderChart(selectorId, data) {

                    console.info(":: Render chart with delay:", $scope.delay);

                    var chart = new MiniChart(selectorId);
                    chart.setSeriesData(data);
                    chart.init();
                }

                // Listeners
                $scope.$on('$destroy', function () {
                    console.debug('** Event triggered: "$destroy"');
                });

                // Init
                DataService.getDataWithDelay($scope.delay).then(function (data) {

                    console.log(">> Got data from service: ", data);

                    // Render chart
                    if (!$scope.$$destroyed)
                        renderChart('chart' + $scope.chartId, data);
                });
            }
        }
    }]);
})(app.lazy);