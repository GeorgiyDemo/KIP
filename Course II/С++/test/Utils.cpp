//
//  Utils.cpp
//  XQuizy
//
//  Created by Яков Линг on 23.06.16.
//  Copyright © 2016 Яков Линг. All rights reserved.
//

#include "Utils.hpp"

bool Util::isStringVectorHas(vector<string> v, string value)
{
    for(int i = 0; i < v.size(); i++)
    {
        if(v[i] == value){
            return true;
        }
    }
    
    return  false;
}

vector<string> Util::splitStringByChar(string str, char delimiter)
{
    std::istringstream ss(str);
    std::string token;
    
    vector<string> v;
    while(std::getline(ss, token, ',')) {
        v.push_back(token);
    }
    return v;
}