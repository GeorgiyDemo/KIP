#include <iostream>
#include <math.h>
#include <string>
#include <ncurses.h>
#include <locale>

#include "practics.cpp"
#include "tasks/task14.cpp"
#include "tasks/task15.cpp"
#include "tasks/task16.cpp"
#include "tasks/task17.cpp"
#include "tasks/task18.cpp"

using namespace std;

int main(){

    setlocale( LC_ALL,"rus" );

    int maink=0;
    int k=0;

    initscr();
    start_color();

    init_pair(1, COLOR_MAGENTA, COLOR_BLACK);
    init_pair(2, COLOR_WHITE, COLOR_BLACK);

    //Красивое меню
    attron(COLOR_PAIR(2));
    printw("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n");
    attron(COLOR_PAIR(1));
    printw(" ---------------------------------------\n");
    printw("|");
    attron(COLOR_PAIR(2));
    printw("           C++ Practics for OP         ");
    attron(COLOR_PAIR(1));
    printw("|\n");
    printw(" ---------------------------------------\n");
    printw("Number of the practic [11-18]\n=> ");
    refresh();
    scanw("%d",&maink);
    attron(COLOR_PAIR(2));
    
    //Этот синтаксис case
    switch (maink){

        case 11:{
            printw("Number of the task [1-4] => "); scanw("%d",&k);
            switch (k){  
                 case 1:{
                    n11_1();
                    break;
                 }  
                 case 2:{
                    n11_2();
                    break;
                 }
                 case 3:{
                    n11_3();
                    break;
                 }
                 case 4:{
                    n11_4();
                    break;
                 } 
                 default:{  
                    printw("Undeclared number :c");
                 }
              }  
            break;
        }

        case 12:{
            printw("Number of the task [1-2] => "); scanw("%d",&k);
            switch (k){  
                 case 1:{
                    n12_1();
                    break;
                 }  
                 case 2:{
                    n12_2();
                    break;
                 } 
                 default:{  
                    printw("Undeclared number :c");
                 }
              }  
            break;
        }

        case 13:{
            printw("Number of the task [1-2] => "); scanw("%d",&k);
            switch (k){  
                 case 1:{
                    n13_1();
                    break;
                 }  
                 case 2:{
                    n13_2();
                    break;
                 } 
                 default:{  
                    printw("Undeclared number :c");
                 }
              }  
            break;
        }

        case 14:{
            n14();
            break;
        }

        case 15:{
            n15();
            break;
        }

        case 16:{
            n16();
            break;
        }

        case 17:{
            
            printw("Number of the task [1-2] => "); scanw("%d",&k);
            switch (k){
                 case 1:{
                    n17_1();
                    break;
                 }  
                 case 2:{
                    n17_2();
                    break;
                 } 
                 default:{  
                    printw("Undeclared number :c");
                 }
              }  
            break;

        }

        case 18:{
            n18();
            break;
        }

        default:{
            printw("Undeclared practic :c");
            break;
        }

    }

    //Красивый конец менюшки
    attron(COLOR_PAIR(1));
    printw("\n ---------------------------------------\n");
    printw("|");
    attron(COLOR_PAIR(2));
    printw("     Georgiy Demenchuk, 2PKS-115       ");
    attron(COLOR_PAIR(1));
    printw("|\n");
    printw(" ---------------------------------------\n");
    attron(COLOR_PAIR(2));
    printw(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
    getch();
    endwin();

return 0;
}
