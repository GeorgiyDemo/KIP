<?php
    session_start();
    $hp_serv = 10-(int)$_SESSION['hp_serv'];
    $hp_user = 10- (int)$_SESSION['hp_user'];
    $name=$_SESSION['username'];
    $error=(int)$_SESSION['error_w'];

    if ($error==1)
        print('Ошибка ввода, повторите попытку!'.'<br><br>');
 
    print('HP алкоголик <b>'.$name.'</b> => '.$hp_user."<br>");
    print('HP алкоголик <b>Вася</b> => '.$hp_serv."<br><br>");
?>

<html>
   <head>
        <meta charset="UTF-8">
        <title>Бой</title>
    </head>
    </body>
        <form action="act_fight.php" method="POST">
            <input type="text" name="point" placeholder="Число от 1 до 3" ><br/>
            <input type="submit" name="vidpr" value="Отправить"><br/>
        </form>
     </body>

</html>

    
