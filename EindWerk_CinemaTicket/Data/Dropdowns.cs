using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;

namespace EindWerk_CinemaTicket.Data
{
    public class Dropdowns
    {
        public List<Genre> Genres { get; set; }
        public List<CinemaHall> CinemaHalls { get; set; }
        public List<Actor> Actors { get; set; }
        public Dropdowns()
        {
            Genres=new List<Genre>();
            CinemaHalls=new List<CinemaHall>();
            Actors=new List<Actor>();
        }
        
    }
}
