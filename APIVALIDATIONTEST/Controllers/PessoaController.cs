using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIVALIDATIONTEST.Data;
using APIVALIDATIONTEST.Models;
using APIVALIDATIONTEST.Services;

namespace APIVALIDATIONTEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaService _pessoaservice;

        public PessoaController(PessoaService pessoaservice)
        {
            _pessoaservice = pessoaservice;
        }

        // GET: api/Pessoa
        [HttpGet]
        public ActionResult<IEnumerable<PessoaModel>> GetPessoaModel()
        {
            return Ok(_pessoaservice.GetAll());
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}")]
        public ActionResult<PessoaModel> GetPessoaModel(int id)
        {
            var pessoaModel = _pessoaservice.GetOne(id);
            if (pessoaModel == null)
                return NotFound();

            return Ok(pessoaModel);
        }

        // PUT: api/Pessoa/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutPessoaModel(int id, PessoaModel pessoaModel)
        {
            if (id != pessoaModel.PessoaId)
                return BadRequest();

            var response = _pessoaservice.Update(pessoaModel);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        // POST: api/Pessoa
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<PessoaModel> PostPessoaModel(PessoaModel pessoaModel)
        {
            var response = _pessoaservice.Insert(pessoaModel);
            if (response.GetType() != typeof(PessoaModel))
                return BadRequest();


            return CreatedAtAction("GetPessoaModel", new { id = pessoaModel.PessoaId }, pessoaModel);
        }

        // DELETE: api/Pessoa/5
        [HttpDelete("{id}")]
        public ActionResult<PessoaModel> DeletePessoaModel(int id)
        {
            return Ok(_pessoaservice.Delete(id));
        }
    }
 }
