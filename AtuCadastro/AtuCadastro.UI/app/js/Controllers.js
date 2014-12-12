/// <reference path="../angular.js" />


/// <reference path="Module.js" />

//The controller is having 'crudService' dependency.
//This controller makes call to methods from the service 
app.controller('crudController', function ($scope, crudService) {

    $scope.IsNewRecord = 1; //The flag for the new record

    loadRecords();

    //Function to load all Employee records
    function loadRecords() {
        var promiseGet = crudService.getClientes(); //The MEthod Call from service

        promiseGet.then(function (pl) { $scope.Clientes = pl.data },
              function (errorPl) {
                  $log.error('Erro ao listar clientes...', errorPl);
              });
    }



    //The Save scope method use to define the Employee object.
    //In this method if IsNewRecord is not zero then Update Employee else 
    //Create the Employee information to the server
    $scope.save = function () {
        var Cliente = {
            ClienteId: $scope.ClienteId,
            Nome: $scope.Nome,
            NroTelefoneResidencial: $scope.NroTelefoneResidencial,
            Endereco: $scope.Endereco,
            DataNascimento: $scope.DataNascimento,
            NroTelefoneCelular: $scope.NroTelefoneCelular
        };
        //If the flag is 1 the it si new record
        if ($scope.IsNewRecord === 1) {
            var promisePost = crudService.post(Cliente);
            promisePost.then(function (pl) {
                $scope.ClienteId = pl.data.ClienteId;
                loadRecords();
            }, function (err) {
                console.log("Err" + err);
            });
        } else { //Else Edit the record
            var promisePut = crudService.put($scope.ClienteId, Cliente);
            promisePut.then(function (pl) {
                $scope.Message = "Updated Successfuly";
                loadRecords();
            }, function (err) {
                console.log("Err" + err);
            });
        }



    };

    //Method to Delete
    $scope.delete = function () {
        var promiseDelete = crudService.delete($scope.ClienteId);
        promiseDelete.then(function (pl) {
            $scope.ClienteId = "";
            $scope.Nome = "";
            $scope.NroTelefoneResidencial = "";
            $scope.Endereco = "";
            $scope.DataNascimento = "";
            $scope.NroTelefoneCelular = "";
            loadRecords();
        }, function (err) {
            console.log("Err" + err);
        });
    }

    //Method to Get Single Employee based on EmpNo
    $scope.get = function (Emp) {
        var promiseGetSingle = crudService.get(Emp.ClienteId);

        promiseGetSingle.then(function (pl) {
            var res = pl.data;
            $scope.ClienteId = res.ClienteId;
            $scope.Nome = res.Nome;
            $scope.NroTelefoneResidencial = res.NroTelefoneResidencial;
            $scope.Endereco = res.Endereco;
            $scope.DataNascimento = res.DataNascimento;
            $scope.NroTelefoneCelular = res.NroTelefoneCelular;

            $scope.IsNewRecord = 0;
        },
                  function (errorPl) {
                      console.log('Erro ao listar clientes...', errorPl);
                  });
    }
    //Clear the Scopr models
    $scope.clear = function () {
        $scope.IsNewRecord = 1;
        $scope.ClienteId = "";
        $scope.Nome = "";
        $scope.NroTelefoneResidencial = "";
        $scope.Endereco = "";
        $scope.DataNascimento = "";
        $scope.NroTelefoneCelular = "";
    }
});