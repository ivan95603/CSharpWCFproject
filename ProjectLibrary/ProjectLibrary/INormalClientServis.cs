using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{

    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface INormalClientServis
    {
        [OperationContract]
        string GetData(string userName, string password);
    }
}
