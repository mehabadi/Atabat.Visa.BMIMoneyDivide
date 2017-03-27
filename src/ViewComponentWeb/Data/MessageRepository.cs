using SoundBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundBoard.Data
{
    public class MessageRepository
    {
        private static readonly List<Message> Messages = new List<Message>();
        private static int IdCount = 0;
        private const string UserIdOne = "44d9e03a-95f6-4f3f-b2b7-b7ec3bd114d7";
        private const string UserIdTwo = "66d80f20-817e-43ba-90cd-c674bfcc9c7b";

        static MessageRepository()
        {
            Messages.Add(new Message
            {
                Id = GetNextId(),
                UserId = UserIdOne,
                Created = new DateTime(2015, 6, 1),
                MessageTitle = "First Message",
                MessageContent = "This is the first message"
            });

            Messages.Add(new Message
            {
                Id = GetNextId(),
                UserId = UserIdOne,
                Created = new DateTime(2015, 6, 2),
                MessageTitle = "Second Message",
                MessageContent = "Hi Mom!"
            });

            Messages.Add(new Message
            {
                Id = GetNextId(),
                UserId = UserIdTwo,
                Created = new DateTime(2015, 6, 3),
                MessageTitle = "Third Message",
                MessageContent = "Hello, ASP.NET MVC 6!"
            });
        }

        public IEnumerable<Message> GetAll()
        {
            return Messages.ToArray();
        }

        public IEnumerable<Message> GetByUserId(string userId)
        {
            return Messages.Where(m => m.UserId == userId).ToArray();
        }

        public Message GetBy(int id)
        {
            return Messages.SingleOrDefault(m => m.Id == id);
        }

        public void Update(Message message)
        {
            // TODO: nothing
        }

        public void Add(Message message)
        {
            message.Id = GetNextId();
            Messages.Add(message);
        }

        private static int GetNextId()
        {
            return ++IdCount;
        }

        
    }
}
