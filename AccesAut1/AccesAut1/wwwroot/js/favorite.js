var productIdValue;

function getProductId(productId) {
    productIdValue = productId;
    console.log("sunt in functie", productId);
}

$("addPreferate").on("click", function () {
    //addProduct();
    console.log("am apasat pe button");
})


function deleteProduct() {
    $.ajax({
        url: "/ProductWishlist/DeleteProduct",
        type: "POST",
        data: {
            ProductId: productIdValue,
            UserId: 0
        },
        complete: function (data, status) {
            if (status === "success") {
                callback();
            }
            else {
                console.log("Error", data);
            }
        }
    });
}

function addProduct() {
    $.ajax({
        url: "/ProductWishlist/AddProduct",
        type: "POST",
        data: {
            ProductId: productIdValue,
            UserId: 0
        },
        complete: function (data, status) {
            if (status === "success") {
                callback();
            }
            else {
                console.log("Error", data);
            }
        }
    });
}