//
//  Question.cpp
//  YaEbalMihalich
//
//  Created by Qustov on 22.06.16.
//  Copyright © 2016 WarmeKat. All rights reserved.
//

#include "Question.hpp"

Answer::Answer(string text, bool right)
{
    this->Text = text;
    this->Right = right;
}

Answer::Answer(string text)
{
    this->Text = text;
    this->Right = false;
}

Question::Question(string question){
    
    this->Text = question;
    this->file = File(Data::rootDir+"/Questions/" + question);
    this->isDef = false;
    
}

void Question::showQuestion()
{
    
    printf("| Вопрос: %s\n\n", this->Text.c_str());
    
    switch (this->getType()) {
        case FREETYPE:
            printf("\n\n| Введите ответ: ");
            break;
            
        case MULSEL:
            for(int i = 0; i < this->getAnswers().size(); i++)
                printf(" - %d) %s\n", i +1, this->getAnswers()[i].Text.c_str());
            printf("\n\n| Впишите цифры через запятую: ");
            break;
            
        case ONEVAR:
            for(int i = 0; i < this->getAnswers().size(); i++)
                printf(" - %d) %s\n", i +1, this->getAnswers()[i].Text.c_str());
            printf("\n\n| Впишите номер правильного ответа: ");
            break;
            
        default:
            break;
    }
    
    cin>>this->givenAnswer;
    
    if(this->givenAnswer == "-") this->isDef = true;
    
    printf("\n");
    
}

int Question::getType()
{
    
    vector<Answer> answers = this->getAnswers();
    int right = 0;
    int q = 0;
    for(int i = 0; i < answers.size(); i++)
    {
        if(answers[i].Right) right++;
        else q++;
    }
    
    
    if(right == 1 && q == 0)
        return FREETYPE;
    if(right == 1 && q > 0)
        return ONEVAR;
    return MULSEL;
    
}


vector<Answer> Question::getAnswers()
{
    vector<string> s = this->file.ReadAllLines();
    vector<Answer> a = vector<Answer>();
    
    for(int i = 0; i < s.size(); i++)
    {
        string row = s[i];
        Answer answer = Answer(row);
       
        if(row.substr(0,2) == "r|")
        {
            answer.Right = true;
            answer.Text = row.substr(2);
        }
        
        a.push_back(answer);
        
    }
    
    return a;
}

void Question::remove()
{
    std::remove(this->file.Path.c_str());
}

void Question::edit(vector<Answer> answers)
{
    string s = "";
    for(int i = 0; i < answers.size(); i++)
        s+=(answers[i].Right ? "r|" : "") + answers[i].Text+"\n";
    File(Data::rootDir+"/Questions/" + this->Text).WriteAllText(s);
}

vector<Question> QuestionsManager::getQuestions(int count)
{
    vector<Question> q = vector<Question>();
    vector<string> file = DirScan::getDir(Data::rootDir+"/Questions");
    for(int i = 0; i < file.size(); i++) if(i< count) q.push_back(Question(file[i]));
    //q = QuestionsManager::ShuffleQuestion(q);
    return q;
    
}

void QuestionsManager::Create(string question, vector<Answer> answers)
{
    string s = "";
    for(int i = 0; i < answers.size(); i++)
        s+=(answers[i].Right ? "r|" : "") + answers[i].Text+"\n";
    File(Data::rootDir+"/Questions/" + question).WriteAllText(s);
    
}
/*

vector<Answer> QuestionsManager::ShuffleAnswers(vector<Answer> answers){
    
    random_shuffle(answers.begin(), answers.end(), iRand);
    
    return answers;
    
}

vector<Question> QuestionsManager::ShuffleQuestion(vector<Question> questions)
{
    
    random_shuffle(questions.begin(), questions.end(), iRand);
    
    return questions;
    
}

vector<string> QuestionsManager::ShuffleString(vector<string> strings){
    
    random_shuffle(strings.begin(), strings.end(), iRand);
    
    return strings;
    
}*/
