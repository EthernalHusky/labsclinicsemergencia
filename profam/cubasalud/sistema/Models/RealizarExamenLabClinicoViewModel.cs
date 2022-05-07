using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;
using System;

namespace sistema.Models
{
    public class RealizarExamenLabClinicoViewModel
    {

        public RealizarExamenLabClinicoViewModel()
        {
        }

        public Examen Examen {get;set;} = new Examen();
        public SelectList ListaExamenesDisponibles {get;set;}
        public SelectList ListaMedicosDisponibles {get;set;}
        public SelectList ListaPaciente {get;set;}
        public SelectList ListaEstados {get;set;}
        public SelectList ListaFormaPagos {get;set;}



        public void Init(ILaboratorioClinico laboratorioClinico, IEmpleado empleadoRepository, IPacientes pacienteRepository, IEnvio envioRepository)
        {
            ListaExamenesDisponibles = new SelectList(laboratorioClinico.GetListExamenesLaboratorio(), "Id", "NombreExamen");
            
            ListaMedicosDisponibles = new SelectList(empleadoRepository.GetListMedicos(), "Id", "Nombres");
            
            ListaPaciente = new SelectList(pacienteRepository.GetList(), "Id", "PacienteConIGSS");
            ListaEstados = new SelectList(pacienteRepository.GetListEstadosExamen(), "Id", "Nombre"); 
            ListaFormaPagos = new SelectList(envioRepository.GetListPagos(), "Id", "NombreFormaPago");

        }
        public int Id
        {
            get { return Examen.Id; }
            set { Examen.Id = value; }
        }
    }
} 