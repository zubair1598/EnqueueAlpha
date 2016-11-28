var EnqueueApp = angular.module('EnqueueApp', [
        // Angular modules 
        //'ngRoute'

        // Custom modules 

        // 3rd Party Modules

]);

EnqueueApp.controller('EnqueueController', function ($scope, enqueueService) {
   
    getStudents();
    function getStudents() {
       
        enqueueService.getStudents()
            .success(function (studs)
            {
                $scope.data = {
                    repeatSelect: null,
                    availableOptions: studs
                };
            })
            .error(function (error) {
                $scope.status = 'Unable to load customer data: ' + error.message;
                console.log($scope.status);
            });
    }

    $scope.AddAppointment = function (appointment) {
        debugger;
        enqueueService.AddAppointment(appointment).success(function (data, status, headers, config) {
            debugger;
            $scope.Token = data;
                
            })
            .error(function (data, status, headers, config) {
                debugger;
            });

    }
});

EnqueueApp.factory('enqueueService', ['$http', function ($http) {

    var enqueueService = {};
    enqueueService.getStudents = function () {
        return $http.get('http://localhost:50522/api/values');
    };

    enqueueService.AddAppointment = function (appointment) {
        debugger;
        var data = JSON.stringify(appointment);
        return $http({
            method: 'POST',
            url: 'http://localhost:50522/api/values',
            data: JSON.stringify(appointment),
            dataType: 'json',
            headers: { 'Content-Type': 'application/json' }
        });
    };


    return enqueueService;

}]);