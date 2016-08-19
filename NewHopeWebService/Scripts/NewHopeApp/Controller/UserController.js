angular.module('NewHopeApp') //extend from the previous app.js
.controller('UserController', function ($scope, User) {
    $scope.users = User.query();
});
