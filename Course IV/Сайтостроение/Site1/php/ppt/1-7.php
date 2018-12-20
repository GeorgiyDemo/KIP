<?php
$doublearr = array(
    array("Геннадий", "Кирилл" , "Анастасия"),  //Name
    array("Одинцово", "Боброво" , "ВДНХ"), //Addres
    array("+79954353464", "+799567753664" , "+79932153464"), //Phone
    array("odi@gmail.com", "kot@kot.ru" , "meow@meow.com")   //Mail
);

$doublearr = array (
    'Name' => array("Геннадий", "Кирилл" , "Анастасия"), 
    'Addres' => array("Одинцово", "Боброво" , "ВДНХ"),
    'Phone' => array("+79954353464", "+799567753664" , "+79932153464"),
    'Mail' => array("odi@gmail.com", "kot@kot.ru" , "meow@meow.com")
);

echo '<table cellpadding="5" cellspacing="0" border="1">';
for ($i=0;$i<count($doublearr)-1;$i++){
    echo "<tr>";
    foreach($doublearr as $key => $value) 
    { 
        echo "<td>".$key = $value[$i]."</td>";
    } 
    echo "</tr>";
}
echo "</table>";

    
?>