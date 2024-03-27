using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Lab2v2 {
    internal class ToDo {
        public int Id { get; set; }
        public required string activity { get; set; }
        public required float accessibility { get; set; }
        public required string type { get; set; }
        public required float participants { get; set; }
        public required float price { get; set; }
        public string? link { get; set; }
        public string? key { get; set; }
        

        public override string ToString() {
            return $"activity: {activity}\naccessibility: {accessibility}\ntype: {type}\nparticipants: {participants}\nprice: {price}\nlink: {link}\nkey: {key}";
        }

    }

}
