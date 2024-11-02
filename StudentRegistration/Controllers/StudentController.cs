using Microsoft.AspNetCore.Mvc;

namespace StudentRegistration.Controllers
{
    public class StudentController : Controller
    {
        private AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Models.Student> students = _context.students;
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int? Id)
        {
            var student = _context.students.FirstOrDefault(x => x.Id == Id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Models.Student student)
        {
            _context.students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            var student = _context.students.FirstOrDefault(x => x.Id == Id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(Models.Student student)
        {
            _context.students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
