var app = angular.module('myApp');
app.controller('indexCtrl', ['$scope', '$rootScope', '$cookieStore', 'consumerService',
   function ($scope, $rootScope, $cookieStore, consumerService) {
       debugger
       $scope.loggedIn = $cookieStore.get('loggedin');
       if ($scope.loggedIn == 'true') {
           $scope.loggedOut = '';
           $rootScope.currentUserSignedIn = true;
           $rootScope.currentUserName = $cookieStore.get('loggedinUserName');
       }
       else {
           $scope.loggedOut = 'true';
       }


       $scope.logout = function () {
           $cookieStore.put('loggedin', '');
           $cookieStore.put('loggedinUserName', '')

           $rootScope.currentUserSignedIn = false;
           $rootScope.currentUserName = '';
       }

   }])