using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2 {
    internal class Facts {
        public List<Fact> data { get; set; }

        public override string ToString() {
            string s = "";

            foreach (Fact fact in data) {
                s+= fact.ToString();
            }

            return s;
        }
    }
}
