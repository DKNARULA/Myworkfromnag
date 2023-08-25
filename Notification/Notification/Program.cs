using System;
using System.Collections.Generic;

// Observer / PubSub Pattern
public interface ISubscriber
{
    void Update(string message);
}

public class NotificationTopic
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }

    public void NotifySubscribers(string message)
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(message);
        }
    }
}

// Factory Pattern
public interface INotificationChannel
{
    void SendNotification(string recipient, string subject, string message);
}

public class EmailChannel : INotificationChannel
{
    public void SendNotification(string recipient, string subject, string message)
    {
        Console.WriteLine($"Sending email to {recipient}: {subject} - {message}");
    }
}

public class SMSChannel : INotificationChannel
{
    public void SendNotification(string recipient, string subject, string message)
    {
        Console.WriteLine($"Sending SMS to {recipient}: {subject} - {message}");
    }
}

public class NotificationFactory
{
    public INotificationChannel CreateEmailChannel()
    {
        return new EmailChannel();
    }

    public INotificationChannel CreateSMSChannel()
    {
        return new SMSChannel();
    }
}

// Singleton Pattern
public class NotificationManager
{
    private static NotificationManager instance;
    private Dictionary<string, List<string>> subscribers;

    private NotificationManager()
    {
        subscribers = new Dictionary<string, List<string>>();
    }

    public static NotificationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new NotificationManager();
            }
            return instance;
        }
    }

    public void AddSubscriber(string user, string topic)
    {
        if (!subscribers.ContainsKey(topic))
        {
            subscribers[topic] = new List<string>();
        }
        subscribers[topic].Add(user);
    }

    public void RemoveSubscriber(string user, string topic)
    {
        if (subscribers.ContainsKey(topic))
        {
            subscribers[topic].Remove(user);
        }
    }
}

// Strategy Pattern
public class NotificationFacade
{
    private NotificationFactory factory;

    public NotificationFacade()
    {
        factory = new NotificationFactory();
    }

    public void SendNotification(string user, string topic, string subject, string message)
    {
        var manager = NotificationManager.Instance;
        if (manager.subscribers.ContainsKey(topic) && manager.subscribers[topic].Contains(user))
        {
            var channel = GetNotificationChannel(topic);
            channel.SendNotification(user, subject, message);
        }
    }

    private INotificationChannel GetNotificationChannel(string topic)
    {
        if (topic == "Email")
        {
            return factory.CreateEmailChannel();
        }
        else if (topic == "SMS")
        {
            return factory.CreateSMSChannel();
        }
        throw new ArgumentException("Invalid topic.");
    }
}


