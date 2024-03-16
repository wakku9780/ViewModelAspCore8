using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelAspCore8.Models;

namespace ViewModelAspCore8.Controllers
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
			List<Student> students = new List<Student>
			{
				new Student{Id=1,Name="Ali",Gender="Male",Standard=12},
				new Student{Id=2,Name="Kumar",Gender="Male",Standard=10},
				new Student{Id=3,Name="Sanaya",Gender="Female",Standard=11},
				new Student{Id=4,Name="Tushar",Gender="Male",Standard=15},
			};

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher{Id=1,Name="Ashok",Qualification="MCS",Salary=45000 },
                new Teacher{Id=2,Name="VK",Qualification="MTECH",Salary=55000},
                new Teacher{Id=3,Name="RBR",Qualification="MBA",Salary=65000 },
                new Teacher{Id=4,Name="KK",Qualification="MA",Salary=30000 },
            };

			SchoolViewModel svm = new SchoolViewModel()
			{
				mySudents = students,
				myTechaers=teachers

			};
            return View(svm);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
