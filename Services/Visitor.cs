using System;
using System.Linq;
using Antlr4.Runtime.Misc;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC.Services
{
  class Visitor : Combined1BaseVisitor<string>, IVisitor
  {
    private readonly IVoiceService _voiceService;

    public Visitor(IVoiceService voiceService)
    {
      _voiceService = voiceService;
    }
    
    public override string VisitCheckVoiceState([NotNull] Combined1Parser.CheckVoiceStateContext context)
    {
      return nameof(VisitCheckVoiceState);
    }

    public override string VisitTurnUpVoice([NotNull] Combined1Parser.TurnUpVoiceContext context)
    {
      Combined1Parser.ValueContext[] values = context.value();

      int? value = GetValueFromContext(values);

      if (value.HasValue)
      {
        _voiceService.VolumeUp(value.Value);

        Console.Out.WriteLine($"Podgłaszanie o [{value}].");
      }

      Console.Out.Write(context.ToStringTree());

      return base.VisitTurnUpVoice(context);
    }

    public override string VisitTurnDownVoice([NotNull] Combined1Parser.TurnDownVoiceContext context)
    {
      Combined1Parser.ValueContext[] values = context.value();

      int? value = GetValueFromContext(values);
      
      if (value.HasValue)
      {
        _voiceService.VolumeDown(value.Value);

        Console.Out.WriteLine($"Przyciszanie o [{value}].");
      }

      Console.Out.Write(context.ToStringTree());

      return base.VisitTurnDownVoice(context);
    }

    private static int? GetValueFromContext(Combined1Parser.ValueContext[] contexts)
    {
      if (contexts.Length > 0)
      {
        var value = contexts.First().val().GetText();
        return Convert.ToInt32(value);
      }

      return null;
    }
  }
}