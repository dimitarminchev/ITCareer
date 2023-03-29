namespace CryptoMiningSystem.Core.Contracts
{
    using System.Collections.Generic;

    public interface IPCController
    {
        string RegisterUser(List<string> args);

        string CreateComputer(List<string> args);

        string Mine();

        string UserInfo(List<string> args);

        string Shutdown();
    }
}