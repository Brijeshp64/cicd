using Microsoft.AspNetCore.Mvc;
using Moq;
using UnitTesting.Controllers;
using UnitTesting.Models;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly Mock<UserController> _controller;

        public UnitTest1()
        {
            _controller = new Mock<UserController>();
        }
        [Fact]
        public void WeatherForcast()
        {

            var controller = new UserController();

            
           var result = controller.GetUsers();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result); // Check it's 200 OK
            var users = Assert.IsAssignableFrom<IEnumerable<User>>(okResult.Value); // Check type

            Assert.Equal(3, users.Count());

            var userList = users.ToList();
            Assert.Equal("Alice", userList[0].Name);
            Assert.Equal("Bob", userList[1].Name);
            Assert.Equal("Charlie", userList[2].Name);
        }
    }
}