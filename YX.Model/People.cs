using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YX.Model
{
  public  class People
    {
        public People()
        {
            Console.WriteLine("{0}被创建",this.GetType().FullName);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description;
    }

    public class PeopleDT0
    {
        public PeopleDT0()
        {
            Console.WriteLine("{0}被创建",this.GetType().FullName);
        }

        public int Id { get; set; }

        public string Name { get; set; }  //ShortName 特性

        public string Description;
    }
}
