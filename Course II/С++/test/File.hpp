//
//  File.hpp
//  DTest
//
//  Created by Яков Линг on 21.06.16.
//  Copyright © 2016 Яков Линг. All rights reserved.
//

#ifndef File_hpp
#define File_hpp

#include <stdio.h>
#include <string>
#include <iostream>
#include <fstream>
#include <vector>


using namespace std;

class File
{
public:
    string Path;
    
    File(string fileName);
    
    /*
     
     @param string text
     Текст, который будет записан в файл
     
     Записывает текст в файл
     
     */
    void WriteAllText(string text);
    
    /*
     
     @return string
     
     Возвращает текст файла
     
     */
    string ReadAllText();
    
    /*
     
     @return vector<string>
     
     Возвращает текст файла
     
     */
    vector<string> ReadAllLines();
    
    /*
     
     @return bool
     
     Возвращает true, если файл существует
     
     */
    bool isEx ();
    
    
};

#include "File.cpp"


#endif /* File_hpp */
