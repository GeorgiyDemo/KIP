/*
3.	Создайте таблицу EXAM_MARKS таким образом, чтобы значения поля EXAM__ID
 были больше значений поля SUBJ_ID, а значения поля SUBJ_ID были больше значений
 поля STUDENT__ID; пусть также будут запрещены значения NULL в любом из этих трех полей.
*/

CREATE TABLE EXAM_MARKS
	(
		STUDENT_ID INTEGER NOT NULL,
		SUBJ_ID INTEGER NOT NULL,
		EXAM_ID INTEGER NOT NULL,
		CHECK (SUBJ_ID > STUDENT_ID),
		CHECK (EXAM_ID  > SUBJ_ID),
	)

INSERT INTO EXAM_MARKS
VALUES (11,111,1111)
