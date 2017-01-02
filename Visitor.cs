using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime;
using sterowanie_glosem.Services.Interfaces;

namespace sterowanie_glosem
{
    class Visitor : Combined1BaseVisitor<String>,IVisitor
    {
        /*    public override int VisitInt(Combined1Parser.IntContext context)
            {
                return int.Parse(context.INT().GetText());
            }*/
        private readonly IVolumeService _volumeService;

        public Visitor(IVolumeService volumeService) {

            _volumeService = volumeService;
        }

        private int? getValueFromContext(Combined1Parser.ValueContext [] contexts) {


            if (contexts.Length > 0)
            {

            //    contexts.First().percent().First().GetText();

                var value = contexts.First().val().GetText();
                return Int32.Parse(value);

            }

            return null;
        }


        public override String VisitKom([NotNull] Combined1Parser.KomContext context)
        {
      //      int toReturn = base.VisitKom(context);
            return "ok";
        }

        public override string VisitDown([NotNull] Combined1Parser.DownContext context)
        {
            var values = context.value();
            Boolean usePercent = false;

            int? value = getValueFromContext(values);
            
            if (values.Length > 0) {

                 var percents = values.First().percent();

                if (percents.Length > 0) {

                    var percent = percents.First().GetText();
                    usePercent = true;
         

                }



            }

           // var children = context.children;

       //     if (context.children())

       //     String percent = context.value().First().percent().First().GetText();

            //   var va = v[0].val();
            // var text = va.GetText();
            Console.Out.WriteLine("Przyciszanie o " + value + usePercent);
            _volumeService.VolumeDown(1);

            Console.Out.Write(
            context.ToStringTree());
            var i = context.start;
            var s = context.GetText();
            var  j = i.GetType();
          //  context.GetToken(Combined1Parser.)
            return base.VisitDown(context);
        }

        /*   public override int VisitAddSub(Combined1Parser.AddSubContext context)
           {
               int left = Visit(context.expr(0));
               int right = Visit(context.expr(1));
               if (context.op.Type == Combined1Parser.ADD)
               {
                   return left + right;
               }
               else
               {
                   return left - right;
               }
           }

           public override int VisitMulDiv(Combined1Parser.MulDivContext context)
           {
               int left = Visit(context.expr(0));
               int right = Visit(context.expr(1));
               if (context.op.Type == Combined1Parser.MUL)
               {
                   return left * right;
               }
               else
               {
                   return left / right;
               }
           }

           public override int VisitParens(Combined1Parser.ParensContext context)
           {
               return Visit(context.expr());
           }*/
    }

}
