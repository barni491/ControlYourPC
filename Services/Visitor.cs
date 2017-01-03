using System;
using System.Linq;
using Antlr4.Runtime.Misc;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem.Services
{
  class Visitor : Combined1BaseVisitor<string>, IVisitor
  {
    private readonly IVolumeService _volumeService;

    public Visitor(IVolumeService volumeService)
    {
      _volumeService = volumeService;
    }
    
    public override string VisitKom([NotNull] Combined1Parser.KomContext context)
    {
      return "ok";
    }

    public override string VisitDown([NotNull] Combined1Parser.DownContext context)
    {
      Combined1Parser.ValueContext[] values = context.value();

      int? value = GetValueFromContext(values);

      Console.Out.WriteLine("Przyciszanie o " + value);

      _volumeService.VolumeDown(1);

      Console.Out.Write(context.ToStringTree());

      return base.VisitDown(context);
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