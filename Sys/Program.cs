using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Sys.Utility;
using Helper;
namespace Sys
{
  class Program
  {
    static void Main(string[] args)
    {
      string command = string.Empty;
      Title = "Sys";
      WriteLine("Sys console info command version 0.1 beta.\nType help to get the availabel commands.\n");
      while (command != "exit")
      {
        Write(">");
        command = ReadLine();

        switch (command.ToLower())
        {
          case "clear":
          case "cls":
            Clear(); // clear the console
            break;
          case "os":
            GetInfo(SystemInfo.GetOperatingSystems());
            break;
          case "ua":
          case "users-accounts":
            GetInfo(SystemInfo.GetUserAccounts());
            break;
          case "sa":
          case "system-accounts":
            GetInfo(SystemInfo.GetUserAccounts());
            break;
          case "cpu":
            GetInfo(SystemInfo.GetCPU());
            break;
          case "mem":
          case "memory":
            GetInfo(SystemInfo.GetMemory());
            break;
          case "dd":
          case "disks-drives":
            GetInfo(SystemInfo.GetDiskDrives());
            break;
          case "dp":
          case "disks-partition":
            GetInfo(SystemInfo.GetDiskPartition());
            break;
          case "ld":
          case "logical-disk":
            GetInfo(SystemInfo.GetLogicalDisks());
            break;
          case "mb":
          case "motherboard":
            GetInfo(SystemInfo.GetMotherBoard());
            break;
          case "bois":
            GetInfo(SystemInfo.GetBios());
            break;
          case "about":
          case "help":
            WriteLine("\n Command                    Alias");
            WriteLine(" --------------------------------");
            WriteLine(" os                            ");
            WriteLine(" users-accounts             ua   ");
            WriteLine(" system-accounts            sa   ");
            WriteLine(" cpu                           ");
            WriteLine(" memory                     mem  ");
            WriteLine(" disks-drives               dd   ");
            WriteLine(" disks-partition            dp   ");
            WriteLine(" logical-disk               ld   ");
            WriteLine(" motherboard                mb   ");
            WriteLine(" bois                          ");
            WriteLine(" about                         \n");
            break;
          default:
            if (command != "")
            {
              WriteLine("Bad command or file not found.");
            }
            break;
        }

      }

    }
  }
}
