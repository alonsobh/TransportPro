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

var MyApp;

var MyApp = {

    seccion: {
        modulo: function () {
        }
    }
}

$(document).ready(function (e) {

    if ($('.clase').length) {
        MyApp.seccion.modulo();
    }

    $("#btn").click(function (e) {
        var addres = $("#textPuntoInicio").val();
        getListPosition("Av. la Fontana 1510, Lima 15024, Perú");
    });

    //Get position from addres

    function getListPosition(addres) {

        //var sData = "{estado: " + estado + "}";
        function getListPosition(addres) {

            var purl = "https://maps.googleapis.com/maps/api/geocode/json?address=" + addres + "";
            $.ajax({
                type: "POST",
                url: purl,
                //data: sData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                error: function (xhr, status, error) {

                },
                success: function (resp) {
                    var registros = resp.d;
                    if ($.type(registros) != "null") {
                        console.log("INFORMATION");
                        console.log(registros);
                    }
                }

            });

        }
    }

});