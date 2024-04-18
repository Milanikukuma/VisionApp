using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSight.Configuration
{
    public class ConstantSettings: ISettings
    {
        public string AzureAnalayzeEndPoint { get => "https://mkcomputeraanalyser.cognitiveservices.azure.com/"; }
        public string AzureAnalayzeKey { get => "ffa687cbca3d4a27a2b42abe58db3459"; }
      

    }
}
