using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Member
    {
        public enum LoginType
        {
            Receptionist,//前台人员
            Manager//管理人员
        }
        private string memberId;//登陆用户名

        public string MemberId//封装后的登陆用户名
        {
            get { return memberId; }
            set { memberId = value; }
        }
        private string memberPwd;//登陆密码

        public string MemberPwd//封装后的登陆密码
        {
            get { return memberPwd; }
            set { memberPwd = value; }
        }
        private LoginType type;//登陆类型

        public LoginType Type//封装后的登陆类型
        {
            get { return type; }
            set { type = value; }
        }
        private string phoneNum;//联系电话

        public string PhoneNum//封装联系电话
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
    }
}
