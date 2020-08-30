using ClasseAbstrata2.Entities.Enums; // Tem que chamar a pasta

namespace ClasseAbstrata2.Entities
{
    abstract class Shape // Classe abstrata! Existem várias formas geométricas (shape)
    {
        public Color Color { get; set; }

   

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double area(); //método abstrato para ser chamado em outras classes.
    }
}
