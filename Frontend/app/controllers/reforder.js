app.controller('reforder',function($scope,$http){
  $http.get("https://localhost:44354/api/products/deleteorder").then(function(response){

       alert("Order Refreshed Successfully");
  }); 
});