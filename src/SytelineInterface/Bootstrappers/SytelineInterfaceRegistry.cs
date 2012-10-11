using StructureMap.Configuration.DSL;
using SytelineInterface.Core.impl;

namespace SytelineInterface.Bootstrappers
{
    public class SytelineInterfaceRegistry : Registry
    {
        public SytelineInterfaceRegistry()
        {
            //Container.Register<IClientWrapper, ClientWrapper>("ido")
            //  .WithDependencies(new
            //  {
            //      url = AFPSTConfiguration.GetSytelineUrl(),
            //      user = configuration.GetSettingBasedOnTestMode("SytelineUser"),
            //      password = configuration.GetSettingBasedOnTestMode("SytelinePwd")
            //  });
             
            var url = "";
            var user =  "SytelineUser";
            var password =  "SytelinePwd";


            For<IClientWrapper>().Use<ClientWrapper>().Named("ido")
                .Ctor<string>("url").Is(url)
                .Ctor<string>("user").Is(user)
                .Ctor<string>("password").Is(password);

            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.WithDefaultConventions();
                     });
        }
    }
}