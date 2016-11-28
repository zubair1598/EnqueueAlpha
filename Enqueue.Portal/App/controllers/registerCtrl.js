var app = angular.module('myApp');
app.controller('registerCtrl', ['$scope', '$rootScope', '$location', '$cookieStore', 'consumerService', function ($scope, $rootScope, $location, $cookieStore, consumerService) {

    // function to submit the form after all validation has occurred            
    $scope.submitForm = function (isValid, user) {
        debugger;
        // check to make sure the form is completely valid
        if (isValid) {
            debugger;
            var userName = user.userName;

            consumerService.registerUser(user)
           .success(function (data, status, headers, config) {

               $rootScope.currentUserSignedIn = true;
               $rootScope.currentUserName = userName;
               alert(data.data.user_name);
               $cookieStore.put('loggedin', 'true');
               $cookieStore.put('loggedinUserName', userName);
               //$scope.status = 'Successfully Login';
               //logger.logError('Successfully Login', '', true);

               $location.path('/home');
           })
           .error(function (data, status, headers, config) {
               $scope.status = 'Unable to load customer data: ' + error.message;
               console.log($scope.status);
           });
        }
    }
}]);
