using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DicomController : Controller
    {
        //
        // GET: /Dicom/
        public ViewResult DisplayDicom()
        {
            Dicom dicomObj = new Dicom
            {
                imgURL = "App_Data/sample.png"
            };

            return View("DisplayDicom", dicomObj);
        }
	}
}