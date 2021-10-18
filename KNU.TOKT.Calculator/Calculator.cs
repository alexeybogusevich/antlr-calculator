using Antlr4.Runtime;

namespace KNU.TOKT.Calculator
{
    public static class Calculator
    {
        public static double Evaluate(string expression)
        {
            var validExpression = expression.Replace(',', '.');
            var lexer = new LabCalculatorLexer(new AntlrInputStream(validExpression));
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowExceptionErrorListener());

            var tokens = new CommonTokenStream(lexer);
            var parser = new LabCalculatorParser(tokens);
            var tree = parser.root();

            var visitor = new LabCalculatorVisitor();
            return visitor.Visit(tree);
        }
    }
}
