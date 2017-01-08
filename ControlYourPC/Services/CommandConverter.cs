using System;
using ControlYourPC.Domain;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC.Services
{
    public class CommandConverter : ICommandConverter
    {
        public Command Convert(string source)
        {

            if (source == null)
            {
                return null;
            }
            string[] strings = source.Split(' ');

            var command = new Command
            {
                CommandType = (CommandType)Enum.Parse(typeof(CommandType), strings[0]),
            };

            if (strings.Length == 2)
            {
                command.Value = strings[1];
            }

            return command;
        }
    }
}