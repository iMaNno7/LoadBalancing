public class ParseState : State
{
    public static bool IsActive;
    
    public override void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
    public static void Start()
    {
        IsActive = true;
    }

    public static void Stop()
    {
        IsActive = false;
    }

    public override void StateChangeCheck(NotificationService notificationService)
    {
        if (FireBaseState.IsActive)
            notificationService.State = new FireBaseState();
    }
}
