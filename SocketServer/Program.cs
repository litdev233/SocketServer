using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入任意键以启动服务");
            Console.ReadKey();

            var bootstarp = BootstrapFactory.CreateBootstrap();
            if (!bootstarp.Initialize())
            {
                Console.WriteLine("Failed to initialize!");
                Console.ReadKey();
                return;
            }

            var result = bootstarp.Start();
            Console.WriteLine("Start result:{0}", result);

            if (result == StartResult.Failed)
            {
                Console.WriteLine("无法启动");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("服务启动成功,输入“q”来停止");

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine();
                continue;
            }

            bootstarp.Stop();

            Console.WriteLine("服务已停止");
            Console.ReadKey();
        }
    }
}
