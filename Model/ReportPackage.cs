using System.Collections.Generic;

namespace ReportPublisher.Model
{
    public class ReportPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public ICollection<FileLocation> SourceLocation { get; set; }
        public ICollection<FileLocation> DestinationLocation { get; set; }
    }
}