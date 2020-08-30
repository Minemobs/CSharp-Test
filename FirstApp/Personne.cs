using System;
namespace FirstApp
{
    class Personne
    {
        private int _age;

        public int Age
        {
            get
            {
                if(_age == 0)
                {
                    return 100;
                }
                else
                {
                    return _age;
                }
            }
            set
            {
                if(value > 0 && value < 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("L'age doit être compris entre 0 et 100.");
                }
            }
        }
    }
}