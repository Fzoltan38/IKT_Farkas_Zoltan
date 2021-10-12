<?php
include('classes.php');
if($_SERVER['REQUEST_METHOD']=='POST'){
  $con=new Connection();
  $reg=new RegCheck($_POST['uName'],$_POST['uPass'],$_POST['uFullName'],$_POST['uEmail']);
}
?>
<h2>Regisztráció</h2>
<form action="<?php echo $_SERVER['PHP_SELF'];?>?id=reglap" method="POST">
  <div class="form-group">
    <label>Felhasználónév</label>
    <input type="text" class="form-control" required  pattern="[a-zA-Z'-'\s]*" name="uName" placeholder="Gépeld be a felhasználó neved">
    <small class="form-text text-muted">A felhasználó neved ékezetet ne tartalmazzon!</small>
  </div>

  <div class="form-group">
    <label>Jelszó</label>
    <input type="password" id="Password" class="form-control" title="Figyelj a kis-nagy betűkre!" name="uPass" required pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" placeholder="Ide jöhet a jelszavad!">
  </div>

  <div class="form-group">
    <label>Jelszó mégegyszer</label>
    <input type="password" id="ConfirmPassword" class="form-control" title="Figyelj a kis-nagy betűkre!" required pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" placeholder="Ismételd meg a jelszavad!">
  </div>
  
  <div id="msg"></div><!--Jeszó vizsgálat eredményének a megjelenítése-->
  <script>
    //A két jeszó mező összehasonlítása
    //Az első jelszó mező id="Password"
    //A A második jelszó mező id="ConfirmPassword"
    $(document).ready(function(){
        $("#ConfirmPassword").keyup(function(){
             if ($("#Password").val() != $("#ConfirmPassword").val()) {
                 $("#msg").html("Jelszavak nem egyezznek!").css("color","red");
             }else{
                 $("#msg").html("Jelszavak egyezznek!").css("color","grey");
            }
      });
        $("#Password").keyup(function(){
             if ($("#Password").val() != $("#ConfirmPassword").val()) {
                 $("#msg").html("Jelszavak nem egyezznek!").css("color","red");
             }else{
                 $("#msg").html("Jelszavak egyezznek!").css("color","grey");
            }
      });
    });
  </script> 
  
  <div class="form-group">
    <label>Teljes név</label>
    <input type="text" class="form-control" name="uFullName" required placeholder="Gépeld be a neved">
    <small class="form-text text-muted">Kérem a teljes neved!</small>
  </div>
 
  <div class="form-group">
    <label>Email cím</label>
    <input type="email" class="form-control" name="uEmail" required placeholder="Gépeld be az email címed!">
    <small class="form-text text-muted">Ide jöhet az email címed, figyelj a formátumra!</small>
  </div>
  <button type="submit" class="btn btn-primary">Regisztrálás</button>
 
</form>