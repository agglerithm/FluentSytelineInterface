using System;
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Factories.impl
{
    public class OpenSessionEnvelopeFactory : IOpenSessionEnvelopeFactory
    {
        public OpenSessionRequestData GetOpenSessionEnvelope(string user, string password, string configName)
        {
            var envelope = new OpenSessionRequestData(user, password, configName, "")
                               {
                                   ApplicationName = Environment.CommandLine.Replace(Environment.CurrentDirectory, ""),
                                   MachineName = Environment.MachineName
                               };
            return envelope;
        }
    }
}