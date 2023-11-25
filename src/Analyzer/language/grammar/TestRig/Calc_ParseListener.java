// Generated from Calc_Parse.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link Calc_ParseParser}.
 */
public interface Calc_ParseListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by the {@code Expr}
	 * labeled alternative in {@link Calc_ParseParser#start}.
	 * @param ctx the parse tree
	 */
	void enterExpr(Calc_ParseParser.ExprContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Expr}
	 * labeled alternative in {@link Calc_ParseParser#start}.
	 * @param ctx the parse tree
	 */
	void exitExpr(Calc_ParseParser.ExprContext ctx);
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
	 * Enter a parse tree produced by the {@code MulDiv}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterMulDiv(Calc_ParseParser.MulDivContext ctx);
	/**
	 * Exit a parse tree produced by the {@code MulDiv}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitMulDiv(Calc_ParseParser.MulDivContext ctx);
	/**
	 * Enter a parse tree produced by the {@code AddSub}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterAddSub(Calc_ParseParser.AddSubContext ctx);
	/**
	 * Exit a parse tree produced by the {@code AddSub}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitAddSub(Calc_ParseParser.AddSubContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Parens}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterParens(Calc_ParseParser.ParensContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Parens}
	 * labeled alternative in {@link Calc_ParseParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitParens(Calc_ParseParser.ParensContext ctx);
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