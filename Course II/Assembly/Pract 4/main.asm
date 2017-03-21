;Кол-во четных чисел в первом массиве, во втором, в третьем
;Найти сред. арифметическое между тремя этими числами
RD #85
WR R1
RD #4
WR R2
CALL 24
WR R6
RD #100
WR R1
RD #4
WR R2
CALL 24
WR R7
RD #110
WR R1
RD #004
WR R2
CALL 24
ADD R7
ADD R6
DIV #3
OUT
NOP
NOP
HLT
RD @R1
WR R3
RD @R1+
WR R4
SUB R3
JS 31
MOV R3,R4
JRNZ R2,26
RD R3
RET
