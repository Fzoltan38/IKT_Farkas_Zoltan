<html>
    <head>
    <link rel="stylesheet" href="index.css">
    </head>

    <body>
    <h1 style="text-align:center;">Vezérlési szerkezetek</h1>
    
    <form action="index.php" method="POST">
        Kérem a kör sugarát: <input type="text" name="text1"><br>
        Mit szeretnél számolni(k,t): <input type="text" name="text2"><br>

        <input type="submit" value="Elküld">
    </form>

    </body>
    
</html>
<?php
include('feldolgoz.php');
?>
