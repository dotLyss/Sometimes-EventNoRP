using LabApi.Events.Arguments.ServerEvents;
using LabApi.Events.CustomHandlers;
using LabApi.Features.Wrappers;

namespace Sometimes_EventNoRP
{
    public class EventsHandler : CustomEventsHandler
    {
        private readonly Config _config;
        public EventsHandler(Config config)
        {
            _config = config;
        }
        
        protected void SubscribeEvents()
        {
            LabApi.Events.Handlers.ServerEvents.RoundStarting += OnServerRoundStarted;
        }

        protected void UnsubscribeEvents()
        {
            LabApi.Events.Handlers.ServerEvents.RoundStarting -= OnServerRoundStarted;
        }
        public void OnServerRoundStarted(RoundStartingEventArgs ev)
        {
            
            System.Random random = new System.Random();
            int randomValue = random.Next(100);
            bool isNoRP = randomValue < _config.NoRPPercentage;
            
            string message = isNoRP ? _config.MessageNoRP : _config.MessageRP;

            foreach (var player in Player.List)
            {
                player.SendBroadcast(message, _config.BroadcastDuration);
            }
        }
    }
}