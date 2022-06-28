using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest.Moqs
{
    public interface ITeamRepository
    {
        Team GetById(int ID );

        List<Team> GetForLaegue(int ID);
    }
}
