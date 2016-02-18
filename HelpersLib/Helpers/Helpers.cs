using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HelpersLib
{
    public static class Helpers
    {
        public static void CreateDirectoryIfNotExist(string path, bool isFilePath = true)
        {
            if (!string.IsNullOrEmpty(path))
            {
                if (isFilePath)
                {
                    path = Path.GetDirectoryName(path);
                }

                if (!string.IsNullOrEmpty(path) && !Directory.Exists(path))
                {
                    try
                    {
                        Directory.CreateDirectory(path);
                    }
                    catch (Exception e)
                    {
                       DebugHelper.WriteException(e);
                    }
                }
            }
        }
    }
}
