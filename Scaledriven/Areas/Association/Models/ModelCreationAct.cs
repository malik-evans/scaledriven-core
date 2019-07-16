using System;
using System.ComponentModel.DataAnnotations;

namespace Scaledriven.Areas.Association.Models
{
    // todo factory alternative definition, preferably strings over ints for enums like with typescript
    public enum ModelCreationSource
    {
        /// <summary>
        /// The record was created from a user's action
        /// </summary>
        User,

        /// <summary>
        /// The record was created by application computation
        /// </summary>
        Application,

        /// <summary>
        /// The record was created somewhere within the source, Such as a factory or seeder
        /// </summary>
        Source
    }

    public class ModelCreationAct
    {
        [DataType(DataType.Time)]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        [Required]
        public string ModelName { get; set; }

        /// <summary>
        /// Wether the record was created yb
        /// </summary>
        [Required]
        public ModelCreationSource ModelCreationSource { get; set; }
    }
}
