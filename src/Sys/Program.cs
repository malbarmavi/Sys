using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Sys.Utility;
using Helper;
using Helper.Extenstion;

namespace Sys
{
  class Program
  {
    static void Main(string[] args)
    {

      string command = string.Empty;
      string about = " commands:\n\tos, users - accounts(ua), system - accounts(sa), cpu, memory(mem),\n\tdisks - drives(dd), disks - partition(dp), logical - disk(ld),\n\tmotherboard(mb),bios , about ";
      Title = "Sys";
      WriteLine("Sys console info command version [0.5.1] beta.\nType help to get the availabel commands.\n");

      while (command != "exit")
      {
        Write(">");
        command = ReadLine();

        switch (command.ToLower().Trim())
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
          case "groups":
            GetInfo(SystemInfo.GetUsersGroups());
            break;
          case "cpu":
            GetInfo(SystemInfo.GetCpu());
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
          case "bios":
            GetInfo(SystemInfo.GetBios());
            break;
          case "about":
            break;
          case "?":
          case "help":
            WriteLine(about);
            break;
          case "exit":
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
