using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.module
{
    class ServiceRequest
    {
        public Response GetRequestData()
        {
            Request r1 = new Request();
            Console.WriteLine("Введите тип запроса: ");
            int type_req = 0;
            if (!Int32.TryParse(Console.ReadLine(), out type_req))
                Console.WriteLine("введите корректный тип запроса: ");

            if (type_req <= Enum.GetNames(typeof(TypeRequest)).Length)
            {
                r1.Req = (TypeRequest)type_req;
            }


            Console.WriteLine("Введите код поставщика: ");
            r1.Bukrs = Console.ReadLine();

            Console.WriteLine("Введите тип Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен. : ");
            r1.Kunnr = Console.ReadLine();


            Console.WriteLine("Введите Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP. ");
            r1.Werks = Console.ReadLine();


            Console.WriteLine("Введите Дату с начала периода: ");
            DateTime data1;
            if (DateTime.TryParse(Console.ReadLine(), out data1))
                r1.Data1 = data1;
            else r1.Data1 = DateTime.MinValue;


            Console.WriteLine("Введите Дату с конца периода: ");
            DateTime data2;
            if (DateTime.TryParse(Console.ReadLine(), out data2))
                r1.Data2 = data2;
            else r1.Data2 = DateTime.MinValue;

           return RequestInput(r1);
        }
        public Response RequestInput(Request r1)
        {
            Response responce = null;
            switch (r1.Req)
            {
                case TypeRequest.none:
                    break;
                case TypeRequest.sales:
                    {
                        List<Sales> s = null;
                        return GetSalesReport(r1, out s);
                    }
                case TypeRequest.salessims:
                    break;
                case TypeRequest.stored:
                    break;
                case TypeRequest.moving:
                    break;
                case TypeRequest.goods_receipt:
                    break;
                default:
                    break;
            }
            return responce;
        }

        public Response GetSalesReport(Request r, out List<Sales> SalesReport)
        {
            Response resp = new Response();
            SalesReport = new List<Sales>();

            SalesReport = GetSalesData(r);
            if (SalesReport.Count <= 0)
            {
                resp.status = Status.error;
                resp.Error = "ошибка";
            }
            else
            {
                resp.status = Status.ok;

            }
            return resp;
        }
        private List<Sales> GetSalesData(Request r)
        {
            List<Sales> saleses = new List<Sales>();
            for (int i = 0; i < (r.Data2 - r.Data1).TotalDays; i++)
            {
                Sales sales = new Sales();
                sales.BsStart = rnd.Next(0, 1000);
                sales.Bukrs = "b" + rnd.Next(0, 20);
                sales.Valuta = (curency)rnd.Next(0, 3);
                sales.IdOutDeliveryData = string.Format("{0:dd.mm.yy}", DateTime.Now.AddDays(rnd.Next(1, 30000)));
                sales.Kunnr = "b" + rnd.Next(0, 20);
                sales.KunnrAdrDost = "b" + rnd.Next(0, 20);
                sales.KunnrAdrUr = "b" + rnd.Next(0, 20);
                sales.KunnrBin = rnd.Next(11111111, 99999999);
                sales.KunnrTxt = "b" + rnd.Next(0, 20);
                sales.Lgort = "b" + rnd.Next(0, 20);
                sales.SalesChanelTxt = (SalesChanelTxt)rnd.Next(0, 2);
                sales.Summ = rnd.Next();

                saleses.Add(sales);
            }
            return saleses;
        }
        private Random rnd = new Random();
    }
}
