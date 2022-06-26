app.controller('placeorder',function($scope,$http){
  $http.get("https://localhost:44354/api/products/orderplace").then(function(response){
      
       alert("Order Placed Successfully");
  }); 

 
  });

