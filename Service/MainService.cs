using System.Threading.Tasks;
using ReportPublisher.Interface;

namespace ReportPublisher.Service
{
    public class MainService
    {
        private readonly IReportDeliveryService _deliveryService;

        public MainService(IReportDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public async Task Execute()
        {
            //_deliveryService.DeliverReports(...,...)
        }
        
    }
}