using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSight.Configuration
{
    public interface ISettings
    {
        public string AzureAnalayzeEndPoint { get; }
        public string AzureAnalayzeKey { get; }
   

    }
}
