using System;
using System.Collections;

namespace Brandon_Cassidy_CS559_Assignment2
{
    class YourQueue : Queue
    {
        // Setting up the person dequeued event.
        public delegate void PersonDequeuedHandler(Person p);
        public event PersonDequeuedHandler PersonDequeued;

        // Setting up the non-person dequeued event.
        public delegate void NonPersonDequeuedHandler(Object o);
        public event NonPersonDequeuedHandler NonPersonDequeued;

        public override object Dequeue()
        {
            string type = this.Peek().GetType().Name;
            if (this.Peek().GetType().Name == "Person")
            {
                Person p = new Person();
                p = (Person)this.Peek();
                RaisePersonDequeuedEvent(p);
            }
            else
            {
                Object o = new Object();
                o = this.Peek();
                RaiseNonPersonDequeuedEvent(o);
            }
            return base.Dequeue();
        }

        private void RaisePersonDequeuedEvent(Person p)
        {
            if(PersonDequeued != null)
            {
                PersonDequeued(p);
            }
            
        }
        private void RaiseNonPersonDequeuedEvent(Object o)
        {
            if (NonPersonDequeued != null)
            {
                NonPersonDequeued(o);
            }
        }
    }
}
