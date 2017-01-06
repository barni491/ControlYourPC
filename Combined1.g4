grammar Combined1;

prog: expr+ ;
 


expr : (COMMAND? voiceUp value?)   #Up
		| (COMMAND? voiceChange value?) #Change
		| (COMMAND? voiceDown value? ) #Down;

value :('o')? val percent?;

voiceUp : VOICE_UP_COMMAND;
voiceDown: VOICE_DOWN_COMMAND; 
percent:PERCENT;
voiceChange : VOICE_COMMAND;
val : INT;

/*
 * Lexer Rules
 */
INT : [0-9]+;

COMMAND : 'zrób' | 'ustaw'; 
VOICE_UP_COMMAND : 'g³oœniej' | 'podg³oœnij'  ;
VOICE_DOWN_COMMAND : 'ciszej' | 'zcisz' | 'przycisz' | 'wycisz'  ;
VOICE_COMMAND : 'g³oœnoœæ';
PERCENT : '%';

WS :   (' ' | '\r' | '\n') -> channel(HIDDEN);