using ReportPublisher.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReportPublisher.Model;

namespace ReportPublisher.Service
{
    public class ReportDeliveryService : IReportDeliveryService
    {
        public ReportDeliveryService(IFileReader fileReader, IFileSender fileSender)
        {
            
        }

        public Task DeliverReports(IEnumerable<ReportPackage> packages, IEnumerable<Client> clients)
        {
            throw new NotImplementedException();
        }
    }
}