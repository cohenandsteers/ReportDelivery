using ReportPublisher.Interface;
using ReportPublisher.Model;
using System.Collections.Generic;

namespace ReportPublisher.Service.Mock
{
    public class MockClientRepo : IClientRepository
    {
        public IEnumerable<Client> GetAll()
        {
            return new List<Client>()
            {
                new()
                {
                    Id = 1,
                    Code = "CL1",
                    Name = "ABC", Accounts = new List<Account>()
                    {
                        new()
                        {
                            Id = 1,
                            Code = "ACC1", Name = "account 1"
                        },
                        new()
                        {
                            Id = 1,
                            Code = "ACC4", Name = "account 4"
                        }
                    }
                },
                new()
                {
                    Id = 2,
                    Code = "CL2",
                    Name = "XYZ", Accounts = new List<Account>()
                    {
                        new()
                        {
                            Id = 1,
                            Code = "ACC2", Name = "account 2"
                        },
                        new()
                        {
                            Id = 1,
                            Code = "ACC3", Name = "account 3"
                        }
                    }
                },
                new()
                {
                    Id = 3,
                    Code = "CL4",
                    Name = "XYZ", Accounts = new List<Account>()
                    {
                        new()
                        {
                            Id = 1,
                            Code = "ACC5", Name = "account 5"
                        }
                    }
                }
            };
        }
    }
}