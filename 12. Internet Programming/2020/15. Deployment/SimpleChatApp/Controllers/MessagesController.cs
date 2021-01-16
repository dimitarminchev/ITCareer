using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
using RestApi.Model;
using RestApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly MessagesContext _dbContext;

        public MessagesController(MessagesContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Message> Get() =>
            _dbContext.Messages.OrderBy(f => f.CreatedOn).Take(100);

        [HttpPost]
        [Route("create")]
        public async Task Post([FromBody]MessageViewModel viewModel)
        {
            _dbContext.Messages.Add(new Message
            {
                Id = Guid.NewGuid(),
                Content = viewModel.Content,
                CreatedOn = DateTime.UtcNow,
                User = viewModel.User
            });
            await _dbContext.SaveChangesAsync();
        }

        [HttpPut("edit/{id}")]
        public async Task Put(Guid id, [FromBody]string content)
        {
            var message = await _dbContext.Messages.FindAsync(id);
            message.Content = content;
            _dbContext.Update(message);
            await _dbContext.SaveChangesAsync();
        }

        [HttpDelete("delete/{id}")]
        public async Task Delete(Guid id)
        {
            var message = await _dbContext.Messages.FindAsync(id);
            _dbContext.Remove(message);
            await _dbContext.SaveChangesAsync();
        }
    }
}
