  <?php 
    session_start();
    $hp_serv = (int)$_SESSION['hp_serv'] ;
    $hp_user = (int)$_SESSION['hp_user']; 

    $p_vin="p_fight.php";
    $s_vin="s_fight.php";
    $next_f="fight.php";

    $error_wr=0;
    
    $vari=(htmlspecialchars($_POST['point']));
    if(($vari>3)or($vari<1))
    {
      $error_wr=1;$_SESSION['error_w']=$error_wr;
      header("Location: $next_f");
      exit;
    }
    
    $r_vari=rand(1,3);
    $damag=rand(1,4);
      
    $filename="textfile/fight.txt";
    $f_file_m = fopen($filename,"a+");
    $dam_y="Промах. Нанесен вред себе - ".$damag;
    $dam_s="Нанесен вред оппоненту - ".$damag;
      
    if ($vari==$r_vari)
    {
      fwrite($f_file_m,$dam_y.PHP_EOL);/*print("Вы настолько бухие что промахнулись и попали по себе и нанесли $damag вреда");*/
      $hp_serv=$hp_serv+$damag;
      $_SESSION['hp_serv']=$hp_serv;
      $_SESSION['hp_user']=$hp_user;
    }
    else
    {
      fwrite($f_file_m,$dam_s.PHP_EOL);
      $hp_user=$hp_user+$damag;/*print("Вы нанесли оппоненту $damag вреда");*/
      $_SESSION['hp_serv']=$hp_serv; 
      $_SESSION['hp_user']=$hp_user;
    }
    
    if ($hp_serv>=10)
    {
      header("Location: $p_vin");
    }
    else if($hp_user>=10)
    {
      header("Location: $s_vin");
    }
    else
    {
      header("Location: $next_f");
      exit;
    }

    fclose($f_file_m);
  ?>