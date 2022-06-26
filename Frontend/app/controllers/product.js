     app.controller('product',function($scope,$http){
               $http.get("https://localhost:44354/api/products/allproduct").then(function(response){
                    $scope.products = response.data;
               }); 

            // $scope.cart=function(p){   
            //             //    var  Id=p.Id;
            //             //    var  Quantity=p.Quantity; 
            //             //  var data = {                         
            //             //     Id,
            //             //     Quantity,                        
            //             // };
                       
            //         var data=[{
            //              ProductId:2,
            //              Quantity:3
            //         }];
            //         // var data =p; 
            //         //ajax.post("api/login",$scope.data,function(resp){},function(err){});
            //         $http.post("https://localhost:44354/api/products/addtocart",JSON.stringify(data))
            //         .then(function(resp){
            //             console.log(resp.data);
                       
            //          alert("Successfully added into cart" );
            //            //window.location.href = "orderdetail";
            //            $location.path("product");
            //         },function(err){
            //             console.log(err);
            //         });
            //     };
           
             } 
     );
