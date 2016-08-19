(function () {
    //create a module
    var app = angular.module('NewHopeApp',['ngRoute']);


    //create a controller
    app.controller('UserController', function ($scope) {
        $scope.message = "This is New Hope Web Site!!!";
    });
    

})();