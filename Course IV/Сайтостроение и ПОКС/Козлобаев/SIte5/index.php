<?php

  print("<title>HTML</title>
  <meta charset='utf-8' />
  <link rel='stylesheet' type='text/css' href='style.css'>");

  $link = mysqli_connect("localhost", "root", "root", "Pract5");
  if (mysqli_connect_errno()) {
      printf("Не удалось подключиться: %s\n", mysqli_connect_error());
      exit();
  }

  $sql = 'SHOW COLUMNS FROM ThisTable';
  $res = $link->query($sql);

  print("<table> 
  <tr id='header'>");

  while($row = $res->fetch_assoc()){
    print("<th>".$row['Field']."</th>");
  }
  print("</tr>");
  if ($result = mysqli_query($link, "SELECT * FROM ThisTable "))
  {

      while($stringresult = $result->fetch_array())
        print("<tr><td>".$stringresult['id']."</td><td>".$stringresult['name']."</td><td>".$stringresult['phone']."</td><td>".$stringresult['address']."</td></tr>");
      mysqli_free_result($result);
  }
  print("</table>");
  mysqli_close($link);

?>