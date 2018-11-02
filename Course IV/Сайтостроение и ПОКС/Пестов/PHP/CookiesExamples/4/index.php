<?php
$catsmoney = array("cat1"=>12000, "cat2"=>1000, "cat3"=>3000);

print(
 "<form action='index.php' method='post'>
 <legend>Выберите котика:</legend>
 <table>
   <tr> 
     <td><label>Котик №1:</label></td><td><img src='../../../img/cat1.jpg'><br>Цена: ".$catsmoney["cat1"]." руб. <br><input type='submit' name='cat1' value='В корзину'></td>
   </tr>
   <tr>
   <td><label>Котик №2:</label></td><td><img src='../../../img/cat2.jpg'><br>Цена: ".$catsmoney["cat2"]." руб. <br><input type='submit' name='cat2' value='В корзину'></td>
   </tr>
   <tr>
   <td><label>Котик №3:</label></td><td><img src='../../../img/cat3.jpg'><br>Цена: ".$catsmoney["cat3"]." руб. <br><input type='submit' name='cat3' value='В корзину'></td>
   </tr>
 </table>
 <input type='submit' name='send' value='В корзину'>
</form>".
"<form action='output.php'>
</form>"
);

if (($_POST["city"] != Null) && ($_POST["years"] != Null))
    SetCookie("city",$_POST["city"],time()+3600);
    SetCookie("years",$_POST["years"],time()+3600);
?>