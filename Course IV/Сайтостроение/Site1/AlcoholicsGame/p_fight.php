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
    
?>
        <form name="gameover" action="index.php" method="POST">
            <input type="submit" name="ank_submit" value="В начало"><br/>
        </form>
     </body>
</html>

<?php
    session_start();
    $_SESSION['hp_serv']=0;
    $_SESSION['hp_user']=0;    
    print('Вы победили!');
    $filename="textfile/fight.txt";
    $buffer="";
    $arr_m="";
    
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