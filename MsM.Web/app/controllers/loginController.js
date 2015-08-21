'use strict';
app.controller('loginController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.loginData = {
        userName: "",
        password: ""
    };

    $scope.message = "";

    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {
            // Pour l'instant on envoi vers la page d'info....
            $location.path('/userinfo');

        },
         function (err) {
             $scope.message = err.error_description;
         });
    };

}]);