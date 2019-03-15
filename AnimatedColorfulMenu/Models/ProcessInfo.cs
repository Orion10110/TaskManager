using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedColorfulMenu.Models
{
    class ProcessInfo
    {
        int id;
        string user;
        string name;
        long memory;
        int priority;
        int threads;
        ProcessThreadCollection threadsList;

        public ProcessInfo(int id, string usr, long mmr, int prior, int thr, string name, ProcessThreadCollection ptc)
        {
            this.id = id;
            User = usr;
            Memory = mmr / 1000000;
            Priority = prior;
            Threads = thr;
            Name = name;
            threadsList = ptc;
        }

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public long Memory { get => memory; set => memory = value; }
        public int Priority { get => priority; set => priority = value; }
        public int Threads { get => threads; set => threads = value; }
        public string Name { get => name; set => name = value; }
        public ProcessThreadCollection TreadsList { get => threadsList; set => threadsList = value; }
    }
}
