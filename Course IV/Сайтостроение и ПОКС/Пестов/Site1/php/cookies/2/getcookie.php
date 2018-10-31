<?php
print(
    "<form action='getcookie.php' method='get'>
<select id='drop' name='drop'>
  <option value='white'>white</option>
  <option value='silver'>silver</option>
  <option value='red'>Красный</option>
  <option value='Черный'>black</option>
</select>
<input type='submit' value='Submit!'>
</form>");

print($_GET["drop"]);
if ($_GET["drop"] != Null) {
    $styleBlock = sprintf('
      <style type="text/css">
         body {
           background:%s
         }
      </style>
    ', $_GET["drop"]);
    print($styleBlock);
  }

?>