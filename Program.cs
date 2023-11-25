﻿using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace antlr_calc
{
    class Program
    {
        static void Main(string[] args)
        {

            using TextReader text_reader = File.OpenText("./src/InputFiles/input.txt");
            // Create an input character stream from standard in
            var input = new AntlrInputStream(text_reader);
            // Create an ExprLexer that feeds from that stream
            parserctx.Calc_Lex lexer = new parserctx.Calc_Lex(input);
            // Create a stream of tokens fed by the lexer
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            // Create a parser that feeds off the token stream
            parserctx.Calc_ParseParser parser = new parserctx.Calc_ParseParser(tokens);
            // Begin parsing at rule start
            IParseTree tree = parser.start();
            
            MyVisitor visitor = new MyVisitor();
            visitor.Visit(tree);

        }
    }
}