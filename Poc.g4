grammar Poc;

// Entry point for the program
prog: statement* ;

// Define statements
statement
    : methodCall ';'?
    | ifStatement
    | loopStatement
    ;

// Define if statements
ifStatement
    : 'if' '(' expression ')' '{' statement* '}' ('else' '{' statement* '}')?
    ;

// Define loop statements
loopStatement
    : 'while' '(' expression ')' '{' statement* '}'
    ;

// Define method calls, which can operate on a 'Task' object
methodCall
    : ('PushToOrder' | 'CallExternal') '(' 'task' ')'
    ;

// Define expressions (for simplicity, just handling booleans or integers)
expression
    : 'true'
    | IDENTIFIER ( '.' IDENTIFIER )* // Support for property access
    | 'false'
    | INT
    | DOUBLE                           // Support for double constants
    | expression ('<' | '>' | '<=' | '>=' | '==' | '!=')
    ;

// Token definitions
IDENTIFIER: [a-zA-Z_][a-zA-Z_0-9]* ;
INT: [0-9]+ ;
DOUBLE: [0-9]+ '.' [0-9]+ ;
WS: [ \t\n\r]+ -> skip ;
