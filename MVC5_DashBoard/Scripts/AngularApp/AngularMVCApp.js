var AngularMVCApp = angular.module('AngularMVCApp', ['Services', 'ui.bootstrap', 'ui.bootstrap.tpls', 'highcharts-ng','ui.grid','ui.grid.pagination']);

AngularMVCApp.controller('HomePageController', ['$scope', '$rootScope', '$filter', '$modal', 'Environment', 'Appli', HomePageController])
    .controller('LiveChartsController', ['$scope', '$rootScope', LiveChartsController])
    .controller('DashboardsController', ['$scope', '$rootScope', 'Dashboard', 'Appli', 'Environment', DashboardsController])
    .controller('AppSearchController', ['$scope', 'Appli', AppSearchController])
    .controller('NavBarController', ['$scope', 'PingRefresh', NavBarController])
    .controller('MonitorGridController', ['$scope', 'Monitor', MonitorGridController]);
    