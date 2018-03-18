using System.Data;
using TournamentGenerator.Imports;

namespace BLL
{
    public static class CompetitorsHelper3
    {
        public static bool ImportFromExcel(string filePath)
        {

            DataSet dataSet = ExcelHepler.ImportFromExcel(filePath);

            int a = 10;
                return false;
        }
    }
}
