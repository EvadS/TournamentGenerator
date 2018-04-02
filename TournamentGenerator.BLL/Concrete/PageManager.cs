using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentGenerator.Imports;
using ViewModels;
using BLL.Extensions;
using TournametGenerator.ViewModels.Result;
using TournametGenerator.ViewModels.Pages;
using TournametGenerator.ViewModels.Competitor;

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

        public Result<bool> ImportFromExcel(string filePath)
        {
            Result<bool> result = new Result<bool>();

            // get from excel
            List<SortableCompetitor> competitorsList = BindCompetotorsList(filePath);

            // arrange by lists 
            List<CompetitorsPage> competitorsPage = ArrangeInTournamentGrid(competitorsList);

            // save to data base 
            result = StoreToDataBase(competitorsPage);

            return result;
        }



       /// <summary>
       /// Создание списка учасников для групировки  из документа excel
       /// </summary>
       /// <param name="filePath"></param>
       /// <returns></returns>
        private List<SortableCompetitor> BindCompetotorsList(string filePath)
        {
            List<SortableCompetitor> result = new List<SortableCompetitor>();
            Result<DataSet> dataSetResult = ExcelHepler.ImportFromExcel(filePath);

            if (!dataSetResult.Success)
                return result;

            DataSet dataSet = dataSetResult.Data;
            // now we get data from first page 
            if (!ExcelHepler.ExistsMinimumColumnsCount(dataSet.Tables[0], Constants.COL_COUNT_IN_IMPOERTED_FILE).Success)            
                return result;            

            List<ImportedCompetitor> importedCompetitorsList = BindImpoertedCompetitorsListByDataSet(dataSet);
            List<SortableCompetitor> compertitorsList = BindSoratableCompetitorsList(importedCompetitorsList);

            return compertitorsList;
        }

        /// <summary>
        /// преобразовать список учасников из варианта который в эксель в варинат который можно сортировать 
        /// </summary>
        /// <param name="importedCompetitorsList"> все проля строки </param>
        /// <returns>нормальтные поля </returns>
        public List<SortableCompetitor> BindSoratableCompetitorsList(List<ImportedCompetitor> importedCompetitorsList)
        {
            //TODO : ДОБАВИТЬ ОБРАБОТКУ ОШИБОК !!!
            List<SortableCompetitor> compertitorsList = new List<SortableCompetitor>();
            foreach (var item in importedCompetitorsList)
            {
                DateTime birthDate = item.BirthDate.ToDateTime(format: "MM/dd/yyyy");
                // TODO : quick variant 
                int sex = 0;
                // TODO : must be change check 
                if (item.sex == "ж")                
                    sex = 1;
                
                // TODO: Временное решение 
                int weight = 0;
                int.TryParse(item.weight, out weight);

                // TODO: Временное решение 
                int q = 0;
                int.TryParse(item.Q, out q);

                SortableCompetitor competitor = new SortableCompetitor()
                {
                    Name = item.Name,
                    BirthDate = birthDate,
                    Club = item.cloub,
                    Coach = item.Coach,
                    Q = q,
                    Sex = sex,
                    Weight = weight
                };

                compertitorsList.Add(competitor);
            }

            return compertitorsList;
        }

        public List<ImportedCompetitor> BindImpoertedCompetitorsListByDataSet(DataSet dataSet)
        {
            List<ImportedCompetitor> competitorsList = new List<ImportedCompetitor>();

            foreach (var item in dataSet.Tables)
            {
                var columns = ((System.Data.DataTable)item).Columns;

                foreach (var row in ((System.Data.DataTable)item).Rows)
                {
                    var name = ((System.Data.DataRow)row).ItemArray[0].ToString();
                    var birthDate = ((System.Data.DataRow)row).ItemArray[1].ToString();
                    var weight = ((System.Data.DataRow)row).ItemArray[2].ToString();
                    var club = ((System.Data.DataRow)row).ItemArray[3].ToString();
                    var sex = ((System.Data.DataRow)row).ItemArray[4].ToString();
                    var power = ((System.Data.DataRow)row).ItemArray[5].ToString();
                    var coach = ((System.Data.DataRow)row).ItemArray[6].ToString();



                    ImportedCompetitor competitor = new ImportedCompetitor()
                    {
                        Name = name,
                        BirthDate = birthDate,
                        cloub = club,
                        Coach = coach,
                        Q = power,
                        sex = sex,
                        weight = weight
                    };

                    competitorsList.Add(competitor);
                }
            }

            return competitorsList;
        }


        private Result<bool> StoreToDataBase(List<CompetitorsPage> competitorsPage)
        {
            Result<bool> result = new Result<bool>();
            result.Success = false;
            result.Message = "Not implement";

            return result;
        }



        /// <summary>
        /// рапеределение по листам 
        /// </summary>
        /// <param name="competitorsList"></param>
        /// <returns></returns>
        public List<CompetitorsPage> ArrangeInTournamentGrid(List<SortableCompetitor> competitorsList)
        {
            var result = new List<CompetitorsPage>();

            return result;
        }

        Result IPageManager.ImportFromExcel(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
