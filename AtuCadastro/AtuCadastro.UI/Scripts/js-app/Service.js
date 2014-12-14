/// <reference path="../angular.js" />
/// <reference path="Module.js" />


app.service('crudService', function ($http) {


    //Create new record
    this.post = function (Cliente) {
        var request = $http({
            method: "post",
            url: "http://localhost:11556/api/Cliente",
            data: Cliente
        });
        return request;
    }
    //Get Single Records
    this.get = function (ClienteId) {
        return $http.get("http://localhost:11556/api/Cliente/" + ClienteId);
    }

    //Get All Employees
    this.getClientes = function () {
        return $http.get("http://localhost:11556/api/Cliente");
    }


    //Update the Record
    this.put = function (ClienteId, Cliente) {
        var request = $http({
            method: "put",
            url: "http://localhost:11556/api/Cliente/" + ClienteId,
            data: Cliente
        });
        return request;
    }

});