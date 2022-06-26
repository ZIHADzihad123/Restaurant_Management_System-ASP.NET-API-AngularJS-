app.controller('refcart',function($scope,$http){
  $http.get("https://localhost:44354/api/products/deletecart").then(function(response){

       alert("Cart Refreshed Successfully");
  }); 
});