'use strict';
app.controller('langueController', function ($scope, $rootScope, $location) {
    $rootScope.Langue = 'fr';

    $scope.doFrancais = function () {
        $rootScope.Langue = 'fr';
        $location.path('/xxxx');
    };
    $scope.doAnglais = function () {
        $rootScope.Langue = 'en';
        $location.path('/xxxx');
    };

   
});