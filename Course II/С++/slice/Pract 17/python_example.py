# -*- coding: utf-8 -*-
f = open('example.txt', 'r')
text = f.read()
arr = text.split(' ')
k = 0
for i in range(len(arr)):
	if len(arr[i])<=4:
		k=k+1;
print('Слов, состоящих из не более чем четырех букв: '+str(k))