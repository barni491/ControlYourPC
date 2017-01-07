using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ControlYourPC.Domain
{
  [Serializable]
  [XmlRoot(nameof(ProgramList))]
  public class ProgramList
  {
    [XmlArray(nameof(Programs)), XmlArrayItem(typeof(Program), ElementName = nameof(Program))]
    public List<Program> Programs { get; set; }
  }
}