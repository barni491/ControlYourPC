using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using sterowanie_glosem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sterowanie_glosem.Services
{
    class GrammarService:IGrammarService
    {
        private readonly Visitor _visitor;

        public GrammarService(Visitor visitor) {
            _visitor = visitor;
        }


        public void analizeGrammar(String text) {
           
            //   AntlrInputStream input = new AntlrInputStream("zrób głośniej o 50 procent" );
            //  AntlrInputStream input = new AntlrInputStream("podgłośnij o 50 procent");
            //  AntlrInputStream input = new AntlrInputStream("głośniej o 50 procent");
            // AntlrInputStream input = new AntlrInputStream("głośniej");
            //AntlrInputStream input = new AntlrInputStream("ustaw głośność na 50 procent");
            //  AntlrInputStream input = new AntlrInputStream("przycisz o 50 procent");
            AntlrInputStream input = new AntlrInputStream(text);
            Combined1Lexer lexer = new Combined1Lexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            Combined1Parser parser = new Combined1Parser(tokens);
            IParseTree tree = parser.prog();
            Console.WriteLine(tree.ToStringTree(parser));
            
       //     Visitor visitor = new Visitor();
              Console.WriteLine(_visitor.Visit(tree));

        }

    }
}
