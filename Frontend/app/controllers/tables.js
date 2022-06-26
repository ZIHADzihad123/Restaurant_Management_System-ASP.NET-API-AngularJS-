app.controller('tables',function($scope,$http){
  $http.get("https://localhost:44354/api/tables/alltables").then(function(response){
       $scope.tables = response.data;
  }); 
  
  }
 

);

 