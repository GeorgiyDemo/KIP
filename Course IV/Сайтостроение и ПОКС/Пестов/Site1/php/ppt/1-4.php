<?php
$x = 20;
$y = 30;
$output_first = (($x*2)>$y) ? 50 : 0;
$x = 5;
$output_second = (($x*2)>$y) ? 50 : 0;
print('Выполнение первого условия в переменной $output_first: '.$output_first."<br>");
print('Выполнение второго условия в переменной $output_second: '.$output_second."<br>");

?>