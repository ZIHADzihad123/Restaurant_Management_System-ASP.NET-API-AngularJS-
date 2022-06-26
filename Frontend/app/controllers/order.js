app.controller('order',function($scope,$http){
  $http.get("https://localhost:44354/api/products/order").then(function(response){      
    $scope.order = response.data;
  }); 
});