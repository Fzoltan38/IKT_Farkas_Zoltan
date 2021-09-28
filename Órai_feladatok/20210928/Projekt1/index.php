<!DOCTYPE html>
<html lang="hu">
<head>
  <title>Projekt1</title>
  <meta charset='utf-8'>
  <meta name='viewport' content='width=device-width, initial-scale=1'>
  <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>
  <script src='https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js'></script>
  <script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js'></script>
  <script src='https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js'></script>
  
  <style>
  .fakeimg {
    height: 200px;
    background: #aaa;
  }
  </style>
</head>
<body>
      <div class='jumbotron text-center' style='margin-bottom:0'><!--Fejléc-->
      <h1>Projekt 1.0</h1>
      </div>     

      <div class="container"> <!--Keret-->   
      <div class='row flex-column-reverse flex-md-row'>

      <div class='col-md-8'><!--Menühöz tartozó tartalom-->
      <h2>Hírek</h2>
      <?php
      
      ?>
      </div>

      <div class='col-md-4 text-light bg-dark'> 
      <p>
      
    
        <?php  
          if(isset($_GET["id"]) && $_GET["id"]=='reglap'){
            include('reg.php');
          }
          else{
            include('login.php');
          }
        ?>

      </p>
      </div>
      </div>
      </div>
      
      <div class='jumbotron text-center' style='margin-bottom:0'><!--Lábléc-->
      <p>Footer</p>
      </div>
</body>
</html>