using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class FolderList
    {
        public bool dataEncryped { get; set; }
        public bool encryptedShare { get; set; }
        public string fileSystem { get; set; }
        public string fileSystemType { get; set; }
        public string folderPath { get; set; }
        public string fullPath { get; set; }
        public bool isValidSource { get; set; }
        public bool missing { get; set; }
    }
}
