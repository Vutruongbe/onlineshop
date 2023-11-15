/// <reference path="../plugins/angular/angular.js" />
//B18: $scope, $rootScope, $scope lồng nhau
//B19: service, ng-click, ng-model, cách gọi sự kiện, custom service
//B20: directive, custom directive


var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);

myApp.directive("teduShopDirective", teduShopDirective);

myApp.service('ValidatorService', Validator);

schoolController.$inject = ['$scope', 'ValidatorService'];

function schoolController($scope, ValidatorService) {
    $scope.checkNumber = function () {
        $scope.message = ValidatorService.checkNumber($scope.num);
    }
    $scope.num = 1;
}

function Validator($window) {
    return {
        checkNumber : checkNumber
        //tên pulic : tên nội bộ
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            //$window.alert('Đây là số chẵn');
            return 'Đây là số chẵn';
        }
        else 
            //$window.alert('Đây là số lẻ');
            return 'Đây là số lẻ';
    }
}

function teduShopDirective() {
    return {
        restrict: "A",
        //template: "<h1>This is my first custom directive</h1>"
        templateUrl: "/Scripts/spa/teduShopDirective.html"
    }
}
//restrict: "E" :element
//restrict: "A" :Attribute
//restrict: "C" :class
//restrict: "M" :Comment

