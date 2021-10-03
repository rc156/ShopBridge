using System.ComponentModel.DataAnnotations;

namespace ShopBridge.Web.Models.BEL
{
    public class Item
    {
        public int ItemId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string ItemName { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        [RegularExpression(@"^[0-9]([.,][0-9]{1,3})?$")]   
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter quantity")]
        [RegularExpression(@"^[0-9]+$")]
        public int Quantity { get; set; }
    }
}