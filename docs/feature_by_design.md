### Feature By Design
_________

**Key Namespaces** -  Application parts
- Application Design - [Scaledriven.Api.Areas]()
- ApiControllers - [Scaledriven.Api.Areas]()
- Database Models  - [Scaledriven.Core.DataAccess.Models]()
- Services Layer - [Scaledriven.Core.Services]()

**Bare Bones of Core**
- Interface - Any interface targeted by [Scaledriven.sln]() csproj 
- Entity - Database Models
- Document - A Razor page
___

Feature Composition
-----------------

A feature begins in Scaledriven.Core. If a requisite model does not exist, create one in
in the `Scaledriven.Core.DataAccess.Models` namespace.


```
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Core.DataAccess.Models
{
    public class Message
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Content { get; set; }
    }
}
```

Register the model as a DatabaseField.

```
using Microsoft.EntityFrameworkCore;
using Scaledriven.Core.DataAccess.Models;

namespace Scaledriven.Core.DataAccess
{
    public class CoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public CoreDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("Scaledriven");
        }

    }
}

```

Lets say the feature is base on a user's action. The action should be represented as a controller method.
By design standards, the action should be represented as an interface member.

```
using System.Collections.Generic;
using Scaledriven.Core.DataAccess.Models;

namespace Scaledriven.Core.AspNetCore.Design
{
    public interface IMessageController
    {
        IEnumerable<Message> Index();
    }
}
```

Define the action in the controller. Don't forget to comment!

```
using Microsoft.AspNetCore.Mvc;
using Scaledriven.Core.AspNetCore.Design;

namespace Scaledriven.Api.Areas.Messaging
{
    [Area("Api/Messaging")]
    [Route("[area]/[controller]")]
    public class MessageController : Controller, IMessageController
    {

        /// <summary>
        /// Get All Commments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}

```

For database access inject `Scaledriven.Core.DataAccess.CoreDbContext`
```
using Microsoft.AspNetCore.Mvc;
using Scaledriven.Core.AspNetCore.Design;
using Scaledriven.Core.DataAccess;

namespace Scaledriven.Api.Areas.Messaging
{
    [Area("Api/Messaging")]
    [Route("[area]/[controller]")]
    public class MessageController : Controller, IMessageController
    {

        private readonly CoreDbContext _coreDbContext;

        public MessageController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }

        /// <summary>
        /// Get All Commments
        /// </summary>
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_coreDbContext.Messages);
        }
        
        /// <summary>
        /// Respond with a fake message
        /// </summary>
        [HttpGet]
        public IActionResult Fake()
        {
            return Ok(new Message {Content = "The bad weather is fine with the admins"});
        }
    }
}
```
Scaledrive.Api uses swagger specification. Confirm the result from swagger-ui `http://localhost:5001/swagger` or any httpClient. 

Boot the API app and confirm the api path from the swagger Endpoint  `http://localhost:5001/swagger/v1/swagger.json`
```
...
"paths": 
    "/Api/Messaging/Message": {
          "get": {
            "tags": [
              "Message"
            ],
            "summary": "Get All Commments",
            "operationId": "Index",
            "consumes": [],
            "produces": [
              "text/plain",
              "application/json",
              "text/json"
            ],
...
```
