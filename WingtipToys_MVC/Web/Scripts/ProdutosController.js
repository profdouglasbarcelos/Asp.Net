$(document).ready(function () {

    $("#CategoriaID").on("change", function () {
        var options = {};

        options.url = "/Produtos/GetProdutosByCategoria";
        options.type = "GET";
        options.data = { "idCategoria": $("#CategoriaID").val() };
        options.dataType = "json";

        options.success = function (data) {
            $("#ProdutoID").empty();
            for (var i = 0; i < data.length; i++) {
                console.log(data[i].Nome);

                $("#ProdutoID").append(
                    "<option value='" + data[i].ProdutoID + "'> " + data[i].Nome + " </option>");
            }
        };

        $.ajax(options);
    });

});