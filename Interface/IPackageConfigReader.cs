using ReportPublisher.Model;
using System.Collections.Generic;

namespace ReportPublisher.Interface
{
    public interface IPackageConfigReader
    {
        IEnumerable<ReportPackage> LoadReportPackageConfiguration();
    }
}