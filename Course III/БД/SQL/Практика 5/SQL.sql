1) SELECT * FROM Orders WHERE Orders WHERE Odate = '2000-03-10' OR Odate = '2000-04-10'
2) SELECT names FROM customers WHERE cname BETWEEN LIKE 'A%' AND LIKE 'G%'; 
3) SELECT * FROM Customers WHERE Cname LIKE ‘C%’ OR Cname LIKE ‘c%’;
4) SELECT * FROM Orders WHERE (Amt is NULL) OR (Amt=0);
5) SELECT COUNT(*) FROM Orders WHERE(Odate='2000-03-10')
6) SELECT * COUNT(city) Distinct FROM Customers WHERE city IS NOT NULL;
7) SELECT CNAME FROM Customers GROUP BY cnum;
8) SELECT MIN(cname) FROM customers WHERE Cname LIKE '6%'
9) SELECT MAX(Rate) FROM customers GROUP BY city; 
10) SELECT odate, COUNT(DISTINCT snum) FROM orders Group by odate

SELECT [DISTINCT] <имя столбца>
FROM <названия таблиц>
[WHERE <условие отбора>]
[ORDER BY <список полей, по которым упорядочивается вывод записей>]
[GROUP BY <список полей группировки>]
[HAVING <условие отбора>]

В [] пишем то, что не обязательно

1)
В разделе ORDER BY задается список полей, которые определяют порядок сортировки
по умолчанию он по возрастанию, если по убыванию - требуется добавить DESC

GROUP BY - задается список полей группировки
В having задается условие отбора для каждой группы

Предложение GROUP BY позволяет выделить из отдельного столбца подмножество значений и применить к нему агрегатную функцию

2)
Допустим, требуется найти самый крупный заказ, полученный каждым продавцом. 
SELECT snumb MAX(amt) FROM Orders Group BY snum;

Разрешается использовать GROUP BY c несколькими столбцами
Например, требуется найти самые крупные заказы, получаемые продавцами в течении 

SELECT SNUM, odate, MAX (amt)
FROM Orders
GROUP BY snum, odate;

