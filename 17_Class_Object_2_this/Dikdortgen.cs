using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Class_Object_2_this
{
    internal class Dikdortgen
    {
        int En;
        int Boy;

        internal void DegerAl(int En, int Boy)
        {
            this.En = En;
            this.Boy = Boy;
            //this.DegerAl(1, 2); // RECURSIVE METHOD
        } 
    }
}
