app.controller('carts',function($scope,$http){
  $http.get("https://localhost:44354/api/products/cart").then(function(response){
       $scope.carts = response.data;
  }); 
});