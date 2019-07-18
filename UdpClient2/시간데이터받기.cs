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
            UdpClient client = new UdpClient();
            
            //Server 소켓 2개 - recv, send
            IPEndPoint des_ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000),
            recv_ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0);
            for (; ; )
            {
                //데이터 없이 UDP소켓에 송신 - 데이터를 수신하는 UDP소켓은 byte[0]와 송신자의 IP/PORT를 받게됨
                client.Send(new byte[0], 0, des_ip);
                // 서버로부터 시간데이터 수신

                //byte - > 메모리 스트림 -> 커서 맨 처음으로 - > Deserialize -> Send

                byte[] rev_data = client.Receive(ref recv_ip);

                BinaryFormatter formatter = new BinaryFormatter();
                //MemoryStream 객체 생성하면서 byte데이터를 삽입
                MemoryStream stream = new MemoryStream(rev_data);
                //Deserialize 를 사용하기 위해서 커서위치를 데이터처음으로 이동
                stream.Seek(0, SeekOrigin.Begin);
                /*
                 *파일스트림, 메모리스트림 어디서든 Seek메소드 사용 가능
                 *읽었던 파일을 다시 읽고 싶다. -> Seek를 사용하면 된다.
                 */
                DateTime server_time = (DateTime)formatter.Deserialize(stream);
                Console.WriteLine("서버의 현재시간 : {0}",server_time.ToString());
                stream.Close();
                Thread.Sleep(2000); // 2초동안 코드가 멈춤
            }
            client.Close();
        }
    }
}