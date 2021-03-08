using APIVALIDATIONTEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVALIDATIONTEST.Interfaces.Respositories
{
    public interface IPessoaRepository
    {
        public IEnumerable<PessoaModel> GetAll();
        public PessoaModel GetOne(int id);
        public PessoaModel Update(PessoaModel pessoa);
        public PessoaModel Insert(PessoaModel pessoa);
        public bool Delete(PessoaModel pessoa);
    }
}
