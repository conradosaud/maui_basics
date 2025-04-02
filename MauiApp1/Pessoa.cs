using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    class Pessoa
    {

        public static List<Pessoa> pessoas = new List<Pessoa>();

        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }


    }
}
