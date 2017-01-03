﻿using Antlr4.Runtime;
using sterowanie_glosem.Services.Interfaces;
using System;

namespace sterowanie_glosem.Services
{
  class GrammarService : IGrammarService
  {
    private readonly Visitor _visitor;

    public GrammarService(Visitor visitor)
    {
      _visitor = visitor;
    }

    public void AnalizeGrammar(string text)
    {
      var input = new AntlrInputStream(text);
      var lexer = new Combined1Lexer(input);
      var tokens = new CommonTokenStream(lexer);
      var parser = new Combined1Parser(tokens);

      Combined1Parser.ProgContext tree = parser.prog();

      string stringTree = tree.ToStringTree(parser);
      string value = _visitor.Visit(tree);

      Console.WriteLine(stringTree);
      Console.WriteLine(value);
    }
  }
}