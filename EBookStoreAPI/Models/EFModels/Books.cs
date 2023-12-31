﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EBookStoreAPI.Models.EFModels
{
    public partial class Books
    {
        public Books()
        {
            Articles = new HashSet<Articles>();
            BookAuthors = new HashSet<BookAuthors>();
            BookImages = new HashSet<BookImages>();
            Carts = new HashSet<Carts>();
            Comments = new HashSet<Comments>();
            Ebooks = new HashSet<Ebooks>();
            OrderItems = new HashSet<OrderItems>();
            PurchaseOrderHistory = new HashSet<PurchaseOrderHistory>();
            PurchaseOrders = new HashSet<PurchaseOrders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Summary { get; set; }
        public string Isbn { get; set; }
        public string Eisbn { get; set; }
        public int Stock { get; set; }
        public bool? Status { get; set; }
        public decimal Price { get; set; }
        public int? Discount { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Publishers Publisher { get; set; }
        public virtual ICollection<Articles> Articles { get; set; }
        public virtual ICollection<BookAuthors> BookAuthors { get; set; }
        public virtual ICollection<BookImages> BookImages { get; set; }
        public virtual ICollection<Carts> Carts { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Ebooks> Ebooks { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
        public virtual ICollection<PurchaseOrderHistory> PurchaseOrderHistory { get; set; }
        public virtual ICollection<PurchaseOrders> PurchaseOrders { get; set; }
    }
}