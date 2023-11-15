/// <reference path="../plugins/angular/angular.js" />
//B18: $scope, $rootScope, $scope lồng nhau 
//B19: service, ng-click, ng-model, cách gọi sự kiện


var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);
myApp.service('Validator', Validator);

schoolController.$inject = ['$scope', 'Validator'];

function schoolController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
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
