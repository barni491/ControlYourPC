using ControlYourPC.Domain;

namespace ControlYourPC.Services.Interfaces
{
  public interface IGrammarService
  {
    Command AnalizeGrammar(string text);
  }
}
