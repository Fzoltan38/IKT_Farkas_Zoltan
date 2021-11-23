<?php
//Ez lesz ős osztály
class Forms{
    protected $uName;
    protected $uPass;
    

    public function getUName(){
        return $this->uName;
    }

    public function getUPass(){
        return $this->uPass;
    }
}
//Login űrlap validálásához létrehozott osztály
class LoginCheck extends Forms{
    private $uNameErr;
    private $uPassErr;

    public function getUNameErr(){
        return $this->uNameErr;
    }

    public function getUPassErr(){
        return $this->uPassErr;
    }

    function __construct($name, $password){
        $this->uName=$name;
        $this->uPass=$password;

        if(empty($this->getUName())){
            $this->uNameErr="A név mező nem lehet üres!";
        }
        else if(!preg_match("/^[a-zA-Z-' ]*$/",$this->getUName())){
            $this->uNameErr="Nem megfelelő formátum!";
        }
        else{
            $this->uNameErr="";
        }   

        $num=8-strlen($this->getUPass());
        if(empty($this->getUPass())){
            $this->uPassErr="A jeszó mező nem lehet üres!";
        }
        else if(strlen($this->getUPass())<8){
            $this->uPassErr="A jeszó legalább 8 karakter legyen! Még: $num karakter kell!";
        }
        else{
            $this->uPassErr="";
        }  
    } 
}
//Reisztrációs űrlap validálásához létrehozott osztály
class RegCheck extends Forms{
    private $uFullName;
    private $uEmail;

    function getUFullName(){
        return $this->uFullName;
    }
    function getUEmail(){
        return $this->uEmail;
    }

    function __construct($name,$password,$fname,$email){
        $this->uName=$name;
        $this->uPass=md5($password);
        $this->uFullName = $fname;
        $this->uEmail = $email;

        $sql = "INSERT INTO `users`(`uname`, `email`, `pwd`, `fullname`, `active`, `rank`, `ban`, `reg_time`, `log_time`) VALUES ('".$this->getUName()."','".$this->getUEmail()."','".$this->getUPass()."','".$this->getUFullName()."',0,0,0,'".date('Y-m-d-H-i')."','0')";
        
        $c=new Connection();
        if (mysqli_query($c->getConn(), $sql)) {
            echo "Új rekord felöltése sikeres volt.";
          } else {
            echo "Error: " . $sql . "<br>" . mysqli_error($c->getConn());
          }
          
        mysqli_close($c->getConn());
        //header('location:index.php');
    }
}

class Connection{
    private $servername;
    private $username;
    private $password;
    private $db;
    private $conn; 
    
    public function getConn(){
        return $this->conn;
    }
    
    function __construct() {
        $this->servername = "localhost";
        $this->username = "root";
        $this->password = "";
        $this->db = "projekt1";
        $this->conn = mysqli_connect($this->servername, $this->username, $this->password, $this->db);
        
        if ($this->conn->connect_error) {
            die("Connection failed: " . $this->conn->connect_error);
        }
    }
}
?>