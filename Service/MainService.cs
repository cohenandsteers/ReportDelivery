using System;
using System.Threading.Tasks;
using ReportPublisher.Interface;

namespace ReportPublisher.Service
{
    public class MainService
    {
        private readonly IReportDeliveryService _deliveryService;
        private readonly IPackageConfigReader _configReader;
        private readonly IClientRepository _clientRepository;

        public MainService(IReportDeliveryService deliveryService,
            IPackageConfigReader configReader,
            IClientRepository clientRepository)
        {
            _deliveryService = deliveryService;
            _configReader = configReader;
            _clientRepository = clientRepository;
        }

        public async Task Execute()
        {
            var pg = _configReader.LoadReportPackageConfiguration();
            var cl = _clientRepository.GetAll();
            await _deliveryService.DeliverReports(pg, cl);
            Console.WriteLine("Hello app");
        }
        
    }
}