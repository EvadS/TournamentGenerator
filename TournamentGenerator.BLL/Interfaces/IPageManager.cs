﻿using System;
using System.Collections.Generic;
using TournametGenerator.ViewModels.Result;

namespace BLL.Interfaces
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

        /// <summary>
        /// загрузить с excel
        /// </summary>
        /// <param name="filePath"></param>
        Result ImportFromExcel(string filePath);
 
    }
}
