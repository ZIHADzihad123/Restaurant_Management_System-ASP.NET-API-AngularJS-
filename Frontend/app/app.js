var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    
    
    
   
    .when("/product", {
        templateUrl : "views/pages/product.html",
        controller: 'product',      
    })
    .when("/carts", {
        templateUrl : "views/pages/carts.html",
        controller: 'carts',      
    })
    .when("/tables", {
        templateUrl : "views/pages/tables.html",
        controller: 'tables',      
    })
    .when("/orderdetail", {
        templateUrl : "views/pages/orderdetail.html",
        controller: 'orderdetail',      
    })
    .when("/restable", {
        templateUrl : "views/pages/reservedtable.html",
        controller: 'reservedtable',      
    })
    .when("/nonrestable", {
        templateUrl : "views/pages/nonrestable.html",
        controller: 'nonrestable',      
    })
   
    .when("/logins", {
        templateUrl : "views/pages/logins.html",
        controller: 'login'
        
    })
    
    .when("/view_profile", {
        templateUrl : "views/pages/view_profile.html"
        
    })
    .when("/registration", {
        templateUrl : "views/pages/registration.html"
        
    })
    .when("/homepage", {
        templateUrl : "views/pages/homepage.html"
        
    })
    .when("/homepag", {
        templateUrl : "views/pages/homepag.html"
        
    })
    .when("/users", {
        templateUrl : "views/pages/users.html",
        controller: 'users',
        
        
    })
    .when("/logout", {
        templateUrl : "views/pages/login.html",
        controller: 'logout',
        
        
    })
    .when("/placeorder", {
        templateUrl : "views/pages/carts.html",
        controller: 'placeorder',
        
        
    })
    .when("/refcart", {
        templateUrl : "views/pages/carts.html",
        controller: 'refcart',
          
    })
    .when("/reforderde", {
        templateUrl : "views/pages/orderdetail.html",
        controller: 'reforderde',
          
    })
    .when("/order", {
        templateUrl : "views/pages/order.html",
        controller: 'order',     
    })
 
    .otherwise({
        redirectTo:"/homepage",
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);

app.config(function($httpProvider){
    $httpProvider.interceptors.push('interCeptor');
})
