using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoundBoard.Data;
using SoundBoard.Services;

namespace SoundBoard.Components
{    
    public class EditMessageViewComponent: ViewComponent
    {
        private readonly MessageRepository _messages;
        private readonly ViewMessageService _service;

        public EditMessageViewComponent(MessageRepository messages, ApplicationDbContext dbContext)
        {
            _messages = messages;
            _service = new ViewMessageService(messages, dbContext);
        }
        //public EditMessageViewComponent()
        //{            
        //}
        //public IViewComponentResult Invoke()
        //{            
        //   return View();
        //}

        public IViewComponentResult Invoke(int id)
        {
            var message = _messages.GetBy(id);

            if (message == null)
            {
                //return HttpNotFound();
            }

            return View(message);
        }

        //[HttpPost]
        //public IViewComponentHelper Update()
        //{
        //    return View();
        //}
    }
}
