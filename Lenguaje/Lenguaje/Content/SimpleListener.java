// Generated from Simple.g4 by ANTLR 4.7.2
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link SimpleParser}.
 */
public interface SimpleListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link SimpleParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(SimpleParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(SimpleParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#line}.
	 * @param ctx the parse tree
	 */
	void enterLine(SimpleParser.LineContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#line}.
	 * @param ctx the parse tree
	 */
	void exitLine(SimpleParser.LineContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#statement}.
	 * @param ctx the parse tree
	 */
	void enterStatement(SimpleParser.StatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#statement}.
	 * @param ctx the parse tree
	 */
	void exitStatement(SimpleParser.StatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#ifBlock}.
	 * @param ctx the parse tree
	 */
	void enterIfBlock(SimpleParser.IfBlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#ifBlock}.
	 * @param ctx the parse tree
	 */
	void exitIfBlock(SimpleParser.IfBlockContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#elseIfBlock}.
	 * @param ctx the parse tree
	 */
	void enterElseIfBlock(SimpleParser.ElseIfBlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#elseIfBlock}.
	 * @param ctx the parse tree
	 */
	void exitElseIfBlock(SimpleParser.ElseIfBlockContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#whileBlock}.
	 * @param ctx the parse tree
	 */
	void enterWhileBlock(SimpleParser.WhileBlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#whileBlock}.
	 * @param ctx the parse tree
	 */
	void exitWhileBlock(SimpleParser.WhileBlockContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#assignment}.
	 * @param ctx the parse tree
	 */
	void enterAssignment(SimpleParser.AssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#assignment}.
	 * @param ctx the parse tree
	 */
	void exitAssignment(SimpleParser.AssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#functionCall}.
	 * @param ctx the parse tree
	 */
	void enterFunctionCall(SimpleParser.FunctionCallContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#functionCall}.
	 * @param ctx the parse tree
	 */
	void exitFunctionCall(SimpleParser.FunctionCallContext ctx);
	/**
	 * Enter a parse tree produced by the {@code constantExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterConstantExpression(SimpleParser.ConstantExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code constantExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitConstantExpression(SimpleParser.ConstantExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code additiveExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterAdditiveExpression(SimpleParser.AdditiveExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code additiveExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitAdditiveExpression(SimpleParser.AdditiveExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code exponentialExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterExponentialExpression(SimpleParser.ExponentialExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code exponentialExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitExponentialExpression(SimpleParser.ExponentialExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code squarerootExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterSquarerootExpression(SimpleParser.SquarerootExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code squarerootExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitSquarerootExpression(SimpleParser.SquarerootExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code identifierExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterIdentifierExpression(SimpleParser.IdentifierExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code identifierExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitIdentifierExpression(SimpleParser.IdentifierExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code mutiplicativeExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterMutiplicativeExpression(SimpleParser.MutiplicativeExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code mutiplicativeExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitMutiplicativeExpression(SimpleParser.MutiplicativeExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code notExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterNotExpression(SimpleParser.NotExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code notExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitNotExpression(SimpleParser.NotExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code comparisonExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterComparisonExpression(SimpleParser.ComparisonExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code comparisonExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitComparisonExpression(SimpleParser.ComparisonExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code booleanExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterBooleanExpression(SimpleParser.BooleanExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code booleanExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitBooleanExpression(SimpleParser.BooleanExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code parentesisExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterParentesisExpression(SimpleParser.ParentesisExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code parentesisExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitParentesisExpression(SimpleParser.ParentesisExpressionContext ctx);
	/**
	 * Enter a parse tree produced by the {@code functionExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterFunctionExpression(SimpleParser.FunctionExpressionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code functionExpression}
	 * labeled alternative in {@link SimpleParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitFunctionExpression(SimpleParser.FunctionExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#multOp}.
	 * @param ctx the parse tree
	 */
	void enterMultOp(SimpleParser.MultOpContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#multOp}.
	 * @param ctx the parse tree
	 */
	void exitMultOp(SimpleParser.MultOpContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#addOp}.
	 * @param ctx the parse tree
	 */
	void enterAddOp(SimpleParser.AddOpContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#addOp}.
	 * @param ctx the parse tree
	 */
	void exitAddOp(SimpleParser.AddOpContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#compareOp}.
	 * @param ctx the parse tree
	 */
	void enterCompareOp(SimpleParser.CompareOpContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#compareOp}.
	 * @param ctx the parse tree
	 */
	void exitCompareOp(SimpleParser.CompareOpContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#expoOp}.
	 * @param ctx the parse tree
	 */
	void enterExpoOp(SimpleParser.ExpoOpContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#expoOp}.
	 * @param ctx the parse tree
	 */
	void exitExpoOp(SimpleParser.ExpoOpContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#sqrtOp}.
	 * @param ctx the parse tree
	 */
	void enterSqrtOp(SimpleParser.SqrtOpContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#sqrtOp}.
	 * @param ctx the parse tree
	 */
	void exitSqrtOp(SimpleParser.SqrtOpContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#boolOp}.
	 * @param ctx the parse tree
	 */
	void enterBoolOp(SimpleParser.BoolOpContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#boolOp}.
	 * @param ctx the parse tree
	 */
	void exitBoolOp(SimpleParser.BoolOpContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#constant}.
	 * @param ctx the parse tree
	 */
	void enterConstant(SimpleParser.ConstantContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#constant}.
	 * @param ctx the parse tree
	 */
	void exitConstant(SimpleParser.ConstantContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleParser#block}.
	 * @param ctx the parse tree
	 */
	void enterBlock(SimpleParser.BlockContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleParser#block}.
	 * @param ctx the parse tree
	 */
	void exitBlock(SimpleParser.BlockContext ctx);
}