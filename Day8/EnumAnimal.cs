using System;

namespace N_EnumAnimal
{
    internal class EnumAnimal
    {
        enum Animal { Mouse, Cow, Tiger } //0, 1, 2 인덱스 값을 가짐
        
        public void EnumAnimalEx()
        {
            Animal animal = Animal.Tiger;
            Console.WriteLine(animal);

            if (animal == Animal.Tiger)
            {
                Console.WriteLine("호랑이");
            }
        }
    }
}
