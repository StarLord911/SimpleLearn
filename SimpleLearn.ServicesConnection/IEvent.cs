using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.ServicesConnection
{
    public interface IEvent
    {
    }

    public class ItemCreatedIntegrationEvent : IEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public ItemCreatedIntegrationEvent(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
