namespace sterowanie_glosem.Domain
{
  public class Command
  {
    public CommandType CommandType { get; set; }

    public string Value { get; set; }
  }
}