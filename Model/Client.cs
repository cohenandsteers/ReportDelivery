using System.Collections.Generic;

namespace ReportPublisher.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}