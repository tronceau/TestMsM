﻿'use strict';
//app.controller('navigationController', function ($scope, $location, placesDataService) {
app.controller('navigationController', function ($scope, $location) {

    $scope.isActive = function (path) {

        return $location.path().substr(0, path.length) == path;
    };
});