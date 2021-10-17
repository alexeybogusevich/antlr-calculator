grammar LabCalculator;

/*
* Parser Rules
*/

root: expression EOF;
expression:
   (INTEGER | FLOAT)                                                  #NumberExpression         |
   MINUS num = expression                                           #NegativeNumberExpression   |
   num = expression POWER pow = expression                             #PowerExpression         |
   LPAREN expression RPAREN                                         #ParenthesisExpression      |
   SIN LPAREN num = expression RPAREN                                  #SinusExpression         |
   COS LPAREN num = expression RPAREN                                #CosinusExpression         |
   TAN LPAREN num = expression RPAREN                                #TangentExpression         |
   LOG LPAREN num = expression COMMA base = expression RPAREN         #LogarithmExpression      |
   left = expression op = (MULTIPLY | DIVIDE) right = expression   #MultOrDivideExpression      |
   left = expression op = (PLUS | MINUS) right = expression        #PlusOrMinusExpression      
   ;

/*
* Lexer Rules
*/

fragment DIGIT: [0-9];

PLUS: '+';
MINUS: '-';
MULTIPLY: '*';
DIVIDE: '/';
POWER: '^';

LPAREN: '(';
RPAREN: ')';
COMMA: ',';

SIN: 'sin';
COS: 'cos';
TAN: 'tg';

INTEGER: DIGIT+;

FLOAT: DIGIT+ '.' DIGIT+;