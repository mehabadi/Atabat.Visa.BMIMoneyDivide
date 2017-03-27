using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoundBoard.Data;

namespace SoundBoard.Components
{
    //[ViewComponent(Name = "LatestMessages")]
    public class LatestMessagesViewComponent: ViewComponent
    {
        private readonly MessageRepository _messages;

        public LatestMessagesViewComponent(MessageRepository messages)
        {
            _messages = messages;
        }
        public IViewComponentResult Invoke(int count)
        {
            var messages = _messages.GetAll().OrderByDescending(m => m.Created).Take(count);
            return View(messages);
        }
        //public IViewComponentResult Invoke()
        //{
        //    var messages = _messages.GetAll().OrderByDescending(m => m.Created).Take(5);
        //    return View(messages);
        //}
        //public IViewComponentResult InvokeAsync()
        //{
        //    var messages = _messages.GetAll().OrderByDescending(m => m.Created).Take(5);
        //    return View(messages);
        //}
    }
}
