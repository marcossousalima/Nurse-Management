using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Commands.Exit;
using Domain.Commands.Inputs.Hospital;
using Domain.Entities;
using Domain.Handles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Commands;

namespace Api.Controllers
{
    [Route("api/v1/hospital")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly CommandHandlerHospital _commandHandlerHospital;
        private readonly CommandHandlerNurse _commandHandlerNurse;

        public HospitalController(CommandHandlerHospital commandHandlerHospital, CommandHandlerNurse commandHandlerNurse)
        {
            _commandHandlerHospital = commandHandlerHospital;
            _commandHandlerNurse = commandHandlerNurse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// GET: api/v1/hospital/
        [HttpGet]
        public async Task<IEnumerable<Hospital>> Get()
        {
            var response = await _commandHandlerHospital.GetAll();
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// GET: api/v1/hospital/id
        [HttpGet("{id}")]
        public async Task<Hospital> Get(Guid id)
        {
            var response = await _commandHandlerHospital.GetById(id);
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CommandCreateHospital"></param>
        /// <returns></returns>
        /// POST: api/v1/hospital/
        [HttpPost]
        public async Task<ICommandExit> Post([FromBody] CreateHospitalCommand createHospitalCommand)
        {
            var response = await _commandHandlerHospital.Handler(createHospitalCommand);
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="CommadUpdateHospital"></param>
        /// <returns></returns>
        /// PUT: api/v1/hospital/id
        [HttpPut("{id}")]
        public async Task<ICommandExit> Put(Guid id, [FromBody] UpdateHospitalCommand updateHospitalCommand)
        {
            updateHospitalCommand.Id = id;
            var response = await _commandHandlerHospital.Handler(updateHospitalCommand);
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// DELETE: api/v1/hospital/id
        [HttpDelete("{id}")]
        public async Task<ICommandExit> Delete(Guid id)
        {
            var nurse = _commandHandlerNurse.BuscarNursePerHospital(id);
            var hospital = _commandHandlerHospital.GetById(id);
            if (hospital != null || nurse != null)
            {
                await _commandHandlerNurse.DeletePerHospital(id);
                await _commandHandlerHospital.Delete(id);
                return new CommandExit(true, "Hospital Deletado Com Sucesso", null);
            }
            return new CommandExit(false, "Erro ao deletar Hospital", null);
        }
    }
}