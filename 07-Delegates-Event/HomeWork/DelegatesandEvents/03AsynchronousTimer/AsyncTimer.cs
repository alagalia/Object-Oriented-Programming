using System;
using System.Threading;

namespace _03AsynchronousTimer
{
    
    class AsyncTimer
    {
        private int ticks;
        public int sleepTimeInMilliseconds;

        public AsyncTimer(Action<int> actionMethod, int tick, int sleepTimeInMilliseconds)
        {
            this.MethodToExecute = actionMethod;//the delegate
            this.Ticks = tick;
            this.SleepTimeInMilliseconds = sleepTimeInMilliseconds;
        }

        public Action<int> MethodToExecute { get; private set; }
        public int Ticks { get; set; }
        public int SleepTimeInMilliseconds { get; set; }



        public void Run()
        {
            for (int i = 1; i < this.Ticks; i++)
            {
                Thread.Sleep(this.SleepTimeInMilliseconds);//приспива процеса

                if (this.MethodToExecute != null)
                {
                    this.MethodToExecute(i);
                }
            }
        }
    }

}
