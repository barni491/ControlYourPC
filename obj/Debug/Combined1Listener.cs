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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="Combined1Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface ICombined1Listener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>ChechVoiceState</c>
	/// labeled alternative in <see cref="Combined1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChechVoiceState([NotNull] Combined1Parser.ChechVoiceStateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ChechVoiceState</c>
	/// labeled alternative in <see cref="Combined1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChechVoiceState([NotNull] Combined1Parser.ChechVoiceStateContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TurnUpVoice</c>
	/// labeled alternative in <see cref="Combined1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTurnUpVoice([NotNull] Combined1Parser.TurnUpVoiceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TurnUpVoice</c>
	/// labeled alternative in <see cref="Combined1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTurnUpVoice([NotNull] Combined1Parser.TurnUpVoiceContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TurnDownVoice</c>
	/// labeled alternative in <see cref="Combined1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTurnDownVoice([NotNull] Combined1Parser.TurnDownVoiceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TurnDownVoice</c>
	/// labeled alternative in <see cref="Combined1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTurnDownVoice([NotNull] Combined1Parser.TurnDownVoiceContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Combined1Parser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] Combined1Parser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Combined1Parser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] Combined1Parser.ProgContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Combined1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] Combined1Parser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Combined1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] Combined1Parser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Combined1Parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] Combined1Parser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Combined1Parser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] Combined1Parser.ValueContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Combined1Parser.voiceUp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVoiceUp([NotNull] Combined1Parser.VoiceUpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Combined1Parser.voiceUp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVoiceUp([NotNull] Combined1Parser.VoiceUpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Combined1Parser.voiceDown"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVoiceDown([NotNull] Combined1Parser.VoiceDownContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Combined1Parser.voiceDown"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVoiceDown([NotNull] Combined1Parser.VoiceDownContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Combined1Parser.voiceState"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVoiceState([NotNull] Combined1Parser.VoiceStateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Combined1Parser.voiceState"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVoiceState([NotNull] Combined1Parser.VoiceStateContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Combined1Parser.percent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPercent([NotNull] Combined1Parser.PercentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Combined1Parser.percent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPercent([NotNull] Combined1Parser.PercentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Combined1Parser.val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVal([NotNull] Combined1Parser.ValContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Combined1Parser.val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVal([NotNull] Combined1Parser.ValContext context);
}
} // namespace sterowanie_glosem
