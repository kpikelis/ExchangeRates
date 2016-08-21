(function () {

    "use strict";

    angular.module("sebApp").factory("exchangeRatesService", exchangeRatesService);
    exchangeRatesService.$inject = ["$http", "$log"];

    function exchangeRatesService($http, $log) {

        var service = this;
        service.getByDate = getByDate;

        function handleSuccess(data) {
            return data;
        }

        function handleError(error) {
            return function () {
                $log.error(error);
                return error;
            };
        }

        function getByDate(date) {
            return $http({
                url: "/ExchangeRates/ExchangeRates/GetExchangeRates",
                method: "GET",
                params: { date: date }
            }).then(handleSuccess, handleError("Error getting all exchange rates. Please contact administrator!"));
        }
        return service;
    }

})();