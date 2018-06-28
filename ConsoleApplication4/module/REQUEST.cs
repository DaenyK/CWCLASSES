using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.module
{
    public enum TypeRequest
    {
        /// <summary>
        /// •	SALES – данные о продажах  •	SALESIMS-данные об общих продажа •	STORED – данные об остатка •	MOVING - данные о перемещениях •	GOODS_RECEIPT - данные по приходам
        /// </summary>
       none, sales, salessims, stored, moving, goods_receipt
    }
    class Request
    {
        /// <summary>
        /// Тип запроса:
        /// </summary>
        public TypeRequest Req { get; set; }
        /// <summary>
        /// Код поставщика из системы SAP ERP (или BIN).  Если идет передача SALESIMS, то код KUNNR не заполняется.
        /// </summary>
        public string Kunnr { get; set; }
        /// <summary>
        /// Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен. 
        /// </summary>
        public string Bukrs { get; set; }
        /// <summary>
        /// Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP. 
        /// </summary>
        public string Werks { get; set; }
        /// <summary>
        /// Дата с начало периода
        /// </summary>
        public DateTime Data1 { get; set; }
        /// <summary>
        /// Дата конец периода
        /// </summary>
        public DateTime Data2 { get; set; }

    }
}
