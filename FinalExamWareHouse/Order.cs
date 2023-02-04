using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamWareHouse
{
    public class Order
    {

        public int Id { get; set; }

        public string? OrderClientName;

        public string? OrderProductName;

        public decimal? OrderProductQuantity;

        public string? OrderDate;

    }
}
