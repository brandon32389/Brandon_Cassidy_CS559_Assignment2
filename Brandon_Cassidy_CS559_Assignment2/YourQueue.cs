using System;
using System.Collections;

namespace Brandon_Cassidy_CS559_Assignment2
{
    class YourQueue : Queue
    {
        // Setting up the person dequeued event.
        public delegate void PersonDequeuedHandler(string Message);
        public event PersonDequeuedHandler PersonDequeued;

        // Setting up the non-person dequeued event.
        public delegate void NonPersonDequeuedHandler(string Message);
        public event NonPersonDequeuedHandler NonPersonDequeued;

        public override object Dequeue()
        {
            string message = "";
            if (this.GetType().ToString() == "Person")
            {
                //message = $"You successfully dequeued {this.firstName}. Their birthday is in x days!";
                RaisePersonDequeuedEvent(message);
            }
            else
            {
                RaisePersonDequeuedEvent(message);
            }
            return base.Dequeue();
        }

        private void RaisePersonDequeuedEvent(string message)
        {
            PersonDequeued(message);
        }
    }
}
