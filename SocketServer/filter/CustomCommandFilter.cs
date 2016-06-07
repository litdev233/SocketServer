using SuperSocket.SocketBase.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer.filter
{
    /// <summary>
    /// 自定义过滤器
    /// </summary>
    public class CustomCommandFilter : CommandFilterAttribute
    {

        /// <summary>
        /// 命令执行前触发
        /// </summary>
        /// <param name="commandContext"></param>
        public override void OnCommandExecuting(SuperSocket.SocketBase.CommandExecutingContext commandContext)
        {
            commandContext.Session.Logger.Info("即将执行命令：" + commandContext.CurrentCommand.Name);
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 命令执行后触发
        /// </summary>
        /// <param name="commandContext"></param>
        public override void OnCommandExecuted(SuperSocket.SocketBase.CommandExecutingContext commandContext)
        {
            commandContext.Session.Logger.Info("命令“" + commandContext.CurrentCommand.Name+"”执行完毕");
            //throw new NotImplementedException();
        }
    }
}
