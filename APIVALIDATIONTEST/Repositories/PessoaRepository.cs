using APIVALIDATIONTEST.Data;
using APIVALIDATIONTEST.Interfaces.Respositories;
using APIVALIDATIONTEST.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVALIDATIONTEST.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        public readonly APIVALIDATIONTESTContext _context;

        public PessoaRepository(APIVALIDATIONTESTContext context)
        {
            _context = context;
        }

        public IEnumerable<PessoaModel> GetAll()
        {
            return _context.PessoaModel.ToList().OrderBy(a => a.Nome);
        }

        public PessoaModel GetOne(int id)
        {
            return _context.PessoaModel.Find(id);
        }

        public PessoaModel Insert(PessoaModel pessoa)
        {
            try
            {
                _context.PessoaModel.Add(pessoa);
                _context.SaveChangesAsync();
                return pessoa;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public PessoaModel Update(PessoaModel pessoa)
        {
            _context.Entry(pessoa).State = EntityState.Modified;

            try
            {
                _context.SaveChangesAsync();
                return this.GetOne(pessoa.PessoaId);
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

        }

        public bool Delete(PessoaModel pessoa)
        {
            try
            {
                _context.PessoaModel.Remove(pessoa);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
