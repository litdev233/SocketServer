using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer.cmd
{
    /// <summary>
    /// 命令2
    /// </summary>
    public class ADD :BaseCommand
    {
        public override void execute(session.CustomSession session, SuperSocket.SocketBase.Protocol.StringRequestInfo requestInfo)
        {
            //throw new NotImplementedException();
            session.Send("hello add");
        }
    }
}
