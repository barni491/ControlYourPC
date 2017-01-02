using Google.Apis.CloudSpeechAPI.v1beta1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sterowanie_glosem.Services.Interfaces
{
    interface ISpeechRecognationService
    {
     //   CloudSpeechAPIService CreateAuthorizedClient();
        String RecognizeCommand();


    }
}
