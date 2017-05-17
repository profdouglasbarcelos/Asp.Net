$(document).ready(function () {

    $("#Nome").on("input", function () {
        var options = {};

        options.url = "/Categorias/AutoCompleteNome";
        options.type = "GET";
        options.data = { "prefixo": $("#Nome").val() };
        options.dataType = "json";

        options.success = function (data) {
            $("#listaCategorias").empty();
            for (var i = 0; i < data.length; i++) {
                console.log(data[i].Nome);

                $("#listaCategorias").append(
                    "<option value='" + data[i].Nome + "'></option>");

                /*
                 $("#listaCategorias").append(
                    "<option label = '" + data[i].Nome
                    + "'value='" + data[i].CategoriaID
                    + "'></option>");
                */
            }
        };

        $.ajax(options);
    });

});