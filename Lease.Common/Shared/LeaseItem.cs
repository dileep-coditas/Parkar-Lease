using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lease.Common.Shared
{
    [Table("tbl_Lease")]
    public class LeaseItem
    {
        public LeaseItem()
        {
        }

        [Dapper.Contrib.Extensions.Key]
        public int LeaseId { get; set; }

        [MaxLength(50)]
        public string StreetAddress { get; set; }

        [MaxLength(50)]
        public string Appartement { get; set; }

        [MaxLength(20)]
        public string City { get; set; }
        public int StateId { get; set; }

        [Required(ErrorMessage = "Zip Code is required.")]
        [MinLength(5, ErrorMessage = "Please enter valid zip code.")]
        [MaxLength(5, ErrorMessage = "Please enter valid zip code.")]
        [RegularExpression("^\\b\\d{5}\\b$", ErrorMessage = "Please enter valid zip code.")]
        public string ZipCode { get; set; }

        [Range(1, int.MaxValue, ErrorMessage ="Select valid term.")]
        public int TermId { get; set; }
    }
}
