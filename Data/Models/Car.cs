using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetProvider.Data.Models
{
    /// <summary>
    /// Description of each machine
    /// </summary>
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
