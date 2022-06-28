using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest.Moqs
{
    public class TeamRepository : ITeamRepository
    {
        public Team GetById(int ID)
        {
            return new Team() { Name = "Ngô Công Bằng" };
        }

        public List<Team> GetForLaegue(int ID)
        {
            return new List<Team>();
        }
    }
}
