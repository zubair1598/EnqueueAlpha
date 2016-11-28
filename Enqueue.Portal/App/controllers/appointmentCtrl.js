var app = angular.module('myApp');
app.controller('appointmentCtrl', function ($scope, $rootScope, $routeParams, appointmentService) {
    $scope.getToken = function (tokenData) {
        debugger

        // for time being inserting consumerID (means currently logged in uder ID)

        tokenData.consumerId = "1";
        tokenData.onlineToken = true;
        // check to make sure the form is completely valid
        //if (isValid) {
        appointmentService.getToken(tokenData)
       .success(function (data, status, headers, config) {

          
       })
       .error(function (data, status, headers, config) {
           $scope.status = 'Unable to load customer data: ' + error.message;

       });
        //}
    }



});
