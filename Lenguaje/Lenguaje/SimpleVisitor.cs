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
        //El dicionario es para definir los parametros
        private Dictionary<string, object?> Variables = new();
        //Estas son las constantes para el gramatica
        public SimpleVisitor()
        {
            Variables["PI"] = Math.PI;
            Variables["E"] = Math.E;
            Variables["escribir"] = new Func<object?[], object?>(Write);
        }
        //Funcion para escribir codigo
        private object? Write(object?[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            return null;
        }
        //Visitante para las llamadas de funciones
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
        //Visitante para las asignaciones de valores de las variables
        public override object VisitAssignment([NotNull] SimpleParser.AssignmentContext context)
        {
            var varName = context.IDENTIFIER().GetText();
            var value = Visit(context.expression());
            Variables[varName] = value;
            return null;
        }
        //Visitante para los identificadores
        public override object VisitIdentifierExpression([NotNull] SimpleParser.IdentifierExpressionContext context)
        {
            var varName = context.IDENTIFIER().GetText();

            if (!Variables.ContainsKey(varName))
            {
                throw new Exception($"Variable {varName} is not defined");
            }
            return Variables[varName];
        }
        //visitante para las constantes
        public override object? VisitConstant([NotNull] SimpleParser.ConstantContext context)
        {
            if (context.INTERGER() is { } i)
                return int.Parse(i.GetText());

            if (context.FLOAT() is { } f)
                return float.Parse(f.GetText());

            if (context.STRING() is { } s)
                return s.GetText()[1..^1];

            if (context.BOOL() is { } b)
                return b.GetText() == "true";

            if (context.NULL() is { })
                return null;

            throw new NotImplementedException();
        }
        // visitnate para las expresiones aditivas
        public override object? VisitAdditiveExpression([NotNull] SimpleParser.AdditiveExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            var op = context.addOp().GetText();
            return op switch
            {
                "+" => Suma(left, right),
                "-" => Resta(left, right),
                _ => throw new NotImplementedException()
            };
        }
        // visitante para las expresiones multiplicativas
        public override object? VisitMutiplicativeExpression([NotNull] SimpleParser.MutiplicativeExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            var op = context.multOp().GetText();
            return op switch
            {
                "*" => Multiplicacion(left, right),
                "/" => Divicion(left, right),
                _ => throw new NotImplementedException()
            };
        }
        // Visitante para las expresiones exponenciales
        public override object? VisitExponentialExpression([NotNull] SimpleParser.ExponentialExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            var op = context.expoOp().GetText();
            return op switch
            {
                "estrella" => Potencia(left, right),
                _ => throw new NotImplementedException()
            };
        }
        //Visitante para las expresiones de raiz cuadrada
        public override object? VisitSquarerootExpression([NotNull] SimpleParser.SquarerootExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var op = context.sqrtOp().GetText();

            return op switch
            {
                "solecito" => Raiz(left),
                _ => throw new NotImplementedException()
            };
        }
        //Metodo de suma
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
        //Metodo de resta
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
        //Metodo de multiplicacion
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
        //Metodo de divicion
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
        //Metodo de potencia
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
        //Metodo de raiz cuadrada
        private object? Raiz(object? value)
        {
            if (value is int v)
                value = (double)v;
            else if (value is float fv)
                value = (double)fv;
            else if (value is double d)
                value = d;
            else if (value is string s)
            {
                if (double.TryParse(s, out double number))
                {
                    value = number;
                }
                else
                {
                    throw new ArgumentException("Invalid string input for square root");
                }
            }
            else
            {
                throw new ArgumentException("Invalid type for square root");
            }
            return Math.Sqrt((double)value);
        }
        //Visitante del While
        public override object? VisitWhileBlock([NotNull] SimpleParser.WhileBlockContext context)
        {
            Func<object?, bool> condition = context.WHILE().GetText() == "bucle"
                ? IsTrue
                : IsFalse
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
        //Visitante del If
        public override object? VisitIfBlock([NotNull] SimpleParser.IfBlockContext context)
        {
            var condition = Visit(context.expression());
            Console.WriteLine($"Condición evaluada: {condition}");

            if (!(condition is bool))
            {
                throw new Exception("La condición del 'if' debe ser de tipo booleano");
            }

            if ((bool)condition)
            {
                Console.WriteLine("La condición es verdadera, ejecutando el bloque 'if'");
                Visit(context.block());
            }
            else if (context.elseIfBlock() != null)
            {
                Console.WriteLine("La condición es falsa, ejecutando el bloque 'else if'");
                Visit(context.elseIfBlock());
            }

            return null;
        }
        //Visitante de las expresiones comparativas
        public override object? VisitComparisonExpression([NotNull] SimpleParser.ComparisonExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));
            var op = context.compareOp().GetText();

            return op switch
            {
                "==" => IsEquals(left, right),
                "!=" => NotEquals(left, right),
                ">" => GreaterThan(left, right),
                "<" => LessThan(left, right),
                ">=" => GreaterThanOrEquals(left, right),
                "<=" => LessThanOrEquals(left, right),
                _ => throw new NotImplementedException()
            };
        }
        //Metodos para las expresiones comparativas
        private object? IsEquals(object? left, object? right)
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
        private object? NotEquals(object? left, object? right)
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
        private object? GreaterThan(object? left, object? right)
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
        private object? LessThan(object? left, object? right)
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
        private object? GreaterThanOrEquals(object? left, object? right)
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
        private object? LessThanOrEquals(object? left, object? right)
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
        //Meotodos para los booleanos
        private bool IsTrue(object? value)
        {
            if (value is bool b)
            {
                return b;
            }

            throw new Exception("El valor de la condición no es un tipo booleano");
        }
        public bool IsFalse(object? value) => !IsTrue(value);
    }
}