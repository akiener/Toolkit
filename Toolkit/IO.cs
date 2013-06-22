using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Toolkit {
    public class IO {
        private String path;

        public IO(String path) {
            this.path = path;
        }

        public void write(string text) {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(text);
            file.Close();
        }

        public String read() {
            StreamReader file = new StreamReader(path);
            string ret = file.ReadToEnd();
            file.Close();
            return ret;
        }

        public void writeObjectToJson(Object o) {
            write(JsonConvert.SerializeObject(o, Formatting.Indented));
        }

        public T readObjectFromJson<T>() {
            return JsonConvert.DeserializeObject<T>(read());
        }
    }
}
