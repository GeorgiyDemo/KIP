<?php
$int = strval($_POST["count_number"]);
$thisnumber = strval($_POST["number"]);
echo "Цифра ".$int." в числе ".$thisnumber." встречается ".substr_count($thisnumber, $int)." раза";
?>