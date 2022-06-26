app.controller('reforderde',function($scope,$http){
  $http.get("https://localhost:44354/api/products/deleteorderde").then(function(response){

       alert("Orderdetails Refreshed Successfully");
  }); 
});