using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace BLL.Concrete
{
    public class PlayerManager : IPlayerManager
    {
        public bool EditCompetitor(Competitor competitor)
        {
            throw new NotImplementedException();
        }

        public bool MoveCompetitorToPage(Competitor competitor, int currentPageNum, int nextPageNum)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCompetitor(Competitor competitor)
        {
            throw new NotImplementedException();
        }
    
    }
}
