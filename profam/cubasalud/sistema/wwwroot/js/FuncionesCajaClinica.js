function GuardarIngreso() {

    var descripcion = prompt("Escribe una descripcion");

    var monto = prompt("Escribe el monto");



    var datos = {

    };

    // console.log(datos);


    $.ajax({
        method: "POST",
        data: datos,
        "dataType": "json",
        "contentType": "application/json",
        url: '/CajaClinica/GuardarIngreso?Descripcion=' + descripcion + '&Monto=' + monto,
        traditional: true,
        success: function(data) {

            //console.log(data);
            location.reload();

        },
        error: function(data) {
            alert(data.error);
        }
    });



}

function GuardarEgreso() {

    var descripcion = prompt("Escribe una descripcion");

    var monto = prompt("Escribe el monto");



    var datos = {

    };

    // console.log(datos);


    $.ajax({
        method: "POST",
        data: datos,
        "dataType": "json",
        "contentType": "application/json",
        url: '/CajaClinica/GuardarEgreso?Descripcion=' + descripcion + '&Monto=' + monto,
        traditional: true,
        success: function(data) {

            //console.log(data);
            location.reload();

        },
        error: function(data) {
            alert(data.error);
        }
    });



}