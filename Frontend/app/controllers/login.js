app.controller("login",function($scope,$http,$location){
    $scope.login=function(){
        
        //ajax.post("api/login",$scope.data,function(resp){},function(err){});
        $http.post("https://localhost:44354/api/login",$scope.data)
        .then(function(resp){
            console.log(resp.data);
            localStorage.setItem("token",resp.data.AccessToken);
          alert("Successfully Logged In");
           //window.location.href = "orderdetail";
           $location.path("product");
        },function(err){
            alert("Entered wrong username or password");
            console.log(err);
        });
    };
});
