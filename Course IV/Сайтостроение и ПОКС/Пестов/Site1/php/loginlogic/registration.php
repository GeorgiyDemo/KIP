<?php

  $mysqli = new mysqli("localhost", "root", "root", "Pract5");
  $userlogin = md5($_POST['login']);
  $userpassword = md5($_POST['pass']);
  $username = base64_encode($_POST['name']);
  
  if (mysqli_connect_errno())
  {
      printf("Ошибка соединения: %s\n", mysqli_connect_error());
      exit();
  }

  $sql = "INSERT INTO Site1 (login, pass, name) VALUES ('$userlogin', '$userpassword', '$username')";
  if ($mysqli->query($sql) === TRUE)
  {
    setcookie('registrated', 'true', time() + 60*60*24*30, '/');
    header("Location: http://127.0.0.1:8888/SITE/index.php");
    exit;
  }

  else
  {
    echo "Ошибка: " . $sql . "<br>" . $mysqli->error;
  }

  $mysqli->close();

?>