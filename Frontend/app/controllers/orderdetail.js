app.controller('orderdetail',function($scope,$http){
  $http.get("https://localhost:44354/api/products/orderdetails").then(function(response){
       $scope.orderdetail = response.data;
  }); 
});
