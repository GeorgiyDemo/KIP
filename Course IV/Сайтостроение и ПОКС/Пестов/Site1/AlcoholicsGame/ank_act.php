<?php
  $hp_serv=0;
  $hp_user=0;
  $error_wr=0;
  session_start();
  $_SESSION['hp_serv']=$hp_serv; 
  $_SESSION['hp_user']=$hp_user; 
  $_SESSION['error_w']=$error_wr;
  
  //Проверка на отправлен ли запрос
  if(isset($_POST['ank_submit']))
  {
    $id=0;
    $m_name=htmlspecialchars($_POST['ank_name']);
    $ank_filename="user_ancet.txt";
    $ank_buff=null;
    $ank_id=0;
    $ank_nullstr="";
    $ank_m_strlen=0;
    
    if (file_exists($ank_filename))
    {
      if(is_writeable($ank_filename))
      {
        $ank_file_m = fopen($ank_filename,"a+");
        $ank_buff= fgets($ank_file_m);
        $lines = file($ank_filename);
        $lastLine = $lines[count($lines)-1];
        $ank_id=((int)$lastLine)+1;
        fwrite($ank_file_m,$m_name.PHP_EOL);
        fwrite($ank_file_m, $str=strval($ank_id).PHP_EOL);
        
        fclose($ank_file_m);
        $next_page="fight.php";
        header("Location:".$next_page);
      }
      else
        print("<h1 color='red'><strong>Нет доступа к файлу. Файл не доступен для записи</strong></h1>");
    
    }
    else
      print('<h1><strong>Нет файла</strong></h1>');

    $_SESSION['username']=$m_name; 
  } 
?>

