using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample501
{
    public class Program
    {
        static void Main()
        {
            CellPhone cp = new CellPhone("hoge@email.com", "090-1234-5678");

            cp.call("080-987-6543");
            cp.SendEmail("fuga@email.com");

            // Phoneインターフェースでインスタンスにアクセス
            Phone phone = (Phone)cp;
            phone.call("052-111-2222");

            // Emailインターフェースでインスタンスにアクセス
            Email mail = (Email)cp;
            mail.SendEmail("bar@email.com");
        }
    }
}