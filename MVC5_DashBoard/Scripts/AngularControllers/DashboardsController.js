var DashboardsController = function ($scope, $rootScope, Dashboard, Appli, Environment) {

    // Get environments
    $scope.Environments = Environment.query();

    // Get Applications
    $scope.Applications = Appli.query();

    $scope.chart1Config = {
        options: {
            chart: {
                type: 'pie',
                height: 500,
                margin: [50, 50, 50, 50]
            },
            tooltip: {
                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
            },
            plotOptions: {
                pie: {
                    allowPointSelect: true,
                    cursor: 'pointer',
                    dataLabels: {
                        enabled: true,
                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                        style: {
                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                        }
                    }
                }
            }
        },
        series: [{
            id: 'base',
            name: 'Result',
            colorByPoint: true,
            data: []
        }],
        title: {
            text: '',
            align: 'center',
            margin: 100
        },
        loading: false,
        useHighStocks: false
    };

    $scope.refreshChart = function (envFilter, appFilter) {
        $scope.chart1Config.loading = true;
        Dashboard.query({ env: envFilter, app: appFilter })
                                 .$promise.then(function (dataChart) {
                                     $scope.chart1Config.loading = false;
                                     $scope.chart1Config.series[0].data = dataChart;
                                     $scope.chart1Config.title.text = envFilter + ': ' + appFilter;
                                 });
    };
}