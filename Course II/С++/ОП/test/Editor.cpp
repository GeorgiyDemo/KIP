//
//  Editor.cpp
//  HardQuizzy 2
//
//  Created by Qustov on 22.06.16.
//  Copyright © 2016 WarmeKat. All rights reserved.
//

#include "Editor.hpp"

void WKEditor::addQuestion(){
    setlocale( LC_ALL,"Russian" );
    for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
    
    printf("+-----------------------------------------------+\n");
    printf("+               Создание вопроса                +\n");
    printf("+-----------------------------------------------+\n");
    printf("+ Введите варинты ответа через Enter, чтобы     +\n");
    printf("+ пометить вариант ответа, как верный,          +\n");
    printf("+ символ + перед ним.                           +\n");
    printf("+ Для завершения ввода введите 0.               +\n");
    printf("+ Для создания вопроса,                         +\n");
    printf("+ в котором надо вписать ответ,                 +\n");
    printf("+ укажите сивол ! перед текстом ответа          +\n");
    printf("+-----------------------------------------------+\n\n");
    
    char question[254];
    char cache[254];
    string cache1;
    cache1 = (const char*)cache;
    
    vector<Answer> answers = vector<Answer>();
    cin.ignore();
    printf("| Введите вопрос: ");
    gets(question);
    printf("\n| Вводите варианты: ");
    while(true){
        
        cache1 = "";
        //Приглашение
        
        gets(cache);
        
        if(cache[0] == '0') break;
        
        if(cache[0] == '!')
        {
            cache1 = (const char*)cache;
            answers.push_back(Answer(cache1.substr(1), true));
            
            break;
        }
        
        if(cache[0] == '+')
        {
            cache1 = (const char*)cache;
            answers.push_back(Answer(cache1.substr(1), true));
        }
        else
            answers.push_back(Answer((const char*)cache, false));
    }
    
    cout << "\n| Ваш вопрос: " << question << endl;
    
    for(int i = 0; i < answers.size(); i++)
    {
        
        printf("| Вариант %d: %s - %s\n", i + 1, answers[i].Text.c_str(), answers[i].Right ? "ВЕРНО" : "НЕ ВЕРНО");
        
    }
    printf("\n");
    
    printf("| Добавить ваш вопрос в список вопросов?(Для подтверждения введите 1): ");
    cin >> cache;
    if(cache[0] == '1')
        QuestionsManager::Create(question, answers);
    
}

void WKEditor::editQuestion(Question questionToEdit){
    setlocale( LC_ALL,"Russian" );
    for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
    
    printf("+-----------------------------------------------+\n");
    printf("+               Редактор вопроса                +\n");
    printf("+-----------------------------------------------+\n");
    printf("+ Введите варинты ответа через Enter, чтобы     +\n");
    printf("+ пометить вариант ответа, как верный,          +\n");
    printf("+ символ + перед ним.                           +\n");
    printf("+ Для завершения ввода введите 0.               +\n");
    printf("+ Для изменения вопроса,                        +\n");
    printf("+ в котором надо вписать ответ,                 +\n");
    printf("+ укажите сивол ! перед текстом ответа          +\n");
    printf("+-----------------------------------------------+\n\n");
    
    char cache[254];
    string cache1;
    cache1 = (const char*)cache;
    
    vector<Answer> answers = vector<Answer>();
    
    cin.ignore();
    printf("| Вводите: \n");
    int i = 0;
    while(true){
        
        cache1 = "";
        //Приглашение
        printf("\n| Вариант ответа %d: ", i+1);
        gets(cache);
        //cin >> cache;
        if(cache[0] == '0') break;
        
        if(cache[0] == '!')
        {
            cache1 = (const char*)cache;
            answers.push_back(Answer(cache1.substr(1), true));
            
            break;
        }
        
        if(cache[0] == '+')
        {
            cache1 = (const char*)cache;
            answers.push_back(Answer(cache1.substr(1), true));
        }
        else
            answers.push_back(Answer((const char*)cache, false));
        i++;
        //printf("'%s'\n", cache);
    }
    
    for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
    
    printf("+-----------------------------------------------+\n");
    printf("+               Редактор вопроса                +\n");
    printf("+-----------------------------------------------+\n\n");
    
    
    for(int i = 0; i < answers.size(); i++)
    {
        
        printf("| Вариант %d: %s - %s\n", i + 1, answers[i].Text.c_str(), answers[i].Right ? "ВЕРНО" : "НЕ ВЕРНО");
        
    }
    printf("\n");
    
    printf("| Изменить ваш вопрос в список вопросов? (Для подтверждения введите 1): ");
    cin >> cache;
    if(cache[0] == '1')
        questionToEdit.edit(answers);
    
    
}

void WKEditor::editQestionMenu()
{
    setlocale( LC_ALL,"Russian" );
    for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
    
    printf("+-----------------------------------------------+\n");
    printf("+               Редактор вопросов               +\n");
    printf("+-----------------------------------------------+\n\n");
    
    vector<Question> quests = QuestionsManager::getQuestions(1000);
    for(int i = 0; i < quests.size(); i++)
    {
        
        printf("| %d - %s\n", i, quests[i].Text.c_str());
        
    }
    
    int remq;
    printf("\n\n| Выберите вопрос для редактирования: ");
    cin >> remq;
    WKEditor::editQuestion(quests[remq]);
}


void WKEditor::removeQuestion(){
    
    for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
    
    printf("+-----------------------------------------------+\n");
    printf("+               Удаление вопроса                +\n");
    printf("+-----------------------------------------------+\n\n");
    
    vector<Question> quests = QuestionsManager::getQuestions(1000);
    for(int i = 0; i < quests.size(); i++)
    {
        
        printf("| %d - %s\n", i, quests[i].Text.c_str());
    
    }
    
    int c;
    int remq;
    printf("\n| Выберите вопрос для удаления: ");
    cin >> remq;
    
    for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
    
    printf("+-----------------------------------------------+\n");
    printf("+               Удаление вопроса                +\n");
    printf("+-----------------------------------------------+\n\n");
    
    printf("\n| Уверены в том, что хотите удалить вопрос №%d", remq);
    cin >> c;
    if(c == 1)
        quests[remq].remove();
}


void WKEditor::mainMenu(){
    setlocale( LC_ALL,"Russian" );
    for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
    
    printf("+---------------------------------------+\n");
    printf("|\t\t\t\tMain Menu\t\t\t\t|\n");
    printf("+---------------------------------------+\n");
    printf("|\t1 - Начать тест\t\t\t\t\t\t|\n");
    printf("|\t2 - Редактор вопросов\t\t\t\t|\n");
    printf("|\t3 - Удаление вопроса\t\t\t\t|\n");
    printf("|\t4 - Создание вопроса\t\t\t\t|\n");
    printf("|\t5 - Выход\t\t\t\t\t\t\t|\n");
    printf("+---------------------------------------+\n");
    printf("|\t\t\t\tHardQuizzy\t\t\t\t|\n");
    printf("+---------------------------------------+\n");
    printf("\n| Выберите пункт меню: ");
    
    int m;
    int k;
    Test t;
    cin >> m;
    switch(m)
    {
        case 1:
            
            for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
            
            printf("+-----------------------------------------------+\n");
            printf("+               Настройка теста                 +\n");
            printf("+-----------------------------------------------+\n\n");
            
            
            printf("| Сколько вопросов будет в тесте?: ");
            cin >> k;
            t = Test();
            t.startTest(k);
            WKEditor::showResults(t);
            
            break;
        case 2:
            
            WKEditor::editQestionMenu();
            
            break;
        case 3:
            
            WKEditor::removeQuestion();
            
            break;
            
        case 4:
            
            WKEditor::addQuestion();
            
            break;
            
        default:
            
            break;
            
            
    }

}

void WKEditor::showResults(Test res){
    //res.QuestionsCount; - ЧИСЛО ВОПРОСОВ
    //res.RightQuestions; - ЧИСЛО ПРАВ ОТВЕТОВ
    setlocale( LC_ALL,"Russian" );
    for(int i = 0; i < 10; i++) printf("\n\n\n\n\n\n\n");
    
    printf("+-----------------------------------------------+\n");
    printf("+                  Результат!                   +\n");
    printf("+-----------------------------------------------+\n\n");
    
    int b = res.QuestionsCount;
    int c;
    //int per = round((a/b) * 100);
    float per = ((float)res.RightQuestions / b) * 100;
    int p = round(per);
    int mark = 2;
    
    if(per >= 50) mark = 3;
    if(per > 70) mark = 4;
    if(per > 90) mark = 5;

    printf("| Правильные отеты: %d/%d\n", res.RightQuestions, res.QuestionsCount);
    printf("| Тест выполнен правильно на: %d%%!\n", p);
    printf("| Ваша оценка: %d!", mark);
    
    cin >> c;
}










