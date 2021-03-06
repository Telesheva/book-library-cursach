using Book_Library_Repository_EF_Core.Models.Book;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Library_ASP.NET_Core_MVC.Models.Books
{
    [ModelMetadataType(typeof(ActionBookModelMetadata))]
    public class UpdateBookModel : BookItem
    {
        public string UpdateBookMassege { get; set; }

        public UpdateBookModel() { }

        public UpdateBookModel(BookItem bookItem) : base(bookItem) { }
    }
}
