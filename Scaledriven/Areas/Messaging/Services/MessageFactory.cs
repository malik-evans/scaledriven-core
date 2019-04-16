using System;
using System.Linq;
using Scaledriven.Areas.Messaging.Models;
using Scaledriven.Interfaces;

namespace Scaledriven.Areas.Messaging.Services
{
    public class MessageFactory<T> : CreatorBase<T> where T : Message, new()
    {
        public override T Create()
        {
            return new T
            {
                SenderId = new Guid().ToString(),
                Text = Faker.Lorem.Sentences(3).First()
            };
        }

    }
}