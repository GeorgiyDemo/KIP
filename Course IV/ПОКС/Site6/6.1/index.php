<?php

  print("<title>HTML</title>
  <meta charset='utf-8' />
  <link rel='stylesheet' type='text/css' href='style.css'>");

  $link = mysqli_connect("localhost", "root", "root", "Pract5");
  if (mysqli_connect_errno()) {
      printf("Не удалось подключиться: %s\n", mysqli_connect_error());
      exit();
  }
  
  if ($result = mysqli_query($link, "SELECT * FROM SS_Products LIMIT 10"))
  {
    $fd = fopen("output.xml", 'w') or die("не удалось создать файл");
    fwrite($fd, "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<items>");
    while($stringresult = $result->fetch_array())
    {
      fwrite
      ($fd, "
        <item>
          <ProductID>".$stringresult['productID']."</ProductID>
          <name>".$stringresult['name']."</name>
          <Price>".$stringresult['Price']."</Price>
          <product_code>".$stringresult['product_code']."</product_code>
        </item>
      ");
    }
    fwrite($fd, "</items>");
      fclose($fd);
      mysqli_free_result($result);
      
  }
  mysqli_close($link);

  $filename = 'output.xml';
  $handle = fopen($filename, "rb");
  $contents = fread($handle, filesize($filename));
  fclose($handle);
  print(htmlspecialchars($contents));

?>