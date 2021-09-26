
<html>

<head>
    <link rel="stylesheet" href="index.css">
</head>
<?php
    
    $sugar=$valszt="";
    if(isset($_POST["text1"]))
    {
        $sugar=$_POST['text1'];

    }
    if(isset($_POST["text2"]))
    {
        $valszt=$_POST['text2'];

    }

    switch($valszt)
    {
        case 'k':{
            $k=2*$sugar*pi();
            echo($k);
            break;
        }

        case 't':{
            $t=pow($sugar,2)*pi();
            echo($t);
            break;
        }

        default:{
            if($sugar !="" || $valszt!=""){
                echo("Nincs ilyen!");
            }
        }

    }

    /*
    $homerseklet=$_POST["text1"];
    if($homerseklet<=0){
        echo("<h2 class=jeg>Szilárd halmazállapotú!</h2>");
    }
    else if($homerseklet < 100){
        echo("<h2 class=viz>Folyékony halmazállapotú!</h2>");
    }
    else {
        echo("<h2 class=goz>Légnemű halmazállapotú!</h2>");
    }*/
?>
</html>