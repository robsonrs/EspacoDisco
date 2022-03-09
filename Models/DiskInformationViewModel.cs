using System.Collections.Generic;

namespace EspacoDisco.Models
{
    public class DiskInformationViewModel
    {
        public List<DiskInformation> listaInformações;
    }

    public class DiskInformation 
    {
        public string DiskName { get; set; }
        public string DiskFreeSpace { get; set; }
        public string DiskTotalSpace { get; set; }
    }

}
