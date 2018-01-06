
--Допустим, нужно получить список продавцов с их текущими заказами. Нуж
SELECT salespeople.sname, orders.onum, orders.odate FROM Salespeople JOIN Orders 
ON Salespeople.snum = orders.snum;

--Нужно получить все заказы с соответствующими именами продавцов  и покупателей.
SELECT sname, cname, onum
FROM Salespeople, Customers, Orders
WHERE Orders.snum = Salespeople.snum;
and Orders.cnum = Customers.cnum;

--Найти все пары покупателей, имеющих одинаковый рейтинг
SELECT first.cname, second.cname, first.rating
FROM Customers.first, Customers.second
WHERE first.rating = second.rating;