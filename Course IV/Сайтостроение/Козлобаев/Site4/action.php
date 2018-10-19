<?php

    print("<h3>Контактная информация</h3>Имя: ".$_POST['name']."<br>");
    print("Телефон: ".$_POST['phone']."<br>"); 
    print("E-mail: ".$_POST['email']."<br>");
    print("Дата посещения: ".$_POST['date']."<br>");

    print("<h3>Персональная информация</h3>Возраст: ".$_POST['age']."<br>");
    print("<br><br>");
    print("<h3>Оценка нашего заведения</h3>Почему вы выбрали наше заведение?: ".$_POST['radiochoise_type']."<br>");
    print("Вы будете рекомендовать наше заведение своим знакомым?: ".$_POST['radiochoise_advice']."<br>");
?>