
var app = angular.module("myApp", ['ngRoute', 'ngCookies']);
app.config(function ($routeProvider) {
    $routeProvider.when('/login', {

        templateUrl: 'login.html',
        controller: 'loginCtrl'
    })
        .when('/register', {

            templateUrl: 'register.html',
            controller: 'registerCtrl'
        })
        .when('/home', {

            templateUrl: 'home.html',
            controller: 'homeCtrl'
        })
         .when('/team', {

             templateUrl: 'team.html',
             controller: 'teamCtrl'
         })
         .when('/appointment', {

             templateUrl: 'appointment.html',
             controller: 'appointmentCtrl'
         })
         .when('/profile', {

             templateUrl: 'profile.html',
             controller: 'profileCtrl'
         })
         .when('/services', {

             templateUrl: 'services.html',
             controller: 'servicesCtrl'
         })
    .otherwise(
        {
            redirectTo: 'home.html'
        });
});