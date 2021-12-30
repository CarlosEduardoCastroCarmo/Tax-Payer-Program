using System.Globalization;
using System.Text;

namespace TaxPayerCourse.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double anualTax = 0.00;

            if(AnualIncome > 20000)
            {
                anualTax = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
            else
            {
                anualTax = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
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
