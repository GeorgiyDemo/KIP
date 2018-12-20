<?php
  function GetDIRFiles($folder, $space){
    $files = scandir($folder);
    foreach($files as $file) {
      if (($file == '.') || ($file == '..'))
        continue;
      if (is_dir($folder.'/'.$file))
      {
        print("<b>[ПАПКА] </b>".$space.$file."<br />");
        GetDIRFiles($folder.'/'.$file, $space.'--> ');
      }
      else
        print("<b>[ФАЙЛ] </b>".$space.$file."<br />");
    }
  }
  GetDIRFiles("./", "");
?>