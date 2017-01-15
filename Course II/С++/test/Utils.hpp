//
//  Utils.hpp
//  HardQuizzy 2
//
//  Created by Яков Линг on 23.06.16.
//  Copyright © 2016 Яков Линг. All rights reserved.
//

#ifndef Utils_hpp
#define Utils_hpp

#include <stdio.h>
#include <string>
#include <vector>
#include <sstream>

using namespace std;

class Util
{
public:
    static bool isStringVectorHas(vector<string> v, string value);
    static vector<string> splitStringByChar(string str, char delimiter);
};

#include "Utils.cpp"

#endif /* Utils_hpp */
