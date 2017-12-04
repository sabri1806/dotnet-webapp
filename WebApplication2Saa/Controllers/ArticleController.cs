using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2Saa.Models;

namespace WebApplication2Saa.Controllers
{
    public class ArticleController : Controller
    {
        private DataContext context = new DataContext();

        /*public ArticleController(DataContext context)
        {
            this.context = context;
        }*/

          public ArticleController()
          {

          }
          

        [HttpGet]
        public ActionResult AddArticle()
        {
            ViewData["Message"] = "New Articles here.";

            return View();
        }

        [HttpGet]
        public ActionResult ViewArticles()
        {
            ViewData["Message"] = "List of articles.";

            return View(context.Articles);
        }

        [HttpPost]
        public ActionResult AddArticle(Article a)
        {
            ViewData["Message"] = "Aqui puede agregar nuevos articulos.";

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Verifique los campos.");
                return View();
            }

            var article = new Article()
            {
                Code = a.Code,
                Description = a.Description,
                Price = a.Price
            };

            context.Articles.Add(article);
            context.SaveChanges();

            ModelState.Clear();

            return View();
        }
    }
}
