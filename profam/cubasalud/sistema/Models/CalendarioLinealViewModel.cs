using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using System;

namespace sistema.Models
{
    public class CalendarioLinealViewModel 
    {
        public string Fecha {get;set;}
        public List<string> Horas = new List<string>
        {
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30",
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
        };

        public IList<Citas> Citas {get;set;}

        public string FechaYHoras
        {
            get {
                return $"{Fecha}";
            }
        }

        // public List<FechaYHorasCalendario> fc()
        // {
        //     return new List<FechaYHorasCalendario>();
        // }
    }

    public class FechaYHorasCalendario
    {
        public DateTime Fecha {get;set;}
        public DateTime Hora {get;set;}
        public Cita Cita {get;set;}
    }
} 