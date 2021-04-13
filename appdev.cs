using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace rating
{
    public interface appdev
    {
        public void fetch(string name);

        public void showCourses(Dictionary<string,List<string>> dict);

        public void displayFilter(string[] s,Dictionary<string,List<string>> x);
        
        public string[] filter();
        public void getChoice();
    }
}