using parserctx;

class MyVisitor : Calc_ParseBaseVisitor<int>
    {

        /* NUMBER */
        public override int VisitNumber(Calc_ParseParser.NumberContext context)
        {
            int value = int.Parse(context.NUMBER().GetText());  // compute value of expression on right
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[Number] ");
            Console.ResetColor();
            Console.WriteLine("Token: " + value + "  Ln " + context.Start.Line + ",Col " + context.Start.Column);
            return value;
        }

        /* left=expression operator=(PLUS|MINUS) right=expression */
        public override int VisitAddSub(Calc_ParseParser.AddSubContext context)
        {
            int left = Visit(context.left);
            int right = Visit(context.right);
            
            if (context.@operator.Text == "+")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[Add] ");
                Console.ResetColor();
                return left + right;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[Sub] ");
            Console.ResetColor();
            return left - right;
        }

        /* left=expression operator=(STAR|SLASH) right=expression */
        public override int VisitMulDiv(Calc_ParseParser.MulDivContext context)
        {
            int left = Visit(context.left);
            int right = Visit(context.right);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[MulDiv] ");
            Console.ResetColor();
            if (context.@operator.Text == "*")
            {
                return left * right;
            }
            return left / right;
        }

        /* left=expression operator=CARET right=expression */
        public override int VisitPower(Calc_ParseParser.PowerContext context)
        {
            int left = Visit(context.left);
            int right = Visit(context.right);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[Power ] ");
            Console.ResetColor();
            
            return (int)Math.Pow(left, right);
        }

        /* LEFT_PARENTHESIS inner=expression RIGHT_PARENTHESIS */
        public override int VisitParens(Calc_ParseParser.ParensContext context)
        {
            /*string LP = context.LEFT_PARENTHESIS().GetText();
            string RP = context.RIGHT_PARENTHESIS().GetText();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[Parens] ");
            Console.ResetColor();      
            Console.WriteLine("Tokens: " + LP + " "+ RP);*/     
            return Visit(context.inner);
        }

        /* MINUS right=expression */
        public override int VisitNegation(Calc_ParseParser.NegationContext context)
        {
            int right = Visit(context.right);
            return 0-right;
        }


        /* (expression SEMICOLON)+ */
        public override int VisitExpr(Calc_ParseParser.ExprContext context)
        {
            foreach (var item in context.expression()){
                int value = Visit(item);
                Console.WriteLine(value);
                Console.WriteLine("");
            }
                        
            return 0;
        }
}