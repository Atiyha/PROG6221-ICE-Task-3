using System;

namespace AlarmSystem
{
    // Task 1: Declare the delegate
    delegate void AlarmHandler();

    // Task 2: Create the Alarm class
    class Alarm
    {
        // Declare the event using the delegate type
        public event AlarmHandler OnAlarmTriggered;

        // Method to trigger the alarm
        public void TriggerAlarm()
        {
            Console.WriteLine("Alarm is triggered!");

            // Call the event using Invoke()
            // The null check ensures there are subscribers before invoking
            OnAlarmTriggered?.Invoke();
        }
    }

    class Program
    {
        // Task 3: Subscriber method
        static void RespondToAlarm()
        {
            Console.WriteLine("Warning! Take action immediately!");
        }

        // Task 4: Main method
        static void Main(string[] args)
        {
            // Create an object of Alarm
            Alarm alarm = new Alarm();

            // Subscribe RespondToAlarm to the event using +=
            alarm.OnAlarmTriggered += RespondToAlarm;

            // Trigger the alarm
            alarm.TriggerAlarm();
        }
    }
}