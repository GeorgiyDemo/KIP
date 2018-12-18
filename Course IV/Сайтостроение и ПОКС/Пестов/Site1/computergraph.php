<!DOCtype html>

<html>
    <head>
        <meta charset=“utf-8”> <title>Приют "Котикус"</title> 
        <meta name="viewport" content="width=device-width, initial-scale=1.0"> <link href="css/bootstrap.min.css" rel="stylesheet"> 
        <!-- <script src="js/secred.js"></script> -->
        <!-- <script src="js/pass.js"></script> -->
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
					<li role="presentation"><a href="./js.php">Javascript</a></li>
					<li role="presentation"><a href="./php.php">PHP</a></li>
					<li role="presentation" class="active"><a href="#">Графика</a></li>
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
					<li role="presentation"><a href="./js.php">Javascript</a></li>
					<li role="presentation"><a href="./php.php">PHP</a></li>
					<li role="presentation" class="active"><a href="#">Графика</a></li>
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
					<li role="presentation"><a href="./js.php">Javascript</a></li>
					<li role="presentation"><a href="./php.php">PHP</a></li>
					<li role="presentation" class="active"><a href="#">Графика</a></li>
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

        <div class="alert alert-info" role="alert">В данном разделе представлены все работы, связанные с дисциплиной "Компьютерная графика"</div>

        <div class="container">
        
            <h2>Примеры работы в CorelDRAW</h2>      
            <table style="width:100%">
            <tr>
                <th>Название</th>
                <th>Рисунок</th> 
            </tr>
            <tr>
                <td><h4>Пример анимации в CorelDRAW</h4></td>
                <td><img src="./img/КГ/corel/ULITKA.gif" width="189" height="255" ></td> 
            </tr>
            <tr>
                <td><h4>Пример анимации в CorelDRAW (альтернатива)</h4></td>
                <td><img src="./img/КГ/corel/CAR.gif" width="295" height="261" ></td> 
            </tr>
            <tr>
                <td><h4>Пример логотипа колледжа №1</h4></td>
                <td><img src="./img/КГ/corel/collegelogo1.png" width="218" height="149"></td> 
            </tr>
            <tr>
                <td><h4>Пример логотипа колледжа №2</h4></td>
                <td><img src="./img/КГ/corel/collegelogo2.png" width="218" height="149" ></td> 
            </tr>
            <tr>
                <td><h4>Построение рисунка с использованием прямоугольников, эллипсов и многоугольников</h4></td>
                <td><img src="./img/КГ/corel/5.png" width="284" height="368" ></td> 
            </tr>
            <tr>
                <td><h4>Создание логотипа</h4></td>
                <td><img src="./img/КГ/corel/4.png" width="185" height="207" ></td> 
            </tr>
            <tr>
                <td><h4>Клоны и клонирование эффектов</h4></td>
                <td><img src="./img/КГ/corel/3.png" width="218" height="149" ></td> 
            </tr>
            <tr>
                <td><h4>Клоны и клонирование эффектов (альтернатива)</h4></td>
                <td><img src="./img/КГ/corel/7.png" width="224" height="224" ></td> 
            </tr>
            <tr>
                <td><h4>Фигурная обрезка</h4></td>
                <td><img src="./img/КГ/corel/1.png" width="218" height="149" ></td> 
            </tr>
            <tr>
                <td><h4>Построение фигурной обрезки</h4></td>
                <td><img src="./img/КГ/corel/6.png" width="249" height="249" ></td> 
            </tr>
            <tr>
                <td><h4>Редактирование контейнера фигурной обрезки</h4></td>
                <td><img src="./img/КГ/corel/2.png" width="212" height="263" ></td> 
            </tr>
            <tr>
                <td><h4>Пошаговые переходы вдоль траектории</h4></td>
                <td><img src="./img/КГ/corel/8.png" width="206" height="292" ></td> 
            </tr>
            <tr>
                <td><h4>Портрет под стеклом</h4></td>
                <td><img src="./img/КГ/corel/9.png" width="253" height="279" ></td> 
            </tr>
            <tr>
                <td><h4>Фрукты</h4></td>
                <td><img src="./img/КГ/corel/fruits.png" width="290" height="109" ></td> 
            </tr>
            
            </table>

            <h2>Примеры работы в Photoshop</h2>      
            <table style="width:100%">
            <tr>
                <th>Название</th>
                <th>Изображение</th> 
            </tr>
            <tr>
                <td><h4>Пример баннеров-анимации в Photoshop</h4></td>
                <td><img src="./img/КГ/photoshop/banners.gif" width="514" height="147" ></td> 
            </tr>
            <tr>
                <td><h4>Пример логотипа колледжа №1</h4></td>
                <td><img src="./img/КГ/photoshop/collegelogo1.png" width="300" height="300" ></td> 
            </tr>
            <tr>
                <td><h4>Пример логотипа колледжа №2</h4></td>
                <td><img src="./img/КГ/photoshop/collegelogo2.png" width="300" height="300" ></td> 
            </tr>
            <tr>
                <td><h4>Разработка шаблона сайта</h4></td>
                <td><img src="./img/КГ/photoshop/sitemarkdown.png" width="500" height="500" ></td> 
            </tr>
           
            
            </table>

        </div>
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