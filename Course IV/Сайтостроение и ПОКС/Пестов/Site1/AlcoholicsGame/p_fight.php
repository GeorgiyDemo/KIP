<html>    
   <head>
        <meta charset="UTF-8">
        <title>Конец игры</title>
    </head>  
    <body>
        <form name="gameover" action="index.php" method="POST">
            <input type="submit" name="ank_submit" value="В начало"><br/>
        </form>
     </body>
</html>

<?php
    session_start();
    $_SESSION['hp_serv']=0;
    $_SESSION['hp_user']=0;    
    print('Вы победили!/');
    $filename="textfile/fight.txt";
    $buffer="";
    $arr_m="";
    print('<p>');
    
    if (file_exists($filename))
    {
        $file_m = fopen($filename,"r");
        while($buffer=fgets($file_m))
            $arr_m .=$buffer."<br/>";
        print($arr_m ."<br/>");
        fclose($file_m);
    }
    
    $file_m = fopen($filename,"w");
   fclose($file_m);
   session_abort();
?>