using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sportsx.api.DTO;
using sportsx.cliente.domain;

namespace sportsx.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPessoaService _pessoaService;

        public PessoaController(IMapper mapper, IPessoaService pessoaService)
        {
            _mapper = mapper;
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public async Task<ActionResult> ObterTodos()
        {
            var pessoas = await _pessoaService.ObterTodos();
            var pessoasDto = _mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaDTO>>(pessoas);
            return Ok(pessoasDto);
        }

        [HttpPut]
        [Route("atualizar-pessoa-fisica")]
        public async Task<ActionResult> AtualizarPessoaFisica([FromBody]PessoaFisicaDTO pessoaFisicaDto)
        {
            var pessoa = _mapper.Map<PessoaFisicaDTO, Pessoa>(pessoaFisicaDto);
            pessoa = await _pessoaService.Atualizar(pessoa);
            var pessoaDto = _mapper.Map<Pessoa, PessoaFisicaDTO>(pessoa);
            return Ok(pessoaDto);
        }

        [HttpPut]
        [Route("atualizar-pessoa-juridica")]
        public async Task<ActionResult> AtualizarPessoaJuridica([FromBody]PessoaJuridicaDTO pessoaJuridicaDTO)
        {
            var pessoa = _mapper.Map<PessoaJuridicaDTO, Pessoa>(pessoaJuridicaDTO);
            pessoa = await _pessoaService.Atualizar(pessoa);
            var pessoaDto = _mapper.Map<Pessoa, PessoaJuridicaDTO>(pessoa);
            return Ok(pessoaDto);
        }

        [HttpPost]
        [Route("cadastrar-pessoa-fisica")]
        public async Task<ActionResult> CriarPessoaFisica([FromBody]PessoaFisicaDTO pessoaFisicaDto)
        {
            var pessoa = _mapper.Map<PessoaFisicaDTO, Pessoa>(pessoaFisicaDto);
            pessoa = await _pessoaService.Adicionar(pessoa);
            var pessoaDto = _mapper.Map<Pessoa, PessoaFisicaDTO>(pessoa);
            return Ok(pessoaDto);
        }

        [HttpPost]
        [Route("cadastrar-pessoa-juridica")]
        public async Task<ActionResult> CriarPessoaJuridica([FromBody]PessoaJuridicaDTO pessoaJuridicaDto)
        {
            var pessoa = _mapper.Map<PessoaJuridicaDTO, Pessoa>(pessoaJuridicaDto);
            var response = await _pessoaService.Adicionar(pessoa);
            var pessoaDto = _mapper.Map<Pessoa, PessoaJuridicaDTO>(response);
            return Ok(pessoaDto);
        }

        [HttpGet]
        [Route("obter-por-id/{id}")]
        public async Task<ActionResult> ObterPorId(int id)
        {
            var pessoa = await _pessoaService.ObterPorId(id);
            var pessoaDto = _mapper.Map<Pessoa, PessoaFisicaDTO>(pessoa);
            return Ok(pessoaDto);
        }

        [HttpGet]
        [Route("obter-juridica-por-id/{id}")]
        public async Task<ActionResult> ObterJuridicaPorId(int id)
        {
            var pessoa = await _pessoaService.ObterPorId(id);
            var pessoaDto = _mapper.Map<Pessoa, PessoaJuridicaDTO>(pessoa);
            return Ok(pessoaDto);
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public async Task<ActionResult> ExcluirPessoa(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }

            var response = await _pessoaService.Excluir(id);

            return Ok(response);
        }


    }
}