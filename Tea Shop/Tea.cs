using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea_Shop
{
    class Tea
    {
        private string _name;
        private string _description;
        private string _type;
        private double _price;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Descriprion
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Tea(string name, string description, string type, double price)
        {
            _name = name;
            _description = description;
            _type = type;
            _price = price;
        }

    }
}
