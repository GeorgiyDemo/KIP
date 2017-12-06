SELECT * FROM dbo.Состав_заказа
LEFT OUTER JOIN dbo.Товары ON dbo.Состав_заказа.Код_товара = dbo.Товары.Код