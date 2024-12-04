using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Lenguaje.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguaje
{
    public class SimpleVisitor : SimpleBaseVisitor<object?>
    {
        private Dictionary<string, object?> Variables = new();

        public SimpleVisitor() 
        {
            Variables["PI"] = Math.PI;
            Variables["E"] = Math.E;
            Variables["escribir"] = new Func<object?[], object?>(Escribir);
        }
        private object? Escribir(object?[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            return null;
        }
        public override object? VisitFunctionCall(SimpleParser.FunctionCallContext context)
        {
            var name = context.IDENTIFIER().GetText();

            var args = context.expression().Select(Visit).ToArray();

            if (!Variables.ContainsKey(name))
            {
                throw new Exception($"La funcion {name} no esta definida");
            }

            if ((Variables[name] is not Func<object?[], object?> func))
                throw new Exception($"Variable {name} no definida");

            return func(args);
        }
        public override object VisitAssignment([NotNull] SimpleParser.AssignmentContext context)
        {
            var varName = context.IDENTIFIER().GetText();
            var value = Visit(context.expression());
            Variables[varName] = value;
            return null;
        }
        public override object VisitIdentifierExpression([NotNull] SimpleParser.IdentifierExpressionContext context)
        {
            var varName = context.IDENTIFIER().GetText();

            if (!Variables.ContainsKey(varName))
            {
                throw new Exception($"Variable {varName} is not defined");
            }
            return Variables[varName];
        }
        public override object? VisitConstant([NotNull] SimpleParser.ConstantContext context)
        {
            if (context.INTERGER() is { } i)
                return int.Parse(i.GetText());

            if (context.FLOAT() is { } f)
                return float.Parse(f.GetText());

            if (context.STRING() is { } s)
                return s.GetText()[1..^1];
            
            if (context.BOOL() is { } b)
                return b.GetText() == "verdadero";

            if (context.NULL() is { } )
                return null;

            throw new NotImplementedException();
        }
        public override object? VisitAdditiveExpression([NotNull] SimpleParser.AdditiveExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            var op = context.addOp().GetText();
            return op switch
            {
                "sumita" => Suma(left, right),
                "restita" => Resta(left, right),
                _ => throw new NotImplementedException()
            };
        }
        public override object? VisitMutiplicativeExpression([NotNull] SimpleParser.MutiplicativeExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            var op = context.multOp().GetText();
            return op switch
            {
                "estrella" => Multiplicacion(left, right),
                "solecito" => Divicion(left, right),
                _ => throw new NotImplementedException()
            };
        }
        public override object? VisitExponentialExpression([NotNull] SimpleParser.ExponentialExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            var op = context.expoOp().GetText();
            return op switch
            {
                "superstar" => Potencia(left, right),
                _ => throw new NotImplementedException()
            };
        }
        public override object? VisitSquarerootExpression([NotNull] SimpleParser.SquarerootExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var op = context.sqrtOp().GetText();

            return op switch
            {
                "supersol" => Raiz(left),
                _ => throw new NotImplementedException()
            };
            }
        private object? Suma(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l + r;
            if (left is float lf && right is float rf)
                return lf + rf;
            if (left is int lInt && right is float rFloat)
                return lInt + rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat + rInt;
            if (left is string || right is string)
                return $"{left}{right}";
            throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}");

        }
        private object? Resta(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l - r;
            if (left is float lf && right is float rf)
                return lf - rf;
            if (left is int lInt && right is float rFloat)
                return lInt - rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat - rInt;
            if (left is string || right is string)
                return $"{left}{right}";
            throw new Exception($"Cannot subtract values of types {left?.GetType()} and {right?.GetType()}");

        }
        private object? Multiplicacion(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l * r;

            if (left is float lf && right is float rf)
                return lf * rf;

            if (left is int lInt && right is float rFloat)
                return lInt * rFloat;

            if (left is float lFloat && right is int rInt)
                return lFloat * rInt;

            if (left is string || right is string)
                return $"{left}{right}";

            throw new Exception($"No se puede añadir valores de tipo {left?.GetType()} y {right?.GetType()}");
        }
        private object? Divicion(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l / r;

            if (left is float lf && right is float rf)
                return lf / rf;

            if (left is int lInt && right is float rFloat)
                return lInt / rFloat;

            if (left is float lFloat && right is int rInt)
                return lFloat / rInt;

            if (left is string || right is string)
                return $"{left}{right}";

            throw new Exception($"No se puede añadir valores de tipo {left?.GetType()} y {right?.GetType()}");
        }
        private object? Potencia(object? left, object? right)
        {
            if (left is int l && right is int r)
                return Math.Pow(l, r);
            if (left is float lf && right is float rf)
                return Math.Pow(lf, rf);
            if (left is int lInt && right is float rFloat)
                return Math.Pow(lInt, rFloat);
            if (left is float lFloat && right is int rInt)
                return Math.Pow(lFloat, rInt);
            if (left is string || right is string)
                return $"{left}^{right}";
            throw new Exception($"Cannot calculate power of values of types {left?.GetType()} and {right?.GetType()}");
        }
        private object? Raiz(object? value)
        {
            if (value is int v)
                return Math.Sqrt(v);

            if (value is float fv)
                return Math.Sqrt(fv);

            if (value is string s)
            {
                double number;
                if (double.TryParse(s, out number))
                {
                    return Math.Sqrt(number);
                }
                else
                {
                    throw new ArgumentException("Invalid string input for square root");
                }
            }
            throw new ArgumentException("Invalid type for square root");
        }
        public override object? VisitWhileBlock([NotNull] SimpleParser.WhileBlockContext context)
        {
            Func<object?, bool> condition = context.WHILE().GetText() == "bucle"
                ? Verdadero
                : Falso
            ;

            if (condition(Visit(context.expression())))
            {
                do
                {
                    Visit(context.block());

                } while (condition(Visit(context.expression())));
            }
            else
            {
                Visit(context.block());
            }

            return null;
        }
        public override object? VisitIfBlock([NotNull] SimpleParser.IfBlockContext context)
        {

            Func<object?, bool> condition = Verdadero;

            if (condition(Visit(context.expression())))
            {
                
                Visit(context.block());
            }
            else if (context.elseIfBlock() != null)
            {
                
                Visit(context.elseIfBlock());
            }

            return null;
        }
        public override object? VisitComparisonExpression([NotNull] SimpleParser.ComparisonExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));
            var op = context.compareOp().GetText();

            return op switch
            {
                "igualito" => Igual(left, right),
                "diferente" => NoIguales(left, right),
                "grandecito" => MayorQue(left, right),
                "pequenito" => MenorQue(left, right),
                "granigual" => MayorIgualQue(left, right),
                "pequeigual" => MenorIgualQue(left, right),
                _ => throw new NotImplementedException()
            };
        }
        private object? Igual(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l = r;

            if (left is float lf && right is float rf)
                return lf = rf;

            if (left is float lFloat && right is int rInt)
                return lFloat = rInt;

            if (left is string || right is string)
                return $"{left}{right}";

            throw new Exception($"No se puede añadir valores de tipo {left?.GetType()} y {right?.GetType()}");
        }
        private object? NoIguales(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l != r;

            if (left is float lf && right is float rf)
                return lf != rf;

            if (left is int lInt && right is float rFloat)
                return lInt != rFloat;

            if (left is float lFloat && right is int rInt)
                return lFloat != rInt;

            if (left is string || right is string)
                return $"{left}{right}";

            throw new Exception($"No se puede añadir valores de tipo {left?.GetType()} y {right?.GetType()}");
        }
        private object? MayorQue(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l > r;

            if (left is float lf && right is float rf)
                return lf > rf;

            if (left is int lInt && right is float rFloat)
                return lInt > rFloat;

            if (left is float lFloat && right is int rInt)
                return lFloat > rInt;

            if (left is string || right is string)
                return $"{left}{right}";

            throw new Exception($"No se puede añadir valores de tipo {left?.GetType()} y {right?.GetType()}");
        }
        private object? MenorQue(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l < r;

            if (left is float lf && right is float rf)
                return lf < rf;

            if (left is int lInt && right is float rFloat)
                return lInt < rFloat;

            if (left is float lFloat && right is int rInt)
                return lFloat < rInt;

            if (left is string || right is string)
                return $"{left}{right}";

            throw new Exception($"No se puede añadir valores de tipo {left?.GetType()} y {right?.GetType()}");
        }
        private object? MayorIgualQue(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l >= r;

            if (left is float lf && right is float rf)
                return lf >= rf;

            if (left is int lInt && right is float rFloat)
                return lInt >= rFloat;

            if (left is float lFloat && right is int rInt)
                return lFloat >= rInt;

            if (left is string || right is string)
                return $"{left}{right}";

            throw new Exception($"No se puede añadir valores de tipo {left?.GetType()} y {right?.GetType()}");
        }
        private object? MenorIgualQue(object? left, object? right)
        {
            if (left is int l && right is int r)
                return l <= r;

            if (left is float lf && right is float rf)
                return lf <= rf;

            if (left is int lInt && right is float rFloat)
                return lInt <= rFloat;

            if (left is float lFloat && right is int rInt)
                return lFloat <= rInt;

            if (left is string || right is string)
                return $"{left}{right}";

            throw new Exception($"No se puede añadir valores de tipo {left?.GetType()} y {right?.GetType()}");
        }
        private bool Verdadero(object? value)
        {
            if (value is bool b)
                return b;

            throw new Exception("El valor no es booleano");
        }
        public bool Falso(object? value) => !Verdadero(value);
    }
}
