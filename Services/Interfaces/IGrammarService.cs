using sterowanie_glosem.Domain;

namespace sterowanie_glosem.Services.Interfaces
{
  public interface IGrammarService
  {
    Command AnalizeGrammar(string text);
  }
}
