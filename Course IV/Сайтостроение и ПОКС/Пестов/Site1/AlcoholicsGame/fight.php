
<html>
	<head>
		<meta charset=“utf-8”> <title>Приют "Котикус"</title> 
		<meta name="viewport" content="width=device-width, initial-scale=1.0"> <link href="../css/bootstrap.min.css" rel="stylesheet"> 
		<style> [class*="col-"] { background-color: #eee; text-align: center; padding-top: 10px; padding-bottom: 10px; margin-bottom: 10px; font-size: 2rem; }
		</style> 

	</head>
	<body>

		<script src="../js/jquery.min.js"></script> 
		<script src="../js/bootstrap.min.js"></script> 
    
<?php
if (isset($_COOKIE['logined']))
{
    print('
            <ul class="nav nav-pills">
            <li role="presentation"><a href="#"><b>Добро пожаловать, '.base64_decode($_COOKIE['logined']).'</b></a></li>
            <li role="presentation"><a href="../index.php">Основное</a></li>
            <li role="presentation"><a href="../history.php">История породы</a></li>
            <li role="presentation"><a href="../veterinary.php">Уход</a></li>
            <li role="presentation"><a href="../other.php">Спонсоры</a></li>
            <li role="presentation"><a href="../about.php">О нас</a></li>
            <li role="presentation"><a href="../canvas.php">Canvas</a></li>
            <li role="presentation"><a href="../js.php">Javascript</a></li>
            <li role="presentation"><a href="../php.php">PHP</a></li>
            <li role="presentation"><a href="../computergraph.php">Графика</a></li>
            <li class="dropdown">
            <a href="#" data-toggle="dropdown" class="dropdown-toggle">
                Игры 
                <b class="caret"></b>
            </a>
                <ul class="dropdown-menu">
                    <li><a href="../citygame.php">Игра "Города" на PHP</a></li>
                    <li><a href="../snakegame.php">Игра "Змейка" на JS</a></li>
                </ul>
            </li>
            </ul>'
        );
}

else if (isset($_COOKIE['registrated']))
    {
        print('
            <ul class="nav nav-pills">
            <li role="presentation"><a href="../login.php">Вход</a></li>
            <li role="presentation"><a href="../index.php">Основное</a></li>
            <li role="presentation"><a href="../history.php">История породы</a></li>
            <li role="presentation"><a href="../veterinary.php">Уход</a></li>
            <li role="presentation"><a href="../other.php">Спонсоры</a></li>
            <li role="presentation"><a href="../about.php">О нас</a></li>
            <li role="presentation"><a href="../canvas.php">Canvas</a></li>
            <li role="presentation"><a href="../js.php">Javascript</a></li>
            <li role="presentation"><a href="../php.php">PHP</a></li>
            <li role="presentation"><a href="../computergraph.php">Графика</a></li>
            <li class="dropdown">
            <a href="#" data-toggle="dropdown" class="dropdown-toggle">
                Игры 
                <b class="caret"></b>
            </a>
                <ul class="dropdown-menu">
                    <li><a href="../citygame.php">Игра "Города" на PHP</a></li>
                    <li><a href="../snakegame.php">Игра "Змейка" на JS</a></li>
                </ul>
            </li>
            </ul>'
        );
    }

else
{
        print('
            <ul class="nav nav-pills">
            <li role="presentation"><a href="../login.php">Регистрация</a></li>
            <li role="presentation"><a href="../index.php">Основное</a></li>
            <li role="presentation"><a href="../history.php">История породы</a></li>
            <li role="presentation"><a href="../veterinary.php">Уход</a></li>
            <li role="presentation"><a href="../other.php">Спонсоры</a></li>
            <li role="presentation"><a href="../about.php">О нас</a></li>
            <li role="presentation"><a href="../canvas.php">Canvas</a></li>
            <li role="presentation"><a href="../js.php">Javascript</a></li>
            <li role="presentation"><a href="../php.php">PHP</a></li>
            <li role="presentation"><a href="../computergraph.php">Графика</a></li>
            <li class="dropdown">
            <a href="#" data-toggle="dropdown" class="dropdown-toggle">
                Игры 
                <b class="caret"></b>
            </a>
                <ul class="dropdown-menu">
                    <li><a href="../citygame.php">Игра "Города" на PHP</a></li>
                    <li><a href="../snakegame.php">Игра "Змейка" на JS</a></li>
                </ul>
            </li>
            </ul>'
        );
}
    
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


        <form action="act_fight.php" method="POST">
            <input type="text" name="point" placeholder="Число от 1 до 3" ><br/>
            <input type="submit" name="vidpr" value="Отправить"><br/>
        </form>
     </body>

</html>

    
