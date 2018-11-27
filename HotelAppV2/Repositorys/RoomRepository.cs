using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppV2
{
    public class RoomRepository
    {
        private HotelDBEntities context;

        public RoomRepository()
        {
            context = new HotelDBEntities();
        }

        public List<Room> GetAvailableRooms(DateTime dateStart, DateTime dateEnd, int persons)
        {
            List<Room> availableRooms;

            using (context)
            {
                    var unavailableRooms = (from booking in context.BookingDetails
                    join room in context.Rooms on booking.RoomID equals room.RoomID
                    where (dateStart <= booking.EndDate && booking.StartDate <= dateEnd)
                    select room).ToList();

                    availableRooms = (from room in context.Rooms.ToList()
                    where !unavailableRooms.Contains(room) && room.Size >= persons
                    select room).ToList();
            }

            return availableRooms;
        }

        public static bool CheckExtraBedCompatible(int roomId)
        {
            HotelDBEntities context = new HotelDBEntities();

            Room room = new Room();
            bool canFitExtraBed;

            using (context)
            {
                room = context.Rooms.Where(r => r.RoomID == roomId).SingleOrDefault();

                if (room.Size <= 1)
                {
                    canFitExtraBed = false;
                }
                else
                {
                    canFitExtraBed = true;
                }

                return canFitExtraBed;
            }
        }

        public static bool CanPersonFitInRoom(int roomId, int people)
        {
            HotelDBEntities context = new HotelDBEntities();
            Room room = new Room();
            bool personFits;

            using (context)
            {
                room = context.Rooms.Where(r => r.RoomID == roomId).SingleOrDefault();

                if (people <= room.Size)
                {
                    personFits = true;
                    return personFits;
                }

                personFits = false;
            }

            return personFits;
        }

        public List<Room> GetAvailableRooms2(string searchValue)
        {
            using (var context = new HotelDBEntities())
            {
                var rooms = context.FindSearchedRooms(searchValue).ToList();

                return rooms;

            }
            
        }


    }
}
