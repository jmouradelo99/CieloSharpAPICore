﻿using System;
using System.Linq;
using Cielo.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Cielo.Core.Exceptions
{
    public class CieloException : Exception
    {
        public CieloException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public CieloException(IRestResponse response)
            : base(response.ErrorMessage, response.ErrorException)
        {
            this.Response = response;
        }

        public Error[] CieloErrors
        {
            get
            {
                if (Response == null || Response.Content == null || !new[] { "text/json", "application/json" }.Contains(Response.ContentType))
                {
                    return null;
                }

                return JsonConvert.DeserializeObject<Error[]>(Response.Content);
            }
        }

        public IRestResponse Response { get; protected set; }
    }
}
