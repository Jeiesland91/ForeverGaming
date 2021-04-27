using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ForeverGaming.Controllers;
using ForeverGaming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;


namespace ForeverGamingTests
{
    [TestFixture]
    public class GameControllerTests
    {
        [TestCase]
        public void IndexActionMethod_ReturnsARedirectToActionResult()
        {
            //arrange

            // act
            var result = _controller.Index();

            // assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            
        }

        [TestCase]
        public void DetailsActionMethod_ReturnsAViewResult()
        {
            // arrange
            var query = new Mock<QueryOptions<Game>>();

            // act
            var result = _controller.Details(10000);

            // assert
            Assert.IsInstanceOf<ViewResult>(result);
            
        }

        [TestCase]
        public void ListActionMethod_ReturnsAViewResult()
        {
            // arrange
            MockHttpSession httpcontext = new MockHttpSession();
            var gameGridDTO = new Mock<GameGridDTO>();

            // act
            var result = _controller.List(gameGridDTO.Object);

            // assert
            Assert.IsInstanceOf<ViewResult>(result);
        }

        private GameController _controller = null;


        [SetUp]
        public void TestSetUp()
        {
            var options = new DbContextOptionsBuilder<GameContext>()
                .UseInMemoryDatabase(databaseName: "ForeverGaming")
                .Options;

            var rnd = new Random();
            var id = rnd.Next(10000, 11000);
            var context = new GameContext(options);
            context.Games.Add(new Game()
            {
                GameId = id,
                Name = "The Witcher",
                GenreId = "RPG",
                TypeId = "Role-Play ",
                FormatId = "PC",
                GameImage = "TheWitcher.png",
            });
            
            context.SaveChanges();

            _controller = new GameController(context);
        }

        [TearDown]
        public void TestTearDown()
        {
            _controller = null;
        }

        public class MockHttpSession : ISession
        {
            readonly Dictionary<string, object> _sessionStorage = new Dictionary<string, object>();
            string ISession.Id => throw new NotImplementedException();
            bool ISession.IsAvailable => throw new NotImplementedException();
            IEnumerable<string> ISession.Keys => _sessionStorage.Keys;
            void ISession.Clear()
            {
                _sessionStorage.Clear();
            }

            public Task CommitAsync(CancellationToken cancellationToken = new CancellationToken())
            {
                throw new NotImplementedException();
            }

            Task ISession.LoadAsync(CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
            void ISession.Remove(string key)
            {
                _sessionStorage.Remove(key);
            }
            void ISession.Set(string key, byte[] value)
            {
                _sessionStorage[key] = Encoding.UTF8.GetString(value);
            }
            bool ISession.TryGetValue(string key, out byte[] value)
            {
                if (_sessionStorage[key] != null)
                {
                    value = Encoding.ASCII.GetBytes(_sessionStorage[key].ToString());
                    return true;
                }
                value = null;
                return false;
            }
        }
    }
}
