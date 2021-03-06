﻿using System;
using System.Net.Http;
using WebApiClient;

namespace WebApiClientTest.Parameterables
{
    public interface IMyApi : IDisposable
    {
        ITask<HttpResponseMessage> PostAsync(string name);
    }
}
