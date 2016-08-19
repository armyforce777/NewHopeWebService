angular.module('NewHopeApp')
.factory('User', function UserFactory($resource) {

    return $resource('/User/GetAllUsers', {}, {});

});