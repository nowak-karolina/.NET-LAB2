using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2 {
    internal class Fact {
        public string id {  get; set; }
        public string type { get; set; }
        [NotMapped]
        public Attributes attributes { get; set; }

        public override string ToString() {
            string s = $"id: {id} \ntype: {type} \nfact: {attributes.body}\n\n";
            return s ;
        }
    }
}
