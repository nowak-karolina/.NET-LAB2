using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2 {
    internal class ToDo {
        public string activity { get; set; }
        public double accessibility { get; set; }
        public string type { get; set; }
        public int participants { get; set; }
        public double price { get; set; }
        public string link { get; set; }
        public string key { get; set; }

        public override string ToString() {
            return $"activity: {activity},\n type: {type}, \nparticipants: {participants}, \npirce: {price}, \nlink: {link}, \nkey: {key}, \naccesibility: {accessibility}";
        }
    }
}
