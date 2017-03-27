'use strict';

(function (ag) {
    ag.directive('aeaMiniChart', ['DataService', 'ClassHelper', 'ChartClass', function (DataService, ClassHelper, ChartClass) {

        /*  
            Dependency inject third-party libs
        */
        //require(['Libs/highcharts']);

        /*  
            Class implementation
        */
        function MiniChart(selectorId) {
            ChartClass.Base.call(this, selectorId);
        }

        ClassHelper.Inherit(MiniChart, ChartClass.Base);

        // Some specific method for this chart component
        MiniChart.prototype.hideChart = function () {
            $('#' + this.container).hide();
        };

        /*  
            Directive implementation
        */
        return {
            scope: {
                delay: '=aeaMiniChart'
            },
            restrict: 'AE',
            replace: true,
            templateUrl: _global.paths.components + '/miniChart/partial.miniChart.html?v=' + _global.appVersion,
            link: function ($scope, $element, $attr) {

                // Variables
                var chart;

                // Scope variables
                $scope.chartId = $scope.$id;
                
                // Private methods
                function renderChart(selectorId, data) {
                    console.info(":: Render chart with delay:", $scope.delay);

                    if (chart)
                        chart = null;

                    chart = new MiniChart(selectorId);
                    chart.setSeriesData(data);
                    chart.init();
                    //chart.hideChart();
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
})(app);