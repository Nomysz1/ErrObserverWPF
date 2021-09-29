﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.IO;
using System.Windows;

namespace ErrObserver
{
    class FileWatcherInsideFolder : Interfaces.IFolder
    {
        public string dirPath { get; private set; }
        public string Extension { get; private set; }

        public Email email;
        public FileWatcherInsideFolder(string filePath, string extension)
        {
            this.dirPath = filePath;
            this.Extension = extension;

        }
        private string returnPattern()
        {
            return String.Concat("*." + this.Extension);
        }

        public void createInstanceOfEmailAccount(string emailAddr, SecureString secureString)
        {
            email = new Email(ref emailAddr, ref secureString);
        }

        public void WatchFilesInsideFolder()
        {
            var isDirectoryStillAvaliable = Directory.Exists(this.dirPath);
            if (isDirectoryStillAvaliable)
            {
                var pattern = returnPattern();
                var dirWatcher = new FileSystemWatcher(this.dirPath, pattern);
                dirWatcher.Created += FileWatcher_Created;
                dirWatcher.EnableRaisingEvents = true;
            }
            else
                MessageBox.Show("Folder nie istnieje {0}", this.dirPath);
        }

        private void FileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            string FullPath = e.FullPath;
            email.send(this.dirPath, FullPath);
        }
    }
}
