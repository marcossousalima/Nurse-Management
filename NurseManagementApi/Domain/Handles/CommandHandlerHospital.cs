using Domain.Commands.Exit;
using Domain.Commands.Inputs.Hospital;
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
    public class CommandHandlerHospital : Notifiable, ICommandHandler<CreateHospitalCommand>,
        ICommandHandler<UpdateHospitalCommand>
    {
        private readonly IHospitalRepository _hospitalRepository;
        public CommandHandlerHospital(IHospitalRepository hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        public async Task<ICommandExit> Handler(CreateHospitalCommand command)
        {
            Hospital hospital = new Hospital(command.Name, command.CNPJ, command.State, command.City, command.Number, command.Complement, command.Neighborhood);
            if (Invalid)
            {
                return new CommandExit(false, "Não foi possivel realizar o cadastro", hospital);
            }

            await Task.Factory.StartNew(() =>
            {
                _hospitalRepository.Create(hospital);
            });
            return new CommandExit(true, "Cadastro Realizado Com Sucesso", null);
        }

        public async Task<ICommandExit> Handler(UpdateHospitalCommand command)
        {
            Hospital hospital = await _hospitalRepository.GetById(command.Id);
            hospital.UpdateHospital(command.Name, command.CNPJ, command.State, command.City, command.Number, command.Complement, command.Neighborhood);
            if (Invalid)
            {
                return new CommandExit(false, "Não foi possivel atualizar o cadastro", hospital);
            }

            await Task.Factory.StartNew(() =>
            {
                _hospitalRepository.Update(hospital);
            });
            return new CommandExit(true, "Cadastro Atualizado Com Sucesso", null);
        }

        public async Task<Hospital> GetById(Guid Id)
        {
            var response = await _hospitalRepository.GetById(Id);
            return response;
        }

        public async Task<IEnumerable<Hospital>> GetAll()
        {
            var response = await _hospitalRepository.GetAll();
            return response;
        }

        public async Task<ICommandExit> Delete(Guid Id)
        {
            await Task.Factory.StartNew(() =>
            {
                _hospitalRepository.Delete(Id);
            });

            return new CommandExit(true, "Registro Deletado Com Successo", null);
        }
    }
}
