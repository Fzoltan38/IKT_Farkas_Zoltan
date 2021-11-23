<?php
  if($_SERVER['REQUEST_METHOD']=='POST'){
    $log=new LoginCheck();
  } 
  else {
    $log=new LoginCheck();
    $log->setUNameErr("A név mezőt ki kell tölteni!");
    $log->setUPassErr("A jelszó mezőt ki kell tölteni!");
  }
?>

<h2>Bejelentkezés</h2>
<form action="<?php echo $_SERVER['PHP_SELF'];?>" method="POST">
  <div class="form-group">
    <label>Felhasználónév</label>
    <input type="text" class="form-control" required name="userName1" value="<?php echo $log->getUName();?>" placeholder="Gépeld be a neved">
    <small class="form-text text-muted" name="userInfo1"><?php echo $log->getUNameErr();?></small>
  </div>
  <div class="form-group">
    <label>Jelszó</label>
    <input type="password" class="form-control" required name="userPass1" value="<?php echo $log->getUPass();?>" placeholder="Ide jöhet a jelszavad!">
    <small class="form-text text-muted" name="userInfo2"><?php echo $log->getUPassErr();?></small>

  </div>
  <div class="form-group">
    <a href="index.php?id=reglap" style="color:white">Regisztráció</a>
  </div>
  <button type="submit" class="btn btn-primary">Elküld</button>
</form>