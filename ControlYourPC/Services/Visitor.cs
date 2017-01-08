using System;
using System.Linq;
using Antlr4.Runtime.Misc;
using ControlYourPC.Services.Interfaces;

namespace ControlYourPC.Services
{
    class Visitor : Combined1BaseVisitor<string>, IVisitor
    {
        private readonly IVoiceService _voiceService;

        public Visitor(IVoiceService voiceService)
        {
            _voiceService = voiceService;
        }

        public override string VisitVoiceSetTo([NotNull] Combined1Parser.VoiceSetToContext context)
        {
            Combined1Parser.ValueContext valueContext = context.value();
            int? value = GetValueFromContext(valueContext);
            _voiceService.SetVolumeTo(value.ToString());
            return $"VoiceSetTo {value}";
           
        }


        public override string VisitRunExternalProcess([NotNull] Combined1Parser.RunExternalProcessContext context)
        {
            string processName = context.runCommand().@string().GetText();
            return $"RunExternalProcess {processName}";
        }

        public override string VisitVoiceUpTo([NotNull] Combined1Parser.VoiceUpToContext context)
        {
            Combined1Parser.ValueContext valueContext = context.value();
            int? value = GetValueFromContext(valueContext);
            _voiceService.SetVolumeTo(value.ToString());
            return $"VoiceUpTo {value}";
        }

        public override string VisitVoiceDownTo([NotNull] Combined1Parser.VoiceDownToContext context)
        {
            Combined1Parser.ValueContext valueContext = context.value();
            int? value = GetValueFromContext(valueContext);

            return $"VoiceDownTo {value}";
           
        }

        public override string VisitVoiceUpAbout([NotNull] Combined1Parser.VoiceUpAboutContext context)
        {
            Combined1Parser.ValueContext valueContext = context.value();
            int? value = GetValueFromContext(valueContext);

            if (!value.HasValue)
            {
                value = 2;
            }

            _voiceService.VolumeUpAbout(value.ToString());

            Console.Out.WriteLine($"Podgłaszanie o [{value}].");
            Console.Out.Write(context.ToStringTree());

            return $"VoiceUpAbout {value}";
        }

        public override string VisitMute([NotNull] Combined1Parser.MuteContext context)
        {
            _voiceService.Mute();
            return "mute";
            
        }

        public override string VisitPrintScreen([NotNull] Combined1Parser.PrintScreenContext context)
        {
            return "TakePrintScreen";
        }

        public override string VisitUnmute([NotNull] Combined1Parser.UnmuteContext context)
        {
            _voiceService.Unmute();
            return "unmute";

        }

        public override string VisitVoiceDownAbout([NotNull] Combined1Parser.VoiceDownAboutContext context)
        {
            Combined1Parser.ValueContext contextValue = context.value();

            int? value = GetValueFromContext(contextValue);
            
            {
                value = 2;
            }

            _voiceService.VolumeDownAbout(value.ToString());

            Console.Out.WriteLine($"Przyciszanie o [{value}].");
            Console.Out.Write(context.ToStringTree());

            return $"VoiceDownAbout {value}" ;
        }

        private static int? GetValueFromContext(Combined1Parser.ValueContext context)
        {
            if (context != null)
            {
                var value = context.val().GetText();
                return Convert.ToInt32(value);
            }
            return null;
        }
    }
}