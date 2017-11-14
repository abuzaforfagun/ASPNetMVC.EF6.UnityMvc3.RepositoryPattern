using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core;
using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core.Models;
using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRepository personRepository;
        private readonly IUnitOfWorkRepository unitOfWorkRepository;

        public HomeController(IPersonRepository personRepository, IUnitOfWorkRepository unitOfWorkRepository)
        {
            this.personRepository = personRepository;
            this.unitOfWorkRepository = unitOfWorkRepository;
        }

        public string Index()
        {
            Person person1 = new Person();
            person1.Name = "Name of a person";
            person1.Email = "p1@email.com";

            ApplicationDbContext context = new ApplicationDbContext();

            var list = personRepository.GetAll();
            var singlePerson = personRepository.Get(1);
            

            string html = "";
            html += singlePerson.Id + "<br/>";

            foreach (var p in list)
            {
                html += p.Name + "<br/>";
            }
            singlePerson.Name = "Fagun";
            personRepository.Add(person1);
            personRepository.Save();

            //unitOfWorkRepository.Complete() not working. It saves nothing.
            //unitOfWorkRepository.Complete();




            return html;
        }
        
    }
}