using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet.TODO.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNet.TODO.Controllers
{
    public class TodoController : Controller
    {
        private TodoRepository _todoRepository;

        // DI (eng.: Dependency Injection) - hrv.: Ubrizgavanje ovisnosti 
        public TodoController(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_todoRepository.GetTodosList());
        }
    }
}

