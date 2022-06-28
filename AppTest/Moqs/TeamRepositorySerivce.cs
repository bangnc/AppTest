using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest.Moqs
{
   public class TeamRepositorySerivce
    {
        private  ITeamRepository _teamRepository;
        public TeamRepositorySerivce(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;

        }
        public Team GetByID(int Id)
        {
           return _teamRepository.GetById(Id);
        }
    }
}
