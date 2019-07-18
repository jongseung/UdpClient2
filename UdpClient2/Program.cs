using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* 
 * UDP 서버에 데이터 없이 송신하는 클라이언트
 */
namespace UdpClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            //UdpClient 객체 생성 - 데이터를 먼저 보내는 송신자측은 포트번호 임시 발급
            UdpClient client = new UdpClient(10000); //PORT번호 고정
            IPEndPoint des_ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
            for (; ; )
            {
                //데이터 없이 UDP소켓에 송신 - 데이터를 수신하는 UDP소켓은 byte[0]와 송신자의 IP/PORT를 받게됨
                client.Send(new byte[0], 0, des_ip);

                // 서버로부터 시간데이터 수신

                Thread.Sleep(2000); // 2초동안 코드가 멈춤

            }
            client.Close();
        }
    }
}