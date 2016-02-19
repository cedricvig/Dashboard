var AppSearchController = function ($scope, Appli, Environment) {

    $scope.ShowAppListIndicator = false;
    // Get Applications
    $scope.Applications = Appli.query();

    $scope.showAppList = function (appFilter) {
        $scope.ShowAppListIndicator = true;
    };

};