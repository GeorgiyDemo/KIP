void TheEight()
{
    newPractical(8, 1,(IntFunction[]){
            /*
             *
             * Задание 1
             *
             */
            []()->int {

                myArray a = myArray();
                a.Create()
                        .Show()
                        .SortOddAndNotOddAccordingly()
                        .Show();

            }

    });
}

void TheNine()
{
    newPractical(9, 1,(IntFunction[]){
                /*
                 *
                 * Задание 1
                 *
                 */
                []()->int {

                    myArray a = myArray();
                    a.Create()
                            .Show()
                            .SortOddAndNotOddBySelect()
                            .Show();

                    return 1;
                }
        });

}

void TheTen()
{
    newPractical(10, 1,(IntFunction[]){
            /*
             *
             * Задание 1
             *
             */
            []()->int {
                myArray a = myArray();
                a.Create()
                        .Show()
                        .SortOddAndNotOddByPaste()
                        .Show();

                return 1;

            }
    });

}

void TheEleven()
{
    newPractical(11, 1,(IntFunction[]){
            /*
             *
             * Задание 1
             *
             */
            []()->int {

                myArray a = myArray();
                a.Create()
                        .Show()
                        .SortOddAndNotOddBySelect()
                        .Show();


                return 1;
            }
    });

}

void DevGround()
{
    newPractical(1612, 1, (IntFunction[]) {

            []()->int {

                drawHeader("Welcome to Development Play Ground!");

                myArray a = myArray();
                a.Create()
                        .Show();

            }

    });
}