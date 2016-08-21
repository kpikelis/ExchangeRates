(function () {
    "use strict";

    angular.module("sebApp").controller("exchangeRatesController", exchangeRatesController);
    exchangeRatesController.$inject = ["$scope", "exchangeRatesService"];

    function exchangeRatesController($scope, exchangeRatesService) {
        var vm = this;
        $scope.exchangeRates = {};
        $scope.searchDate = null;
        $scope.errorMessage = null;
        $scope.searchByDate = function (date) {
            $scope.errorMessage = null;
            var exchangeRatesServicePromise = exchangeRatesService.getByDate(date);
            exchangeRatesServicePromise.then(function (result) {
                if(result.status == 200)
                    $scope.exchangeRates = result.data;
                else {
                    $scope.errorMessage = result;
                    $scope.exchangeRates = {};
                }
            });
        };
    };
})();