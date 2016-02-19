var HomePageController = function ($scope, $rootScope, $filter, $modal, Environment, Appli) {

    // Creation du  Proxy HubSignalR
    var connection = $.hubConnection();
    var hub = connection.createHubProxy("MonitorHub");

    // Abonnement aux données de cluster poussées par le serveur
    hub.on('RefreshLifeTests', function (data, date) {
        $rootScope.$apply(function () {
            $scope.clusterModel = data;
            $scope.currentServerTime = date;
        });
    });

    // Reconnection du client en cas d'arrêt ou redémarrage du serveur
    // (et même au démarrage de IIS qui peut être lent !)
    hub.connection.disconnected(function () {
        setTimeout(function () {
            hub.connection.start();
        }, 5000); //  5 seconds
    });

    connection.start();

    // Init ServerTime
    $scope.currentServerTime = "";

    // Get environments
    $scope.Environments = Environment.query();

    var GetNodeOK = function (nodes) {
        var nodeOK = 0;
        var nodeNotExist = 0;
        for (var i = 0; i < nodes.length; i++) {
            if (nodes[i].LifeResult == 200) nodeOK++;
            if (nodes[i].LifeResult == 600) nodeNotExist++;
        }
        if (nodes.length == nodeNotExist) return -1;
        else return nodeOK;
    };

    $scope.GetLifeResult = function (nodes) {
        var n = GetNodeOK(nodes);
        if (n == -1) return 0; //inactive
        else if (n == nodes.length) return 1; //OK
        else if (n == 0) return 2; // KO
        else return 3; // partial OK
    };

    $scope.GetNodeOKCount = function (nodes) {
        var n = GetNodeOK(nodes);
        if (n == -1) n = 0;
        return n;
    };

    // Region Search Appli ------------------------------------


    $scope.open = function (filter, Appli) {

        var modalInstance = $modal.open({
            animation: true,
            templateUrl: 'AppSearchTemplate.html',
            controller: ['$scope','$modalInstance','Appli',function ($scope, $modalInstance, Appli) {
                $scope.filterApp = filter;

                // Get Applications
                $scope.AppliList = Appli.query();

                $scope.submit = function () {
                    $modalInstance.dismiss('cancel');
                };
                $scope.cancel = function () {
                    $modalInstance.dismiss('cancel');
                };
                $scope.ok = function (selectedItem) {
                    $modalInstance.close(selectedItem);
                };
            }]
        });

        modalInstance.result.then(function (selectedItem) {
            $scope.appFilter = selectedItem;
        });
    };



};

// The $inject property of every controller needs to be a string array equal to the controllers arguments, only as strings
//HomePageController.$inject = ['$scope', '$rootScope', '$filter', '$resource', 'Environment', 'Appli'];