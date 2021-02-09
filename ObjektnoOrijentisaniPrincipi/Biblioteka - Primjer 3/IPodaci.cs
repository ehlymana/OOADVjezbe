using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public interface IPodaci
    {
        public int GenerišiID()
        {
            int broj = 0;
            for (int i = 0; i < 10; i++)
            {
                Random generator = new Random();
                broj += (int) Math.Pow(10, i) * generator.Next(0, 9);
            }
            return broj;
        }

        string DajOpis();
    }
}
