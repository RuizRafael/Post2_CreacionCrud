using POST2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POST2.Repositories
{
    public interface IRepositoryLlegadas
    {
        List<Llegada> GetLlegadas();

        Llegada BuscarLlegada(int id);

        void EliminarLlegada(int id);


        void InsertarLlegada(int id, string fly, string airlane, string from, string to, int gate, string hour);


        void ModificarLlegada(int id, string fly, string airlane, string from, string to, int gate, string hour);
    }
}
