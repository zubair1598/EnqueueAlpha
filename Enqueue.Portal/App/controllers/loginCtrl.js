var app = angular.module('myApp');
app.controller('loginCtrl', ['$scope', '$rootScope', '$location', '$cookieStore', 'consumerService',
function ($scope, $rootScope, $location, $cookieStore, consumerService) {

    $scope.login = function (user) {

        debugger;
        // check to make sure the form is completely valid
        //if (isValid) {
        consumerService.login(user)
       .success(function (data, status, headers, config) {
           debugger;
           $rootScope.currentUserSignedIn = true;
           $rootScope.currentUserName = data.data.user_name;
           alert(data.data.user_name);
           $cookieStore.put('loggedin', 'true');
           $cookieStore.put('loggedinUserName', data.data.user_name);
           //$scope.status = 'Successfully Login';
           //logger.logError('Successfully Login', '', true);

           $location.path('/home');
       })
       .error(function (data, status, headers, config) {
           debugger;
           $scope.status = 'Unable to load customer data: ' + error.message;

       });
        //}
    }

}]);
