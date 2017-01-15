//
//  DIRScan.cpp
//  HardQuizzy 2
//
//  Created by Qustov on 22.06.16.
//  Copyright © 2016 WarmeKat. All rights reserved.
//

#include "DIRScan.hpp"

std::vector<std::string> DirScan::getDir(std::string path){
    
    std::vector<std::string> out = std::vector<std::string>();
    
    DIR *dir = opendir(path.c_str());
    if(dir)
    {
        struct dirent *ent;
        while((ent = readdir(dir)) != NULL)
        {
            if(strcmp(ent->d_name, ".") && strcmp(ent->d_name, "..") && strcmp(ent->d_name, ".DS_Store"))
                out.push_back(ent->d_name);
            
        }
    }
    else
    {
        fprintf(stderr, "Error opening directory\n");
    }
    
    return  out;
    
}

