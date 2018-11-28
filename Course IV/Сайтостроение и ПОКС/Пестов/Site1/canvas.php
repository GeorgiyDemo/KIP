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
  </body>
</html>      
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
					<li role="presentation"><a href="./veterinary.php">Уход</a></li>
					<li role="presentation"><a href="./other.php">Спонсоры</a></li>
					<li role="presentation"><a href="./about.php">О нас</a></li>
					<li role="presentation" class="active"><a href="#">Canvas</a></li>
					<li role="presentation"><a href="./js.php">Javascript</a></li>
					<li role="presentation"><a href="./php.php">PHP</a></li>
					<li role="presentation"><a href="./citygame.php">Игра "Города"</a></li>
					<li role="presentation"><a href="./computergraph.php">Графика</a></li>
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
					<li role="presentation"><a href="./veterinary.php">Уход</a></li>
					<li role="presentation"><a href="./other.php">Спонсоры</a></li>
					<li role="presentation"><a href="./about.php">О нас</a></li>
					<li role="presentation" class="active"><a href="#">Canvas</a></li>
					<li role="presentation"><a href="./js.php">Javascript</a></li>
					<li role="presentation"><a href="./php.php">PHP</a></li>
					<li role="presentation"><a href="./citygame.php">Игра "Города"</a></li>
					<li role="presentation"><a href="./computergraph.php">Графика</a></li>
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
					<li role="presentation"><a href="./veterinary.php">Уход</a></li>
					<li role="presentation"><a href="./other.php">Спонсоры</a></li>
					<li role="presentation"><a href="./about.php">О нас</a></li>
					<li role="presentation" class="active"><a href="#">Canvas</a></li>
					<li role="presentation"><a href="./js.php">Javascript</a></li>
					<li role="presentation"><a href="./php.php">PHP</a></li>
					<li role="presentation"><a href="./citygame.php">Игра "Города"</a></li>
					<li role="presentation"><a href="./computergraph.php">Графика</a></li>
					</ul>'
				);
		}
			
		?>

<canvas id="myCanvas" width="1000" height="1000"></canvas>
<script>
    	var canvas = document.getElementById('myCanvas');
    	var c = canvas.getContext('2d');
		c.canvas.width  = window.innerWidth;
		c.canvas.height = window.innerHeight;
		var cX = canvas.width / 2;
		var cY = canvas.height / 2;
		var red = "#c43511";
		var white = "#FFF";
		var black = "#000000";
		var blue = "#5e8dc1";
    	var imageObj = new Image();

    	imageObj.onload = function() {
	    	c.drawImage(imageObj, 0, 0);
	        c.beginPath();
	        c.moveTo(170, 80);
	        c.bezierCurveTo(130, 100, 130, 150, 230, 150);
	        c.bezierCurveTo(250, 180, 320, 180, 340, 150);
	        c.bezierCurveTo(420, 150, 420, 120, 390, 100);
	        c.bezierCurveTo(430, 40, 370, 30, 340, 50);
	        c.bezierCurveTo(320, 5, 250, 20, 250, 50);
	        c.bezierCurveTo(200, 5, 150, 20, 170, 80);
	        c.closePath();
	        c.lineWidth = 2;
	        c.fillStyle = blue;
	        c.fill();
	        c.strokeStyle = black;
	        c.stroke();
			c.beginPath();
			c.rect(cX - 100, cY - 50, 200, 200);
			c.moveTo(1000,1000)
			c.lineTo(1000,1000)
			c.fillStyle = red;
			c.fill();
			c.closePath();
			c.beginPath();
			c.rect(cX - 70, cY - 20, 40, 40);
			c.fillStyle = blue;
			c.fill();
			c.closePath();
			c.beginPath();
			c.moveTo(cX - 100, cY - 50);
			c.lineTo(cX, cY - 150);
			c.lineTo(cX + 100, cY - 50);
			c.lineTo(cX - 100, cY -50);
			c.fillStyle = red;
			c.fill();
			c.closePath();
			c.beginPath();
			c.rect(cX + 20, cY + 71, 50, 80);
			c.fillStyle = "#755c1d";
			c.fill();
			c.closePath();
			c.beginPath();
			c.rect(cX + 60, cY - 120, 20, 50);
			c.rect(cX + 50, cY - 130, 40, 10);
			c.fillStyle = black;
			c.fill();
			c.closePath();
			c.beginPath();
			c.moveTo(cX - 70, cY);
			c.lineTo(cX - 30, cY);
			c.moveTo(cX - 50, cY - 20);
			c.lineTo(cX - 50, cY + 20);
			c.strokeStyle = black;
			c.lineWidth = 2;
			c.stroke();
			c.closePath();
      };
      imageObj.src = './img/s1.jpg';
	</script>
	<?php

if (isset($_COOKIE['logined']))
		{
			print("
			<form action='./php/loginlogic/exitbutton.php' method='POST'>
			<button type='submit' class='btn btn-primary btn-lg'>Выход</button><br>
			</form>");
		}
?>
</body>

</html>