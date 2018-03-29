using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IPageManager
    {
        /// <summary>
        /// получить учасником по номеру странице 
        /// </summary>
        /// <param name="pageNum"></param>
        /// <returns></returns>
        List<ViewModels.Competitor> GetcompetitorByPageNumber(int pageNum);

        /// <summary>
        /// получить список учасников по коду категории
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        List<ViewModels.Competitor> GetcompetitorByCategoryId(int categoryId);
        /// <summary>
        /// принять большую раззность в q
        /// </summary>
        /// <param name="pageNum"></param>
        void  ApplyBigqOnPage(int pageNum);

        /// <summary>
        /// автоматическое расположение 
        /// </summary>
        void ArrangeByTreeStructure();
    }
}
