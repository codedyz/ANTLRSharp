// Generated from /home/eddy/Documentos/Auto Progra/dotnet/C#/FirstAntlrSharp/src/Analyzer/grammar/Calc_Parse.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link Calc_ParseParser}.
 */
public interface Calc_ParseListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link Calc_ParseParser#start}.
	 * @param ctx the parse tree
	 */
	void enterStart(Calc_ParseParser.StartContext ctx);
	/**
	 * Exit a parse tree produced by {@link Calc_ParseParser#start}.
	 * @param ctx the parse tree
	 */
	void exitStart(Calc_ParseParser.StartContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Number}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterNumber(Calc_ParseParser.NumberContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Number}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitNumber(Calc_ParseParser.NumberContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Negation}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterNegation(Calc_ParseParser.NegationContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Negation}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitNegation(Calc_ParseParser.NegationContext ctx);
	/**
	 * Enter a parse tree produced by the {@code AdditionOrSubtraction}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterAdditionOrSubtraction(Calc_ParseParser.AdditionOrSubtractionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code AdditionOrSubtraction}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitAdditionOrSubtraction(Calc_ParseParser.AdditionOrSubtractionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code MultiplicationOrDivision}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterMultiplicationOrDivision(Calc_ParseParser.MultiplicationOrDivisionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code MultiplicationOrDivision}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitMultiplicationOrDivision(Calc_ParseParser.MultiplicationOrDivisionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Parentheses}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterParentheses(Calc_ParseParser.ParenthesesContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Parentheses}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitParentheses(Calc_ParseParser.ParenthesesContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Power}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterPower(Calc_ParseParser.PowerContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Power}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitPower(Calc_ParseParser.PowerContext ctx);
}