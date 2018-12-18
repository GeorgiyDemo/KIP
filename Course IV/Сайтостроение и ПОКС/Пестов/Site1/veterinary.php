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
					<li role="presentation"><a href="./computergraph.php">Графика</a></li>
					<li class="dropdown">
					<a href="#" data-toggle="dropdown" class="dropdown-toggle">
						Игры 
						<b class="caret"></b>
					</a>
						<ul class="dropdown-menu">
							<li><a href="./citygame.php">Игра "Города" на PHP</a></li>
							<li><a href="./snakegame.php">Игра "Змейка" на JS</a></li>
						</ul>
					</li>
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
					<li role="presentation"><a href="./computergraph.php">Графика</a></li>
					<li class="dropdown">
					<a href="#" data-toggle="dropdown" class="dropdown-toggle">
						Игры 
						<b class="caret"></b>
					</a>
						<ul class="dropdown-menu">
							<li><a href="./citygame.php">Игра "Города" на PHP</a></li>
							<li><a href="./snakegame.php">Игра "Змейка" на JS</a></li>
						</ul>
					</li>
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
					<li role="presentation"><a href="./computergraph.php">Графика</a></li>
					<li class="dropdown">
					<a href="#" data-toggle="dropdown" class="dropdown-toggle">
						Игры 
						<b class="caret"></b>
					</a>
						<ul class="dropdown-menu">
							<li><a href="./citygame.php">Игра "Города" на PHP</a></li>
							<li><a href="./snakegame.php">Игра "Змейка" на JS</a></li>
						</ul>
					</li>
					</ul>'
				);
		}
			
		?>

		<h1>Уход<small> за сиамской кошкой</small></h1>
		<p>Сиамские кошки отличаются независимостью и высоким интеллектом, идеально подходят в качестве котов-партнеров. При содержании питомца этой породы в квартире или частном доме нужно помнить о том, что кот больше всего ценит уважение и внимание, поэтому ни в коем случае нельзя его бить, кричать на него. Сиамские кошки не требуют особого комфорта, им главное – внимание того человека, которого они выбрали хозяином (это не обязательно должен быть тот, кто купил котенка и кормит его).</p>
		
		<h2>Условия жизни сиамской кошки</h2>
		<p>Одна из важных положительных привычек сиамской кошки – чистоплотность. Кошке нужно организовать собственное уютное пространство, в котором питомцев будет чувствовать себя как в укрытии. Желательно расположить лежанку на некотором возвышении, т.к. коты этой породы очень любят наблюдать за всем происходящим. Важным условием является оборудование спального места питомцу в теплом сухом месте, т.к. из-за постоянной сырости и влажности у кошки могут появиться проблемы с бронхами.</p>

		<h2>Привычки и повадки сиамов</h2>
		<p>Привязываясь к одному хозяину, сиамский кот может начать ревновать его к другим домашним животным, а также другим членам семьи. Умные и хитрые животные, которые легко обучаются. Имеют пронзительный голос, которым пользуются, чтобы добиться желаемого. С помощью своих длинных лап могут научиться открывать сумки, ящички, шкафы, чтобы достать нужный предмет.</p>

		<h2>Примечание</h2>
		<p>Кошки сиамские очень чувствительны к анестезии.
		Стоит иметь в виду, что каждая кошка индивидуальна. Данное описание характерно для породы в целом и не всегда полностью совпадает с характеристиками конкретной кошки этой породы!</p>
<?php

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