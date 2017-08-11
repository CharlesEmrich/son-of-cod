using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class ContactControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ContactController controller = new ContactController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Contacts_Test()
        {
            //Arrange
            ContactController controller = new ContactController();

            //Act
            var result = controller.Contacts();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
