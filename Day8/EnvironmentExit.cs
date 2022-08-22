using System;

namespace N_EnvironmentExit
{
    internal class EnvironmentExit
    {
        static public void EnvironmentExitEx()
        {
            Console.WriteLine("시스템 폴더");
            Console.WriteLine(Environment.SystemDirectory);

            Console.WriteLine("닷넷 기준 버전");
            Console.WriteLine(Environment.Version);

            Console.WriteLine("운영 체제 버전");
            Console.WriteLine(Environment.OSVersion);

            Console.WriteLine("컴퓨터 이름");
            Console.WriteLine(Environment.MachineName);

            Console.WriteLine("사용자 이름");
            Console.WriteLine(Environment.UserName);

            Console.WriteLine("현재 폴더");
            Console.WriteLine(Environment.CurrentDirectory);

            Console.WriteLine("문서 폴더");
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }
    }
}
