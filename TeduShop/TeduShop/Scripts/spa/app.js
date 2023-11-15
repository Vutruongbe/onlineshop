/// <reference path="../plugins/angular/angular.js" />
//B18: $scope, $rootScope, $scope lồng nhau 


var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);
myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);

//function studentController($rootScope, $scope) {
//    $rootScope.message = "Student";
//    //$scope.message = "Student";
//};

function schoolController($scope) {
    $scope.message = "School";
};

function studentController($scope) {
    //$scope.message = "Student";
};

function teacherController($scope) {
    //$scope.message = "Teacher";
};
