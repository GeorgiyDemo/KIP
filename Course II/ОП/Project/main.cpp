#include <iostream>
#include "math.h"
#include "util/myStyle.cpp"
#include "util/math.cpp"
#include "util/myArray.cpp"

#include "first.cpp"
#include "newClass.cpp"

typedef int (*IntFunction) ();

using namespace std;

int main() {


    int number = 0;

    drawHeader("Практические по ОП");

    ShowIt("Введите номер практической: ");

    cin>>number;

    switch (number)
    {
        case 1:
            TheFirst();
            break;

        case 2:
            TheSecond();
            break;

        case 3:
            The3d();
            break;

        case 4:
            The4th();
            break;

        case 6:
            The6th();
            break;

        case 8:
            TheEight();
            break;

        case 9:
            TheNine();
            break;

        case 10:
            TheTen();
            break;

        case 11:
            TheEleven();
            break;

        case 1612:
            DevGround();
            break;

        default: TheFirst();
            break;

    }

    return 0;
}

