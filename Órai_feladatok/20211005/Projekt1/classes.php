<?php
//Ez lesz ős osztály
class Forms{
    protected $uName;
    protected $uPass;
    protected $uNameErr;
    protected $uPassErr;
   
}

//Login űrlap validálásához létrehozott osztály
class LoginCheck extends Forms{

}

//Reisztrációs űrlap validálásához létrehozott osztály
class RegCheck extends Forms{

}
?>