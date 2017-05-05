using SOProyect2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOProyect2
{
    class Consumer
    {
        public int ID;
        private int Priority;
        StatusWorker Status;
        public Consumer(int id)
        {
            this.ID = id;
            this.Status = StatusWorker.free;
        }

        public void setPriority(int priority)
        {
            this.Priority = priority;
        }
    }
}
