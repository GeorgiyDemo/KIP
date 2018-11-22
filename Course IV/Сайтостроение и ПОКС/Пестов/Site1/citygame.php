<!DOCtype html>
<html>
	<head>
		<meta charset=“utf-8”> <title>Приют "Котикус"</title> 
		<meta name="viewport" content="width=device-width, initial-scale=1.0"> <link href="css/bootstrap.min.css" rel="stylesheet"> 
		<style> [class*="col-"] { background-color: #eee; text-align: center; padding-top: 10px; padding-bottom: 10px; margin-bottom: 10px; font-size: 2rem; }
		</style> 

	</head>
	<body>
		<script src="js/jquery.min.js"></script> 
		<script src="js/bootstrap.min.js"></script> 

		<style>
			p {
    			font-size: 120%;
    		}			
			
			.col-lg-6:first-child {
  				background-color: white;
			}

			.table-responsive {
  				font-size: 120%;
  				background-color: #eee;
			}

			.label-default{
			  background-color: #337ab7;
			}
		</style>

		<?php
		if (isset($_COOKIE['logined']))
		{
			print('
					<ul class="nav nav-pills">
					<li role="presentation"><a href="#"><b>Добро пожаловать, '.base64_decode($_COOKIE['logined']).'</b></a></li>
					<li role="presentation"><a href="./index.php">Основное</a></li>
					<li role="presentation"><a href="./history.php">История породы</a></li>
					<li role="presentation" class="active"><a href="#">Уход</a></li>
				  	<li role="presentation"><a href="./other.php">Спонсоры</a></li>
				  	<li role="presentation"><a href="./about.php">О нас</a></li>
				  	<li role="presentation"><a href="./canvas.php">Canvas</a></li>
				  	<li role="presentation"><a href="./js.php">Javascript</a></li>
				  	<li role="presentation"><a href="./php.php">PHP</a></li>
					</ul>'
				);
		}

		else if (isset($_COOKIE['registrated']))
			{
				print('
					<ul class="nav nav-pills">
					<li role="presentation"><a href="./login.php">Вход</a></li>
					<li role="presentation"><a href="./index.php">Основное</a></li>
			  		<li role="presentation"><a href="./history.php">История породы</a></li>
				  	<li role="presentation" class="active"><a href="#">Уход</a></li>
					<li role="presentation"><a href="./other.php">Спонсоры</a></li>
					<li role="presentation"><a href="./about.php">О нас</a></li>
					<li role="presentation"><a href="./canvas.php">Canvas</a></li>
					<li role="presentation"><a href="./js.php">Javascript</a></li>
					<li role="presentation"><a href="./php.php">PHP</a></li>
					</ul>'
				);
			}

		else
		{
				print('
					<ul class="nav nav-pills">
					<li role="presentation"><a href="./login.php">Регистрация</a></li>
					<li role="presentation"><a href="./index.php">Основное</a></li>
			  		<li role="presentation"><a href="./history.php">История породы</a></li>
				  	<li role="presentation" class="active"><a href="#">Уход</a></li>
					<li role="presentation"><a href="./other.php">Спонсоры</a></li>
					<li role="presentation"><a href="./about.php">О нас</a></li>
					<li role="presentation"><a href="./canvas.php">Canvas</a></li>
					<li role="presentation"><a href="./js.php">Javascript</a></li>
					<li role="presentation"><a href="./php.php">PHP</a></li>
					</ul>'
				);
		}
	
	if ($_POST["startgame"] != "")
	{
		//Удаляем таблицу если есть и создаем новую;
		setcookie('gamestarted', "true", time() + 60*60*24*30, '/');
		header("Location: http://127.0.0.1:8888/SITE/citygame.php");
		exit;
	}
	
	if ($_POST["stopgame"] != "")
	{
		if (isset($_COOKIE['gamestarted'])) {
			unset($_COOKIE['gamestarted']);
			setcookie('gamestarted', null, -1, '/');
		}
	}

	if (isset($_COOKIE['gamestarted']))
	{
		if ($_POST["answer"] != "")
		{
			$link = mysqli_connect("localhost", "root", "root", "GorodaGame");
			$getname = mysqli_query($link, "SELECT name FROM city WHERE (name='".$_POST["answer"]."')");
			if ($getname->num_rows == 0)
				print("Не существует такого города '".$_POST["answer"]."'");
			else{
	
				if (mysqli_connect_errno()) {
					printf("Не удалось подключиться: %s\n", mysqli_connect_error());
					exit();
				}
				
				$result = mysqli_query($link, "SELECT name FROM city WHERE (name LIKE '".strtoupper(mb_substr($_POST["answer"], -1))."%')");
				if ($result->num_rows != 0)
				{
					print($_POST["answer"]." -> ". $result->fetch_assoc()["name"]);
				}
				
				mysqli_free_result($result);
				mysqli_free_result($getname);
				mysqli_close($link);
			}
		}
	
		print("
		<form action='citygame.php' method='POST'>
				Ваш ответ: <input type='text' name='answer'>
				<input type='submit' value = 'Отправить'>
			</form>
		");
	}
	if (isset($_COOKIE['gamestarted']))
	{
		print("<form action='citygame.php' method='POST'>
		<input type='submit' name='stopgame' value = 'Закончить игру'>
		</form>");
	}
	else
	{
		print("<form action='citygame.php' method='POST'>
		<input type='submit' name='startgame' value = 'Начать игру'>
		</form>");
	}
	
if (isset($_COOKIE['logined']))
		{
			print("
			<form action='./php/loginlogic/exitbutton.php' method='POST'>
			<button type='submit' class='btn btn-primary btn-lg'>Выход</button><br>
			</form>");
		}
?>
<small>Данная организация работает исключительно на деньги с ВАШИХ пожертвований</small>
</body>

</html>