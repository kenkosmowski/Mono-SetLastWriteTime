using System;

namespace SetLastWriteTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// works
			// //guest:@127.0.0.1:51400/%5BC%5D%20Windows%2010  ->  /Volumes/C

			// doesn't work
			// //GUEST:@Windows%2010._smb._tcp.local/%5BC%5D%20Windows%2010  ->  /Volumes/C

			var path = "/Volumes/C/Dev/test.txt";
			System.IO.File.SetLastWriteTime(path, DateTime.Now.AddDays(-1));
        }
    }
}
