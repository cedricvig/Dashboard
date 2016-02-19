var MonitorGridController = function ($scope, Monitor) {

    var paginationOptions = {
        pageIndex: 1,
        pageSize: 5
    };

    $scope.gridOptions = {
        enableSorting: true,
        paginationPageSizes: [5, 10, 20],
        paginationPageSize: 10,
        useExternalPagination: true,
        columnDefs: [
          { name: 'Result Date', field: 'resultDate', cellFilter: 'date:\'yyyy-MM-dd HH:mm:sss\'' },
          { name: 'Application Code', field: 'applicationCode' },
          { name: 'Application Name', field: 'applicationName' },
          { name: 'Machine Name', field: 'machineName' },
          { name: 'Result', field: 'result' }
        ],
        onRegisterApi: function (gridApi) {
            $scope.gridApi = gridApi;
            gridApi.pagination.on.paginationChanged($scope, function (pageIndex, pageSize) {
                paginationOptions.pageIndex = pageIndex;
                paginationOptions.pageSize = pageSize;
                getPage();
            });
        }
    };



    $(window).resize(function () {

        $scope.$apply(function () {

            setGridSize('grid1', window.innerWidth * 0.94 + 'px');
        });

    });

    var setGridSize = function (gridId, width, height) {
        if (width !== null) {
            angular.element(document.getElementById(gridId)).css('width', width);
        }

        if (height !== null) {
            angular.element(document.getElementById(gridId)).css('height', height);
        }
    }

    var getPage = function () {
        $scope.gridOptions.data = Monitor.query({ pageIndex: paginationOptions.pageIndex, pageSize: paginationOptions.pageSize });
    };
    
    setGridSize('grid1', window.innerWidth * 0.9 + 'px');
    getPage();
}