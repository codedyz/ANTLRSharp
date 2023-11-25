grammar Calc_Parse;
import Calc_Lex;

start : (expression SEMICOLON)+  #Expr;

expression
   : NUMBER                                                 # Number
   | MINUS right=expression                                 # Negation
   | LEFT_PARENTHESIS inner=expression RIGHT_PARENTHESIS    # Parens
   | left=expression operator=CARET right=expression        # Power
   | left=expression operator=(STAR|SLASH) right=expression # MulDiv
   | left=expression operator=(PLUS|MINUS) right=expression # AddSub
   ;