var context = new NotificationService();
context.SendNotification("test 1");
context.SendNotification("test 2");
context.SendNotification("test 3");
context.SendNotification("test 4");
FireBaseState.IsActive = false;
context.SendNotification("test 5");
context.SendNotification("test 6");
context.SendNotification("test 7");
context.SendNotification("test 8");
context.SendNotification("test 9");
Console.ReadKey();

//can use circuit breacker 
//can use Load Balancing 