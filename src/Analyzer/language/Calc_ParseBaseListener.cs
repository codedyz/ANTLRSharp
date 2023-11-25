//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calc_Parse.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace parserctx {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICalc_ParseListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class Calc_ParseBaseListener : ICalc_ParseListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>Expr</c>
	/// labeled alternative in <see cref="Calc_ParseParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] Calc_ParseParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Expr</c>
	/// labeled alternative in <see cref="Calc_ParseParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] Calc_ParseParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumber([NotNull] Calc_ParseParser.NumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumber([NotNull] Calc_ParseParser.NumberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNegation([NotNull] Calc_ParseParser.NegationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNegation([NotNull] Calc_ParseParser.NegationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDiv([NotNull] Calc_ParseParser.MulDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDiv([NotNull] Calc_ParseParser.MulDivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSub([NotNull] Calc_ParseParser.AddSubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSub([NotNull] Calc_ParseParser.AddSubContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Parens</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParens([NotNull] Calc_ParseParser.ParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Parens</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParens([NotNull] Calc_ParseParser.ParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Power</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPower([NotNull] Calc_ParseParser.PowerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Power</c>
	/// labeled alternative in <see cref="Calc_ParseParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPower([NotNull] Calc_ParseParser.PowerContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace parserctx