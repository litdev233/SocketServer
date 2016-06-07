using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer.session
{
    /// <summary>
    /// 自定义Session
    /// </summary>
    public class CustomSession : AppSession<CustomSession>
    {
        //在此自定义额外属性
        ///// <summary>
        ///// 登陆状态
        ///// </summary>
        //public string IsLogin { get; set; }


        protected override void OnSessionStarted()
        {
            this.Send("welecome to custom socket");
        }

        protected override void HandleUnknownRequest(SuperSocket.SocketBase.Protocol.StringRequestInfo requestInfo)
        {
            this.Send("Unknow request");
        }

        protected override void HandleException(Exception e)
        {
            this.Send("Application error: {0}", e.Message);
        }

        protected override void OnSessionClosed(CloseReason reason)
        {
            //添加业务逻辑，这些逻辑将在回话结束后执行
            base.OnSessionClosed(reason);
        }
    }
}
