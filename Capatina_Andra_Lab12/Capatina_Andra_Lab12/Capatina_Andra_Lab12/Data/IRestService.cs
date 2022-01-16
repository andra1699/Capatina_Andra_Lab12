using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Capatina_Andra_Lab12.Models;
using Capatina_Andra_Lab12.Data;


namespace Capatina_Andra_Lab12
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
