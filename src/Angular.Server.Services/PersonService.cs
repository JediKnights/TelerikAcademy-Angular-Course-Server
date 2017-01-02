namespace Angular.Server.Services
{
    using System;
    using System.Linq;

    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;
    using Abstractions;

    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public IQueryable<Person> All()
        {
            return this.personRepository.All();
        }

        public Person GetById(Guid id)
        {
            return this.personRepository.GetById(id);
        }

        public void Add(Person person)
        {
            this.personRepository.Add(person);
            this.personRepository.SaveChanges();
        }

        public void Update(Person person)
        {
            this.personRepository.Update(person);
            this.personRepository.SaveChanges();
        }

        public void Delete(Person person)
        {
            this.personRepository.Delete(person);
            this.personRepository.SaveChanges();
        }

        public void HardDelete(Person person)
        {
            this.personRepository.HardDelete(person);
            this.personRepository.SaveChanges();
        }
    }
}
