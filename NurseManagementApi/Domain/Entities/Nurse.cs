using Flunt.Validations;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Nurse : Entity
    {
        public Nurse()
        {

        }
        public Nurse(string name, string cpf, DateTime birthDate, string coren, Guid id_Hospital)
        {
            CPF = cpf;
            if (!ValidateCpf(CPF))
                AddNotification("CPF", "O CPF informado é inválido.");
            Name = name;
            BirthDate = birthDate;
            Coren = coren;
            Id_Hospital = id_Hospital;
        }

        public string Name { get; private set; }
        public string CPF { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Coren { get; private set; }
        public Guid Id_Hospital { get; private set; }

        //Variavel Auxiliar
        public string NameHospital { get; set; }

        public void UpdateNurse(string name, string cpf, DateTime birthDate, string coren, Guid id_Hospital)
        {

            CPF = cpf;
            if (!ValidateCpf(CPF))
                AddNotification("CPF", "O CPF informado é inválido.");
            Name = name;
            BirthDate = birthDate;
            Coren = coren;
            Id_Hospital = id_Hospital;
        }
        private bool ValidateCpf(string cpf)
        {
            var multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            var tempCpf = cpf.Substring(0, 9);
            var soma = 0;

            for (var i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            var resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            var digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (var i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
