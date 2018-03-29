using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentGenerator.Imports;
using ViewModels;

namespace BLL.Concrete
{
    public class PageManager : IPageManager
    {
        public void ApplyBigqOnPage(int pageNum)
        {
            throw new NotImplementedException();
        }

        public void ArrangeByTreeStructure()
        {
            throw new NotImplementedException();
        }

        public List<Competitor> GetcompetitorByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Competitor> GetcompetitorByPageNumber(int pageNum)
        {
            throw new NotImplementedException();
        }

        public void ImportFromExcel(string filePath)
        {
            DataSet dataSet = ExcelHepler.ImportFromExcel(filePath);
        }

        public bool ArrangeInTournamentGrid()
        {
            return false;
        }
    }
}
