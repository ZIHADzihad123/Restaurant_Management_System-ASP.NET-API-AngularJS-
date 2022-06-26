app.controller('reservedtable',function($scope,$http){
  $http.get("https://localhost:44354/api/tables/reservetables").then(function(response){
       $scope.table = response.data;
  }); 
});