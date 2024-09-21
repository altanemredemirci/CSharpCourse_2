﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_2_RestaurantOtomasyonu
{
    internal class Masa
    {
        public int Id { get; set; }
        public bool Dolu { get; set; }
        public List<Siparis> Siparisler { get; set; }

        public Masa()
        {
            Siparisler = new List<Siparis>();
        }

        internal static Masa MasaDoldur(List<Masa> liste) 
        {
            foreach (Masa masa in liste)
            {
                if (!masa.Dolu)
                {
                    masa.Dolu = true;
                    return masa;
                }
            }
            return null;
        }
    }   
}
