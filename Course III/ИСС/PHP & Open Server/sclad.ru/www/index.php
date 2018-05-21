<html>
<meta charset="utf-8">
<head><title> Авторизация  </title>
<?php
   require_once('connect.php'); 
   $sql="SELECT name FROM USERS ORDER BY name";
   $result=mysql_query($sql);
?>
   <form action="start.php" method="post">
   <select  name="z1"> 
<?php
     while ($line=mysql_fetch_row($result))
     { echo "<option value='".$line[0]."'>$line[0]";
     }
?>
</select><br><br>
 Пароль:<input type='password' name='pass1'>
<input name='enterStart' STYLE="font-size: 14pt; font-family: Tahoma, 
sans-serif"
   type='submit' value='Перейти к работе с базой'>
</form>
