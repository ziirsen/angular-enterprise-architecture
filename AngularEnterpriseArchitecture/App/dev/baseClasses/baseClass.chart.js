'use strict';

(function (ag) {
    ag.service('ChartClass', [function () {

        function Chart(container) {
            this.container = container;
        }

        Chart.prototype.setSeriesData = function (series) {
            this.series = series;
        };

        Chart.prototype.getSeriesData = function () {
            return this.series || [];
        };

        Chart.prototype.init = function () {
            Highcharts.chart(this.container, {
                title: {
                    text: 'Solar Employment Growth by Sector, 2010-2016'
                },

                subtitle: {
                    text: 'Source: thesolarfoundation.com'
                },

                yAxis: {
                    title: {
                        text: 'Number of Employees'
                    }
                },
                legend: {
                    layout: 'vertical',
                    align: 'right',
                    verticalAlign: 'middle'
                },
                plotOptions: {
                    series: {
                        pointStart: 2010
                    }
                },
                series: this.getSeriesData()
            });
        };

        // Expose class
        this.Base = Chart;

    }]);
})(app.lazy);
