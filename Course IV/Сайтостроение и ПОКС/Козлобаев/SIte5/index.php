<?php

  print("<title>HTML</title>
  <meta charset='utf-8' />
  <link rel='stylesheet' type='text/css' href='style.css'>");

  $link = mysqli_connect("localhost", "root", "root", "Pract5");
  if (mysqli_connect_errno()) {
      printf("Не удалось подключиться: %s\n", mysqli_connect_error());
      exit();
  }

  $sql = 'SHOW COLUMNS FROM SS_Products';
  $res = $link->query($sql);

  print("<table> 
  <tr id='header'>");

  while($row = $res->fetch_assoc()){
    print("<th>".$row['Field']."</th>");
  }
  print("</tr>");
  if ($result = mysqli_query($link, "SELECT * FROM SS_Products LIMIT 50"))
  {

      while($stringresult = $result->fetch_array())
        print("<tr><td>".$stringresult['productID'].
              "</td><td>".$stringresult['categoryID'].
              "</td><td>".$stringresult['name'].
              "</td><td>".$stringresult['description'].
              "</td><td>".$stringresult['customers_rating'].
              "</td><td>".$stringresult['Price'].
              "</td><td>".$stringresult['Price'].
              "</td><td>".$stringresult['in_stock'].
              "</td><td>".$stringresult['customer_votes'].
              "</td><td>".$stringresult['items_sold'].
              "</td><td>".$stringresult['enabled'].
              "</td><td>".$stringresult['list_price'].
              "</td><td>".$stringresult['product_code'].
              "</td><td>".$stringresult['sort_order'].
              "</td><td>".$stringresult['default_picture'].
              "</td><td>".$stringresult['date_added'].
              "</td><td>".$stringresult['date_modified'].
              "</td><td>".$stringresult['viewed_times'].
              "</td><td>".$stringresult['eproduct_filename'].
              "</td><td>".$stringresult['eproduct_available_days'].
              "</td><td>".$stringresult['eproduct_download_times'].
              "</td><td>".$stringresult['weight'].
              "</td><td>".$stringresult['meta_description'].
              "</td><td>".$stringresult['meta_keywords'].
              "</td><td>".$stringresult['free_shipping'].
              "</td><td>".$stringresult['min_order_amount'].
              "</td><td>".$stringresult['shipping_freight'].
              "</td><td>".$stringresult['classID'].
              "</td>"
              
            );
      mysqli_free_result($result);
  }
  print("</table>");
  mysqli_close($link);

?>