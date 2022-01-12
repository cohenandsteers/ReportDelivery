using System.IO;
using System.Threading.Tasks;

namespace ReportPublisher.Interface
{
    public interface IFileSender
    {
        Task SendFile(string destinationFolder, string fileName, Stream file);
    }
}