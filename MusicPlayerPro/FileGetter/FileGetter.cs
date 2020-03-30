using System;
using System.IO;


namespace MusicPlayerPro
{
    public class FileGetter
    {
        private const string _filesDirectory = "D:/musicD";
        public string _fileName ; 
        private Uri _filePathUri;

        public Uri GetUriPathToFile(string fileName)
        {
           return _filePathUri=new Uri(Path.Combine(_filesDirectory,fileName));
        }
    }
}
