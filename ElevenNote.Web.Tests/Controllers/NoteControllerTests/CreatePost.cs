using ElevenNote.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ElevenNote.Web.Tests.Controllers.NoteControllerTests
{
    [TestClass]
    public class CreatePost : NoteControllerTestsBase
    {
        private ActionResult Act()
        {
            return Controller.Create(new NoteCreate());
        }

        [TestMethod]
        public void ShouldReturnRedirectToRouteResult()
        {
            var result = Act();

            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        }

        [TestMethod]
        public void ShouldCallCreateOnce()
        {
            var result = Controller.Create(new NoteCreate());

            Assert.AreEqual(1, Service.CreateNoteCallCount);
        }
    }
}
