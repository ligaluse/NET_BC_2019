using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
   public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //virskategorijas identif., ja nav definets - pamatkategorija
        //categoryid var but nullejams, tapec aiz int jaliek "?"
        public int? CategoryId { get; set; }
    }
}
