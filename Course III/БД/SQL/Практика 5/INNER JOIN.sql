
SELECT * FROM dbo.Состав_заказа
INNER JOIN dbo.Товары ON  dbo.Состав_заказа.Код_товара = dbo.Товары.Код