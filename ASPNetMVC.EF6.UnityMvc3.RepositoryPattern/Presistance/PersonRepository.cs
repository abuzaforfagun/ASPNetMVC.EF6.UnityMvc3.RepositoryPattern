using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core.Models;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Presistance
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext context;

        public PersonRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Add(Person person)
        {
            context.Persons.Add(new Person { Name = "person 2" });
            
        }

        public void Save()
        {
            context.SaveChanges();
        }
        public void AddRange(List<Person> persons)
        {
            context.Persons.AddRange(persons);
        }

        public Person Get(int id)
        {
            return context.Persons.SingleOrDefault(i => i.Id == id);
            
        }

        public List<Person> GetAll()
        {
            return context.Persons.ToList();
            
        }

        public void Remove(Person person)
        {
            context.Persons.Remove(person);
        }
    }
}