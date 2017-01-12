using System;
using Antlr4.Runtime;
using ControlYourPC.Domain;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC.Services
{
  class GrammarService : IGrammarService
  {
    private readonly IVisitor _visitor;
    private readonly ICommandConverter _commandConverter;

    public GrammarService(IVisitor visitor, ICommandConverter commandConverter)
    {
      _visitor = visitor;
      _commandConverter = commandConverter;
    }

    public Command AnalizeGrammar(string text)
    {
      var input = new AntlrInputStream(text);
      var lexer = new Combined1Lexer(input);
      var tokens = new CommonTokenStream(lexer);
      var parser = new Combined1Parser(tokens);

      Combined1Parser.ProgContext tree = parser.prog();

      string stringTree = tree.ToStringTree((Parser) parser);
      Console.WriteLine(stringTree);
     
      string value = ((Combined1BaseVisitor<string>)_visitor).Visit(tree);
      //Console.WriteLine(value);
      
      Command command = _commandConverter.Convert(value);

      return command;
    }
  }
}