 <HTML>
<meta charset="utf-8">
 <BODY>
<?php
if (isset($_POST['okb']))
{ if ($_POST['person']=='' or $_POST['email']=='' or $_POST['q']=='')
   {    echo "<font color='red'>Вы ввели не все данные</font>";
     echo "<br><a href=obrabotka.php>назад</a>";
     exit;   }
   echo 'Оправлено. Получатель - '.$_POST['person'];
   $komu="cashaev@rambler.ru";
   $tema="Вопрос от".$_POST['person']."  ".$_POST['email'];
   $text_pisma=$_POST['q'];
   $z=mail($komu,$tema,$text_pisma); }  
 ?>
<form action="obrabotka.php" method="post">
Имя <br>
<input type="text" name="person">
<br> E-mail<input type="text" name="email">
<br> Вопрос:<br>
<br><textarea name="q" cols=10 rows=5>
</textarea>
<br>
<input type="submit" name="okb" value="OK">
</form>

 </BODY></HTML>