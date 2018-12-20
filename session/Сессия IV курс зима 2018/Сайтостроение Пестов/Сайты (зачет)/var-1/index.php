<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Вариант 1</title>

    <!-- Подключаем стили !-->
    <link rel="stylesheet" href="styles.css">
    <link rel="stylesheet" href="slider.css">

    <!-- Подключаем jQuery для слайдера !-->
    <script src="/scripts/jquery-2.2.4.min.js"></script>

</head>
<body>

  <div class="container">
    <header>
      <div class="header-title">
        Название сайта
      </div>
    </header>

    <div class="wrapper">
      <main>
        <div class="top-menu">
          <ul>
            <li><a href="#">Главная</a></li>
            <li><a href="#">Статьи</a></li>
            <li><a href="#">Контакты</a></li>
          </ul>
        </div>

        <section class="js">
          <h2>Оценка зачётной работы</h2>
            <ul>
              <li><input type="checkbox" id="html" id="html"> HTML</li>
              <li><input type="checkbox" id="css" id="css"> CSS</li>
              <li><input type="checkbox" id="bootstrap"> Bootstrap</li>
              <li><input type="checkbox" id="spisok" onclick="toggle()"> Дополнительно
                <ul id="ul_spisok" hidden>
                  <li><input type="checkbox" id="raskr"> Раскрывающиеся меню</li>
                  <li><input type="checkbox" id="js"> JavaScript</li>
                  <li><input type="checkbox" id="slider"> Слайдер</li>
                  <li><input type="checkbox" id="php"> PHP</li>
                </ul>
              </li>
            </ul>

            <div id="total">
            </div>

            <input type="submit" onclick="buttonTotal()" name="count" value="Посчитать">

        </section>

        <section class="php">
          <h2>Подсчёт суммы чисел</h2>
          <form action="index.php" method="post" name="zadanie1">
            <label for="">Введите число</label>
            <input type="text" name="number">
            <input type="submit" name="post-button" value="Отправить">
          </form>

          <?php
          if (isset($_POST['post-button'])) {
            $number = $_POST["number"];
            $summ = 0;
            $number = str_split($number);
            for ($i=0; $i<count($number); $i++)
              $summ += $number[$i];
              echo '<b>Сумма числа:</b> ', $summ;
            }
          ?>
        </section>



      </main>

      <aside>
        <div class="side-menu">
          <ul>
            <li class="title">Меню</li>
            <li> <a href="#">Статьи</a>
            <ul>
              <li> <a href="#">Статья</a> </li>
              <li> <a href="#">Статья JS</a> </li>
              <li> <a href="#">Статья PHP</a> </li>

            </ul>  </li>
            <li> <a href="#">Контакты</a>
          </ul>
        </div>

      </aside>

    </div>

    <section class="sec-slider">
      <div class="slider">
        <ul class="slidewrapper" data-current="0">
          <li class="slide"><img src="/web-building/slider/img/1.jpg"></li>
          <li class="slide"><img src="/web-building/slider/img/2.jpg"></li>
          <li class="slide"><img src="/web-building/slider/img/3.jpg"></li>
          <li class="slide"><img src="/web-building/slider/img/4.jpg"></li>
          <li class="slide"><img src="/web-building/slider/img/5.jpg"></li>
        </ul>

        <div class="slider-nav">
          <div class="nav-left" onclick="backSlide()" id="prev"></div>
          <div class="nav-right" onclick="nextSlide()" id="next"></div>
        </div>

      </div>

      <div class="control-links">
        <span class="control-slide active">0</span>
        <span class="control-slide">1</span>
        <span class="control-slide">2</span>
        <span class="control-slide">3</span>
        <span class="control-slide">4</span>
      </div>

    </section>

    <footer>
        Потёмкин Иван Владимирович. 4ПКС-315. 
    </footer>

  </div>

<!-- Подключаем скрипты !-->
<script src="scripts.js"></script>
<script src="slider.js"></script>

</body>
</html>
