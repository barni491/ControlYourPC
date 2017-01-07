using System;
using Antlr4.Runtime;
using ControlYourPC.Domain;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC.Services
{
  class GrammarService : IGrammarService
  {
    private readonly IVisitor _visitor;

    public GrammarService(IVisitor visitor)
    {
      _visitor = visitor;
    }

    public Command AnalizeGrammar(string text)
    {
      var input = new AntlrInputStream(text);
      var lexer = new Combined1Lexer(input);
      var tokens = new CommonTokenStream(lexer);
      var parser = new Combined1Parser(tokens);

      Combined1Parser.ProgContext tree = parser.prog();

      string stringTree = tree.ToStringTree((Parser) parser);
      string value = ((Combined1BaseVisitor<string>)_visitor).Visit(tree);
  
      Console.WriteLine(stringTree);
      Console.WriteLine(value);

      return new Command();
    }
  }
}