using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOProyect2.Enum
{
    /// <summary>
    /// Enum that check status to worker
    /// </summary>
    public enum StatusWorker { process, free, sleep }
    public enum SQLExecutor { insert, delete }
    /// <summary>
    /// Enum that check type worker
    /// </summary>
    public enum TypeWorker { producer, consumer }
}
