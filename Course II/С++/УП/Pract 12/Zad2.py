def recursion(n):
    cnt = 1
    cnt2 = 0
    for i in range(1, n):
        print(cnt)
        cnt2 += 1
        if cnt2 == cnt:
            cnt += 1
            cnt2 = 0

n = int(input('Введите n => '))
print('Первые '+str(n)+' элементов последовательности:')
recursion(n)