<html>
<meta charset="utf-8">
<?php
if ($_GET['enter_system']=="OK")
   { echo "Привет   ".$_GET['name_of_user'];
     $f=fopen("zzz.txt","a+t") or die("Файл не открывается");
     flock($f,2);
     fputs($f,$_GET['name_of_user']);
     fputs($f," ");
     fputs($f,$_GET['Variant']);
     fputs($f,"   ");
     flock($f,3);
     fclose($f);
     }
else
     echo "Ошибка ";
?>

</html>
