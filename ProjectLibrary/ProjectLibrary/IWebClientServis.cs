﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    [ServiceContract]
    public interface IWebClientServis
    {
        [OperationContract]
        [WebInvoke(Method = "GET", 
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetData/{userName}/{password}")]
        string GetData(string userName, string password);

    }
}
