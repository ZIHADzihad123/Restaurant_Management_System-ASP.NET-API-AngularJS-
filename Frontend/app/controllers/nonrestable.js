app.controller('nonrestable',function($scope,$http){
  $http.get("https://localhost:44354/api/tables/nonreservetables").then(function(response){
       $scope.table = response.data;
  }); 
  $scope.addItem = function(id){
    $http({
              method:"POST",
              url:"https://localhost:44354/api/tables/tablereserve",
              data:id
          }).success(function(data){
           alert("Ordered Successfully");
          });
   };
});