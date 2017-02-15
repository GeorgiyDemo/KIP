//
//  DIRScan.hpp
//  HardQuizzy 2
//
//  Created by Qustov on 22.06.16.
//  Copyright © 2016 WarmeKat. All rights reserved.
//

#ifndef DIRScan_hpp
#define DIRScan_hpp

#include <stdio.h>
#include <iostream>
#include <string>
#include <sys/types.h>
#include <dirent.h>
#include <vector>

class DirScan
{
public:
    
    /**
     
     @param string path
     Путь до директории
     
     @return vector<string>
     Возвращает файлы в директории
     
     */
    static std::vector<std::string> getDir(std::string path);
};

#include "DIRScan.cpp"

#endif /* DIRScan_hpp */
