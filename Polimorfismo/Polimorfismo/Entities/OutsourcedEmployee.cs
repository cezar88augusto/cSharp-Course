

namespace Polimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AddicitonalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hour, double valuePerHour, double addicitonalCharge) : base(name, hour, valuePerHour)
        {
            AddicitonalCharge = addicitonalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddicitonalCharge;
        }


    }
}
