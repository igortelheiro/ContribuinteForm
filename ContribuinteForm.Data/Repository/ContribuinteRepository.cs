using System.Collections.Generic;

namespace ContribuinteForm.Data.Repository
{
    public class ContribuinteRepository
    {
        private readonly List<Contribuinte> Contribuintes;

        public ContribuinteRepository()
        {
            Contribuintes = new List<Contribuinte>();
        }

        public List<Contribuinte> GetAll() => Contribuintes;


        public Contribuinte Get(string documento) =>
            Contribuintes.Find(c => c.Documento == documento);


        public void Add(Contribuinte newContribuinte) => Contribuintes.Add(newContribuinte);


        public List<Contribuinte> Update(string documento, Contribuinte newContribuinte)
        {
            var oldContribuinte = Get(documento);
            Contribuintes.Remove(oldContribuinte);
            Contribuintes.Add(newContribuinte);
            
            return Contribuintes;
        }

        public List<Contribuinte> Delete(string documento)
        {
            var contribuinte = Get(documento);
            Contribuintes.Remove(contribuinte);
            
            return Contribuintes;
        }
    }
}
