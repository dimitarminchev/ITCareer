using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
using RestApi.Model;
using RestApi.ViewModel;

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
        public IEnumerable<Message> Get()
        {
            return _dbContext.Messages;
        }

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
