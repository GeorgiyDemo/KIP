//
//  main.cpp
//  HardQuizzy 2
//
//  Created by Qustov on 22.06.16.
//  Copyright © 2016 WarmeKat. All rights reserved.
//

#include <iostream>
#include <sys/stat.h>
#include "Question.hpp"
#include "Editor.hpp"

int main(int argc, const char * argv[]) {
    setlocale( LC_ALL,"Russian" );
    mkdir(Data::rootDir.c_str(), S_IRWXU);
    mkdir((Data::rootDir+"/Questions").c_str(), S_IRWXU);
    
    Question q = Question("Вова зеленый?");
    
    for(int i = 0; i < q.getAnswers().size(); i++)
        cout << q.getAnswers()[i].Text+" "+(q.getAnswers()[i].Right ? "ДА" : "НЕТ") << endl;
    while (true) {
        
         WKEditor::mainMenu();
    }
   
    
    return 0;
}
