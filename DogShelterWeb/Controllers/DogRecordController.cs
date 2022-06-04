using DogShelterWeb.Data;
using DogShelterWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogShelterWeb.Controllers
{
    public class DogRecordController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DogRecordController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Category> objDogRecordList=_db.Categories;
            return View(objDogRecordList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if(category.Age<0)
            {
                ModelState.AddModelError("Age", "The age of a dog can't be less the zero years");
            }
            
            if(category.Name==category.Dog_Breed)

            {
                ModelState.AddModelError("CustomError", "The name of the dog can't be the same as their breed");
            }
            if(ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);

            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);


        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);

            ViewBag.Name = categoryFromDb.Name;
            ViewBag.Age = categoryFromDb.Age;
            ViewBag.Dog_Breed = categoryFromDb.Dog_Breed;
            ViewBag.DateArrived = categoryFromDb.DateArrived;

            return View();


        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public IActionResult PostDelete(int? id)
        {

            var rowToRemove=_db.Categories.Find(id);
            if(id==null || id==0)
            {
                return NotFound();
            }

            _db.Categories.Remove(rowToRemove);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}
