using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;

namespace EindWerk_CinemaTicket.Interfaces
{
    public interface ICinemaSeat
    {
        IEnumerable<CinemaSeat> GetAll();
        CinemaSeat GetById(int Id);
        void Insert(CinemaSeat seat);
        void Update(CinemaSeat seat);
        void Delete(CinemaSeat seat);
    }
}
