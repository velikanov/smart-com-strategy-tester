using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Server
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Description { get; set; }
        public bool Checked { get; set; }
        public bool Default { get; set; }
    }
    public class ServerCollection
    {
        public ObservableCollection<Server> List;

        public ServerCollection()
        {
            List = new ObservableCollection<Server>();
        }
    }
}
