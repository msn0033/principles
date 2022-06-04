using _SOLID_Dependency_Inversion_Principle_DIP.After;

namespace SOLID_Dependency_Inversion_Principle_DIP.After
{
    public class NotificationService
    {



        public IMessageService _MessageService { get; }

        public NotificationService(IMessageService messageService)
        {
            this._MessageService = messageService;

        }
        public void Notify()
        {
            _MessageService.Send();
        }
    }
}