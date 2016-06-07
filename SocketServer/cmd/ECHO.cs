using SocketServer.filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer.cmd
{
    /// <summary>
    /// 命令1
    /// </summary>
    [CustomCommandFilter]
    public class ECHO :BaseCommand
    {
        public override void execute(session.CustomSession session, SuperSocket.SocketBase.Protocol.StringRequestInfo requestInfo)
        {
            //throw new NotImplementedException();
            session.Send("I have received a echo,request body is : "+requestInfo.Body);
        }
    }
}
