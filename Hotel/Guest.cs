using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public enum IsVip
    {
        yes, no
    }
    public class Guest
    {
       
        private string guestName;//客人的姓名

        public string GuestName//封装客人的姓名
        {
            get { return guestName; }
            set { guestName = value; }
        }
        private string guestID;//客人的身份证号

        public string GuestID//封装客人的身份证号
        {
            get { return guestID; }
            set { guestID = value; }
        }

        private IsVip vip;//客人是否是VIP

        public IsVip Vip//对vip进行封装
        {
            get { return vip; }
            set { vip = value; }
        }
    }
}
