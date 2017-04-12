using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFileManager
{
    public static class FileUtils
    {
        /// <summary>
        /// GetDirsInDirectory adds all directories from directory dirName to list
        /// </summary>
        /// <param name="dirName">Directory to find directories in</param>
        /// <param name="list">List of founded directories</param>
        public static void GetDirsIndDirectory(string dirName, ConcurrentBag<string> list)
        {
                foreach (var path in Directory.GetDirectories(dirName))
                    list.Add(Path.GetFileName(path));
        }

        /// <summary>
        /// GetFilesInDirectory finds all files in directory dirName and adds them to list
        /// </summary>
        /// <param name="dirName">Directory to find files in</param>
        /// <returns></returns>
        public static ConcurrentBag<string> GetFilesInDirectory(string dirName)
        {
            var returnList = new ConcurrentBag<string>();
            foreach (var path in Directory.GetFiles(dirName))
            {
                returnList.Add(Path.GetFileName(path));
            }
            return returnList;
        }

        /// <summary>
        /// Retutns list of drive disks
        /// </summary>
        /// <returns></returns>
        public static List<string> GetDriveName() => DriveInfo.GetDrives().Select(d => d.Name).ToList();

        /// <summary>
        /// Returns data of file in with way = path
        /// </summary>
        /// <param name="path">Way to file</param>
        /// <returns></returns>
        public static string GetFileString(string path)
        {
            try
            {  
                var data = new byte[100];
                var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, data.Length, true);
                fs.ReadAsync(data, 0, data.Length);
                fs.Close();
                return (Encoding.ASCII.GetString(data) + " ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        public static void Rename(string srcFile, string destFile)
        { 
            var fi = new FileInfo(srcFile);
            var path = fi.DirectoryName + '\\';
            Directory.Move(srcFile, path + destFile);
        }

        public static string MakeCopyFileName(string fileName)
        {
            var fi = new FileInfo(fileName);
            return fi.DirectoryName + '\\' + Path.GetFileNameWithoutExtension(fi.Name) + "Copy" + fi.Extension;
        }

        public static string MakeCopyDirectoryName(string directoryName) => (directoryName + "Copy");

        public static bool IsFile(string path) => File.Exists(path);

        public static string CountFilesInFolder(string path)
        {
            var di = new DirectoryInfo(path);
            return di.GetDirectories().Length + " folders, " + di.GetFiles().Length + " files";
        }

        public  static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        public static void RemoveHidden(DirectoryInfo di)
        {
            var attributes = RemoveAttribute(di.Attributes, FileAttributes.Hidden);
            File.SetAttributes(di.FullName, attributes);
        }

        public static void RemoveReadOnly(DirectoryInfo di)
        {
            var attributes = RemoveAttribute(di.Attributes, FileAttributes.ReadOnly);
            File.SetAttributes(di.FullName, attributes);
        }
    }
}
