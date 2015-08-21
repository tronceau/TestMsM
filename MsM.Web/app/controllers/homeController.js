app.controller('homeController', ['$scope', '$rootScope', function ($scope, $rootScope) {
    if ($rootScope.Langue == 'fr') {
        $scope.msgConnexion = "Connexion";
        $scope.msgInscription = "Inscription";
        $scope.msgVisiteur = "Visiteur";
    }
    else{
        $scope.msgConnexion = "Sign in";
        $scope.msgInscription = "Sign up";
        $scope.msgVisiteur = "Visit";
    }
}]);