
namespace Polimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hour { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() // Para que outra classe possa herdar as propriedades desta classe, deve-se colocoar um constrrutor vazio.
        {

        }
        public Employee(string name, int hour, double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() // Para tornar o método OVERRIDE em outra classe, deve-se colcoar a palavras VIRTUAL
        {
            return Hour * ValuePerHour;
        }
    }
}
