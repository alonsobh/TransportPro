// Detecciones de ie 9 e ie8 (si no se usaran eliminar)

//conditionizr.add('ie9', function () {
//    return (Function('/*@cc_on return (/^9/.test(@_jscript_version) && /MSIE 9\.0(?!.*IEMobile)/i.test(navigator.userAgent)); @*/')());
//});

// Que hacer cuando sean positivas las detecciones (eliminar si no se usaran)

/*conditionizr.config({
    assets: 'js/',
    tests: {
        'ie8': ['class']
    }
});*/

//conditionizr.polyfill('js/min/placeholders.min.js', ['ie9','ie8']); (ejemplo de polyfill)

// Main

var map;


function initMap() {

    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: -12.0846567, lng: -76.9308747 },
        zoom: 15
    });



}

$("#btn").click(function (e) {
    var addres = $("#textPuntoInicio").val();
    //getListPosition("Av. la Fontana 1510, Lima 15024, Perú");
    var latOrigen = -12.02177;
    var longOrigen = -77.10634;
    var latdestino = -12.0399;
    var longdestino = -77.09913;
    getListPosition(latOrigen, longOrigen, latdestino, longdestino);
});

function getListPosition(locationLatitud, locationLongitud, destinationLatitud, destinationLongitud) {
    var sData = "{locationLatitud: " + locationLatitud + ",locationLongitud: " + locationLongitud + ",destinationLatitud:" + destinationLatitud + ",destinationLongitud:" + destinationLongitud + "}";
    var purl = "index.aspx/GetDate";
    $.ajax({
        type: "POST",
        url: purl,
        data: sData,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (xhr, status, error) {

        },
        success: function (resp) {
            var registros = resp.d;
            if ($.type(registros) != "null") {
                console.log("INFORMATION");
                console.log(registros);
                loadJson(registros);
                loadTable(registros);
            }
        }

    });



}
function loadTable(registros) {

    //var linea = JSON.parse(registros)[0].Detalle[0];
    //console.log(linea);
    //var location = new google.maps.LatLng(origin.latitud, origin.longitud);
    //var marker = new google.maps.Marker({
    //    position: location,
    //    map: map
    //});



}

function loadJson(registros) {


    var paraderos = JSON.parse(registros)[0].Detalle[0].Linea.Paraderos;
    console.log(paraderos);

    var paraderoOrigen = JSON.parse(registros)[0].Detalle[0].ParaderoOrigen;
    var paraderoDestino = JSON.parse(registros)[0].Detalle[0].ParaderoDestino;

    var latOrigen = paraderoOrigen.Coordenada.Latitud;
    var longOrigen = paraderoOrigen.Coordenada.Longitud;
    var latdestino = paraderoDestino.Coordenada.Latitud;
    var longdestino = paraderoDestino.Coordenada.Longitud;

    drawLines(latOrigen, longOrigen, latdestino, longdestino);

    console.log(paraderoOrigen);


    //for (var i = 1; i < paraderos.length; i++) {

    //    var latOrigen = paraderos[i - 1].Coordenada.Latitud;
    //    var longOrigen = paraderos[i - 1].Coordenada.Longitud;
    //    var latdestino = paraderos[i].Coordenada.Latitud;
    //    var longdestino = paraderos[i].Coordenada.Longitud; 

    //    drawLines(latOrigen, longOrigen, latdestino, longdestino);

    //}

    //var latOrigen = -12.08465;
    //var longOrigen = -76.93087;
    //var latdestino = -12.08788;
    //var longdestino = -76.9471;
    //drawLines(latOrigen, longOrigen, latdestino, longdestino);



    function drawLines(latOri, longOri, latDest, longDest) {

        console.log(longDest);


        var directionsService = new google.maps.DirectionsService();
        var directionsDisplay = new google.maps.DirectionsRenderer({
            map: map,
            preserveViewport: true
        });

        directionsService.route({
            origin: new google.maps.LatLng(latOri, longOri),
            destination: new google.maps.LatLng(latDest, longDest),
            waypoints: [{
                stopover: false,
                location: new google.maps.LatLng(latOri, longOri) //origin location
            }],
            travelMode: google.maps.TravelMode.DRIVING
        },

        function (response, status) {
            if (status === google.maps.DirectionsStatus.OK) {
                // directionsDisplay.setDirections(response);
                var polyline = new google.maps.Polyline({
                    path: [],
                    strokeColor: "#000",
                    strokeWeight: 3
                });
                var bounds = new google.maps.LatLngBounds();


                var legs = response.routes[0].legs;
                for (i = 0; i < legs.length; i++) {
                    var steps = legs[i].steps;
                    for (j = 0; j < steps.length; j++) {
                        var nextSegment = steps[j].path;
                        for (k = 0; k < nextSegment.length; k++) {
                            polyline.getPath().push(nextSegment[k]);
                            bounds.extend(nextSegment[k]);
                        }
                    }
                }

                polyline.setMap(map);
            } else {
                window.alert('Directions request failed due to ' + status);
            }
        }

        );
    }


}




$(document).ready(function (e) {





    //==================================


    if ($('.clase').length) {
        MyApp.seccion.modulo();
    }

    //$("#btn").click(function (e) {
    //    var addres = $("#textPuntoInicio").val();
    //    //getListPosition("Av. la Fontana 1510, Lima 15024, Perú");
    //    var latOrigen = -12.02177;
    //    var longOrigen = -77.10634;
    //    var latdestino = -12.0399;
    //    var longdestino = -77.09913;
    //    getListPosition(latOrigen, longOrigen, latdestino, longdestino);
    //});

    //Get position from addres




    //function getListPosition(locationLatitud, locationLongitud, destinationLatitud, destinationLongitud) {
    //    var sData = "{locationLatitud: " + locationLatitud + ",locationLongitud: " + locationLongitud + ",destinationLatitud:" + destinationLatitud + ",destinationLongitud:" + destinationLongitud + "}";
    //    var purl = "index.aspx/GetDate";
    //    $.ajax({
    //        type: "POST",
    //        url: purl,
    //        data: sData,
    //        contentType: "application/json; charset=utf-8",
    //        dataType: "json",
    //        error: function (xhr, status, error) {

    //        },
    //        success: function (resp) {
    //            var registros = resp.d;
    //            if ($.type(registros) != "null") {
    //                console.log("INFORMATION");
    //                console.log(registros);
    //                loadJson(registros);
    //            }
    //        }

    //    });

    //    function loadJson(registros) {
    //        var paraderos = JSON.parse(registros)[0].Detalle[0].Linea.Paraderos;
    //        console.log(paraderos);

    //        $.each(paraderos, function (i, f) {

    //            console.log(f);
    //        });

    //    }

    //}




});