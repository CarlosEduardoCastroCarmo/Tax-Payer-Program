using System.Text;
using System.Globalization;

namespace TaxPayerCourse.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployee) :
            base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double Tax()
        {
            double anualTax = 0;

            if(NumberOfEmployee > 10)
            {
                anualTax = (AnualIncome * 0.14);
            }
            else
            {
                anualTax = AnualIncome * 0.16;
            }

            return anualTax;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + ": " + "$ " + Tax().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
