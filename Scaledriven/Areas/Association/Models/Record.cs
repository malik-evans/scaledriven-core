using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Areas.Association.Models
{
    public class RecordSection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        /// <summary>
        /// Content of the record section such as file data
        /// </summary>
        [DataType(DataType.Text)]
        public string Content { get; set; }
    }

    public class Record
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }


        /// <example>
        ///   new Record
        /// {
        ///    SubjectType = nameof(Models.Manager)
        /// }
        /// </example>
        [Required]
        public string SubjectType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        public IEnumerable<RecordSection> Sections { get; set; }

    }
}
