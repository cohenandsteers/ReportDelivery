using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ReportPublisher.Interface
{
    public interface IFileReader
    {
        Task<IEnumerable<FileInfo>> GetFiles(string fileLocation, string filter, string fileType);
    }
}