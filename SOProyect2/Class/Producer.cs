using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOProyect2.Enum;

namespace SOProyect2
{
    class Producer
    {
        public int ID;
        StatusWorker Status;

        public Producer(int id)
        {
            this.ID = id;
            this.Status = StatusWorker.free;
        }
    }
}
