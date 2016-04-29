using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sys
{
  using Helper.Extention;
  public static class Utility
  {
    public static void GetInfo<T>(List<T> infoList)
    {
      WriteLine("");
      foreach (var info in infoList)
      {
        GetInfo(info);
      }
      WriteLine("");
    }

    public static void GetInfo(object info)
    {
      foreach (var prop in info.GetType().GetProperties())
      {
        if (prop.GetValue(info).ToString().IsValidString())
        {
          WriteLine($" {FormateMemberName(prop.Name).PadRight(25)}: {prop.GetValue(info).ToString().PadRight(5)}");
        }
      }
      WriteLine("");

    }
    /// <summary>
    /// put a space before capital leter eg AccountName => Account Name
    /// </summary>
    /// <param name="memberName">Name of member</param>
    /// <returns></returns>
    public static string FormateMemberName(string memberName) => memberName.Select(c => char.IsUpper(c) ? $" {c}" : c.ToString()).Aggregate((sum, i) => $"{sum}{i}");

  }
}
