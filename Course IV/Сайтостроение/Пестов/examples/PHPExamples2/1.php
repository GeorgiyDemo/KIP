<?php
$thisnumber = strval($_POST["number"]);
$localeresult = 0;
for ($i=0;$i<strlen($thisnumber);$i++)
{
    $localeresult += intval($thisnumber[$i]);
}
print("Результат: ".$localeresult);
?>