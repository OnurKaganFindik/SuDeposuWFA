using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDeposuWFA
{
    public class SuDeposu
    {
        private readonly decimal _kapasite;
        public decimal Kapasite { get; { return _kapasite; } }

        public decimal SuMiktari { get; private set; }

        public decimal DolulukOrani { get { return SuMiktari / Kapasite; } }

        public SuDeposu(decimal kapasite)
        {
            _kapasite = kapasite;
        }

        public void SuEkle(decimal miktar)
        {
            if (miktar<0)
            {
                throw new ArgumentException("Eklenecek su miktarı sıfırdan küçük olamaz.");
            }
            SuMiktari += miktar;
        }
    }
}
