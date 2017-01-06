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


        public override string VisitUp([NotNull] Combined1Parser.UpContext context)
        {
            int? value = null;

            Combined1Parser.ValueContext values = context.value();
            if (values != null)
            {
                value = GetValueFromContext(values);
            }

            Console.Out.WriteLine("Podgłaśnianie o " + value);
            if (value != null)
            {
                _volumeService.VolumeUp(value.GetValueOrDefault());
            }
            return base.VisitUp(context);
        }



        public override string VisitDown([NotNull] Combined1Parser.DownContext context)
        {
            int? value = null;

            Combined1Parser.ValueContext values = context.value();
            if (values != null) {
                value = GetValueFromContext(values);
            }
       
            Console.Out.WriteLine("Przyciszanie o " + value);
            if (value != null) {
                _volumeService.VolumeDown(value.GetValueOrDefault());
            }

        return base.VisitDown(context);
    }

    private static int GetValueFromContext(Combined1Parser.ValueContext context)
    {
        
            
        String value =  context.val().GetText();
        return Convert.ToInt32(value);  
    }
  }
}