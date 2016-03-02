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
        public static string BrowseFolder(string title = "Browse folder")
        {
            FolderDialog dlg = new FolderDialog();

            if (dlg.ShowDialog())
            {
                return dlg.Path;
            }

            return null;
        }

        public static void CreateDirectoryFromDirectoryPath(string path)
        {
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

        public static void CreateDirectoryFromFilePath(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                CreateDirectoryFromDirectoryPath(Path.GetDirectoryName(path));
            }
        }
    }
}