#!/bin/bash
antlr4 -o TestRig Calc_Parse.g4
javac -cp ./antlr-4.13.1-complete.jar -g -Xlint  TestRig/Calc_Parse*.java
java  -cp ./antlr-4.13.1-complete.jar:./TestRig org.antlr.v4.gui.TestRig Calc_Parse start -gui ./../../../InputFiles/input
