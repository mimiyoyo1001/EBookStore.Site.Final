﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EBookStoreAPI.Models.EFModels
{
    public partial class Authors
    {
        public Authors()
        {
            BookAuthors = new HashSet<BookAuthors>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Profile { get; set; }

        public virtual ICollection<BookAuthors> BookAuthors { get; set; }
    }
}