using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea_Shop
{
    [Serializable]
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

        public static string TeaFile = "../../data/t.txt";
        public static List<Tea> TeaList;

        public static List<Tea> ReadTea(string _fileName)
        {

            List<Tea> _teaList = new List<Tea>();
            using (var sr = new StreamReader(_fileName))
            {
                while (sr.EndOfStream == false)
                {
                    var row = sr.ReadLine();
                    var words = row.Split(':');
                    Tea t = new Tea(words[0], words[1], words[2], double.Parse(words[3]));
                    _teaList.Add(t);


                }

            }


            return _teaList;
        }

        public static void SaveData(string _fileName, List<Tea> _teaList)
        {
            using (var sw = new StreamWriter(_fileName))
            {
                foreach (var tea in _teaList)
                {
                    sw.WriteLine($"{tea.Name}:{tea.Descriprion}:{tea.Type}:{tea.Price}");
                }
            }
        }

    }
}
