//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Konrad\Documents\Visual Studio 2015\Projects\ControlYourPC\ControlYourPC\Combined1.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace sterowanie_glosem {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class Combined1Lexer : Lexer {
	public const int
		T__0=1, T__1=2, INT=3, MUL=4, DIV=5, ADD=6, SUB=7, COMMAND=8, VOICE_UP_COMMAND=9, 
		VOICE_DOWN_COMMAND=10, VOICE_COMMAND=11, PERCENT=12, WS=13;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "INT", "MUL", "DIV", "ADD", "SUB", "COMMAND", "VOICE_UP_COMMAND", 
		"VOICE_DOWN_COMMAND", "VOICE_COMMAND", "PERCENT", "WS"
	};


	public Combined1Lexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'o'", "'na'", null, "'*'", "'/'", null, "'-'", null, null, null, 
		"'g?o?no??'", "'%'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "INT", "MUL", "DIV", "ADD", "SUB", "COMMAND", "VOICE_UP_COMMAND", 
		"VOICE_DOWN_COMMAND", "VOICE_COMMAND", "PERCENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Combined1.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\xFx\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x3\x2\x3\x2\x3\x3"+
		"\x3\x3\x3\x3\x3\x4\x6\x4$\n\x4\r\x4\xE\x4%\x3\x5\x3\x5\x3\x6\x3\x6\x3"+
		"\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\t\x39"+
		"\n\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n"+
		"\x3\n\x3\n\x3\n\x3\n\x3\n\x5\nM\n\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\v\x5\vh\n\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f"+
		"\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x2\x2\x2\xF\x3\x2\x3\x5\x2\x4"+
		"\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17"+
		"\x2\r\x19\x2\xE\x1B\x2\xF\x3\x2\x5\x3\x2\x32;\x4\x2%%--\x5\x2\f\f\xF\xF"+
		"\"\"}\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2"+
		"\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2"+
		"\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19"+
		"\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x3\x1D\x3\x2\x2\x2\x5\x1F\x3\x2\x2\x2"+
		"\a#\x3\x2\x2\x2\t\'\x3\x2\x2\x2\v)\x3\x2\x2\x2\r+\x3\x2\x2\x2\xF-\x3\x2"+
		"\x2\x2\x11\x38\x3\x2\x2\x2\x13L\x3\x2\x2\x2\x15g\x3\x2\x2\x2\x17i\x3\x2"+
		"\x2\x2\x19r\x3\x2\x2\x2\x1Bt\x3\x2\x2\x2\x1D\x1E\aq\x2\x2\x1E\x4\x3\x2"+
		"\x2\x2\x1F \ap\x2\x2 !\a\x63\x2\x2!\x6\x3\x2\x2\x2\"$\t\x2\x2\x2#\"\x3"+
		"\x2\x2\x2$%\x3\x2\x2\x2%#\x3\x2\x2\x2%&\x3\x2\x2\x2&\b\x3\x2\x2\x2\'("+
		"\a,\x2\x2(\n\x3\x2\x2\x2)*\a\x31\x2\x2*\f\x3\x2\x2\x2+,\t\x3\x2\x2,\xE"+
		"\x3\x2\x2\x2-.\a/\x2\x2.\x10\x3\x2\x2\x2/\x30\a|\x2\x2\x30\x31\at\x2\x2"+
		"\x31\x32\a\xF5\x2\x2\x32\x39\a\x64\x2\x2\x33\x34\aw\x2\x2\x34\x35\au\x2"+
		"\x2\x35\x36\av\x2\x2\x36\x37\a\x63\x2\x2\x37\x39\ay\x2\x2\x38/\x3\x2\x2"+
		"\x2\x38\x33\x3\x2\x2\x2\x39\x12\x3\x2\x2\x2:;\ai\x2\x2;<\a\x41\x2\x2<"+
		"=\aq\x2\x2=>\a\x41\x2\x2>?\ap\x2\x2?@\ak\x2\x2@\x41\ag\x2\x2\x41M\al\x2"+
		"\x2\x42\x43\ar\x2\x2\x43\x44\aq\x2\x2\x44\x45\a\x66\x2\x2\x45\x46\ai\x2"+
		"\x2\x46G\a\x41\x2\x2GH\aq\x2\x2HI\a\x41\x2\x2IJ\ap\x2\x2JK\ak\x2\x2KM"+
		"\al\x2\x2L:\x3\x2\x2\x2L\x42\x3\x2\x2\x2M\x14\x3\x2\x2\x2NO\a\x65\x2\x2"+
		"OP\ak\x2\x2PQ\au\x2\x2QR\a|\x2\x2RS\ag\x2\x2Sh\al\x2\x2TU\a|\x2\x2UV\a"+
		"\x65\x2\x2VW\ak\x2\x2WX\au\x2\x2Xh\a|\x2\x2YZ\ar\x2\x2Z[\at\x2\x2[\\\a"+
		"|\x2\x2\\]\a{\x2\x2]^\a\x65\x2\x2^_\ak\x2\x2_`\au\x2\x2`h\a|\x2\x2\x61"+
		"\x62\ay\x2\x2\x62\x63\a{\x2\x2\x63\x64\a\x65\x2\x2\x64\x65\ak\x2\x2\x65"+
		"\x66\au\x2\x2\x66h\a|\x2\x2gN\x3\x2\x2\x2gT\x3\x2\x2\x2gY\x3\x2\x2\x2"+
		"g\x61\x3\x2\x2\x2h\x16\x3\x2\x2\x2ij\ai\x2\x2jk\a\x41\x2\x2kl\aq\x2\x2"+
		"lm\a\x41\x2\x2mn\ap\x2\x2no\aq\x2\x2op\a\x41\x2\x2pq\a\x41\x2\x2q\x18"+
		"\x3\x2\x2\x2rs\a\'\x2\x2s\x1A\x3\x2\x2\x2tu\t\x4\x2\x2uv\x3\x2\x2\x2v"+
		"w\b\xE\x2\x2w\x1C\x3\x2\x2\x2\a\x2%\x38Lg\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace sterowanie_glosem