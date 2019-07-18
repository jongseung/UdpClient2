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
 * 멀티캐스트 : 224.0.1.0 - 239.255.255.255 중 특정 네트워크에 가입해 1대다 통신을 사용하는 기법.
 * 224.0.0.0 ~ 244.0.0.255는 네트워크 장치가 사용하는 영역으로 멀티캐스트에 가입할수 없다.
 * 멀티캐스트에 가입할 수 있는 소켓은 UDP 소켓만 가입가능. UDP 소켓은 여러개의 멀티캐스트를 가입할수 있고, 탈퇴가 자유로움. 가입된 멀티캐스트로 들어오는 데이터를 수신 할 수 있으나 포트번호가 다르면 수신받을 수 없음.
 * 멀티캐스트 그룹으로 데이터 송신시 IP설정을 멀티캐스트의 IP로 설정해 데이터 송신
 * 멀티캐스트는 다른 네트워크 영역에 있는 UDP소켓에게 전달 할 수 있음.
 * TTL (Time TO Live) : 네트워크 장비(라우터)를 거칠때마다 TTL값이 1씩 감소해 TTL이 0이되면 데이터가 소멸됨, TTL을 높힐수록 물리적으로 멀리 떨어진 UDP소켓에게 데이터를 전송이 가능함
 * 
 * 예제로 배우는 C# , Topcit, 소켓 교재를 이용하면 더 자세히 알 수 있다.
 * 
 * UDP 송신 프로그램 - 멀티케스트를 통해 데이터를 송신
 */

namespace UdpClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            //UdpClient 객체 생성 - 13000포트

            //송신할 멀티캐스트의 IP/PORT 저장할 IPEndPoint 객체 생성
            
            //멀티 캐스트 IP : 224.0.1.0 PORT : 13000

            //문자열, byte[], BinaryFormatter, MemoryStream 변수 생성
            
            //보낼데이터를 byte[]로 가공

            //송신
            
            //UdpClient 객체 연결 종료
        }
    }
}