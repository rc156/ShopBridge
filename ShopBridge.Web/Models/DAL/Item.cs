using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ShopBridge.Web.Models.DAL
{
    public class Item
    {
        public static async Task<List<BEL.Item>> GetItems()
        {
            List<BEL.Item> items = new List<BEL.Item>();
            try
            {
                using (SqlConnection conn = SqlHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("INV.sp_Items_Bind", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (await dataReader.ReadAsync())
                        {
                            items.Add(new BEL.Item
                            {
                                ItemId = Convert.ToInt32(dataReader["ItemId"]),
                                ItemName = Convert.ToString(dataReader["ItemName"]),
                                Description = Convert.ToString(dataReader["Description"]),
                                Price = Convert.ToDecimal(dataReader["Price"]),
                                Quantity = Convert.ToInt32(dataReader["Quantity"]),
                            });
                        }
                    }
                }
                return items;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<int> SaveItems(Models.BEL.Item item)
        {
            try
            {
                using (SqlConnection conn = SqlHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("INV.sp_Items_Save", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@ItemId", SqlDbType.Int).Value = item.ItemId;
                    cmd.Parameters.AddWithValue("@ItemName", SqlDbType.NVarChar).Value = item.ItemName;
                    cmd.Parameters.AddWithValue("@Description", SqlDbType.NVarChar).Value = item.Description;
                    cmd.Parameters.AddWithValue("@Price", SqlDbType.Decimal).Value = item.Price;
                    cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = item.Quantity;
                    return await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<int> DelteItem(int ItemId)
        {
            try
            {
                using (SqlConnection conn = SqlHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("INV.sp_Items_Delete", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@ItemId", SqlDbType.Int).Value = ItemId;
                    return await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}