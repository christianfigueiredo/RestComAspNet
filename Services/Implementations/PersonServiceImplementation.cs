using RestComAspNet.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RestComAspNet.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int  i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }       

        public Person FindById(long id)
        {
           return new Person 
           { 
               Id = IncrementAndGet(),
               PrimeiroNome = "José",
               Sobrenome = "Ríos",
               Endereco = "Rio das Ostras - RJ",
               Genero = "Masculino"
           };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                PrimeiroNome = "Nome pessoa" + i,
                Sobrenome = "Sobrenome Pessoa" + i,
                Endereco = "Um endereco" + i,
                Genero = "Masculino"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
