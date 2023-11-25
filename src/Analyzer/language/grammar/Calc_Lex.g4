/*
    ANTLR to C#
    cd src/Analyzer/language/grammar/
    antlr4 -Dlanguage=CSharp -o ../. -package parserctx -visitor *.g4
*/

lexer grammar Calc_Lex;

LEFT_PARENTHESIS: '(';
RIGHT_PARENTHESIS: ')';
CARET: '^';
STAR: '*';
SLASH: '/';
PLUS: '+';
MINUS: '-';
SEMICOLON: ';';
NUMBER: [0-9]+;
WHITESPACE: [ \r\n\t]+ -> skip;