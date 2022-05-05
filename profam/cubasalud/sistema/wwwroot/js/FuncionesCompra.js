var sumatotal = 0.00;
var total = 0.00;
var total2 = 0.00;
var total3 = 0.00;
var saldo= 0;

actualizarPreciosVenta();

$('#boton').click(function(){
var fecha = document.getElementById('reservationtime').value;
var empleadoid = document.getElementById('empleadoselect').vaalue;

var datos = "";
$.ajax({
    method: "POST",
    data: datos,
    dataType: 'json',
    url: '/CrearPDF/VentasPdf?fecha= '+fecha+'&empleadoid='+empleadoid,
    traditional: true,
    success: function (data, state) {

    console.log(JSON.stringify(data));
    console.log(state);

    },
    error: function (data) {
        console.log(data);
    },
});
});
 
function LimpiarModal(){
    document.getElementById('montotxt').value="";
    document.getElementById('vuelto-n').innerHTML="0.00";
    saldo = total;

}


$('#buscartxt').keypress(function (e) {
    var keycode = e.which;
    if (keycode == '13') {
        var codigo = $("#buscartxt").val();

        var datos = { "codigo": codigo };

        $.ajax({
            method: "POST",
            data: datos,
            dataType: 'json',
            url: '/Productos/RetornarProductoClinica',
            traditional: true,
            success: function (data, state) {
                agregarATabla(data);
            },
            error: function (data) {
                console.log(data);
            },

        });
    }
});



function FiltrarProductos(codigo) {

    var datos = { "codigo": codigo }

    $.ajax({
        method: "POST",
        data: datos,
        dataType: "json",
        url: '/Venta/BusquedaProductosClinica',
        traditional: true,
        success: function (data, state) {

            agregarALista(data);

        },
        error: function (data) {
            console.log(data);
        },

    });

}


$(".cantidad-fila").on("click", function() {

    var monto = document.getElementsByClassName('cantidad-fila').value;

    var total = monto * sumatotal;


    document.getElementById('precio-total-a-pagar').innerHTML = total.toFixed(2);

    // document.getElementById('total-a-pagar2').innerHTML = sumatotal.toFixed(2);



    // if (vuelto < 0) {
    //     document.getElementById('vuelto-n').innerHTML = "0.00";

    // } else {
    //     document.getElementById('vuelto-n').innerHTML = vuelto.toFixed(2);
    // }

});

$("#descuentoventa").on('change', function () {

    var descuento = document.getElementById('descuentoventa').value;

    total = document.getElementById('precio-total-a-pagar').value;
    sumatotal = parseFloat(total) - parseFloat(descuento);

    console.log(total);
    console.log(descuento);
    console.log(sumatotal);

    document.getElementById('precio-total-a-pagar').innerHTML = sumatotal.toFixed(2);
    document.getElementById('total-a-pagar2').innerHTML = sumatotal.toFixed(2);


})


function editarValorFila(r) {

    total = 0.00;
    total2 = 0.00;
    total3 = 0.00;

    var val = r.value;

    var sig = r.parentNode.parentNode.querySelectorAll("td.precio-fila")[0].querySelectorAll("input")[0].value;

    var suma2 = val * sig;

    // var porc = r.parentNode.parentNode.querySelectorAll("td.porcentaje")[0].querySelectorAll("input")[0].value
    // var desc = suma2 * (parseInt(porc)/100);
    // r.parentNode.parentNode.querySelectorAll("td.desc-t")[0].innerHTML=desc.toFixed(2);

    var totalfin = parseFloat(suma2);
    // r.parentNode.parentNode.querySelectorAll("td.subtotal-t")[0].innerHTML = suma2.toFixed(2);
    r.parentNode.parentNode.querySelectorAll("td.total-t")[0].innerHTML = totalfin.toFixed(2);

    


    actualizarPreciosVenta();


}


function actualizarPreciosVenta(){

    var lista = document.getElementById('contentdetalle').querySelectorAll("td.total-t");
    console.log(lista);

    lista.forEach(function (item) {
        total = parseFloat(total) + parseFloat(item.innerText);
    });

    // document.getElementById('subtotal-venta').innerHTML = total2.toFixed(2);
    // document.getElementById('descuento-venta').innerHTML = total3.toFixed(2);
    document.getElementById('precio-total-a-pagar').innerHTML = total.toFixed(2);
    // document.getElementById('total-a-pagar2').innerHTML = total.toFixed(2);
    // document.getElementById('total-saldo-venta').innerHTML = saldo.toFixed(2);

}



function editarPorcentaje(r) {

    total = 0.00;
    total2 = 0.00;
    total3 = 0.00;

    var val = r.value;

   

    var sub = r.parentNode.parentNode.querySelectorAll("td.subtotal-t")[0].innerHTML;

    var desc = parseFloat(sub) * (parseFloat(val)/100);

   r.parentNode.parentNode.querySelectorAll("td.desc-t")[0].innerHTML=desc.toFixed(2);

    var totalfin = sub - desc;

    console.log(val);
    console.log(sub);
    console.log(desc);
    console.log(totalfin);

    r.parentNode.parentNode.querySelectorAll("td.total-t")[0].innerHTML = totalfin.toFixed(2);

    actualizarPreciosVenta();


}


function escogerPrecio(r) {

    total = 0.00;
    total2 = 0.00;
    total3 = 0.00;

    var precio = r.value;

    var cantidad = r.parentNode.parentNode.querySelectorAll("td.cantidad-fila")[0].querySelectorAll("input")[0].value;

    var suma2 = parseInt(cantidad) * parseFloat(precio);

    //var descuento = r.parentNode.parentNode.querySelectorAll("td.desc-t")[0].innerHTML;
    var porc = r.parentNode.parentNode.querySelectorAll("td.porcentaje")[0].querySelectorAll("input")[0].value;

    var desc = suma2 * (parseInt(porc) / 100);

    r.parentNode.parentNode.querySelectorAll("td.desc-t")[0].innerHTML = desc.toFixed(2);

    var totalfin = parseFloat(suma2) - parseFloat(desc);

    r.parentNode.parentNode.querySelectorAll("td.subtotal-t")[0].innerHTML = suma2.toFixed(2);
    r.parentNode.parentNode.querySelectorAll("td.total-t")[0].innerHTML = totalfin.toFixed(2);



    actualizarPreciosVenta();

}


$("#montotxt").on("keyup", function () {

    var monto = document.getElementById('montotxt').value;

    var vuelto = monto - total;
    saldo = total - monto;

    

    if (vuelto <0){

        vuelto = 0.00;
    }

    if (saldo <0)
    {
        saldo=0;
    }

    console.log(saldo);
    document.getElementById('vuelto-n').innerHTML = vuelto.toFixed(2);
    document.getElementById('total-saldo-venta').innerHTML = saldo.toFixed(2);

});

$("#clienteselect").on('change', function () {

    var nombre = { "nombre": $("#clienteselect option:selected").text() }

    $.ajax({
        method: "POST",
        data: nombre,
        dataType: 'json',
        url: '/Cliente/RetornarCliente',
        traditional: true,
        success: function (data, state) {
            console.log(data);

            if (data === null) {
                document.getElementById("Nit").value = "";
                document.getElementById("nombres").value = nombre.nombre;
                document.getElementById("direccion").value = "";
                return;
            }

            document.getElementById("Nit").value = data.nit;
            // document.getElementById("nombres").value = data.nombre;
            document.getElementById("direccion").value = data.direccion;




        },
        error: function (data) {

        },

    });
});



$( "#agregarprodt").click(function() {
    var codigo = document.getElementById('productoselecttxt').value;
    BuscarProductoByCodigo(codigo);

  });


function BuscarProductoByCodigo(codigo)
{
    var datos = {"id" : codigo }

    return $.ajax({
        method: "GET",
        data : datos,
        dataType: 'json',
        url: '/Productos/RetornarProductoByIdCompras',
        traditional: true,
        success: function (data, state) {
           agregarATabla(data)
        },
        error: function (data) {
        }

    });
}


function agregarATabla(data) {
    //total= total + data.precio;
    total = 0.00;
    total2 = 0.00;
    total3 = 0.00;

    console.log(data);

    var htmlTags = '<tr style="background-color:rgba(255,211,105,0.5);"> <td class="nuevo-detalle"> ' + data.id + '</td>' +
        '<td> ' + data.nombreProducto + ' </td>' +
        '<td class="cantidad-fila" ><input type="text" onchange="editarValorFila(this)" style="background-color:rgba(255,211,105,0.5);" value="1" class="form-control "></td>' +
        '<td class="precio-fila">' +
        '<input class="form-control" value="'+data.precio.toFixed(2)+'">'+
        '</td>' +
        // '<td class="porcentaje"><input type="text" value="0" class="form-control" style="background-color:rgba(255,211,105,0.5);" onchange="editarPorcentaje(this)"></td>' +
        // '<td class="desc-t">0.00</td>' +
        // '<td class="subtotal-t">' + data.precio.toFixed(2) + '</td>' +
        '<td class="total-t">' + data.precio.toFixed(2) + '</td>' +
        '<td><button  type="button"  class="btn btn-danger btn-sm" onclick="eliminarFila(this)">Quitar</button></td>' +
        '<td style="display:none;" > ' + data.id + ' </td>'+
        '<td style="display:none;">B</td></tr>';



    //var total= '<span>'+sumatotal.toFixed(2)+'</span>'

    $('#contentdetalle').append(htmlTags);


    actualizarPreciosVenta();

    // Es para que muestre un mensaje de alerta al tener exito en buscar el producto y agregar.
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-center",
        "preventDuplicates": true,
        "onclick": null,
        "showDuration": "100",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "show",
        "hideMethod": "hide"
    };
    toastr.success('Producto agregado!');
}



function eliminarFila(r) {
    total = 0.00;
    total2 = 0.00;
    total3 = 0.00;


    var i = r.parentNode.parentNode.rowIndex;
    document.getElementById("tablecompra").deleteRow(i);

   
    actualizarPreciosVenta();
}



function GuardarComoPedido() {
    if(!confirm("¿Está seguro que desea guardarlo como solicitud?")){
        return;
    }
    var detalleCompra = new Array();

    $.each($("#tablecompra tbody tr"), function () {
        detalleCompra.push({
            "ProductoId": parseInt($(this).find("td").eq(0).html()),
            "Cantidad": parseInt(this.querySelectorAll("td.cantidad-fila")[0].querySelectorAll("input")[0].value),
            "Precio": parseFloat(this.querySelectorAll("td.precio-fila")[0].querySelectorAll("input")[0].value),
            "Total": parseFloat(parseFloat($(this).find("td").eq(4).html()).toFixed(2)),
        });
    });

   // var pago = document.getElementById('formapagoselect').value;
    

    var datos = {
        "encabezado": {
            "Proveedor": $("#proveedorselect option:selected").text(),
            "NoComprobante": document.getElementById('nocomprobante').value,
            "EmpleadoId": parseInt(document.getElementById('empleadocompraid').value),
            "FechaLimite": document.getElementById('fechalimite').value,
            "Observacion": document.getElementById('observacion').value,
            "TipoCompraId": document.getElementById('tipolistaselect').value,
        },

        "detalle": detalleCompra,
    }

    console.log(datos);

    
   var data = { "datos": datos }

    $.ajax({
        method: "POST",
        data: JSON.stringify(datos),
        "dataType": "json",
        "contentType": "application/json",
        url: '/Compra/GuardarComoPedidoCompra',
        traditional: true,
        success: function (data) {
            alert(data);
            window.location.href = "/Compra/Modificar/" + data;
        },
        error: function (data) {
            alert(data.responseJSON.messsage);
        }
    });
}

function GuardarCompraGenerar() {
    if(!confirm("¿Está seguro que desea generar compra?")){
        return;
    }
    var detalleCompra = new Array();

    $.each($("#tablecompra tbody tr"), function () {
        detalleCompra.push({
            "ProductoId": parseInt($(this).find("td").eq(0).html()),
            "Cantidad": parseInt(this.querySelectorAll("td.cantidad-fila")[0].querySelectorAll("input")[0].value),
            "Precio": parseFloat(this.querySelectorAll("td.precio-fila")[0].querySelectorAll("input")[0].value),
            "Total": parseFloat(parseFloat($(this).find("td").eq(4).html()).toFixed(2)),
        });
    });

   // var pago = document.getElementById('formapagoselect').value;
    

    var datos = {
        "encabezado": {
            "Proveedor": $("#proveedorselect option:selected").text(),
            "NoComprobante": document.getElementById('nocomprobante').value,
            "EmpleadoId": parseInt(document.getElementById('empleadocompraid').value),
            "FechaLimite": document.getElementById('fechalimite').value,
            "Observacion": document.getElementById('observacion').value,
            "TipoCompraId": document.getElementById('tipolistaselect').value,
        },

        "detalle": detalleCompra,
    }

    console.log(datos);

    
   var data = { "datos": datos }

    $.ajax({
        method: "POST",
        data: JSON.stringify(datos),
        "dataType": "json",
        "contentType": "application/json",
        url: '/Compra/GuardarComoCompra',
        traditional: true,
        success: function (data) {
            alert(data);
            window.location.href = "/Compra/Modificar/" + data;
        },
        error: function (data) {
            alert(data.responseJSON.messsage);
        }
    });
}

function ModificarCompra(id) {

    var productoDetalleTabla = new Array();
    var productosEnBaseDeDatos = new Array();

    // $.each($("#tablecompra tbody tr td.nuevos"), function() {
    //     ids_insertados.push({
    //         "Ids": $(this).html(),
    //     });
    // });

    $.each($("#tablecompra tbody tr td.nuevo-detalle"), function () {
        productoDetalleTabla.push({
            "Ids": parseInt($(this).parent().find("td").eq(0).html()),
            "Cantidad":parseInt($(this).parent().find("td").eq(2).find("input").val()),   
            "Precio": parseInt($(this).parent().find("td").eq(3).find("input").val()), 
            "Total": parseInt($(this).parent().find("td").eq(4).html()),
        });
    });

    $.each($("#tablecompra tbody tr td.idProd"), function() {

        productosEnBaseDeDatos.push({
            "Id" : parseInt($(this).html()),
            "ProductoId": parseInt($(this).parent().find("td").eq(6).html()),
            "Cantidad":parseInt($(this).parent().find("td").eq(2).find("input").val()),   
            "Precio": parseInt($(this).parent().find("td").eq(3).find("input").val()), 
            "Total": parseInt($(this).parent().find("td").eq(4).html()),
        });
    });

    var datos = {
        "encabezado": {
            "CompraId": id,
            "Proveedor": $("#proveedorselect option:selected").text(),
            "NoComprobante": document.getElementById('nocomprobante').value,
            "EmpleadoId": parseInt(document.getElementById('empleadocompraid').value),
            "FechaLimite": document.getElementById('fechalimite').value,
            "Observacion": document.getElementById('observacion').value,
            "TipoCompraId": document.getElementById('tipolistaselect').value,
        },
        //listas
        "nuevos": productoDetalleTabla, 
        "detalle": productosEnBaseDeDatos,
    };

    console.log(datos);

    $.ajax({
        method: "POST",
        data: JSON.stringify(datos),
        "dataType": "json",
        "contentType": "application/json",
        url: '/Compra/ModificarCompra',
        traditional: true,
        success: function(data, textStatus) {
            
            alert("OK");
        },
        error: function(data) {
            alert(data.error);
        }
    });

}

function CambiarAComprado(compraId)
{
    var datos = {"compraId" : compraId};

    $.ajax({
        method: "POST",
        data: datos,
        // dataType: "json",
        // contentType: "application/json",
        url: '/Compra/CambiarAComprado/',
        traditional: true,
        success: function(data){
            alert("OK")
        },
        error: function(data){
            console.log(data);
        }
    });
}

$('#casamedicaseelecttxt').on('select2:select', function (e) {
    
    var datos = {"laboratorioId": parseInt(this.value)}
    
    $.ajax({
        method: "GET",
        data: datos,
        dataType: "json",
        "url": "/Productos/GetProductosByLaboratorioId/",
        traditional: true,
        success: function(data){
            console.log(data);
            $('#productoselecttxt').empty();
            data.forEach(el => {
                var html = '<option value="'+el.id+'">'+el.text+'</option>'
                $('#productoselecttxt').append(html);
            });
            
        },
        error: function(data)
        {
            alert(data);
        }
    });
    
  });

