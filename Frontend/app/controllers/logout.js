app.controller("logout",function($http){
    //localStorage.removeItem('token');
    //include ajax in dependency
    //ajax.get("api/logout",function(resp){},function(err){});
    
    $http.get("https://localhost:44354/api/logout")
    .then(function(rsp){
        localStorage.removeItem("token");
        $location.path("login");
    },function(err){
        console.log(err);
    });

    

});
