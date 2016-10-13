(function () {
    "use strict";
    angular
        .module("productManagement")
        .controller("productListCtrl",
                    productListCtrl);
    function productListCtrl() {
        var vm = this;   
            vm.produtcs = [
                {" productId": 1,
                "productName": "An ice sculpture",
                "productCode": "GDN-1100",
                "releaseDate": "September 19 2016",
                "description": "An ice sculpture",
                "cost": 12.50,
                "price": 12.50,
                 "category":"Garden",
                "tags": ["cold", "ice"],
               "imageUrl":"https://openclipart.org/image/90px/svg_to_png/203262/Owls-vintage-02.png"
                },
                {"productId": 2,
                "productName": "An ice sculpture",
                "productCode": "GDN-1100",
                "releaseDate": "September 19 2016",
                "description": "An ice sculpture",
                "cost": 12.50,
                "price": 12.50,
                "category":"Garden",
                "tags": ["cold", "ice"],
               "imageUrl":"https://openclipart.org/image/90px/svg_to_png/246358/Bessenkrans.png"
                },
                {"productId": 3,
                "productName": "An ice sculpture",
                "productCode": "GDN-1100",
                "releaseDate": "September 19 2016",
                "description": "An ice sculpture",
                "cost": 12.50,
                "price": 12.50,
                "category":"Garden",
                "tags": ["cold", "ice"],
               "imageUrl":"https://openclipart.org/image/90px/svg_to_png/256997/Chromatic-Lotus-Flower-Line-Art-2-No-Background.png"
                }
            ]
            vm.showImage=false;
            
            vm.toggleImage=function(){
                vm.showImage=!vm.showImage;
            }
    }
}());