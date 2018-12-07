<?php
if(isset($_FILES['inputfile']))
  {
    $destiation_dir = dirname(__FILE__) .'/'.$_FILES['inputfile']['name'];
    move_uploaded_file($_FILES['inputfile']['tmp_name'], $destiation_dir );
    print("Ваше изображение:<br><img src='".'./'.$_FILES['inputfile']['name']."'>");
  }
else
  {
    print
    ("
    <form method='POST' action='index.php' enctype='multipart/form-data'>
    <label for='inputfile'>Upload File</label>
    <input type='file' id='inputfile' name='inputfile'></br>
    <input type='submit' value='Click To Upload'>
    </form>"
    );
  }
?>