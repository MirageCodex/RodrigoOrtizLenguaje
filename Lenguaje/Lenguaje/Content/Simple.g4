grammar Simple;

program: line* EOF;

line: statement | ifBlock | whileBlock;

statement: (assignment | functionCall) ';';

ifBlock: 'si' expression block ('sino' elseIfBlock);

elseIfBlock: block | ifBlock;

whileBlock: WHILE expression block ('sino' elseIfBlock); 

WHILE: 'bucle' | 'hasta';

assignment: IDENTIFIER 'asigno' expression;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

expression
    :constant                           #constantExpression
    |IDENTIFIER                         #identifierExpression
    |functionCall                       #functionExpression
    |'(' expression ')'                 #parentesisExpression
    |'!' expression                     #notExpression
    | expression multOp expression      #mutiplicativeExpression
    | expression addOp expression       #additiveExpression
    | expression expoOp expression      #exponentialExpression
    | expression sqrtOp expression      #squarerootExpression
    | expression compareOp expression  #comparisonExpression
    | expression boolOp expression      #booleanExpression
; 

multOp: 'estrella'|'solecito';
addOp: 'sumita'|'restita';
compareOp: 'igualito'|'diferente'|'pequenito'|'grandecito'|'pequeigual'|'granigual';
expoOp : 'superstar';
sqrtOp: 'supersol';
boolOp: BOOL_OPERATOR;

BOOL_OPERATOR: 'y'|'o'|'xor';

constant: INTERGER | FLOAT | STRING | BOOL | NULL;

INTERGER: [0-9]*;
FLOAT: [0-9]+ '.'[0-9]*; 
STRING: ('"' ~'"'* '"') | ('\'' ~'\''* '\'');
BOOL: 'verdadero' | 'falso';
NULL: 'null';

block: '{' line* '}';

WS: [ \t\r\n]+ -> skip;
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;

