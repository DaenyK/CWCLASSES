using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.module
{
    public enum curency
    {
        KZT = 398, RUB = 643, USD = 840
    }
    public enum SalesChanelTxt
    {
        opt = 8, roz = 7, net=9
    }

    
   public  class Sales
    {
        public string Bukrs { get; set; }
        public string Werks { get; set; }
        public string Lgort { get; set; }

        public int SalesChanel { get; private set; }

        private SalesChanelTxt SalesChanelTxt_;
        public SalesChanelTxt SalesChanelTxt
        {
            get { return SalesChanelTxt_; }
            set
            {
                SalesChanelTxt_ = value;
                SalesChanel = (int)value;
            }
        }




        public string Kunnr { get; set; }
        public string KunnrTxt { get; set; }
        public int KunnrBin { get; set; }
        public string KunnrAdrUr { get; set; }
        public string KunnrAdrDost { get; set; }
        public string IdOutDelivery { get; set; }
        public string IdOutDeliveryData { get; set; }
        public double BsStart { get; set; }
        public double Summ { get; set; }
        public string SummWithCur
        { get
            {
                return Summ + " " + Valuta.ToString();
            }
        }

        public curency Valuta { get; set; } = curency.KZT;
    }
}
