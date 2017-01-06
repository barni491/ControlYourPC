grammar Combined1;

prog: expr+ ;

expr : (COMMAND* voiceUp value*)   #TurnUpVoice
		| (COMMAND* voiceState value*) #ChechVoiceState
		| (COMMAND* voiceDown value* ) #TurnDownVoice;

value :('o' | 'na')* val percent*;

voiceUp : VOICE_UP_COMMAND;
voiceDown: VOICE_DOWN_COMMAND; 
voiceState : VOICE_STATE_COMMAND;
percent:PERCENT;
val : INT;

/*
 * Lexer Rules
 */
INT : [0-9]+;
COMMAND : 'zr�b' | 'ustaw'; 
VOICE_UP_COMMAND : 'g�o�niej' | 'podg�o�nij'  ;
VOICE_DOWN_COMMAND : 'ciszej' | 'zcisz' | 'przycisz' | 'wycisz'  ;
VOICE_STATE_COMMAND : 'g�o�no��';
PERCENT : '%';

WS :   (' ' | '\r' | '\n') -> channel(HIDDEN);