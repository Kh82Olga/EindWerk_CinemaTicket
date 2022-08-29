using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;

namespace EindWerk_CinemaTicket.Interfaces
{
    public interface ITimetable
    {
        IEnumerable<Timetable> GetAll();
        Timetable GetById(int Id);
        void Insert(Timetable timetable);
        void Update(Timetable timetable);
        void Delete(Timetable timetable);
    }
}
