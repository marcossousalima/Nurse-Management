using Flunt.Validations;
using Shared.Entities;

namespace Domain.Entities
{
    public class Hospital : Entity
    {
        public Hospital()
        {

        }
        public Hospital(string name, string cnpj, string state, string city, int number, string complement, string neighborhood)
        {
            CNPJ = cnpj;
            if (!ValidateCnpj(CNPJ))
                AddNotification("CNPJ", "O CNPJ informado é inválido.");
            Name = name;
            State = state;
            City = city;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
        }

        public void UpdateHospital(string name, string cnpj, string state, string city, int number, string complement, string neighborhood)
        {
            CNPJ = cnpj;
            if (!ValidateCnpj(CNPJ))
                AddNotification("CNPJ", "O CNPJ informado é inválido.");
            Name = name;
            State = state;
            City = city;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
        }

        public string Name { get; private set; }
        public string CNPJ { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public int Number { get; private set; }
        public string Complement { get; private set; }
        public string Neighborhood { get; private set; }


        private bool ValidateCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}
