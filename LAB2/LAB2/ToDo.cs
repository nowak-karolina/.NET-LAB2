using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2 {
    internal class ToDo {
        public string activity;
        public string type;
        public int participants;
        public int price;
        public string link;
        public string key;
        public int accessibility;

        public override string ToString() {
            return $"activity: {activity},\n type: {type}, \nparticipants: {participants}, \npirce: {price}, \nlink: {link}, \nkey: {key}, \naccesibility: {accessibility}";
        }
    }
}
