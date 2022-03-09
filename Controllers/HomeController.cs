using EspacoDisco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace EspacoDisco.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<DiskInformation> listaInformações = new List<DiskInformation>();;
            foreach (DriveInfo drive in drives)
            {
                listaInformações.Add(new DiskInformation() { 
                    DiskFreeSpace = String.Format("{0:0.##}GB", drive.TotalFreeSpace / 1024d / 1024d / 1024d),
                    DiskName = drive.Name,
                    DiskTotalSpace = String.Format("{0:0.##}GB", drive.TotalSize / 1024d / 1024d / 1024d)
                });
            }

            return View(new DiskInformationViewModel { listaInformações = listaInformações});
        }
    }
}
