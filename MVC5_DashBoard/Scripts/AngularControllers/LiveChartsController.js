var LiveChartsController = function ($scope, $rootScope) {
    var dataChart = [0, 0];

    $scope.chartConfig = {
        options: {
            chart: {
                type: 'line'
            }
        },
        series: [{
            id: 'base',
            name: 'Serie Name',
            data: dataChart
        }],
        title: {
            text: 'Title'
        },
        loading: false,
        units: [['hour',
	            [1, 2, 5, 10, 15, 30]
        ]]
    };

    // Creation du  Proxy HubSignalR
    var connection = $.hubConnection();
    var hub = connection.createHubProxy("MonitorHub");

    // Abonnement aux données de cluster poussées par le serveur
    hub.on('RefreshLifeTests', function (clusterModel, date) {
        $rootScope.$apply(function () {

            dataChart.push([date, GetNodeOK(clusterModel)]);
            $scope.chartConfig.series[0].data = dataChart;
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

    //clusterModel.Clusters
    var GetNodeOK = function (clusterModel) {
        var nodeOK = 0;
        for (var icluster = 0; icluster < clusterModel.Clusters.length; icluster++) {
            for (var imonitors = 0; imonitors < clusterModel.Clusters[icluster].Monitors.length; imonitors++) {
                for (var inode = 0; inode < clusterModel.Clusters[icluster].Monitors[inode].Nodes.length; inode++) {
                    if (clusterModel.Clusters[icluster].Monitors[inode].Nodes[inode].LifeResult == 200) nodeOK++;
                }
            }
        }
        return nodeOK;
    };
}