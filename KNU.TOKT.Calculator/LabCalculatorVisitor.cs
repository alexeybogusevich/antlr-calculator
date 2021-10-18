using System;
using System.Globalization;

namespace KNU.TOKT.Calculator
{
    public class LabCalculatorVisitor : LabCalculatorBaseVisitor<double>
    {
        public override double VisitPowerExpression(LabCalculatorParser.PowerExpressionContext context) =>
            Math.Pow(base.Visit(context.num), (int)base.Visit(context.pow));

        public override double VisitNumberExpression(LabCalculatorParser.NumberExpressionContext context) =>
            double.Parse(context.GetText(), NumberStyles.Any, CultureInfo.InvariantCulture);

        public override double VisitMultOrDivideExpression(LabCalculatorParser.MultOrDivideExpressionContext context)
        {
            switch (context.op.Text)
            {
                case "*": return (base.Visit(context.left) * base.Visit(context.right));
                case "/": return (base.Visit(context.left) / base.Visit(context.right));
                default:
                    throw new ArgumentException($"Unsupported operator '{context.op.Text}'");
            }
        }

        public override double VisitPlusOrMinusExpression(LabCalculatorParser.PlusOrMinusExpressionContext context)
        {
            switch (context.op.Text)
            {
                case "+": return (base.Visit(context.left) + base.Visit(context.right));
                case "-": return (base.Visit(context.left) - base.Visit(context.right));
                default:
                    throw new ArgumentException($"Unsupported operator '{context.op.Text}'");
            }
        }

        public override double VisitCosinusExpression(LabCalculatorParser.CosinusExpressionContext context) =>
            Math.Cos(base.Visit(context.num));

        public override double VisitLogarithmExpression(LabCalculatorParser.LogarithmExpressionContext context) =>
            Math.Log(base.Visit(context.num), base.Visit(context.@base));

        public override double VisitTangentExpression(LabCalculatorParser.TangentExpressionContext context) =>
            Math.Tan(base.Visit(context.num));

        public override double VisitSinusExpression(LabCalculatorParser.SinusExpressionContext context) =>
            Math.Sin(base.Visit(context.num));

        public override double VisitNegativeNumberExpression(LabCalculatorParser.NegativeNumberExpressionContext context) =>
            -1 * base.Visit(context.num);

        protected override double AggregateResult(double aggregate, double nextResult) =>
            aggregate + nextResult;
    }
}
