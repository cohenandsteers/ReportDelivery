using ReportPublisher.Interface;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ReportPublisher.Service.Mock
{
    public class MockFileSender : IFileSender
    {
        public async Task SendFile(string destinationFolder, string fileName, Stream file)
        {
            Console.WriteLine(
                $"Received file {fileName} for {destinationFolder}. FileSize: {file.Length}");
        }
    }
}