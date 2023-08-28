using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
	public class departController : Controller
	{
		Context c = new Context();
		public JsonResult Listele()
		{
			var degerler = c.departmanlars.ToList();
			return Json(degerler);
		}
		public IActionResult Anasayfa()
		{

			return View();
		}


		//public IActionResult DepartmanSil(int id)
		//{
		//	var dep = c.departmanlars.Find(id);
		//	c.departmanlars.Remove(dep);
		//	c.SaveChanges();
		//	return RedirectToAction("Anasayfa");
		//}


		/* public IActionResult YeniDepartman()
         {
             return View();
         }
         public IActionResult YeniDepartman2()
         {
             return View();
         }*/
		/*  [HttpPost]
          public IActionResult YeniDepartman(departmanlar d)
          {
              c.departmanlars.Add(d);
              c.SaveChanges();
              return RedirectToAction("Anasayfa");
          }*/
		/*public IActionResult DepartmanGetir(int id)
          {
              var depart = c.departmanlars.Find(id);
              return View(depart);
          }
          public IActionResult DepartmanGuncelle(departmanlar d)
          {
              var dep = c.departmanlars.Find(d.ID);
              dep.DepartmanAd = d.DepartmanAd;
              c.SaveChanges();
              return RedirectToAction("Anasayfa");
          }*/
		[HttpPost]
		public bool Delete(int id)
		{
			var dep = c.departmanlars.Find(id);
			c.departmanlars.Remove(dep);
			return c.SaveChanges() > 0; //?... MESELA BURDA BOOL DEĞER DÖNDÜRDÜK AMA SUCCESS FONKSİYONUNDA KULLANMADIK ?...
		}
	
		[HttpPost]
		public IActionResult Ekle(departmanlar d)
		{
			if (!ModelState.IsValid)
			{
				var errors = ModelState.Where(state => state.Value.Errors.Any())
									   .ToDictionary(
											kvp => kvp.Key,
											kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
									   );

				return BadRequest(errors);
			}

			c.departmanlars.Add(d);
			c.SaveChanges();
			return Json(d);
		}


		public IActionResult DepartmanGetir(int id)
		{
			var depart = c.departmanlars.Find(id);
			return View(depart);
		}
		public IActionResult Guncelle(departmanlar d)
		{
			var dep = c.departmanlars.Find(d.ID);
			dep.DepartmanAd = d.DepartmanAd;
			c.SaveChanges();
			return RedirectToAction("Anasayfa");
		}
	}
}

