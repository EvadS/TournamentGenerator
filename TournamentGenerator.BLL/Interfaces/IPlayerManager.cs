using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace BLL.Abstract
{
    public interface IPlayerManager 
    {
        /// <summary>
        /// переместить учасника на страницу 
        /// </summary>
        /// <param name="competitor">перемещаемый учасник </param>
        /// <param name="currentPageNum">текущая страница</param>
        /// <param name="nextPageNum">номер страницу на которую перемещаем</param>
        /// <returns></returns>
        bool MoveCompetitorToPage(Competitor competitor, int currentPageNum, int nextPageNum);

        /// <summary>
        /// удалить учасника
        /// </summary>
        /// <param name="competitor">Учасник</param>
        /// <returns></returns>
        bool RemoveCompetitor(Competitor competitor);

        /// <summary>
        /// редактирование учасника
        /// </summary>
        /// <param name="competitor">Учасник</param>

        /// <returns></returns>
        bool EditCompetitor(Competitor competitor);
    }
}
