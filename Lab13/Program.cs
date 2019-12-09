using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\ООП\OOP_Lab13\";
            Console.WriteLine(PAVDiskInfo.GetDiskInfo());
            PAVLog.Write(PAVDiskInfo.GetDiskInfo());

            Console.WriteLine(PAVFileInfo.GetFileInfo());
            PAVLog.Write(PAVFileInfo.GetFileInfo());
            Console.WriteLine(PAVFileInfo.GetPath());
            PAVLog.Write(PAVFileInfo.GetPath());
            Console.WriteLine(PAVFileInfo.GetTimeCreation());
            PAVLog.Write(PAVFileInfo.GetTimeCreation());

            Console.WriteLine(PAVDirInfo.GetCreationTime());
            PAVLog.Write(PAVDirInfo.GetCreationTime());
            Console.WriteLine(PAVDirInfo.GetDirCount());
            PAVLog.Write(PAVDirInfo.GetDirCount());
            Console.WriteLine(PAVDirInfo.GetFilesCount());
            PAVLog.Write(PAVDirInfo.GetFilesCount());
            Console.WriteLine(PAVDirInfo.GetDirList());
            PAVLog.Write(PAVDirInfo.GetDirList());
            PAVLog.Write("$Session - " + DateTime.Now.Date.ToString() + "$");


            PAVFileManager.MoveFiles(path);
            PAVFileManager.MoveDirectoriesByExtension(path, ".css");
            PAVFileManager.ToZip(path);

            Console.WriteLine("======================================");
            Console.WriteLine("============= FROM FILE ==============");
            Console.WriteLine($"============= COUNT: {PAVLog.GetRecordCount()}================");
            Console.WriteLine("======================================\n");
            Console.WriteLine(PAVLog.GetInfoByDay(DateTime.Now.Date));

            PAVLog.Close();

        }
    }
}