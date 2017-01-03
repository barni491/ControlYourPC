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
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class Combined1Parser : Parser {
	public const int
		T__0=1, T__1=2, INT=3, MUL=4, DIV=5, ADD=6, SUB=7, COMMAND=8, VOICE_UP_COMMAND=9, 
		VOICE_DOWN_COMMAND=10, VOICE_COMMAND=11, PERCENT=12, WS=13;
	public const int
		RULE_prog = 0, RULE_expr = 1, RULE_value = 2, RULE_voiceUp = 3, RULE_voiceDown = 4, 
		RULE_percent = 5, RULE_voiceChange = 6, RULE_val = 7;
	public static readonly string[] ruleNames = {
		"prog", "expr", "value", "voiceUp", "voiceDown", "percent", "voiceChange", 
		"val"
	};

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

	public override string SerializedAtn { get { return _serializedATN; } }

	public Combined1Parser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgContext : ParserRuleContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 17;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 16; expr();
				}
				}
				State = 19;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << COMMAND) | (1L << VOICE_UP_COMMAND) | (1L << VOICE_DOWN_COMMAND) | (1L << VOICE_COMMAND))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DownContext : ExprContext {
		public VoiceDownContext voiceDown() {
			return GetRuleContext<VoiceDownContext>(0);
		}
		public ITerminalNode[] COMMAND() { return GetTokens(Combined1Parser.COMMAND); }
		public ITerminalNode COMMAND(int i) {
			return GetToken(Combined1Parser.COMMAND, i);
		}
		public ValueContext[] value() {
			return GetRuleContexts<ValueContext>();
		}
		public ValueContext value(int i) {
			return GetRuleContext<ValueContext>(i);
		}
		public DownContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterDown(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitDown(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDown(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class KomContext : ExprContext {
		public VoiceUpContext voiceUp() {
			return GetRuleContext<VoiceUpContext>(0);
		}
		public ITerminalNode[] COMMAND() { return GetTokens(Combined1Parser.COMMAND); }
		public ITerminalNode COMMAND(int i) {
			return GetToken(Combined1Parser.COMMAND, i);
		}
		public ValueContext[] value() {
			return GetRuleContexts<ValueContext>();
		}
		public ValueContext value(int i) {
			return GetRuleContext<ValueContext>(i);
		}
		public KomContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterKom(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitKom(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitKom(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ChangeContext : ExprContext {
		public VoiceChangeContext voiceChange() {
			return GetRuleContext<VoiceChangeContext>(0);
		}
		public ITerminalNode[] COMMAND() { return GetTokens(Combined1Parser.COMMAND); }
		public ITerminalNode COMMAND(int i) {
			return GetToken(Combined1Parser.COMMAND, i);
		}
		public ValueContext[] value() {
			return GetRuleContexts<ValueContext>();
		}
		public ValueContext value(int i) {
			return GetRuleContext<ValueContext>(i);
		}
		public ChangeContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterChange(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitChange(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChange(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_expr);
		int _la;
		try {
			State = 60;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,7,_ctx) ) {
			case 1:
				_localctx = new KomContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				{
				State = 24;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMAND) {
					{
					{
					State = 21; Match(COMMAND);
					}
					}
					State = 26;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 27; voiceUp();
				State = 31;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << INT))) != 0)) {
					{
					{
					State = 28; value();
					}
					}
					State = 33;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
				}
				break;

			case 2:
				_localctx = new ChangeContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				{
				State = 37;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMAND) {
					{
					{
					State = 34; Match(COMMAND);
					}
					}
					State = 39;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 40; voiceChange();
				State = 44;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << INT))) != 0)) {
					{
					{
					State = 41; value();
					}
					}
					State = 46;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
				}
				break;

			case 3:
				_localctx = new DownContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				{
				State = 50;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMAND) {
					{
					{
					State = 47; Match(COMMAND);
					}
					}
					State = 52;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 53; voiceDown();
				State = 57;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << INT))) != 0)) {
					{
					{
					State = 54; value();
					}
					}
					State = 59;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public ValContext val() {
			return GetRuleContext<ValContext>(0);
		}
		public PercentContext[] percent() {
			return GetRuleContexts<PercentContext>();
		}
		public PercentContext percent(int i) {
			return GetRuleContext<PercentContext>(i);
		}
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitValue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_value);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 65;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==T__0 || _la==T__1) {
				{
				{
				State = 62;
				_la = _input.La(1);
				if ( !(_la==T__0 || _la==T__1) ) {
				_errHandler.RecoverInline(this);
				} else {
					Consume();
				}
				}
				}
				State = 67;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 68; val();
			State = 72;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==PERCENT) {
				{
				{
				State = 69; percent();
				}
				}
				State = 74;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VoiceUpContext : ParserRuleContext {
		public ITerminalNode VOICE_UP_COMMAND() { return GetToken(Combined1Parser.VOICE_UP_COMMAND, 0); }
		public VoiceUpContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_voiceUp; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterVoiceUp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitVoiceUp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVoiceUp(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VoiceUpContext voiceUp() {
		VoiceUpContext _localctx = new VoiceUpContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_voiceUp);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 75; Match(VOICE_UP_COMMAND);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VoiceDownContext : ParserRuleContext {
		public ITerminalNode VOICE_DOWN_COMMAND() { return GetToken(Combined1Parser.VOICE_DOWN_COMMAND, 0); }
		public VoiceDownContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_voiceDown; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterVoiceDown(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitVoiceDown(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVoiceDown(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VoiceDownContext voiceDown() {
		VoiceDownContext _localctx = new VoiceDownContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_voiceDown);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 77; Match(VOICE_DOWN_COMMAND);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PercentContext : ParserRuleContext {
		public ITerminalNode PERCENT() { return GetToken(Combined1Parser.PERCENT, 0); }
		public PercentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_percent; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterPercent(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitPercent(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPercent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PercentContext percent() {
		PercentContext _localctx = new PercentContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_percent);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 79; Match(PERCENT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VoiceChangeContext : ParserRuleContext {
		public ITerminalNode VOICE_COMMAND() { return GetToken(Combined1Parser.VOICE_COMMAND, 0); }
		public VoiceChangeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_voiceChange; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterVoiceChange(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitVoiceChange(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVoiceChange(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VoiceChangeContext voiceChange() {
		VoiceChangeContext _localctx = new VoiceChangeContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_voiceChange);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 81; Match(VOICE_COMMAND);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValContext : ParserRuleContext {
		public ITerminalNode INT() { return GetToken(Combined1Parser.INT, 0); }
		public ValContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_val; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterVal(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitVal(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVal(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValContext val() {
		ValContext _localctx = new ValContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_val);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 83; Match(INT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\xFX\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x3\x2\x6\x2\x14\n\x2\r\x2\xE\x2\x15\x3\x3\a\x3\x19\n\x3\f\x3\xE\x3"+
		"\x1C\v\x3\x3\x3\x3\x3\a\x3 \n\x3\f\x3\xE\x3#\v\x3\x3\x3\a\x3&\n\x3\f\x3"+
		"\xE\x3)\v\x3\x3\x3\x3\x3\a\x3-\n\x3\f\x3\xE\x3\x30\v\x3\x3\x3\a\x3\x33"+
		"\n\x3\f\x3\xE\x3\x36\v\x3\x3\x3\x3\x3\a\x3:\n\x3\f\x3\xE\x3=\v\x3\x5\x3"+
		"?\n\x3\x3\x4\a\x4\x42\n\x4\f\x4\xE\x4\x45\v\x4\x3\x4\x3\x4\a\x4I\n\x4"+
		"\f\x4\xE\x4L\v\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3"+
		"\t\x3\t\x2\x2\x2\n\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x2\x3"+
		"\x3\x2\x3\x4Z\x2\x13\x3\x2\x2\x2\x4>\x3\x2\x2\x2\x6\x43\x3\x2\x2\x2\b"+
		"M\x3\x2\x2\x2\nO\x3\x2\x2\x2\fQ\x3\x2\x2\x2\xES\x3\x2\x2\x2\x10U\x3\x2"+
		"\x2\x2\x12\x14\x5\x4\x3\x2\x13\x12\x3\x2\x2\x2\x14\x15\x3\x2\x2\x2\x15"+
		"\x13\x3\x2\x2\x2\x15\x16\x3\x2\x2\x2\x16\x3\x3\x2\x2\x2\x17\x19\a\n\x2"+
		"\x2\x18\x17\x3\x2\x2\x2\x19\x1C\x3\x2\x2\x2\x1A\x18\x3\x2\x2\x2\x1A\x1B"+
		"\x3\x2\x2\x2\x1B\x1D\x3\x2\x2\x2\x1C\x1A\x3\x2\x2\x2\x1D!\x5\b\x5\x2\x1E"+
		" \x5\x6\x4\x2\x1F\x1E\x3\x2\x2\x2 #\x3\x2\x2\x2!\x1F\x3\x2\x2\x2!\"\x3"+
		"\x2\x2\x2\"?\x3\x2\x2\x2#!\x3\x2\x2\x2$&\a\n\x2\x2%$\x3\x2\x2\x2&)\x3"+
		"\x2\x2\x2\'%\x3\x2\x2\x2\'(\x3\x2\x2\x2(*\x3\x2\x2\x2)\'\x3\x2\x2\x2*"+
		".\x5\xE\b\x2+-\x5\x6\x4\x2,+\x3\x2\x2\x2-\x30\x3\x2\x2\x2.,\x3\x2\x2\x2"+
		"./\x3\x2\x2\x2/?\x3\x2\x2\x2\x30.\x3\x2\x2\x2\x31\x33\a\n\x2\x2\x32\x31"+
		"\x3\x2\x2\x2\x33\x36\x3\x2\x2\x2\x34\x32\x3\x2\x2\x2\x34\x35\x3\x2\x2"+
		"\x2\x35\x37\x3\x2\x2\x2\x36\x34\x3\x2\x2\x2\x37;\x5\n\x6\x2\x38:\x5\x6"+
		"\x4\x2\x39\x38\x3\x2\x2\x2:=\x3\x2\x2\x2;\x39\x3\x2\x2\x2;<\x3\x2\x2\x2"+
		"<?\x3\x2\x2\x2=;\x3\x2\x2\x2>\x1A\x3\x2\x2\x2>\'\x3\x2\x2\x2>\x34\x3\x2"+
		"\x2\x2?\x5\x3\x2\x2\x2@\x42\t\x2\x2\x2\x41@\x3\x2\x2\x2\x42\x45\x3\x2"+
		"\x2\x2\x43\x41\x3\x2\x2\x2\x43\x44\x3\x2\x2\x2\x44\x46\x3\x2\x2\x2\x45"+
		"\x43\x3\x2\x2\x2\x46J\x5\x10\t\x2GI\x5\f\a\x2HG\x3\x2\x2\x2IL\x3\x2\x2"+
		"\x2JH\x3\x2\x2\x2JK\x3\x2\x2\x2K\a\x3\x2\x2\x2LJ\x3\x2\x2\x2MN\a\v\x2"+
		"\x2N\t\x3\x2\x2\x2OP\a\f\x2\x2P\v\x3\x2\x2\x2QR\a\xE\x2\x2R\r\x3\x2\x2"+
		"\x2ST\a\r\x2\x2T\xF\x3\x2\x2\x2UV\a\x5\x2\x2V\x11\x3\x2\x2\x2\f\x15\x1A"+
		"!\'.\x34;>\x43J";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace sterowanie_glosem
