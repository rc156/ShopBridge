using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Web.Models.BLL
{
    public class Item
    {
        private void ItemIsValid(BEL.Item item)
        {
        }
        public static async Task<List<BEL.Item>> GetItems()
            => await DAL.Item.GetItems();
        public static async Task<int> SaveItems(Models.BEL.Item item)
           => await DAL.Item.SaveItems(item);
        public static async Task<int> DelteItem(int ItemId)
            => await DAL.Item.DelteItem(ItemId);
    }




}