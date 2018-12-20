<!DOCtype html>

<html>
	<head>
		<meta charset=“utf-8”> <title>Приют "Котикус"</title> 
		<meta name="viewport" content="width=device-width, initial-scale=1.0"> <link href="css/bootstrap.min.css" rel="stylesheet"> 
		<!-- <script src="js/secred.js"></script> -->
		<!-- <script src="js/pass.js"></script> -->
		<link rel="stylesheet" type="text/css" href="./css/snakestyle.css">
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
					<li role="presentation"><a href="./veterinary.php">Уход</a></li>
					<li role="presentation"><a href="./other.php">Спонсоры</a></li>
					<li role="presentation"><a href="./about.php">О нас</a></li>
					<li role="presentation"><a href="./canvas.php">Canvas</a></li>
					<li role="presentation"class="active"><a href="#">Javascript</a></li>
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
					<li role="presentation"><a href="./veterinary.php">Уход</a></li>
					<li role="presentation"><a href="./other.php">Спонсоры</a></li>
					<li role="presentation"><a href="./about.php">О нас</a></li>
					<li role="presentation"><a href="./canvas.php">Canvas</a></li>
					<li role="presentation"class="active"><a href="#">Javascript</a></li>
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
					<li role="presentation"><a href="./veterinary.php">Уход</a></li>
					<li role="presentation"><a href="./other.php">Спонсоры</a></li>
					<li role="presentation"><a href="./about.php">О нас</a></li>
					<li role="presentation"><a href="./canvas.php">Canvas</a></li>
					<li role="presentation"class="active"><a href="#">Javascript</a></li>
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

		<div class="alert alert-info" role="alert">В данном разделе представлены примеры работ на JavaScript</div>
		
		<h2 class="w3-center">Слайдшоу</h2>

		<div class="w3-content w3-display-container">
		<img class="mySlides" src="./img/cat1.jpg" style="width:50%">
		<img class="mySlides" src="./img/cat2.jpg" style="width:50%">
		<img class="mySlides" src="./img/cat3.jpg" style="width:50%">
		<img class="mySlides" src="./img/cat4.jpg" style="width:50%">

		<button class="w3-button w3-black w3-display-left" onclick="plusDivs(-1)">&#10094;</button>
		<button class="w3-button w3-black w3-display-right" onclick="plusDivs(1)">&#10095;</button>
		</div>

		<script type="text/javascript">
			//document.write("1. Лес - часть поверхности Земного шара, покрытая древесными растениями<br>2. В настоящее время коты красавчики");
		</script>

		<script type="text/javascript">
			document.write(var1)

			if (var1==25)
				document.write("A");
			if (var1>15)
				document.write("Ж");
			if (var1<33)
				document.write("К");
			if (var2==10)
				document.write("А");
			if ((var1+var2)==30)
				document.write("Д");
			if((var2-var1)==7)
				document.write("Ш");
			if(var3<6)
				document.write("М");
			if((var3==8) && ((var1+var2)==17))
				document.write("З");
			if((var3-var2)==(var1+var2))
				document.write("Н");
			if(var4==(var1+var2+var3))
				document.write("А");
			if(var4>((var2-var3)*4))
				document.write("Н");
			if(var5==(var1*4))
				document.write("Б");
			if(var5==(var2*3))
				document.write("Ь");
			if(((var1+var2+var3+var4+var5)/3)>60)
				document.write("К");
		</script> 

		<script type="text/javascript">

			for (var ch1=0; ch1 < arr.length; ch1++){

				for (var ch2=ch1+1; ch2 < arr.length+1; ch2++){
					if (arr[ch1]>arr[ch2]){

						var buf = arr[ch2];
						arr[ch2] = arr[ch1];
						arr[ch1] = buf;
					}
				}
			}
			alert(arr)

			document.write("<br>")
			for (var checkchar=0; checkchar < 10000; checkchar+=20)
				document.write("<b>Число<b>"+checkchar+"<br></b>")
		</script> 

		<script>
		var slideIndex = 1;
		showDivs(slideIndex);

		function plusDivs(n) {
		showDivs(slideIndex += n);
		}

		function showDivs(n) {
		var i;
		var x = document.getElementsByClassName("mySlides");
		if (n > x.length) {slideIndex = 1}    
		if (n < 1) {slideIndex = x.length}
		for (i = 0; i < x.length; i++) {
			x[i].style.display = "none";  
		}
		x[slideIndex-1].style.display = "block";  
		}
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