﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
    }
}