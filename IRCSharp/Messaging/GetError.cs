using System.Collections.Generic;
using System.Threading;

namespace IRCSharp.Messaging
{
    public class GetError
    {
        public ManualResetEventSlim Ready = new ManualResetEventSlim(false);
        public string Match = string.Empty;
        public IRCErrorCode Error = new IRCErrorCode();
        public ServerErrorMessage Result = new ServerErrorMessage();
    }
}