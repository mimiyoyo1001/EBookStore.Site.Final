﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EBookStoreAPI.Models
{
    public partial class Ebooks
    {
        public Ebooks()
        {
            EbookOrders = new HashSet<EbookOrders>();
        }

        public int Id { get; set; }
        public int BookId { get; set; }
        public decimal Price { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Books Book { get; set; }
        public virtual ICollection<EbookOrders> EbookOrders { get; set; }
    }
}