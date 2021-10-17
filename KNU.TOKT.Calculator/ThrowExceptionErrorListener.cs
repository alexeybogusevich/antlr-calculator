using Antlr4.Runtime;
using System;

namespace KNU.TOKT.Calculator
{
    class ThrowExceptionErrorListener : BaseErrorListener, IAntlrErrorListener<int>
    {
        public override void SyntaxError(
            IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e) =>
            throw new ArgumentException("Invalid Expression: {0}", msg, e);

        public void SyntaxError(
            IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e) =>
                throw new ArgumentException("Invalid Expression: {0}", msg, e);
    }
}
