using SocketServer.filter;
using SocketServer.session;
using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer.server
{
    /// <summary>
    /// 自定义服务
    /// </summary>
    //[CustomCommandFilter]
    public class CustomServer : AppServer<CustomSession>
    {
        protected override bool Setup(SuperSocket.SocketBase.Config.IRootConfig rootConfig, SuperSocket.SocketBase.Config.IServerConfig config)
        {
            return base.Setup(rootConfig, config);
        }

        protected override void OnStarted()
        {
            this.Logger.Info("Custom服务启动...");
            base.OnStarted();
        }

        protected override void OnStopped()
        {
            this.Logger.Info("Custom服务停止...");
            base.OnStopped();
        }

        protected override void OnNewSessionConnected(CustomSession session)
        {
            this.Logger.Info("新的连接加入，标识：" + session.SessionID);
            base.OnNewSessionConnected(session);
        }

    }
}
