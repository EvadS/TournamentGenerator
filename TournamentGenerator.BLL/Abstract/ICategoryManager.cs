using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace BLL.Abstract
{
    /// <summary>
    /// TODO : impletent DI
    /// </summary>
    public interface  ICategoryManager
    {
        List<Category> GetCategories();
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool RemoveCategory(Category category);
    }
}
