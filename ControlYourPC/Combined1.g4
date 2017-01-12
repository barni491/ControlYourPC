grammar Combined1;

prog: expr+ ;

expr : ((COMMAND? voiceUp ABOUT_COMMAND value?) |(UP_COMMAND VOICE_NOUN ABOUT_COMMAND? value?))  #VoiceUpAbout
		| (((UP_COMMAND VOICE_NOUN)|(VOICE_UP_COMMAND)) TO_COMMAND value) # VoiceUpTo
		| (((DOWN_COMMAND VOICE_NOUN)|(VOICE_DOWN_COMMAND)) TO_COMMAND value  ) #VoiceDownTo
		| (COMMAND? VOICE_DOWN_COMMAND ABOUT_COMMAND? value? ) #VoiceDownAbout
		| (COMMAND? VOICE_NOUN TO_COMMAND? value ) #VoiceSetTo		
		|( VOICE_MUTE_COMMAND | ( (TURN_OFF_COMMAND | VOICE_MUTE_COMMAND)  VOICE_NOUN))  #Mute 
		|( TURN_ON_COMMAND  VOICE_NOUN)  #Unmute
		| printScreenExpr #PrintScreen 
		| runCommand #RunExternalProcess;


printScreenExpr : (COMMAND? PRINTSCREEN_NOUN);

aboutValue :ABOUT_COMMAND? val percent?;
value :val percent?;

voiceUp : VOICE_UP_COMMAND;
voiceDown: VOICE_DOWN_COMMAND; 

percent:PERCENT;
val : INT;

runCommand : (TURN_ON_COMMAND | RUN_COMMAND) string ;

/*
 * Lexer Rules
 */



string : WORD+; 

INT : [0-9]+;
COMMAND : 'zr�b' | 'ustaw'; 
UP_COMMAND : 'zwi�ksz';
DOWN_COMMAND : 'zmniejsz';
ABOUT_COMMAND: 'o'|'po'|'od'|'to';
RUN_COMMAND :  'uruchom' | 'odpal' | 'otw�rz' | 'wystartuj';
TO_COMMAND: 'do' | 'na';
TURN_OFF_COMMAND : 'wy��cz' ;
TURN_ON_COMMAND : 'w��cz';
VOICE_UP_COMMAND : 'g�o�niej' | 'podg�o�nij'  ;
VOICE_DOWN_COMMAND : 'ciszej' | 'zcisz' | 'przycisz'   ;
VOICE_MUTE_COMMAND: 'wycisz';
VOICE_NOUN : 'g�os'| 'g�o�niki'|'g�o�no��';
PERCENT : '%';

PRINTSCREEN_NOUN : 'zrzut' | 'zrzut ekranu';
WORD 	: ('a'..'z' |  'A'..'Z')+ ;
WS :   (' ' | '\r' | '\n') -> channel(HIDDEN);