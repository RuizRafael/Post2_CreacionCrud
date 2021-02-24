using POST2.Data;
using POST2.Models;
using POST2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POST2.Repositories
{
    public class RepositoryLlegadas : IRepositoryLlegadas
    {
        LlegadasContext context;

        public RepositoryLlegadas(LlegadasContext context)
        {
            this.context = context;
        }
        public Llegada BuscarLlegada(int idLlegada)
        {
            return this.context.Llegadas.Where(z => z.Id == idLlegada).FirstOrDefault();
        }

        public void EliminarLlegada(int idLlegada)
        {
            Llegada Llegada = this.BuscarLlegada(idLlegada);
            this.context.Llegadas.Remove(Llegada);
            this.context.SaveChanges();
        }

        public List<Llegada> GetLlegadas()
        {
            var consulta = from datos in context.Llegadas
                           select datos;
            return consulta.ToList();
        }

        public void InsertarLlegada(int id, string fly, string airlane, string from, string to, int gate, string hour)
        {
            Llegada llegada = new Llegada();
            llegada.Id = id;
            llegada.Fly = fly;
            llegada.Airlane = airlane;
            llegada.From = from;
            llegada.To = to;
            llegada.Gate = gate;
            llegada.Hour =  hour;
            this.context.Llegadas.Add(llegada);
            this.context.SaveChanges();
        }

    

        public void ModificarLlegada(int id, string fly, string airlane, string from, string to, int gate, string hour)
        {
            Llegada llegada = new Llegada();
            llegada.Id = id;
            llegada.Fly = fly;
            llegada.Airlane = airlane;
            llegada.From = from;
            llegada.To = to;
            llegada.Gate = gate;
            llegada.Hour = hour;
            this.context.Llegadas.Update(llegada);
            this.context.SaveChanges();
        }
    }
}
