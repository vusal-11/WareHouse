using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamWareHouse
{
    public class User
    {
        public string? UserName { get; set; }
        public string? PassWord { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public List<Client> clients = new List<Client>();
        public List<Order> orders = new List<Order>();




    }
}
