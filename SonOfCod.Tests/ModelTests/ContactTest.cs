using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ModelTests
{
    public class ContactTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var contact = new Contact();
            contact.Name = "Emma Goldman";

            //Act
            var result = contact.Name;

            //Assert
            Assert.Equal("Emma Goldman", result);
        }

        [Fact]
        public void GetEmailTest()
        {
            //Arrange
            var contact = new Contact();
            contact.Email = "emma@goldman-sachs.com";

            //Act
            var result = contact.Email;

            //Assert
            Assert.Equal("emma@goldman-sachs.com", result);
        }
    }
}

