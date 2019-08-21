using System;
using System.IO;
using System.Linq;
using System.Text;

namespace cw_8_1
{
    class Program
    {
        static void Main()
        {
            const string fileName = @"test.txt";
            const string testMassage = "Hello world!";

            byte[] messageAnsiBytes = Encoding.UTF8.GetBytes(testMassage);

            FileStream testFileStream = File.Open(
                fileName,
                //FileMode.OpenOrCreate,
                FileMode.Create,
                FileAccess.Write,
                FileShare.Read);

            //testFileStream.Seek(0, SeekOrigin.End);
            testFileStream.Write(messageAnsiBytes);
            testFileStream.Flush();
            testFileStream.Close();

            // final steps of the first access demo


        }
    }
}
