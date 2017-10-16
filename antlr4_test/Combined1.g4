grammar Combined1;

/*
 * Parser Rules
 */

compileUnit
	: (expression
	| var_declaration)
	EOF
	;

expression
		:
			expression PLUS expression 
		|	NUMBER
		;

var: (TYPE ('[' ']')*);
var_declaration: var ID ';' ;
/*
 * Lexer Rules
 */
TYPE: 'int';
PLUS: '+';
ID: [a-z]+;
NUMBER: [0-9]+;


WS
	:	( ' ' | '\t' |  '\f' | '\r' | '\n' )+ -> channel(HIDDEN)
	;