public class FireBaseState : State
{    
    private static bool IsActive;
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
    public static bool Status() => IsActive;

    public override void StateChangeCheck(NotificationService notificationService)
    {
        if (ParseState.Status())
            notificationService.State = new ParseState();
    }
}
