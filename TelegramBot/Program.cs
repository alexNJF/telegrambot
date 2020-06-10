using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    class Program
    {

        static void Main(string[] args)
        {
            Controlls.SSL();
            Controlls ctrl = new Controlls();//bot controller
            Console.WriteLine("Server Started ");
            while (true)
            {
                string last_index = ctrl.read_index();
                T_result new_massage = ctrl.get_update(last_index);
                if (new_massage.result.Count > 0)
                {
                    ctrl.responce(new_massage);
                    ctrl.save_index(ctrl.get_update());
                }
            }
        }
    }
}
