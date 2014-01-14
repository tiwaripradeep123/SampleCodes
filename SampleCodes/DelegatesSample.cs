using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleCode
{

    public delegate void WorkStarted();
    public delegate void WorkProgressing();
    public delegate int WorkCompleted();


    public class Worker
    {
        public event WorkStarted Started;
        public event WorkProgressing Progress;
        public event WorkCompleted Completed;

        public void DoWork()
        {
            if (this.Started != null)
            {
                this.Started();
            }

            if (this.Progress != null)
            {
                this.Progress();
            }

            if (this.Completed != null)
            {
                foreach (WorkCompleted item in this.Completed.GetInvocationList())
                {
                   
                   //IAsyncResult result = item.BeginInvoke( null, null);
                   //item.EndInvoke(result);

                    item.BeginInvoke(this.WorkGraded, item);
                }
            }
        }

        private void WorkGraded(IAsyncResult ar)
        {
            var work = (WorkCompleted) ar.AsyncState;
            int grade = work.EndInvoke(ar);
            Console.WriteLine("Found grade -> " + grade);
        }

        
    }

    public class Boss 
    {
        public void WorkHasStarted()
        {
            Console.WriteLine("Boss -> work has started");
        }


        public void WorkInProgress()
        {
            Console.WriteLine("Boss -> work in progess");
        }



        public int WorkHasCompleted()
        {
            int number = (new Random()).Next(1, 10);
            Thread.Sleep(number *500);
            Console.WriteLine("Boss ->It's about time !  " + number);
            return number;
        }


    }

    class Universe
    {
        public int WorkHasCompleted()
        {
            int number = (new Random()).Next(1, 20)/2;
            Thread.Sleep(number * 500);
            Console.WriteLine("Universe ->It's about time !  " + number);

            return number;
        }
    }
}
