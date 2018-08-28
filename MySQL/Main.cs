using System;
using GTANetworkAPI;
using SampleRageMySQL.Models;
using System.Linq;

namespace SampleRageMySQL
{
    public class Main : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                foreach(var user in db.Users)
                {
                    Console.WriteLine("(" + user.id + ") User: " + user.login);
                }
            }
        }
    }
}
