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
    }
}
