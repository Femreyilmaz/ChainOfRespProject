using ChainOfRespProject.ChainOfResponsibility;
using ChainOfRespProject.DAL;
using ChainOfRespProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfRespProject.Controllers
{

    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer(_context);
            Employee managerAssistant = new ManagerAsistant(_context);
            Employee manager = new Manager(_context);
            Employee areaDirector = new AreaDirector(_context);

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
