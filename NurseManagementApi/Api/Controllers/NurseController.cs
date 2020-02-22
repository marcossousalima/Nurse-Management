using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Commands.Exit;
using Domain.Commands.Inputs.Nurse;
using Domain.Entities;
using Domain.Handles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Commands;

namespace Api.Controllers
{
    [Route("api/v1/nurse")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly CommandHandlerNurse _commandHandlerNurse;

        public NurseController(CommandHandlerNurse commandHandlerNurse)
        {
            _commandHandlerNurse = commandHandlerNurse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// GET: api/v1/nurse/
        [HttpGet]
        public async Task<IEnumerable<Nurse>> Get()
        {
            var response = await _commandHandlerNurse.GetAll();
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// GET: api/v1/hospital/id
        [HttpGet("{id}")]
        public async Task<Nurse> Get(Guid id)
        {
            var response = await _commandHandlerNurse.GetById(id);
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CommandCreateHospital"></param>
        /// <returns></returns>
        /// POST: api/v1/hospital/
        [HttpPost]
        public async Task<ICommandExit> Post([FromBody] CreateNurseCommand createNurseCommand)
        {
            var response = await _commandHandlerNurse.Handler(createNurseCommand);
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="CommadUpdateHospital"></param>
        /// <returns></returns>
        /// PUT: api/v1/nuser/id
        [HttpPut("{id}")]
        public async Task<ICommandExit> Put(Guid id, [FromBody] UpdateNurseCommand updateNurseCommand)
        {
            updateNurseCommand.Id = id;
            var response = await _commandHandlerNurse.Handler(updateNurseCommand);
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// DELETE: api/v1/nurse/id
        [HttpDelete("{id}")]
        public async Task<ICommandExit> Delete(Guid id)
        {
            var nurse = _commandHandlerNurse.GetById(id);
            if (nurse != null)
            {
                await _commandHandlerNurse.Delete(id);
                return new CommandExit(true, "Enfermeiro Deletado Com Sucesso", null);
            }
            return new CommandExit(false, "Erro ao deletar Enfemeiro", null);
        }

    }
}