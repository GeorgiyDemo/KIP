<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head>
	<meta http-equiv="content-type" content="text/html; charset=utf-8" />
	<title>Задание 7</title>
</head>
<body>
	<?php 
	    $a = strval($_POST["number"]);
		$a = (string) round(($a * 12/360), 2);
		$hour = str_split($a);
		$max = count($hour);
		$i = 0;
		$min = 0;
		while($i <= $max-1)
		{
			if($i == ($max - 2) || $i == ($max - 1))
			{
				if($hour[$i] == 0)
				{
					$hour[$i] = '0';
				}
				$min =$min.$hour[$i];
			}
			$i++;
		}
		$min = round($min * 0.6);
		echo "<br/>";
		echo $hour[0].$hour[1]." ч ".$min." мин";
	?>
</body>
</html>
