using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample501
{
    internal class CellPhone    :Phone, Email
    {
        private string mail_address;
        private string phone_number;
        // コンストラクタ
        public CellPhone(string adress, string number)
        {
            mail_address = adress;
            phone_number = number;
        }

        public void SendEmail(string address)
        {
            Console.WriteLine(address + "に" + mail_address + "からメールを送信します。");
        }
        public void call(string number)
        {
            Console.WriteLine(number + "に" + phone_number + "から電話を掛けます。");
        }

    }
}
