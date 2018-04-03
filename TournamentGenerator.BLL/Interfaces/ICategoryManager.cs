using System;
using System.Collections.Generic;
using ViewModels;

namespace BLL.Interfaces
{
    /// <summary>
    /// TODO : impletent DI
    /// </summary>
    public interface  ICategoryManager: IDisposable
    {
        List<Category> GetCategories();
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool RemoveCategory(Category category);
    }
}
