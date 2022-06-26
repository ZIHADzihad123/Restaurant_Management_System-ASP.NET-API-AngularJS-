app.controller("products",function($scope,$http){
    // var data = $route.current.$$route.user;
    // console.log(JSON.parse(data));
    // ajax.get("https://localhost:44327/api/products",success,error);
    // function success(response){
    //   $scope.products=response.data;
    // }
    // function error(error){

    // }

    $http.get("https://localhost:44327/api/products")
    .then(function(resp){
        $scope.products = resp.data;
    },function(err){
        console.log(err);
    });

});


