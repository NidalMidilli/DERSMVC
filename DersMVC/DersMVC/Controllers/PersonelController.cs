using DataAccess.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Security.Cryptography.X509Certificates;

namespace DersMVC.Controllers
{
    public class PersonelController : Controller
    {

        private readonly IRepository<Personel> repository;

        public PersonelController(IRepository<Personel> repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = repository.Liste();
            return View(result);
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(Personel pers)
        {
            var result = repository.Ekle(pers);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Personel pers)
        {
            var result = repository.Sil(pers);
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Personel pers)
        {
            var result = repository.Guncelle(pers);
            return View(result);
        }
        
    }
}
