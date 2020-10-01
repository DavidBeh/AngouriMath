//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./AngouriMath.g by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AngouriMath.Core.Antlr {

    using System.Linq;
    using AngouriMath;
    using static AngouriMath.Core.Exceptions.FunctionArgumentCountException;
    using static AngouriMath.Entity.Number;
    using AngouriMath.Core.Exceptions;


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IAngouriMathListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
internal partial class AngouriMathBaseListener : IAngouriMathListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.factorial_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactorial_expression([NotNull] AngouriMathParser.Factorial_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.factorial_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactorial_expression([NotNull] AngouriMathParser.Factorial_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.power_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPower_list([NotNull] AngouriMathParser.Power_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.power_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPower_list([NotNull] AngouriMathParser.Power_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.power_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPower_expression([NotNull] AngouriMathParser.Power_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.power_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPower_expression([NotNull] AngouriMathParser.Power_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.unary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_expression([NotNull] AngouriMathParser.Unary_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.unary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_expression([NotNull] AngouriMathParser.Unary_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.mult_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMult_expression([NotNull] AngouriMathParser.Mult_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.mult_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMult_expression([NotNull] AngouriMathParser.Mult_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.sum_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSum_expression([NotNull] AngouriMathParser.Sum_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.sum_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSum_expression([NotNull] AngouriMathParser.Sum_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.inequality_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInequality_expression([NotNull] AngouriMathParser.Inequality_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.inequality_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInequality_expression([NotNull] AngouriMathParser.Inequality_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.equality_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEquality_expression([NotNull] AngouriMathParser.Equality_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.equality_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEquality_expression([NotNull] AngouriMathParser.Equality_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.negate_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNegate_expression([NotNull] AngouriMathParser.Negate_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.negate_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNegate_expression([NotNull] AngouriMathParser.Negate_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.and_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnd_expression([NotNull] AngouriMathParser.And_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.and_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnd_expression([NotNull] AngouriMathParser.And_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.xor_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXor_expression([NotNull] AngouriMathParser.Xor_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.xor_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXor_expression([NotNull] AngouriMathParser.Xor_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.or_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOr_expression([NotNull] AngouriMathParser.Or_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.or_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOr_expression([NotNull] AngouriMathParser.Or_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.implies_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImplies_expression([NotNull] AngouriMathParser.Implies_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.implies_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImplies_expression([NotNull] AngouriMathParser.Implies_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] AngouriMathParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] AngouriMathParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.function_arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_arguments([NotNull] AngouriMathParser.Function_argumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.function_arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_arguments([NotNull] AngouriMathParser.Function_argumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] AngouriMathParser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] AngouriMathParser.AtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] AngouriMathParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] AngouriMathParser.StatementContext context) { }

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
} // namespace AngouriMath.Core.Antlr
