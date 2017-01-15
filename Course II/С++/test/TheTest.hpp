//
//  TheTest.hpp
//  XQuizy
//
//  Created by Яков Линг on 22.06.16.
//  Copyright © 2016 Яков Линг. All rights reserved.
//

#ifndef TheTest_hpp
#define TheTest_hpp

#include <stdio.h>
#include <string>
#include <vector>
#include "Data.hpp"
#include "Question.hpp"
#include "Utils.hpp"

using namespace std;

struct DEFQuestion{
    Question q;
    int n;
};

class Test
{
public:
    vector<Question> Questions;
    vector<string> Answers;
    vector<Question> lately;
    int RightQuestions;
    int QuestionsCount;
    
    /**
     
     @param int questionsCount
     Количество вопросов
     
     Запускает тест
     
     */
    void startTest(int questionsCount);
    
    /**
     
     Проверка ввода данных
     
     */
    void revisor();
};

#include "TheTest.cpp"

#endif /* TheTest_hpp */
