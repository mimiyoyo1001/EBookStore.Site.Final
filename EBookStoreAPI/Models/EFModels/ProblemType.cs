﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EBookStoreAPI.Models.EFModels
{
    public partial class ProblemType
    {
        public ProblemType()
        {
            CustomerServiceMails = new HashSet<CustomerServiceMails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerServiceMails> CustomerServiceMails { get; set; }
    }
}