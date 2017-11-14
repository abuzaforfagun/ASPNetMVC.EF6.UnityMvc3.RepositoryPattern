using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core
{
    public interface IPersonRepository
    {
        void Add(Person person);
        void Remove(Person person);
        Person Get(int id);
        void AddRange(List<Person> persons);
        List<Person> GetAll();
        void Save();
    }
}