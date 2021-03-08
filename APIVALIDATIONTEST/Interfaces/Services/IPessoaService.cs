using APIVALIDATIONTEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVALIDATIONTEST.Interfaces.Services
{
    public interface IPessoaService
    {
        public IEnumerable<PessoaModel> GetAll();
        public PessoaModel GetOne(int id);
        public PessoaModel Update(PessoaModel pessoa);
        public PessoaModel Insert(PessoaModel pessoa);
        public bool Delete(int id);
    }
}
