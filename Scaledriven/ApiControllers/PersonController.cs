using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Scaledriven.Areas.Association.Database;
using Scaledriven.Areas.Association.Design;
using Scaledriven.Areas.Association.Models;
using Scaledriven.Areas.Shared.Services;

namespace Scaledriven.ApiControllers
{
    public class PersonController : AssociationApiControllerBase
    {
        private readonly AssociationDbContext _context;
        private readonly IFactory<Person> _factory;

        public PersonController(AssociationDbContext context, IFactory<Person> factory) : base(context)
        {
            _context = context;
            _factory = factory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_context.Persons.Select( p => p));
        }

        [HttpGet]
        public IActionResult Factory() => Ok(_factory.CreateMany());

        [HttpPost("Seed")]
        public IActionResult Seed()
        {
            _context.Persons.AddRange(_factory.CreateMany());
            return Ok(new ModelCreationAct
            {
                ModelCreationSource = ModelCreationSource.Source,
                ModelName = nameof(Person)
            });
        }
    }
}
