//
//  Editor.hpp
//  HardQuizzy 2
//
//  Created by Qustov on 22.06.16.
//  Copyright © 2016 WarmeKat. All rights reserved.
//

#ifndef Editor_hpp
#define Editor_hpp

#include <stdio.h>
#include <string>
#include "File.hpp"
#include <iostream>
#include "Question.hpp"
#include "TheTest.hpp"
#include "math.h"

using namespace std;

class WKEditor{
public:
    
    static void addQuestion();
    static void editQuestion(Question questionToEdit);
    static void editQestionMenu();
    static void removeQuestion();
    static void mainMenu();
    static void showResults(Test res);
    
};

#include "Editor.cpp"

#endif /* Editor_hpp */
