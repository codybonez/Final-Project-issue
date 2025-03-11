using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Final_Project
{
  public  class Person
    {
        public string age { get; set; }
        public string name { get; set; }
        public string DOB { get; set; }

        public override string? ToString()
        {
            return $"{age} - {name} - {DOB}";
        }
    }





}
