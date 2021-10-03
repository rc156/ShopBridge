using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ShopBridge.Web.Models.DAL;

namespace ShopBridge.Web.Controllers
{
    public class ItemsController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public async Task<IEnumerable<Models.BEL.Item>> GetItems()
        {
            return await Models.BLL.Item.GetItems();
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IHttpActionResult> SaveItem(Models.BEL.Item item)
        {
            int retval = await Models.BLL.Item.SaveItems(item);
            if (retval > 0)
                return Ok();
            return BadRequest("Problem saving Item");
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task<IHttpActionResult> UpdateItem(Models.BEL.Item item)
        {
            int retval = await Models.BLL.Item.SaveItems(item);
            if (retval > 0)
                return Ok();
            return BadRequest("Problem updating Item");

        }

        // DELETE api/<controller>/5
        [HttpDelete, Route("{ItemId}")]
        public async Task<IHttpActionResult> DeleteItem(int ItemId)
        {
            int retval = await Models.BLL.Item.DelteItem(ItemId);
            if (retval > 0)
                return Ok();
            return BadRequest("Problem deleting Item");

        }
    }
}