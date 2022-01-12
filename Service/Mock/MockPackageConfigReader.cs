using System.Collections.Generic;
using ReportPublisher.Interface;
using ReportPublisher.Model;

namespace ReportPublisher.Service.Mock
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
                    SourceLocation = new List<FileLocation>()
                    {
                        new ()
                        {
                            LocationType = "folder",
                            Location= @"SourceReports\Marketing",
                            FileType = "pdf",
                            Filter = "*"
                        }
                    },
                    DestinationLocation = new List<FileLocation>()
                    {
                        new ()
                        {
                            LocationType = "folder",
                            Location= @"c:\temp\Marketing",
                            FileType = "pdf",
                            Filter = "*"
                        },
                        new ()
                        {
                            LocationType = "folder",
                            Location= @"c:\temp\Archive",
                            FileType = "zip",
                            Filter = "*"
                        }

                    }
                },
                new ()
                {
                    Id = 1,
                    Active = true,
                    Name = "Finance",
                    SourceLocation = new List<FileLocation>()
                    {
                        new ()
                        {
                            LocationType = "folder",
                            Location = @"SourceReports\Finance",
                            FileType = "xlsx",
                            Filter = "*"
                        }
                    },
                    DestinationLocation = new List<FileLocation>()
                    {
                        new ()
                        {
                            LocationType = "folder",
                            Location= @"c:\temp\FinanceReports",
                            FileType = "pdf",
                            Filter = "*"
                        },
                        new ()
                        {
                            LocationType = "email",
                            Location= @"c:\temp\Archive",
                            FileType = "zip",
                            Filter = "*"
                        }

                    }
                }
            };
        }
    }
}