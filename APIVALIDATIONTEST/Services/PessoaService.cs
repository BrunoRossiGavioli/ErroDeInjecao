using APIVALIDATIONTEST.Interfaces.Services;
using APIVALIDATIONTEST.Models;
using APIVALIDATIONTEST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVALIDATIONTEST.Services
{
    public class PessoaService : IPessoaService
    {
        public readonly PessoaRepository _pessoaRepository;

        public PessoaService(PessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<PessoaModel> GetAll()
        {
            return _pessoaRepository.GetAll();
        }

        public PessoaModel GetOne(int id)
        {
            return _pessoaRepository.GetOne(id);
        }

        public PessoaModel Insert(PessoaModel pessoa)
        {
            return _pessoaRepository.Insert(pessoa);
        }

        public PessoaModel Update(PessoaModel pessoa)
        {
            return _pessoaRepository.Update(pessoa);
        }

        public bool Delete(int id)
        {
            var obj = _pessoaRepository.GetOne(id);
            if (obj == null)
                return false;

            return _pessoaRepository.Delete(obj);
        }
    }
}
