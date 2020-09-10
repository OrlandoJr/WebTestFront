using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using WebTestFront.Shared.ViewModel;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebTestFront.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesAppService _context;
        private readonly IMapper _mapper;

        public ClientesController(IClientesAppService context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Clientes
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            try
            { 
            return Ok(_mapper.Map<IEnumerable<ClientesModel>, IEnumerable<ClientesViewModel>>(await _context.GetAllAsync()));
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        // GET: api/Clientes/Chico
        //[Route("[action]/{Nome}")]
        [HttpGet("[action]/{Nome}")]
        public async Task<IActionResult> GetByName(string Nome)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<ClientesModel>, IEnumerable<ClientesViewModel>>(await _context.GetByNameAsync(Nome)));

            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

        }

        // GET: api/Clientes/5
        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                return Ok(_mapper.Map<ClientesModel, ClientesViewModel>(await _context.GetByIDAsync(Id)));

            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

        }

        // POST: api/Clientes
        [HttpPost("[action]")]
        public async Task<OkObjectResult> Post(ClientesViewModel entity)
        {
            try
            {                
                var clientes = _mapper.Map<ClientesViewModel, ClientesModel>(entity);
                return new OkObjectResult(await _context.AddAsync(clientes));

            }catch(Exception e)
            {
                return new OkObjectResult(e.Message);
            }
        }

        // PUT: api/Clientes/5
        [HttpPut]
        public async Task<OkObjectResult> Put(ClientesViewModel entity)
        {
            try
            {
                await _context.UpdateAsync(_mapper.Map<ClientesViewModel, ClientesModel>(entity));
                return new OkObjectResult("Atualizado");

            }
            catch (Exception e)
            {
                return new OkObjectResult(e.Message);
            }
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{Id}")]
        public async Task<OkObjectResult> Delete(int Id)
        {
            try
            {
                var entity = await _context.GetByIDAsync(Id);
                await _context.RemoveAsync(entity);

                return new OkObjectResult("Deletado");

            }
            catch (Exception e)
            {
                return new OkObjectResult(e.Message);
            }
        }
    }
}
