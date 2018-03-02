#!/bin/bash

TARGET_BUILD_FOLDER=../../../hello_pixy_outside/build
PROJECT_NAME=hello_pixy_outside

mkdir $TARGET_BUILD_FOLDER
mkdir $TARGET_BUILD_FOLDER/hello_pixy_outside

cd $TARGET_BUILD_FOLDER/hello_pixy_outside
cmake ../../src
make
