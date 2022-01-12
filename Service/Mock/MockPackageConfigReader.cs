using ReportPublisher.Interface;
using ReportPublisher.Model;
using System.Collections.Generic;

namespace ReportPublisher.Service
{
    public class MockPackageConfigReader : IPackageConfigReader
    {
        public IEnumerable<ReportPackage> LoadReportPackageConfiguration()
        {
            return new List<ReportPackage>()
            {
                new ()
                {
                    Id = 1,
                    Active = true,
                    Name = "Marketing",
                    Files = new List<FilesLocation>()
                    {
                        new ()
                        {
                            DestinationLocation = @"c:\temp\ClientReports",
                            SourceLocation = @"SourceReports\Marketing",
                            FileType = "pdf",
                            Filter = "*"
                        }
                    }
                },
                new ()
                {
                    Id = 1,
                    Active = true,
                    Name = "Finance",
                    Files = new List<FilesLocation>()
                    {
                        new ()
                        {
                            DestinationLocation = @"c:\temp\FinanceReports",
                            SourceLocation = @"SourceReports\Finance",
                            FileType = "xlsx",
                            Filter = "*"
                        }
                    }
                }
            };
        }
    }
}