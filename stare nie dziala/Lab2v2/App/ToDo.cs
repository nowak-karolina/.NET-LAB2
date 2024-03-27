using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App {
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
            return $"activity: {activity}{Environment.NewLine}accessibility: {accessibility}{Environment.NewLine}" +
                $"type: {type}{Environment.NewLine}participants: {participants}{Environment.NewLine}" +
                $"price: {price}{Environment.NewLine}link: {link}{Environment.NewLine}key: {key}";
        }
    }
}
