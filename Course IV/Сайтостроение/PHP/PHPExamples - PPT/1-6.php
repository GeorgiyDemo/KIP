<?php
$main_arr = array(); 
$counter = 0;
for ($i = 1; $i <= 100; $i++) {
    if($i % 2 === 0){
        $main_arr[$counter]=$i;
        $counter++;
    }
}

for ($i = 0; $i <= count($main_arr); $i++) {
    if($main_arr[$i] % 5 === 0)
        print($main_arr[$i]."<br>");
}

?>