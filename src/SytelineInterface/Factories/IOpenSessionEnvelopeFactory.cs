using Mongoose.IDO.Protocol;

namespace SytelineInterface.Factories
{
    public interface IOpenSessionEnvelopeFactory
    {
        OpenSessionRequestData GetOpenSessionEnvelope(string user, string password, string configName);
    }
}