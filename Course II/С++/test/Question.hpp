//
//  Question.hpp
//  YaEbalMihalich
//
//  Created by Qustov on 22.06.16.
//  Copyright © 2016 WarmeKat. All rights reserved.
//

#ifndef Question_hpp
#define Question_hpp

#include <stdio.h>
#include <string>
#include <vector>
#include "File.hpp"
#include "Data.hpp"
#include "DIRScan.hpp"
#include "SAUtils.hpp"

using namespace std;

const int FREETYPE = 0;
const int ONEVAR = 1;
const int MULSEL = 2;
const int DEFFERED = 3;

/**
 
 Сущность ответа
 
 Может быть инициализирован:
 
 По умолчанию ответ НЕ ВЕРНЫЙ.
 
 Answer( текст ответа )
 
          string       правильность
 Answer( текст ответа, right|false )
 
 */
class Answer
{
public:
    
    Answer(string text, bool right);
    Answer(string text);
    
    bool Right;
    string Text;
};

/**
 
 Объект вопроса
 
 */
class Question
{
public:
    
    /**
     
     Ответ, который был введен пользователем
     
     */
    string givenAnswer;
    
    File file = File("");
    
    bool isDef;
    
    /**
     
     @param string question
     Текст вопроса
     
     Возвращает сущность вопроса
     
     
     */
    Question(string question);
    
    /**
     
     @var string
     
     Возвращает текст вопроса
     
     */
    string Text;
    
    /**
     
     @var vetcor<Answer>
     
     Возвращает текст вопросов
     
     */
    vector<Answer> Answers;
    
    /**
     
     Возвращает варианты ответов к вопросу
     
     */
    vector<Answer> getAnswers();
    
    /**
     
     Выводит вопрос
     
     */
    void showQuestion();
    
    /**
     
     Возвращает тип вопроса
     
     */
    int getType();
    
    /**
     
     Удаляет вопрос
     
     */
    void remove();
    
    /*
     
     @param vector<Answer> answers
     Вектор с вопросами
     
     Редактирует вопрос
     
     
     */
    void edit(vector<Answer> answers);
    
    
    
};

class QuestionsManager
{
public:
    
    /**
     
     @param int count
     Количество вопросов
     
     Возвращает вопросы
     
     */
    static vector<Question> getQuestions(int count);
    
    /**
     
     @param string question
     Текст вопроса
     
     @param vector<Answer> answers
     Вектор ответов
     
     */
    static void Create(string question, vector<Answer> answers);
    
    //static vector<Answer> ShuffleAnswers(vector<Answer> answers);
  //  static vector<Question> ShuffleQuestion(vector<Question> questions);
//    static vector<string> ShuffleString(vector<string> strings);
    
    
};

#include "Question.cpp"

#endif /* Question_hpp */
