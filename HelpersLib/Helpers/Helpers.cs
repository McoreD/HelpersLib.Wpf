using Gat.Controls;
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
            OpenDialogView openDialog = new OpenDialogView();
            OpenDialogViewModel vm = (OpenDialogViewModel)openDialog.DataContext;
            vm.IsDirectoryChooser = true;
            vm.Caption = title;
            vm.DateFormat = OpenDialogViewModelBase.ISO8601_DateFormat;
            vm.OpenText = "Select folder";
            vm.SelectFolder = true;
            // vm.Owner = this;
            vm.StartupLocation = WindowStartupLocation.CenterScreen;

            if (vm.Show() == true)
            {
                if (!string.IsNullOrEmpty(vm.SelectedFilePath))
                    return vm.SelectedFilePath;
                else if (vm.SelectedFolder != null && !string.IsNullOrEmpty(vm.SelectedFolder.Path))
                    return vm.SelectedFolder.Path;
            }

            return null;
        }

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