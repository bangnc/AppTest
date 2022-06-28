using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTest.Moqs;
using Moq;

namespace UnitTestProject1.Moqs
{
    public class MockTeamRepository : Mock<ITeamRepository>
    {
        public MockTeamRepository MockGetByID(Team result)
        {
            Setup(x => x.GetById(It.IsAny<int>())).Returns(result);
            return this;
        }

        public MockTeamRepository MockGetForLeague(List<Team> results)
        {
            Setup(x => x.GetForLaegue(It.IsAny<int>())).Returns(results);
            return this;
        }
    }
}
