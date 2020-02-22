using Domain.Commands.Exit;
using Domain.Commands.Inputs.Nurse;
using Domain.Entities;
using Domain.Repositories;
using Flunt.Notifications;
using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Handles
{
  public  class CommandHandlerNurse : Notifiable, ICommandHandler<CreateNurseCommand>,
        ICommandHandler<UpdateNurseCommand>
    {
        private readonly INurseRepository _nurseRepository;
        public CommandHandlerNurse(INurseRepository nurseRepository)
        {
            _nurseRepository = nurseRepository;
        }

        public async Task<ICommandExit> Handler(CreateNurseCommand command)
        {
            Nurse nurse = new Nurse(command.Name, command.CPF, command.BirthDate, command.Coren, command.Id_Hospital);
            if (Invalid)
            {
                return new CommandExit(false, "Erro ao cadastrar Nurse", nurse);
            }

            await Task.Factory.StartNew(() =>
            {
                _nurseRepository.Create(nurse);
            });

            return new CommandExit(true, "Cadastro Realizado Com Sucesso", nurse);
        }

        public async Task<ICommandExit> Handler(UpdateNurseCommand command)
        {
            Nurse nurse = await _nurseRepository.GetById(command.Id);
            nurse.UpdateNurse(command.Name, command.CPF, command.BirthDate, command.Coren, command.Id_Hospital);
            if (Invalid)
            {
                return new CommandExit(false, "Erro ao cadastrar Nurse", nurse);
            }

            await Task.Factory.StartNew(() =>
            {
                _nurseRepository.Update(nurse);
            });

            return new CommandExit(true, "Atualização Realizado Com Sucesso", nurse);
        }

        public async Task<Nurse> GetById(Guid Id)
        {
            var response = await _nurseRepository.GetById(Id);
            return response;
        }

        public async Task<IEnumerable<Nurse>> GetAll()
        {
            var response = await _nurseRepository.GetAll();
            return response;
        }

        public async Task<ICommandExit> Delete(Guid Id)
        {
            await Task.Factory.StartNew(() =>
            {
                _nurseRepository.Delete(Id);
            });

            return new CommandExit(true, "Registro Deletado Com Successo", null);
        }

        public async Task<ICommandExit> DeletePerHospital(Guid id)
        {
            await Task.Factory.StartNew(() =>
            {
                _nurseRepository.DeleteNursePerHospital(id);
            });
            return new CommandExit(true, "Enfermeiros Deletado com sucesso", null);
        }

        public async Task<IEnumerable<Nurse>> BuscarNursePerHospital(Guid id)
        {
            var response = await _nurseRepository.GetAllPerHospital(id);
            return response;
        }
    }
}
