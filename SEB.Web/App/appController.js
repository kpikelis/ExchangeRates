(function () {

    "use strict";

    angular.module("sebApp").controller("appController", appController);
    appController.$inject = ["$rootScope"];

    function appController($rootScope) {
        var vm = this;
        vm.title = "SEB";
        vm.isAngularPage = false;

        $rootScope.$on("$routeChangeStart", function (event, next, current) {
            vm.isAngularPage = arguments[1].$$route != null;
        });
    };
})();