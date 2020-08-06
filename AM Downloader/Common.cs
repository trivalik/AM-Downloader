﻿using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Data;

namespace AMDownloader
{
    static class Common
    {
        public const long KILOBYTE = 1024;
        public const long MEGABYTE = KILOBYTE * KILOBYTE;
        public const long GIGABYTE = MEGABYTE * KILOBYTE;
        public const long TERABYTE = GIGABYTE * KILOBYTE;

        public static class ApplicationPaths
        {
            public static string DownloadsHistory { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Assembly.GetExecutingAssembly().GetName().Name, "history"); } }
            public static string SavedLocationsHistory { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Assembly.GetExecutingAssembly().GetName().Name, "downloadpaths"); } }
            public static string DownloadsFolder { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"); } }
        }

        public static string GetValidFilename(string defaultFilename)
        {
            string path = Path.GetDirectoryName(defaultFilename);
            string filename = Path.GetFileName(defaultFilename);
            string result = path + Path.DirectorySeparatorChar + filename;
            int i = 0;

            while (File.Exists(result))
            {
                result = path + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(filename) + " (" + ++i + ")" + Path.GetExtension(filename);
            };

            return result;
        }
    }
}
