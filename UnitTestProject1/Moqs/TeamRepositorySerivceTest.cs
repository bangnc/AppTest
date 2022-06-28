using AppTest.Moqs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Moqs
{
    [TestClass]
   public class TeamRepositorySerivceTest
    {
        [TestMethod]
        public void GetByID()
        {
            var data = new Team() { Name = "Ngô Công Bằng" };
            // Arrange
            var mockTeamRepository = new MockTeamRepository()
                                     .MockGetByID(data)
                                     .MockGetForLeague(new List<Team>());
            // Act
            TeamRepositorySerivce teamRepositorySerivce = new TeamRepositorySerivce(mockTeamRepository.Object);
            // Assert
            var result = teamRepositorySerivce.GetByID(10);
            Assert.AreEqual(data, result);
        }
    }
}
