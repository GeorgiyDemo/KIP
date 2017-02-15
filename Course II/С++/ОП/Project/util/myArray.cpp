#include "MatrixArrayView.cpp"
#include <string>
typedef void (*VoidFunc) (int val, int index, int * args);
/**
 *
 * Класс для работы с массивами
 *
 * @warning Класс привязан к типу int и не работает с остальными числовыми типами данных!
 * При генерации массива вручную используется метод cin, который вместо дроби введет максимальный int.
 *
 */
class myArray
{

private:
    /*
     * Длина массива
     */
    int length;
    /*
     * Массив
     */
    int * array;

public:
    /**
     *
     * Устанавливаает массив
     *
     */
    myArray setArray(int * a, int size)
    {
        this->array = a;
        this->length = size;
        return *this;
    }

    /**
     *
     * @param int length
     * Длина массива
     *
     * Устанавливает длину массива
     *
     * Длина массива необходима в сортировке
     * и выводе.
     *
     */
    myArray setLength(int length)
    {
        if(length < 0)
        {
            Warning("Массив не может иметь отрицательную длину!");
            this->length = 1;
            return  * this;
        }

        this->length = length;
        return * this;
    }

    /**
     *
     * @param int value
     * Значение
     *
     * @param int index
     * Индекс элемента в массиве
     *
     * Присваивает значение value в индекс index
     *
     */
    myArray setValue(int value, int index)
    {
        if(index >= this->length)
        {
            Warning("Индекс значение не может быть больше длины массива!");
            return * this;
        }

        this->array[index] = value;
        return * this;
    }

    /**
     *
     * @param int index
     * Индекс элемента
     *
     * Возвращает элемент массива
     *
     */
    int getValue(int index)
    {
        if(index >= this->length)
        {
            Warning("Индекс значение не может быть больше длины массива!");
            return 0;
        }

        return this->array[index];
    }

    /**
     *
     * @param VoidFunc func
     * Функция, которая будет запускать на каждом элементе.
     *
     * Функция должна иметь вид:
     *
     * [](int value, int i, int * args) {}
     *
     * Где первый аргумент - текущее значение в массиве,
     * второй аргумент - счетчик,
     * третий аргумент - переданные данные (invoker)
     *
     * @param int * args
     * Данные, которые будут переданы хэндлеру
     *
     * Выполняется для каждого элемента в массиве
     *
     */
    myArray each(VoidFunc func, int * args)
    {

        for(int i = 0; i < this->length; i++)
            func(this->array[i], i,  args);

        return *this;
    }

    /**
     *
     * @param int steps 1
     * Количество шагов сдвига.
     * По-умолчанию установлено: 1
     *
     * Сдвигает массив на steps
     *
     * Пример:
     *
     * int a[3] = [ 1, 2, 3 ];
     *
     * myArray b = myArray();
     * b.setArray(a, 3);
     * b.Show(); //1, 2, 3
     *
     * b.Shift(2);
     *
     * b.Show();//3
     *
     */
    myArray Shift(int steps = 1)
    {
        if(this->length-steps <= 0)
        {
            Warning("Массив не может быть сдвинут! Иначе он будет пуст.");

            return * this;
        }

        int * newArray = new int[this->length-steps];
        int k = 0;

        for(int i = steps; i < this->length; i++)
        {
            newArray[k] = this->array[i];
            k++;
        }

        this->length -= steps;
        this->array = newArray;

        return * this;
    }

    /**
     *
     * Разворачивает массив слева на право
     *
     */
    myArray Reverse()
    {
        int * newArray = new int[this->length];

        int j = 0;
        for(int i = this->length; i >= 0; i--) {
            newArray[j] = this->array[i-1];
            j++;
        }

        this->array = newArray;

        return *this;
    }

    /**
     *
     * Создает новый массив
     *
     *
     * @param bool hand
     * Если значение true, начнется ручной ввод,
     * по-умолчанию ввод автоматический
     *
     * @param int min 10
     * Минимальное значение элементов массива,
     * который создан автоматически
     *
     * @param int max 99
     * Максимальное значение элементов массива,
     * который созданавтоматически
     *
     * Создает новый массив
     *
     */
    myArray Create(bool hand = false, int min = 10, int max = 99)
    {
        ShowIt("Введите размер массива: "); cin>>this->length;
        int * a = new int[this->length];
        int c;

        if(this->length>30)
        {
            this->length = getRandomInt(10, 30);
            Warning("Не думаю, что Вам нужен такой большой массив. Новый размер массива: " + to_string(this->length));
        }

        for(int i = 0; i<this->length; i++)
        {
            if(hand){

                ShowIt("Введите элемент номер "+to_string(i)+": ");cin>>c;
                a[i] = c;
            }
            else
            {
                a[i] = getRandomInt(min, max);
            }
        }

        this->array = a;
        return *this;
    }

    /**
     *
     * @param int length
     * Длина предначератонного массива
     *
     * @param int min 10
     * Минимальное значение элементов массива,
     * который создан автоматически
     *
     * @param int max 99
     * Максимальное значение элементов массива,
     * который созданавтоматически
     *
     * @param bool hand false
     * Если значение true, начнется ручной ввод,
     * по-умолчанию ввод автоматический
     *
     * Создает предначертанный массив
     * Предначертание заключается в том, что количество
     * элементов в массиве указывается в самой функции
     * и пользователь лишается возможности указать
     * длину массива, как это делается в Create.
     *
     */
    myArray CreateFateful(int length, int min = 10, int max = 99, bool hand = false)
    {
        this->setLength(length);

        int * a = new int[this->length];
        int c;
        for(int i = 0; i<this->length; i++)
        {
            if(hand){

                ShowIt("Введите элемент номер "+to_string(i)+": ");cin>>c;
                a[i] = c;
            }
            else
            {
                a[i] = getRandomInt(min, max);
            }
        }

        this->array = a;
        return *this;
    }

    /**
     *
     * Выводит массив на экран
     *
     */
    myArray Show()
    {
        cout << "\n [ Output ]: \n\n";

        for(int i = 0; i<this->length; i++)
        {
            if(i == 0) cout << "\t\t";
            cout << to_string(this->array[i]);
            if(i+1!=this->length) cout << ", ";
            if(i%10 == 0 && i > 0) cout << "\n\t\t";
        }
        cout << "\n\n";


        return *this;
    }

    /**
     *
     * @param bool OddIndexes true
     * Включает в произведение четные элементы
     *
     * @param bool OddIndexes true
     * Включает в произведение НЕчетные элементы
     *
     * Возвращает произведение элементов массива
     *
     */
    int getMultiply(bool OddIndexes = true, bool NotOddIndexes = true)
    {
        int k = 1;
        int multi = 1;

        for(int i = 0; i < this->length; i++)
        {

            if(k % 2 == 0)
            {
                if(OddIndexes) multi *= this->array[i];
            }
            else
            {
                if(NotOddIndexes) multi *= this->array[i];
            }

            k++;
        }

        return  multi;
    }

    /**
     *
     * @param bool untilFirstPassive false
     * Ищет среднее арифмитическое до первого
     * отрицательного элемента
     *
     * Возвращает среднее арифмитическое массива
     *
     */
    double getAverage(bool untilFirstPassive = false)
    {
        double sum = 0, k = 0;

        for(int i = 0; i < this->length; i++)
        {
            if(untilFirstPassive && this->array[i] < 0) break;

            sum += this->array[i];

            /*
             * k вместо i взята для укрощения работы
             * и сокращения количества условий.
             */

            k++;
        }
        if(sum == 0) return 0;
        return sum / k;
    }

    /**
     *
     * @param bool fromMin
     * От минимально к максимальному (true) или наоборот (false)?
     *
     * @param int startFrom
     * Элемент с которого начнется сортировка
     *
     * Сортирует массив
     *
     */
    myArray Sort(bool fromMin = true, int startFrom = 0)
    {
        int temp; // временная переменная для обмена элементов местами

        // Сортировка массива пузырьком
        for (int i = startFrom; i < this->length - 1; i++) {
            for (int j = 0; j < this->length - i - 1; j++) {
                if (this->array[j] > this->array[j + 1]) {
                    // меняем элементы местами
                    temp = this->array[j];
                    this->array[j] = this->array[j + 1];
                    this->array[j + 1] = temp;
                }
            }
        }

        if(!fromMin) this->Reverse();

        return *this;
    }


    /**
     *
     * Сортирует четные и нечетные элементы массива
     *
     */
    myArray SortOddAndNotOddAccordingly()
    {
        int * odd = new int[this->length]; int oi = 0;
        int * notOdd = new int[this->length]; int noi = 0;

        /**
         *
         * Разбиваем массив на массив ченых / нечетных
         *
         */
        for(int i = 0; i < this->length; i++)
        {
            /**
             * Четное
             */
            if(i % 2 == 0)
            {
                odd[oi] = this->array[i]; oi++;
            }
            else
            {
                notOdd[noi] = this->array[i]; noi++;
            }
        }

        myArray myArray1 = myArray();
        myArray myArray2 = myArray();

        int p = std::floor(this->length/2);

        odd = myArray1.setArray(odd, this->length).Sort(true, p).getArray(); oi = 0;
        notOdd = myArray2.setArray(notOdd, this->length).Sort(false).getArray(); noi = 0;

        for(int i = 0; i < this->length; i++)
        {
            /**
             * Четное
             */
            if(i % 2 == 0)
            {
                this->array[i] = odd[oi]; oi++;
            }
            else
            {
                this->array[i] = notOdd[noi]; noi++;
            }
        }

        return *this;
    }


    /**
     *
     * Возвраращет количество элементов в массиве
     *
     */
    int getLength()
    {
        return this->length;
    }

    /**
     *
     * Возвращает массив из класса
     *
     */
    int * getArray()
    {
        return this->array;
    }

    /**
     *
     * @param bool fromMin
     * От минимально к максимальному (true) или наоборот (false)?
     *
     * @param int startFrom
     * Элемент с которого начнется сортировка
     *
     * Сортирует массив выборкой
     *
     */
    myArray SortBySelect(bool fromMin = false, int startFrom = 0)
    {
        int i, j, temp, key;


        for (i = startFrom; i < this->length - 1; i++) {
            temp = this->array[i];
            key = i;

            for (j = i + 1; j < this->length; j++)
                if (this->array[j] < this->array[key]) key = j;

            if (key != i) {
                this->array[i] = this->array[key];
                this->array[key] = temp;
            }
        }

        if(!fromMin) {
            this->Reverse();
        }

        return *this;
    }

    /**
     *
     * @param bool fromMin
     * От минимально к максимальному (true) или наоборот (false)?
     *
     * @param int startFrom
     * Элемент с которого начнется сортировка
     *
     * Сортирует массив методом вставки
     *
     */
    myArray SortByPaste(bool fromMin = false, int startFrom = 0)
    {
        int i, j, index=0, temp=0;

        for (i=startFrom; i<this->length-1; i++) {
            index = i + 1;
            temp = this->array[index];

            for (j = i + 1; j > 0; j--) {
                if (temp < this->array[j - 1]) {
                    this->array[j] = this->array[j - 1];
                    index = j - 1;
                }
            }

            this->array[index] = temp;
        }

        if(!fromMin) {
            this->Reverse();
        }

        return *this;
    }

    /**
     *
     * Сортирует четные и нечетные элементы массива выборкой
     *
     */
    myArray SortOddAndNotOddBySelect()
    {
        int * odd = new int[this->length]; int oi = 0;
        int * notOdd = new int[this->length]; int noi = 0;

        /**
         *
         * Разбиваем массив на массив ченых / нечетных
         */

        for(int i = 0; i < this->length; i++)
        {

            if(i % 2 == 0)
            {
                odd[oi] = this->array[i]; oi++;
            }
            else
            {
                notOdd[noi] = this->array[i]; noi++;
            }
        }

        myArray myArray1 = myArray();
        myArray myArray2 = myArray();

        int p = std::round(this->length/2);

        odd = myArray1.setArray(odd, this->length).SortBySelect(true, p).getArray(); oi = 0;
        notOdd = myArray2.setArray(notOdd, this->length).SortBySelect(false).getArray(); noi = 0;

        int * temp = new int[this->length];

        for(int i = 0; i < this->length; i++)
        {
            /**
             * Четное
             */

            if(i % 2 == 0)
            {
                temp[i] = odd[oi]; oi++;
            }
            else
            {
                temp[i] = notOdd[noi]; noi++;
            }
        }

        this->array = temp;

        return *this;
    }

    /**
     *
     * Сортирует четные и нечетные элементы методом вставки
     *
     */
    myArray SortOddAndNotOddByPaste()
    {
        int * odd = new int[this->length]; int oi = 0;
        int * notOdd = new int[this->length]; int noi = 0;

        /**
         *
         * Разбиваем массив на массив ченых / нечетных
         */

        for(int i = 0; i < this->length; i++)
        {

            if(i % 2 == 0)
            {
                odd[oi] = this->array[i]; oi++;
            }
            else
            {
                notOdd[noi] = this->array[i]; noi++;
            }
        }

        myArray myArray1 = myArray();
        myArray myArray2 = myArray();

        int p = std::floor(this->length/2);

        odd = myArray1.setArray(odd, this->length).SortByPaste(true, p).getArray(); oi = 0;
        notOdd = myArray2.setArray(notOdd, this->length).SortByPaste(false).getArray(); noi = 0;

        for(int i = 0; i < this->length; i++)
        {
            /**
             * Четное
             */

            if(i % 2 == 0)
            {
                this->array[i] = odd[oi]; oi++;
            }
            else
            {
                this->array[i] = notOdd[noi]; noi++;
            }
        }

        return *this;
    }
};
