using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using SocketServer.session;

namespace SocketServer.cmd
{
    /// <summary>
    /// 命令基类
    /// </summary>
    public abstract class BaseCommand : CommandBase<CustomSession,StringRequestInfo>
    {
        public override void ExecuteCommand(CustomSession session, StringRequestInfo requestInfo)
        {
            //throw new NotImplementedException();
            session.Logger.Info("收到命令：" + requestInfo.Key + ",请求内容：" + requestInfo.Body);
            execute(session, requestInfo);
        }

        public abstract void execute(CustomSession session, StringRequestInfo requestInfo);
    }
}
