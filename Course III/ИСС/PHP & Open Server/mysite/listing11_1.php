<html>
<meta charset="utf-8">
<?php
if ($_GET['enter_system']=="OK")
   { echo "Внесена оценка студента с фамилией - ".$_GET['name_of_user'];
     $f=fopen("zzzzz.txt","a+t") or die("Файл не открывается");
     flock($f,2);
     fputs($f,$_GET['name_of_user']);
     fputs($f," ");
     fputs($f,$_GET['spisok1']);
     fputs($f,"\n");
     flock($f,3);
     fclose($f);
     }
else
     echo "Ошибка ";
?>

</html>
