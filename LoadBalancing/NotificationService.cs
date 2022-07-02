public class NotificationService
{
    State state;
    static NotificationService() 
    {
        FireBaseState.Start();
        ParseState.Start();
    }

    public NotificationService() => this.State = new ParseState();
    
    public NotificationService(State state) => this.State = state;

    public State State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("notification service: " + state.GetType().Name);
        }
    }
    public void SendNotification(string message)
    {
        state.SendNotification(message);
        state.StateChangeCheck(this);
    }
}
