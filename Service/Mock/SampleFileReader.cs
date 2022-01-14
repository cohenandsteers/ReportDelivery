using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportPublisher.Interface;

namespace ReportPublisher.Service.Mock
{
    public class SampleFileReader : IFileReader
    {
        public async Task<IEnumerable<FileInfo>> GetFiles(string fileLocation, string filter, string fileType) =>
            throw new NotImplementedException();
    }
}
