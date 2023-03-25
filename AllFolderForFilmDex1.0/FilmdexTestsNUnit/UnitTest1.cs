using Data;
using Data.Model;
using Filmdex.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace FilmdexTestsNUnit
{
    public class FilmsControllerTests
    {
        [Test]
        public void Index_Returns_ViewResult()
        {

            var controller = new FilmsController();
            var result = controller.Index();
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void Index_Returns_Model_With_Films()
        {

            var context = new FilmdexContext();
            var controller = new FilmsController(context);
            var result = controller.Index() as ViewResult;
            var model = result.ViewData.Model as List<Film>;
            Assert.IsNotNull(model);
            Assert.IsTrue(model.Any());
        }
        [Test]
        public void Details_With_Null_Id_Returns_BadRequest()
        {

            var controller = new FilmsController();
            var result = controller.Details(null);
            Assert.IsInstanceOf<HttpStatusCodeResult>(result);
            var httpResult = result as HttpStatusCodeResult;
            Assert.AreEqual(HttpStatusCode.BadRequest, httpResult.StatusCode);
        }

        [Test]
        public void Details_With_Valid_Id_Returns_ViewResult_With_Film()
        {

            var context = new FilmdexContext();
            var controller = new FilmsController(context);
            var filmId = 1;
            var result = controller.Details(filmId) as ViewResult;
            var model = result.ViewData.Model as Film;
            Assert.IsNotNull(model);
            Assert.AreEqual(filmId, model.Id);
        }
        [Test]
        public void Create_Returns_ViewResult()
        {

            var controller = new FilmsController();
            var result = controller.Create();
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void Create_ViewResult_Has_No_Model()
        {

            var controller = new FilmsController();
            var result = controller.Create() as ViewResult;
            Assert.IsNull(result.ViewData.Model);
        }
        [Test]
        public void Create_With_Valid_Model_Saves_Film_And_Redirects_To_Index()
        {

            var context = new FilmdexContext();
            var controller = new FilmsController(context);
            var film = new Film
            {
                Title = "Test Film",
                Genre = "Action",
                WatchedOn = DateTime.Today
            };
            var result = controller.Create(film) as System.Web.Mvc.RedirectToRouteResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.IsTrue(context.Film.Any(f => f.Title == "Test Film"));
        }

        [Test]
        public void Create_With_Invalid_Model_Returns_ViewResult_With_Model()
        {

            var controller = new FilmsController();
            var film = new Film
            {
                Title = "",
                Genre = "Action",
                WatchedOn = DateTime.Today
            };
            controller.ModelState.AddModelError("Title", "Title is required");
            var result = controller.Create(film) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(film, result.ViewData.Model);
        }
        [Test]
        public void Edit_With_Valid_Id_Returns_ViewResult_With_Film()
        {

            var context = new FilmdexContext();
            var controller = new FilmsController(context);
            var film = context.Film.First();
            var result = controller.Edit(film.Id) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(film, result.ViewData.Model);
        }

        [Test]
        public void Edit_With_Invalid_Film_Returns_ViewResult()
        {

            var controller = new FilmsController();
            var film = new Film { Title = "" };
            controller.ModelState.AddModelError("Title", "Title is required.");
            var result = controller.Edit(film) as ViewResult;
            Assert.IsNotNull(result);
            Assert.IsFalse(controller.ModelState.IsValid);
            Assert.AreEqual(film, result.ViewData.Model);
        }
        public void Delete_With_Valid_Id_Returns_ViewResult()
        {

            var context = new FilmdexContext();
            var controller = new FilmsController(context);
            var id = context.Film.First().Id;
            var result = controller.Delete(id) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(context.Film.Find(id), result.ViewData.Model);
        }

        [Test]
        public void Delete_With_Invalid_Id_Returns_HttpNotFoundResult()
        {

            var controller = new FilmsController();
            var id = -1;
            var result = controller.Delete(id) as HttpNotFoundResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
        }
        [Test]
        public void DeleteConfirmed_With_Valid_Id_Removes_Film_And_Redirects_To_Index_Action()
        {

            var context = new FilmdexContext();
            var controller = new FilmsController(context);
            var id = context.Film.First().Id;
            var result = controller.DeleteConfirmed(id) as System.Web.Mvc.RedirectToRouteResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);

            var deletedFilm = context.Film.Find(id);
            Assert.IsNull(deletedFilm);
        }

        [Test]
        public void DeleteConfirmed_With_Invalid_Id_Returns_HttpNotFoundResult()
        {

            var controller = new FilmsController();
            var id = -1;
            var result = controller.DeleteConfirmed(id) as HttpNotFoundResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
        }

    }

}