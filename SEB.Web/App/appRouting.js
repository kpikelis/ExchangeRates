(function () {

    "use strict";
    angular.module("sebApp").config(config);
    config.$inject = ["$routeProvider"];

    function config($routeProvider)
    {
        $routeProvider.when('/ExchangeRates', {
            controller: "exchangeRatesController",
            controllerAs: "vm",
            templateUrl: "Areas/ExchangeRates/Views/ExchangeRates.html",
            caseInsensitiveMatch: true
        }).otherwise({
            controller: function () {
                window.location.replace('/');
            }
        });
        
    };
})();