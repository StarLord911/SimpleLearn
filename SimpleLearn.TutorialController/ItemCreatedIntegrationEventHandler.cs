using EventBus.Base.Standard;
using SimpleLearn.ServicesConnection;
using System;

namespace SimpleLearn.TutorialController
{
    public class ItemCreatedIntegrationEventHandler : IIntegrationEventHandler<ItemCreatedIntegrationEvent>
    {
        public ItemCreatedIntegrationEventHandler()
        {
        }

        public async Task Handle(ItemCreatedIntegrationEvent @event)
        {
            //Handle the ItemCreatedIntegrationEvent event here.
        }
    }
}
