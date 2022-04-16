using CadastroClientes.Models;
using CadastroClientes.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CadastroClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly InterfaceCliente _repository;

        public ClienteController(InterfaceCliente repository)
        {
            _repository = repository;
        }

        // GET: api/<ValuesController>
        [HttpGet("Buscar")]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/<ValuesController>/5
        [HttpGet("BuscarPorCodigo")]
        public ValueTask<Cliente> Get(int codigo)
        {
            return _repository.Get(codigo);
        }

        // POST api/<ValuesController>
        [HttpPost("Salvar")]
        public async Task<IActionResult> Post([FromBody] Cliente cliente)
        {
            try
            {
                await _repository.Add(cliente);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("Alterar")]
        public async Task<IActionResult> Put([FromBody] Cliente cliente)
        {
            try
            {
                await _repository.Put(cliente);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("Remover")]
        public async Task<IActionResult> Delete(int codigo)
        {
            try
            {
                await _repository.Delete(codigo);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}