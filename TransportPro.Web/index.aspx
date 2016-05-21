<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TransportPro.Web.index" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <title>notepierdas | belatrix</title>
    <meta charset="utf-8">
    <meta name="description" content="Descripción de la página">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" href="images/favicon.png" type="image/png">
    <link rel="stylesheet" href="css/main.css">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" integrity="sha384-0mSbJDEHialfmuBBQP6A4Qrprq5OVfW37PRR3j5ELqxss1yVqOtnepnHVP9aJ7xS" crossorigin="anonymous"></script>

<style type="text/css">
      

        #map {
            height: 100%;
        }
    </style>
</head>
<body>
    <header>
        <div class="container">
            <!--span contenido header-->
        </div>
    </header>
    <main>
      <div class="container main">
        <div class="title">
          <h1>no te pierdas</h1>
          <h2>tu estas aqui</h2>
        </div>
        <div class="contenido-mapa">
         

            <div class="mapa">

                <div id="map"></div>
            </div>
            


        </div>
        <div class="contenido-boton"><a href="#" class="btn btn-lg btn-primary">pon tu ruta</a></div>
      </div>
    </main>
    <footer>
        <div class="container">
            <!--span contenido footer-->
        </div>
    </footer>
   
  
    
     <script async defer
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyATO6qIIrwjPUfyC4G7oxjtZszv_SWB4-k&callback=initMap">
    </script>
    <script src="js/min/recursos.min.js"></script>
    <script src="js/main.js"></script>
    <script>

        function getListPosition() {
                
            var sData = "{estado: " + estado + "}";
            var purl = "FE_Bandeja_Pendientes.aspx/";
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

                    }
                }

            });

        }


        var latLongArray = new Array();

        function Marker() {
            this.latitud;
            this.longitud;
            this.color;
        }

        var marker = new Marker();
        marker.latitud = -12.0846567;
        marker.longitud = -76.9308747;
        marker.color = "#000";
        latLongArray.push(marker);
        var marker2 = new Marker();
        marker2.latitud = -12.0823247;
        marker2.longitud = -76.9317647;
        marker2.color = "#2EFE2E";
        latLongArray.push(marker2);
        var marker3 = new Marker();
        marker3.latitud = -12.0838144;
        marker3.longitud = -76.9408897;
        marker3.color = "#0040FF";
        latLongArray.push(marker3);

        var map;
        function initMap() {
            map = new google.maps.Map(document.getElementById('map'), {
                center: { lat: -12.0846567, lng: -76.9308747 },
                zoom: 15
            });
            console.log(latLongArray);

            for (var i = 1; i < latLongArray.length; i++) {
                console.log("LATLONG");
                console.log(latLongArray[i]);

                var origen = latLongArray[i - 1];
                var destino = latLongArray[i];
                drawLines(origen, destino);

            }

            function drawLines(origin, destination) {
                console.log("ORIGEN");
                console.log(origin);
                console.log("DESTINO");
                console.log(destination);

                var location = new google.maps.LatLng(origin.latitud, origin.longitud);
                var marker = new google.maps.Marker({
                    position: location,
                    map: map
                });

                var directionsService = new google.maps.DirectionsService();
                var directionsDisplay = new google.maps.DirectionsRenderer({
                    map: map,
                    preserveViewport: true
                });

                directionsService.route({
                    origin: new google.maps.LatLng(origen.latitud, origen.longitud),
                    destination: new google.maps.LatLng(destination.latitud, destination.longitud),
                    waypoints: [{
                        stopover: false,
                        location: new google.maps.LatLng(origen.latitud, origen.longitud) //origin location
                    }],
                    travelMode: google.maps.TravelMode.DRIVING
                },

                function (response, status) {
                    if (status === google.maps.DirectionsStatus.OK) {
                        // directionsDisplay.setDirections(response);
                        var polyline = new google.maps.Polyline({
                            path: [],
                            strokeColor: destination.color,
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

    </script>
</body>
</html>
