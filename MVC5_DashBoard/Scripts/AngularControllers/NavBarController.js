var NavBarController = function ($scope, PingRefresh) {

    $scope.PingActivated = PingRefresh.query();

    $scope.updatePing = function () {
        PingRefresh.save($scope.PingActivated.value);
    };
}
