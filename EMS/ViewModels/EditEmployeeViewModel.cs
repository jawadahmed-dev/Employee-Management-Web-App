using DemoDotNetCore.Models;
using EMS.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DemoDotNetCore.ViewModels
{
	public class EditEmployeeViewModel
	{
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public Department? Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
