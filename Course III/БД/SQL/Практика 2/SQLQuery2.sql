/*
2.	Создайте таблицу предметов обучения SUBJECT так, чтобы количество 
отводимых на предмет часов по умолчанию было равно 36, не допускались 
записи с отсутствующим количеством часов, поле SUBJ_ID являлось первичным
 ключом таблицы и значения семестров (поле SEMESTER) лежали в диапазоне от 1 до 12
*/

CREATE TABLE SUBJECTIS
	(
		SUBJ_ID INTEGER NOT NULL,
		COUNT_HOURS INTEGER DEFAULT 36 NOT NULL,
		SEMESTER INTEGER CHECK (SEMESTER < 13 AND SEMESTER > 0),
	)

INSERT INTO SUBJECTIS (SUBJ_ID,SEMESTER)
VALUES (1,5)