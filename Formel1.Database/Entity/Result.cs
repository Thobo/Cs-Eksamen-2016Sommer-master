using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Formel1.Database.Entity
{
    public class Result
    {
        public int ResultId { get; set; }

        [Required]
        //[StringLength(24)]
        [DisplayName("Racerkører")]
        public int DriverId { get; set; }

        [Required]
        //[StringLength(20)]
        [DisplayName("Hold")]
        public int TeamId { get; set; }

        [Required]
        //[DataType(DataType.Time)]
        [DisplayName("Tid")]
        public DateTime? RaceTime { get; set; }

        //[Required]
        //[DataType(DataType.Time)]
        //public DateTime TimeAfterWinner { get; set; }

        [Required]
        public int Point { get; set; }

        [Required]
        [DisplayName("Omg.")]
        public int PlusLabs { get; set; }

        [Required]
        public int RaceId { get; set; }

        /// <summary>
        /// Did Not Finish
        /// </summary>
        [DisplayName("Udgået")]
        public string DNF { get; set; }
    }
}