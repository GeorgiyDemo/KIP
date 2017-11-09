/*1.	Создайте таблицу EXAMJVIARKS так, чтобы не допускался ввод в таблицу
двух записей об оценках одного студента по конкретным экзамену и предмету обучения, 
а также, чтобы не допускалось проведение двух экзаменов по любым предметам в один день
*/

CREATE TABLE EXAMJVIARKS 
	(
		STUDENT_ID INTEGER,
		EXAM_ID INTEGER,
		SUBJECT1 CHAR (25),
		MARK INTEGER,
		DATE1 CHAR (25) UNIQUE,
		UNIQUE (STUDENT_ID, EXAM_ID, SUBJECT1)

);

INSERT INTO EXAMJVIARKS
VALUES (2, 12,'Теория алгоритмов',5,'02.03.2017')
