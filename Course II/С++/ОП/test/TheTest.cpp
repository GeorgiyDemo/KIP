//
//  TheTest.cpp
//  XQuizy
//
//  Created by Яков Линг on 22.06.16.
//  Copyright © 2016 Яков Линг. All rights reserved.
//

#include "TheTest.hpp"

void Test::startTest(int questionsCount)
{
    this->Questions = QuestionsManager::getQuestions(questionsCount);
    questionsCount = (int)this->Questions.size();
    
    for(int i = 0; i < questionsCount; i++)
    {
        for (int n = 0; n < 10; n++)
            printf( "\n\n\n\n\n\n" );
        
        printf("+-----------------------------------------------+\n");
        printf("                   Вопрос %d                    \n", i+1);
        printf("+-----------------------------------------------+\n");
        printf("+   Впишите '-' (без кавычек), чтобы отложить   +\n");
        printf("+        вопрос и поразмыслить над ним.         +\n");
        printf("+-----------------------------------------------+\n\n");
        
        this->Questions[i].showQuestion();
    }
    
    
    for(int i = 0; i < questionsCount; i++)
    {
        if(this->Questions[i].isDef)
        {
            for (int n = 0; n < 10; n++)
                printf( "\n\n\n\n\n\n" );
            
            printf("+-----------------------------------------------+\n");
            printf("                   Вопрос %d                    \n", i+1);
            printf("+-----------------------------------------------+\n");
            printf("+   Внимание! Вы используете второй шанс для    +\n");
            printf("+  ответа на вопрос. Если вопрос будет отложен, +\n");
            printf("+    Вы больше не сvожете ответить на него!     +\n");
            printf("+-----------------------------------------------+\n\n");
            
            this->Questions[i].showQuestion();
        }
    }
    
    this->revisor();
    
}

void Test::revisor()
{
    for (int n = 0; n < 10; n++)
        printf( "\n\n\n\n\n\n" );
    
    printf("+-----------------------------------------------+\n");
    printf("+                   Результат!                  +\n");
    printf("+-----------------------------------------------+\n\n");
    
    
    int k = 0;
    int z = 0;
    vector<string> s;
    int c = 0;
    
    for(int q = 0; q < this->Questions.size(); q++)
    {
        Question quest = this->Questions[q];
        
        switch (quest.getType())
        {
            case ONEVAR:
                try{
                    z = stoi(quest.givenAnswer);
                    if(quest.getAnswers()[z-1].Right){
                        k++;
                        printf("| Вопрос %d: Верно\n", q+1);
                    }else printf("| Вопрос %d: Не верно\n", q+1);

                }
                catch(exception e){
                    printf("| Вопрос %d: Не верно\n", q+1);
                }
                break;
                
            case MULSEL:
                s = Util::splitStringByChar((string)quest.givenAnswer, ',');
                c = 0;
                for(int i = 0; i < s.size(); i++)
                {
                    if(quest.getAnswers()[stoi(s[i])-1].Right) c++;
                }
                if(c == s.size()){
                    k++;
                    printf("| Вопрос %d: Верно\n", q+1);
                }else printf("| Вопрос %d: Не верно\n", q+1);
                
                break;
            case FREETYPE:
                if(quest.getAnswers()[0].Text == quest.givenAnswer){
                    k++;
                    printf("| Вопрос %d: Верно\n", q+1);
                }else printf("| Вопрос %d: Не верно\n", q+1);
                break;
                
                
            default:
              
                break;
        }
        
    }
    
    //printf("OTVETI: %d\n", k);
    
    this->RightQuestions = k;
    this->QuestionsCount = (int)this->Questions.size();
    
    int c1;
    
    printf("\n| Введите 1 что бы просмотреть итоговый отчет: ");
    cin >> c1;
    
    //WKEditor::showResults(this);
    
}