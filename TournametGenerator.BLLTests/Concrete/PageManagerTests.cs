using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournametGenerator.ViewModels.Competitor;

namespace BLL.Concrete.Tests
{
    [TestClass()]
    public class PageManagerTests
    {

        List<ImportedCompetitor> importedList = new List<ImportedCompetitor>()
        {
            //Стецюк Егор 10/2/2010   19  Академії Кіокушин   м   0   Галоян А.Г.
            new ImportedCompetitor (){Name = "", BirthDate = "" , weight=""}

        };


        [TestMethod()]
        public void ArrangeInTournamentGridTest()
        {
            Assert.Fail();
        }
    }
}