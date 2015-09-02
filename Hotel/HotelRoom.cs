using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class HotelRoom
    {
        public enum Status
        {
            empty,full
        }
        private string hotelRoomNo;//房间号

        public string HotelRoomNo//封装房间号
        {
            get { return hotelRoomNo; }
            set { hotelRoomNo = value; }
        }
        private Status roomStatus;//房间当前状态

        public Status RoomStatus//封装当前状态
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }
        private float price;//房间价格

        public float Price//封装房间价格
        {
            get { return price; }
            set { price = value; }
        }
        private DateTime checkInDate;

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }
        private DateTime chechOutDate;

        public DateTime ChechOutDate
        {
            get { return chechOutDate; }
            set { chechOutDate = value; }
        }

        private int duration;

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
