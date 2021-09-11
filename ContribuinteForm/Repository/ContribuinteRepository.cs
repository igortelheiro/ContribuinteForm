using ContribuinteForm.Model;
using System.Collections.Generic;

namespace ContribuinteForm.Repository
{
    public class ContribuinteRepository
    {
        private readonly List<ContribuinteModel> _contribuintes;

        public ContribuinteRepository()
        {
            _contribuintes = new List<ContribuinteModel>();
        }

        public List<ContribuinteModel> GetAll() => _contribuintes;


        public ContribuinteModel Get(string documento) =>
            _contribuintes.Find(c => c.Documento == documento);


        public void Add(ContribuinteModel newContribuinte) => _contribuintes.Add(newContribuinte);


        public List<ContribuinteModel> Update(string documento, ContribuinteModel newContribuinte)
        {
            var oldContribuinte = Get(documento);
            _contribuintes.Remove(oldContribuinte);
            _contribuintes.Add(newContribuinte);
            
            return _contribuintes;
        }

        public List<ContribuinteModel> Delete(string documento)
        {
            var contribuinte = Get(documento);
            _contribuintes.Remove(contribuinte);
            
            return _contribuintes;
        }

        public List<ContribuinteModel> Delete(ContribuinteModel contribuinte)
        {
            _contribuintes.Remove(contribuinte);
            return _contribuintes;
        }
    }
}
