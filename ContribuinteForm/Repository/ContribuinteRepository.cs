using ContribuinteForm.Model;
using System.Collections.Generic;

namespace ContribuinteForm.Repository
{
    public class ContribuinteRepository
    {
        public readonly List<ContribuinteModel> Contribuintes;

        public ContribuinteRepository()
        {
            Contribuintes = new List<ContribuinteModel>();
        }

        public List<ContribuinteModel> GetAll() => Contribuintes;


        public ContribuinteModel Get(string documento) =>
            Contribuintes.Find(c => c.Documento == documento);


        public void Add(ContribuinteModel newContribuinte) => Contribuintes.Add(newContribuinte);


        public List<ContribuinteModel> Update(string documento, ContribuinteModel newContribuinte)
        {
            var oldContribuinte = Get(documento);
            Contribuintes.Remove(oldContribuinte);
            Contribuintes.Add(newContribuinte);
            
            return Contribuintes;
        }

        public List<ContribuinteModel> Delete(string documento)
        {
            var contribuinte = Get(documento);
            Contribuintes.Remove(contribuinte);
            
            return Contribuintes;
        }

        public List<ContribuinteModel> Delete(ContribuinteModel contribuinte)
        {
            Contribuintes.Remove(contribuinte);
            return Contribuintes;
        }
    }
}
