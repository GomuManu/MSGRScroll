using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGRScroll_DAL
{
    public class ChatDAL
    {

        SMRGScrollEntities modelo;

        public ChatDAL()
        {
            modelo = new SMRGScrollEntities();
        }

        public void crearChat(Chat chat)
        {
            modelo.Chat.Add(chat);
            modelo.SaveChanges();
        }

    }
}
