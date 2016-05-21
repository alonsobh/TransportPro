<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page.aspx.cs" Inherits="TransportPro.Web.page" %>
<!DOCTYPE html>
<html lang="es">
  <head>
    <title>Hackatrix | No te pierdas</title>
    <meta charset="utf-8">
    <meta name="description" content="Descripción de la página">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" href="images/favicon.png" type="image/png">
    <link rel="stylesheet" href="css/main.css"><!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" integrity="sha384-0mSbJDEHialfmuBBQP6A4Qrprq5OVfW37PRR3j5ELqxss1yVqOtnepnHVP9aJ7xS" crossorigin="anonymous"></script>
  </head>
  <body>
    <header>
      <div class="container">
        <!--span contenido header-->
      </div>
    </header>
    <main>
      <div class="container main">
        <h1>no te pierdas</h1>
        <div class="contenido-mapa">
          <!--.contenido-destino
          .row
              span Punto de partida
              input(type="text")
          .row
              span Punto de llegada
              input(type="text")
          
          -->
        </div>
        <form class="form-horizontal">
          <div class="form-group">
            <label class="col-sm-2">Punto de partida</label>
            <div class="col-sm-10">
              <input type="text" class="form-control" id="textPuntoInicio">
            </div>
          </div>
          <div class="form-group">
            <label class="col-sm-2">Punto de llegada</label>
            <div class="col-sm-10">
              <input type="text" class="form-control">
            </div>
          </div>
          <div class="contenido-boton"><a href="#" id="btn" class="btn btn-lg btn-primary">pon tu ruta</a></div>
        </form>
        <div class="contenido-tabla table-responsive">
          <table class="table table-striped table-bordered table-hover table-condensed" id="table">
            <thead>
              <tr>
                <th>Ruta</th>
                <th>Linea</th>
                <th>Distancia</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>ruta1</td>
                <td>linea1</td>
                <td>10km</td>
              </tr>
              <tr>
                <td>ruta1</td>
                <td>linea1</td>
                <td>10km</td>
              </tr>
              <tr>
                <td>ruta1</td>
                <td>linea1</td>
                <td>10km</td>
              </tr>
              <tr>
                <td>ruta1</td>
                <td>linea1</td>
                <td>10km</td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </main>
    <footer>
      <div class="container">
        <!--span contenido footer-->
      </div>
    </footer>
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.2/jquery.min.js"></script>
    <script src="js/min/recursos.min.js"></script>
    <script src="js/main.js"></script>
  </body>
</html>
