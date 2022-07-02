public abstract class State
{
    public abstract void SendNotification(string message);
    public abstract void StateChangeCheck(NotificationService notificationService);
}
