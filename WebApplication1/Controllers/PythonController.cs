using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using Cluster.Models;
using Cluster.Repositories;
using IronPython.Hosting;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    public class PythonController : ApiController
    {

		[Route("api/Execute_Python")]
		[HttpGet]
		
		public void python()
		{
			Console.WriteLine("This is the result from python query");
			var py = Python.CreateEngine();
            try
            {
                //py.ExecuteFile("file:D:\\Work\\PGN\\NIMO\\Python\\Run_Python_Script.bat");
                Process.Start("file:D:\\Work\\PGN\\NIMO\\Python\\Run_Python_Script.bat");
                //Process.Start("file:D:\\Work\\PGN\\NIMO\\Python\\Run_Clustering.bat");
            }
            catch(Exception ex)
            {
				Console.WriteLine(ex.Message.ToString());
            }

		}


	}
}
