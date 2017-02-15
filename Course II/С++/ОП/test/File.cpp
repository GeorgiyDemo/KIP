//
//  File.cpp
//  DTest
//
//  Created by Яков Линг on 21.06.16.
//  Copyright © 2016 Яков Линг. All rights reserved.
//

#include "File.hpp"

File::File(string fileName){
    this->Path = fileName;
};

void File::WriteAllText(string text){
    ofstream myfile (this->Path);
    if (myfile.is_open())
    {
        myfile << text;
        myfile.close();
    }
    //else Logger::Error("Unable to open file");
};

string File::ReadAllText(){
    string line;
    string data = "";
    ifstream myfile (this->Path);
    if (myfile.is_open())
    {
        while ( getline (myfile,line) )
        {
            data.append(line+'\n');
        }
        myfile.close();
    }
    //else Logger::Error("Unable to open file");
    return data;
};

vector<string> File::ReadAllLines(){
    vector<string> data = vector<string>();
    
    string line;
    ifstream myfile (this->Path);
    if (myfile.is_open())
    {
        while ( getline (myfile,line) )
        {
            data.push_back(line);
        }
        myfile.close();
    }
   // else Logger::Error("Unable to open file");
    return data;
};

bool File::isEx(){
    ifstream f(this->Path);
    return f.good();
}
