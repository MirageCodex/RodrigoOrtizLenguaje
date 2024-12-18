//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dlcht\source\repos\Lenguaje\Lenguaje\Content\Simple.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Lenguaje.Content {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SimpleParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISimpleVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpression([NotNull] SimpleParser.ConstantExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] SimpleParser.AdditiveExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>exponentialExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExponentialExpression([NotNull] SimpleParser.ExponentialExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>squarerootExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSquarerootExpression([NotNull] SimpleParser.SquarerootExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] SimpleParser.IdentifierExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>mutiplicativeExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMutiplicativeExpression([NotNull] SimpleParser.MutiplicativeExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] SimpleParser.NotExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparisonExpression([NotNull] SimpleParser.ComparisonExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanExpression([NotNull] SimpleParser.BooleanExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>parentesisExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParentesisExpression([NotNull] SimpleParser.ParentesisExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>functionExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionExpression([NotNull] SimpleParser.FunctionExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] SimpleParser.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] SimpleParser.LineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] SimpleParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] SimpleParser.IfBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfBlock([NotNull] SimpleParser.ElseIfBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileBlock([NotNull] SimpleParser.WhileBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] SimpleParser.AssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] SimpleParser.FunctionCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] SimpleParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultOp([NotNull] SimpleParser.MultOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddOp([NotNull] SimpleParser.AddOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareOp([NotNull] SimpleParser.CompareOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.expoOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpoOp([NotNull] SimpleParser.ExpoOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.sqrtOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSqrtOp([NotNull] SimpleParser.SqrtOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolOp([NotNull] SimpleParser.BoolOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] SimpleParser.ConstantContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] SimpleParser.BlockContext context);
}
} // namespace Lenguaje.Content
