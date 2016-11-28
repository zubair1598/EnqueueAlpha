var app = angular.module('myApp');
app.factory('consumerService', ['$http', function ($http) {

    var enqueueService = {};
    
    enqueueService.registerUser = function (user) {
        debugger;
        
        return $http({
            method: 'POST',
            url: 'http://meetdoctornow.com/api/consumer/register',
            data: JSON.stringify(user),
            dataType: 'json',
            headers: { 'Content-Type': 'application/json' }

        });
    };

    enqueueService.login = function (user) {
        debugger;

        return $http({
            method: 'POST',
            url: 'http://meetdoctornow.com/api/consumer/login',
            data: JSON.stringify(user),
            dataType: 'json',
            headers: { 'Content-Type': 'application/json' }

        });
    };

    return enqueueService;

}]);