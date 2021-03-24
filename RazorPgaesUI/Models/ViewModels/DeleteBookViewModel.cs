using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPgaesUI.Models.ViewModels
{
    public class DeleteBookViewModel
    {
        [Range(minimum:1,double.MaxValue)]
        public int Id { get; set; }
    }
}
