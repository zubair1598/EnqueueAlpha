var app = angular.module('myApp');
app.factory('appointmentService', ['$http', function ($http) {

    var appointmentService = {};

    appointmentService.getToken = function (user) {
        debugger;

        return $http({
            method: 'Get',
            url: 'http://meetdoctornow.com/api/token/get/9/1/1/test/1123/true',
            data: JSON.stringify(user),
            dataType: 'json',
            headers: { 'Content-Type': 'application/json' }

        });
    };

    return appointmentService;

}]);