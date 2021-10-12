<?php
class Connection{

    private $servername;
    private $username;
    private $password;
    private $db;
    private $conn; 
   
    
    function __construct($servername, $username, $password,$db) {
        $this->servername = $servername;
        $this->username = $username;
        $this->password = $password;
        $this->db = $db;
        $this->conn = new mysqli($servername, $username, $password, $db);
    }

}    
?>