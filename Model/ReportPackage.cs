using System.Collections.Generic;

namespace ReportPublisher.Model
{
    public class ReportPackage
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public int Id { get; set; }
        public ICollection<FilesLocation> Files { get; set; }
    }
}