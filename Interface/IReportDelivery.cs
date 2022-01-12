using System.Collections.Generic;
using System.Threading.Tasks;
using ReportPublisher.Model;

namespace ReportPublisher.Interface
{
    public interface IReportDeliveryService
    {
        Task DeliverReports(IEnumerable<ReportPackage> packages, IEnumerable<Client> clients);
    }
}