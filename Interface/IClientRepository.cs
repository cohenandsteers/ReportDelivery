using ReportPublisher.Model;
using System.Collections.Generic;

namespace ReportPublisher.Interface
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();
    }
}