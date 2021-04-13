using System;
using System.Linq;
using System.Collections.Generic;


namespace rating
{
    public interface computer
    {
        public void welcome(string s);
        public void fetch(string name);
        public void showCourses(Dictionary<string,List<string>> dict);
        public void displayFilter(string[] s, Dictionary<string,List<string>> x);

        public string[] filter();

       // public void rate();

        public void rev();
        public int getChoice();
   }
}