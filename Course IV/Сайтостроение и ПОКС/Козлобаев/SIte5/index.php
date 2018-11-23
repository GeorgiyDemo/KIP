<?php
print("MEOW");
/*
print("  <style type='text/css'>
.layout {
 width: 100%;
}
TD {
 vertical-align: top;
 padding: 5px;
}
TD.leftcol {
 width: 200px;
 background: #ccc;
}
TD.rightcol {
 background: #fc3;
}
</style>");


$link = mysqli_connect("localhost", "root", "root", "Pract5");
    $checkdublicate = mysqli_query($link, "SELECT * FROM Pract5.'Table';");
    if ($checkdublicate->num_rows == 0)
    {
        var_dump(fetch_assoc());
        $finalresult->fetch_assoc();
        foreach($finalresult as $key=>$value)
            print($key." ".$value);
    }

print("
 <form>
 <legend>Таблица:</legend>
 <table cellspacing='0' class='layout'>
 <tr> 
  <td class='leftcol'><b>Название товара</b></td>
  <td class='rightcol'><b>Цена<b>
  </td>
 </tr>
  </form>
");
/*
  $finalprice = 0;
  foreach($_COOKIE as $key=>$value)
  {
    print(" <tr> 
    <td class='leftcol'>".$catsnamesarr[$key]."</td>
    <td class='rightcol'>".$catspricearr[$key]." руб."."</td>
   </tr>");
   $finalprice +=(double) $catspricearr[$key];
  }

print(
  "<tr> 
  <td class='leftcol'><b>Итог:</b></td>
  <td class='rightcol'><b>".$finalprice." руб.<b></td>
 </tr>
 </table>
 </form>
 <form action='index.php' method='post'>
 <input type='submit' name='send' value='К списку товаров'>
</form>");

*/
?>