using infrastructure_project.Repositories;
using Moq;
using Shouldly;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private Mock<GameRepository> _mckGameRepository;
        public UnitTest1()
        {
            _mckGameRepository = new Mock<GameRepository>();
        }
        [Fact]
        public void Test1()
        {
            var mockObject = _mckGameRepository.Object;

            mockObject.ShouldNotBeNull();
        }
    }
}
