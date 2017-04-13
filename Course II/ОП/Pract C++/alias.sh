#!/bin/bash
echo "Demka's C++ shell"
if [ -f a.out ] ; then
    echo "[shell] a.out has been removed" & rm a.out
fi
g++ $1
if [ -f a.out ] ; then
    echo "[shell] build success, running.." && ./a.out
fi

