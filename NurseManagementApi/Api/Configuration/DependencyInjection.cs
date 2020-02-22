using Domain.Commands.Exit;
using Domain.Commands.Inputs.Hospital;
using Domain.Commands.Inputs.Nurse;
using Domain.Handles;
using Domain.Repositories;
using Infra.Configuration;
using Infra.Connection;
using Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection Dependencies(this IServiceCollection services)
        {
            //base de dados
            services.AddSingleton<IdbConfiguration, AppConfiguration>();
            services.AddSingleton<IDB, MSSQLDB>();

            //repositorios
            services.AddTransient<INurseRepository, NurseRepository>();
            services.AddTransient<IHospitalRepository, HospitalRepository>();

            //comandos de entrada
            services.AddTransient<ICommandInput, CreateHospitalCommand>();
            services.AddTransient<ICommandInput, UpdateHospitalCommand>();

            services.AddTransient<ICommandInput, CreateNurseCommand>();
            services.AddTransient<ICommandInput, UpdateNurseCommand>();

            //comandos saida
            services.AddTransient<ICommandExit, CommandExit>();

            //Manipuladores
            services.AddTransient<CommandHandlerHospital>();
            services.AddTransient<CommandHandlerNurse>();

            return services;
        }
    }
}

