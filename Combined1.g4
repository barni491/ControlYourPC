grammar Combined1;

prog: expr+ ;
 
/*expr : expr op=(MUL|'/') expr   # MulDiv
     | expr op=(ADD|'-') expr   # AddSub
     | INT                  # int
     | '(' expr ')'         # parens
     ;
*/

expr : (COMMAND* voiceUp value*)   #Kom
		| (COMMAND* voiceChange value*) #Change
		| (COMMAND* voiceDown value* ) #Down;

value :('o' | 'na')* val percent*;

voiceUp : VOICE_UP_COMMAND;
voiceDown: VOICE_DOWN_COMMAND; 
percent:PERCENT;
voiceChange : VOICE_COMMAND;
val : INT;

/*
 * Lexer Rules
 */
INT : [0-9]+;
MUL : '*';
DIV : '/';
ADD : '#' | '+';
SUB : '-';
COMMAND : 'zrób' | 'ustaw'; 
VOICE_UP_COMMAND : 'g?o?niej' | 'podg?o?nij'  ;
VOICE_DOWN_COMMAND : 'ciszej' | 'zcisz' | 'przycisz' | 'wycisz'  ;
VOICE_COMMAND : 'g?o?no??';
PERCENT : '%';

WS :   (' ' | '\r' | '\n') -> channel(HIDDEN);