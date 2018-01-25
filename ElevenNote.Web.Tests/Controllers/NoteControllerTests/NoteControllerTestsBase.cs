using ElevenNote.Services;
using ElevenNote.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ElevenNote.Web.Tests.Controllers.NoteControllerTests
{
    // Arrange
    // Act
    // Assert

    [TestClass]
    public abstract class NoteControllerTestsBase
    {
        protected NoteController Controller;
        //protected only provides access to the class itself and those that inherit it

        protected FakeNoteService Service;

        [TestInitialize]
        public virtual void Arrange() //virtual means it can be overridden
        {
            Service = new FakeNoteService();

            Controller = new NoteController(
                new Lazy<INoteService>(() => Service));
        }
    }
}
