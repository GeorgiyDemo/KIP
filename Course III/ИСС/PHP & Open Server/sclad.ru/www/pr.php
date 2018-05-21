<meta charset="utf-8">
<?php
require_once('connect.php'); 
if (isset($_POST['enterNew'])) 
// Если это результат обработки формы данного файла
{
  // Выбор индекса склада, где располагается новый товар
  $sqlScl="SELECT id,naz FROM Scladi
           WHERE naz='".$_POST['SclNewTovar']."'";
  $dataScl=mysql_query($sqlScl);
  $lineScl=mysql_fetch_row($dataScl);
  // Запись нового товара
 $zx=$_POST['NewCol'];
 $sqlNewTov="INSERT INTO Tovar SET tovar='"
 .$_POST['NewTovar']."',idScl=".$lineScl[0].",Col=".$zx;
 mysql_query($sqlNewTov) or die(mysql_error());
}
$sql="SELECT tovar,idScl,Col FROM Tovar ORDER BY tovar";
$data=mysql_query($sql);
?>
<font style="font-size:16pt">
Имеющиеся позиции товаров  :</font>
<table border=1>
<?php
while ($line=mysql_fetch_row($data))
  {
?>
<tr><td>
<?php
echo $line[0];
?>
</td><td>
<?php 
$sql2="SELECT id,naz FROM Scladi WHERE id=".$line[1];
$data2=mysql_query($sql2);
$line2=mysql_fetch_row($data2);
echo $line2[1];
?>
</td>
<td>
<?php
echo $line[2];
?>
</td></tr>
<?php
}
?>
</table>
<div style="position:absolute;top:5;left:500">
<font size="+2"> Форма ввода новых товаров</font>
<form method='post' action=''>
<font style="font-size:16pt">
Название нового товара  :<input type='text'
        name='NewTovar' value=''><br>
<br>
<?php
  $sql3="SELECT id,naz FROM Scladi";
  $result3=mysql_query($sql3);
  echo 'Склад  :<select  name="SclNewTovar">'; 
  while ($line3=mysql_fetch_row($result3))
     { echo "<option value='".$line3[1]."'>$line3[1]";
     }
?>
</select><br><br>
Количество  :<input type='text' name='NewCol' value=''><br>
<br>
<center>
<br><input name='enterNew'
 type='submit' value='Ввести товар'>
</form>
<br>
<a  href="index.php">Вернуться на главную страницу </a>
</center>
</div>
