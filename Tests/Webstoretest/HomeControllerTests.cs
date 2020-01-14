using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Controllers;
using WebStore.Interfaces;
using Xunit;

namespace Webstoretest

{
    public class HomeControllerTests
    {
        private HomeController _controller;
        public HomeControllerTests()
        {
            var mockService = new Mock<IValueService>();
            mockService.Setup(c => c.GetAsync())
                .ReturnsAsync(new List<string> { "1", "2" });
            _controller = new HomeController(mockService.Object, null);
        }



        [Fact]
        public async Task Index_Method_Returns_View_With_Values()
        {

            //Arrange

            //Act
            var result = await _controller.Index();
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<string>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());


        }

        [Fact]
        public void ContactUs_Returns_View()
        {

            //Arrange

            //Act
            var result = _controller.ContactUs();
            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ErrorStatus_404_Redirects_to_NotFound()
        {
            //Arrange

            //Act
            var result = _controller.ErrorStatus("404");

            //Assert

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Notfound", redirectToActionResult.ActionName);

        }

        [Fact]
        public void ErrorStatus_Antother_Returns_Content_Result()
        {
            //Act
            var result = _controller.ErrorStatus("500");


            //Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Статусный код ошибки:500", contentResult.Content);
        }

        [Fact]
        public void Checkout_Returns_View()
        {
            var result = _controller.Checkout();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void BlogSingle_Returns_View()
        {
            var result = _controller.BlogSingle();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Blog_Returns_View()
        {
            var result = _controller.Blog();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Error_Returns_View()
        {
            var result = _controller.Error();
            Assert.IsType<ViewResult>(result);
        }


    }
    }


