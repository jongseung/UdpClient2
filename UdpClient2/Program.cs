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
 * 브로드캐스트 : 해당 컴퓨터가 속한 네트워크 영역에 연결된 모든 컴퓨터/ 스마트폰/ 인터넷 장비에게 동일한 데이터를 동일한 포트로 송신하는 기능
 * 이 데이터를 받는 장치들은 포트번호를 고정한 UDP 소켓을 생성해 수신을 대기
 * 단점 : 해당 데이터를 받는 장치나 안받는 장치에 상관없이 모든 장치에 데이터를 송신하기 때문에 해당 네트워크 영역에 부하가 발생
 * UDP 송신 프로그램 - 브로드캐스트를 통해 데이터를송신
 */

namespace UdpClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}