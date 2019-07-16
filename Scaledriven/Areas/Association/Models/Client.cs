using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Areas.Association.Models
{
    public class Client : Person
    {
        public IEnumerable<Purchase> Purchases { get; set; }
        public IEnumerable<Inquire> Inquires { get; set; }
    }

    /**
     * for now, inquires and purchases differ only in signature
     */
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public Client Client { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public string CompanyId { get; set; }
    }

    public class Inquire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public Client Client { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public string CompanyId { get; set; }
    }
}
