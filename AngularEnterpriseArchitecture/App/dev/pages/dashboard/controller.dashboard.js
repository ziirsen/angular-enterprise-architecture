'use strict';

(function(ag) {
    ag.controller('DashboardController', ['$scope', 'DataService', function ($scope, DataService) {

        //console.log("DashboardController: get data .... ");
        //DataService.getDataById(2);

        $scope.name = 'Overview';

        $scope.eventAll = function () {
            $scope.$broadcast('onSetTitle', { title: 'Event all' });
        };

        $scope.eventById = function (id) {
            $scope.$broadcast('onSetTitle', { id: id, title: 'Event by id: ' + id });
        };
    }]);
})(app.lazy);