<?php
$sqlhost="localhost";
$sqluser="root";
$sqlpass="";
$db="Firma";
mysql_connect($sqlhost,$sqluser,$sqlpass) or die("MySQL не доступен! 
".mysql_error());
mysql_select_db($db) or die("Нет соединения с базой 
данных".mysql_error());
?>
