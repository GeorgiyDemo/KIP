<?php

  print("<title>HTML</title>
  <meta charset='utf-8' />
  <link rel='stylesheet' type='text/css' href='style.css'>");

  $link = mysqli_connect("localhost", "root", "root", "Pract5");
  if (mysqli_connect_errno()) {
      printf("Не удалось подключиться: %s\n", mysqli_connect_error());
      exit();
  }

  print("<table> 
  <tr id='header'>");

    print("<th>productID</th>".
    "<th>categoryID</th>".
    "<th>name</th>".
    "<th>customers_rating</th>".
    "<th>Price</th>"
  );

  print("</tr>");
  if ($result = mysqli_query($link, "SELECT * FROM SS_Products LIMIT 150"))
  {

      while($stringresult = $result->fetch_array())
        print("<tr><td>".$stringresult['productID'].
              "</td><td>".$stringresult['categoryID'].
              "</td><td>".$stringresult['name'].
              "</td><td>".$stringresult['customers_rating'].
              "</td><td>".$stringresult['Price'].
              "</td>"
              
            );
      mysqli_free_result($result);
  }
  print("</table>");
  mysqli_close($link);

?>