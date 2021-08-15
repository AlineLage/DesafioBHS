using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyStore.WebAPI.Data;
using MyStore.WebAPI.Dto;
using MyStore.WebAPI.Models;
//using MyStore.WebAPI.Data;

namespace MyStore.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        public PedidoController() { }

        public readonly IRepository _repo;
        private readonly IMapper _mapper;

        public PedidoController(IRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;            
        }
            
        [HttpGet]
        public IActionResult Get()
        {
            var pedidos = _repo.GetAllPedidos(true);
           
            return Ok(_mapper.Map<IEnumerable<PedidoDto>>(pedidos));
        }

        [HttpGet("getRegister")]
        public IActionResult GetRegister()
        {
            return Ok(new PedidoRegistrarDto());
        }

        // api/aluno
        [HttpGet("{codigo}")]
        public IActionResult GetByCodigo(int codigo)
        {
            var pedido = _repo.GetPedidoByCodigo(codigo, false);
            if (pedido == null) return BadRequest("Pedido não encontrado");

            var PedidoDto = _mapper.Map<PedidoDto>(pedido);

            return Ok(PedidoDto);
        }

        // api/aluno
        [HttpPost]
        public IActionResult Post(PedidoRegistrarDto model)
        {
            var pedido = _mapper.Map<Pedido>(model);

            _repo.Add(pedido);
            if (_repo.SaveChanges())
            {
                return Created($"/api/pedido/{model.Codigo}", _mapper.Map<PedidoDto>(pedido));
            }

            return BadRequest("Pedido não cadastrado");
        }

        [HttpPut("{codigo}")]
        public IActionResult Put(int codigo, PedidoRegistrarDto model)
        {
            var pedido = _repo.GetPedidoByCodigo(codigo);
            if (pedido == null) return BadRequest("Pedido não encontrado");

            _mapper.Map(model, pedido);

            _repo.Update(pedido);
            if (_repo.SaveChanges())
            {
                return Created($"/api/pedido/{model.Codigo}", _mapper.Map<PedidoDto>(pedido));
            }

            return BadRequest("Pedido não atualizado");
        }

        [HttpPatch("{codigo}")]
        public IActionResult Patch(int codigo, PedidoRegistrarDto model)
        {
            var pedido = _repo.GetPedidoByCodigo(codigo);
            if (pedido == null) return BadRequest("Pedido não encontrado");

            _mapper.Map(model, pedido);

            _repo.Update(pedido);
            if (_repo.SaveChanges())
            {
                return Created($"/api/pedido/{model.Codigo}", _mapper.Map<PedidoDto>(pedido));
            }

            return BadRequest("Pedido não atualizado");
        }

        [HttpDelete("{codigo}")]
        public IActionResult Delete(int codigo)
        {
            var pedido = _repo.GetPedidoByCodigo(codigo);
            if (pedido == null) return BadRequest("Pedido não encontrado");

           _repo.Delete(pedido);
            if (_repo.SaveChanges())
            {
                return Ok("Pedido deletado");
            }

            return BadRequest("Pedido não deletado");
        }
    }
}