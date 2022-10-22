using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBok.Services
{
    internal interface IFileManager
    {
        public void Save(string filePath, string content);
        public void Read(string filePath);
    }
    internal class FileManager : IFileManager
    {
        public void Read(string filePath)
        {
            throw new NotImplementedException();
        }

        public void Save(string filePath, string content)
        {
            throw new NotImplementedException();
        }
    }
}
