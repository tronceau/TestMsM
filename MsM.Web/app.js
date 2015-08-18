var app = angular.module('MsmApp', ['ngRoute', 'ngResource', 'ui.bootstrap']);
app.config(function ($routeProvider) {
    $routeProvider.when("/home", {
        controller: "homeController",
        templateUrl: "/app/views/homeresult.html"
    });
    $routeProvider.otherwise({ redirectTo: "/home" });
});