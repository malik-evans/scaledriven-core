using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Scaledriven.Areas.Messaging.Models;
using Scaledriven.Database;
using Scaledriven.Interfaces;

namespace Scaledriven.Areas.Messaging.Controllers
{
  [Area("Messaging")]
  [ApiController]
  [Route("api/[area]/[controller]")]
  public class MessageController : ControllerBase
  {

    protected readonly ICreator<Message> _messageFactory;

    protected readonly ApplicationDbContext _applicationDbContext; 

    public MessageController(ICreator<Message> messageFactory, ApplicationDbContext dbContext)
    {
      _messageFactory = messageFactory;
      _applicationDbContext = dbContext;
      
      _applicationDbContext.Messages.AddRange(_messageFactory.CreateMany(50));
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Message>), 200)]
    public JsonResult Index() => new JsonResult(_messageFactory.CreateMany(20));
    
    [HttpGet("Database")]
    [ProducesResponseType(typeof(IEnumerable<Message>), 200)]
    public JsonResult Database() => 
      new JsonResult(_applicationDbContext.Messages.Select( m => m));
    
    [HttpGet("Show")]
    public JsonResult Show() => new JsonResult(_messageFactory.Create());


  }
}