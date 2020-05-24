using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSGRScroll_DAL;

namespace MSGRSrcoll_BLL
{
    public class ChatBLL
    {

        public void crearChat(Chat chat)
        {
            ChatDAL chatDAL = new ChatDAL();
            chatDAL.crearChat(chat);
        }

    }
}
