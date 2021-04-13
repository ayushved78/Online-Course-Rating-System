using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rating
{
    class courses : computer, webapp, appdev
    {
        protected  List<string> catalog=new List<string>(){"Computer Science", "Business and Marketing","Arts","Web Development","App Development"};
        public List<string> services=new List<string>(){"Filter","Rate","Review","More details","Back"};  
        private void showCatalog()
        {
            Console.WriteLine("Categories Available: ");
            Console.WriteLine("\n");
            for(int i=0;i<catalog.Count;i++)
              Console.Write(i+1+". "+catalog[i]+"\t");
            Console.WriteLine();
            
        }
        private int getCategory()
        {
            Console.WriteLine("\n Select the category : ");
            return Int32.Parse(Console.ReadLine());
        }
        public int getService()
        {
             for(int i=0;i<services.Count;i++)
              Console.Write(i+1+". "+services[i]+"\t");
             Console.WriteLine('\n');
             return Int32.Parse(Console.ReadLine());
        }
        protected void welcome(string current)
        {
            Console.WriteLine("\nWelcome to "+current+" Portal !");   
        }
        protected void fetch(string fileName)
        {
            using (StreamReader r = new StreamReader(fileName+".json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach(var item in array.input)
                {
                      List<string> temp=new List<string>();
                      foreach(string desc in item.description)
                      {
                           temp.Add(desc);
                      } 
                      string nam=item.name;
                      if(fileName=="input")
                        cs.Add(nam,temp);
                      else if(fileName=="inp1")
                        web.Add(nam,temp);
                      else if(fileName=="inp2")
                        app.Add(nam,temp);
                }
            }
           
        }
        public void showCourses(Dictionary<string,List<string>> dict)
        {
            foreach(var i in dict)
            {
             Console.WriteLine(i.Key);
             foreach(var j in dict[i.Key])
             {
                 Console.WriteLine(j);
             }
             Console.WriteLine();
            }
        } 

        public void displayFilter(string[] s, Dictionary<string,List<string>> dict)
        {
            List<string> cur=new List<string>();
            foreach(var i in s)
            {
                foreach(var j in dict.Keys)
                {
                    if(j.ToLower().Contains(i.ToLower()))
                     cur.Add(j);
                }
            }
            var x=new HashSet<string>(cur);
            foreach(var i in x)
            {
                Console.WriteLine(i);
                foreach(var j in dict[i])
                 Console.WriteLine(j);
                Console.WriteLine();
            }
        }
        /*public static string[] operator+(string[] a,string[] b)
        {

            string[] cat=new string[](); 
            return cat;
        }*/

        public string[] filter()
        {
            Console.WriteLine("Enter the filters: ");
            string x=Console.ReadLine();
            string[] filt=x.Split(' ',5,StringSplitOptions.None);
            //string[] filt2=filt+{"abc","def"};

            return filt;
        }

       public void rev()
       {
           string filePath = @"C:\Users\ayush\Desktop\ptdemo\rating\review.txt";
           List<string> lines = new List<string>();
           List<review> rv = new List<review>();

           lines = File.ReadAllLines(filePath).ToList();
           foreach(String line in lines)
           {
               string[] item = line.Split(',');
               //review r = new review(item[0],item[1],item[2],item[3]);
               //rv.Add(r);
           }

           List<string> outCont = new List<string>();

           foreach(review r in rv)
           {
               Console.WriteLine(r);
               outCont.Add(r.ToString());
           }

           String fn,ln,em,rm;
            Console.WriteLine("F name: ") ;
            fn = Console.ReadLine();
            Console.WriteLine("L name::");
            ln = Console.ReadLine();
            Console.WriteLine("email:");
            em = Console.ReadLine();
            Console.WriteLine("review:");
            rm = Console.ReadLine();


          // rv.Add(fn,ln,em,rm);

           File.WriteAllLines(filePath, outCont);

            if(!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(outCont);
                    sw.Write(fn,ln,em,rm);
                }
            }
            Console.ReadKey();
       }


        public int getChoice()
        {
            Console.WriteLine("\nSelect the course: ");
            return Int32.Parse(Console.ReadLine());
        }

        public void start()
        {
            showCatalog();
            int choice=getCategory();
            Console.WriteLine("Loading "+catalog[choice-1]+"............");
            Thread.Sleep(2000);
                int exit=0;
                 //var service=new computer();
                welcome(catalog[choice-1]);
                string fileName="input";
                Dictionary<string,List<string>> temp=new Dictionary<string, List<string>>();
                switch(choice)
                {
                    case 1: fileName="input"; temp=cs;  break;
                    case 4: fileName="inp1";  temp=web; break;
                    case 5: fileName="inp2";  temp=app; break;
                    default: break;
                }
                fetch(fileName: fileName);
                if(choice==5)
                 showCourses(app);
                else if(choice==4)
                 showCourses(web);
                else 
                 showCourses(cs);
                while(exit!=5)
                {
                exit=getService();
                 if(exit==1)
                 {
                    string[] s=filter();
                    Console.WriteLine("\n");
                    displayFilter(s,temp);
                 }
                 else if(exit==3)
                 {
                     rev();
                 }
                }
        }

        public courses()
        {
            start();   
        }
        public static void Main()
        {
            Console.WriteLine("\n\n\t\t******* Welcome to Online Course Rating System *********\n\n");
            Console.WriteLine("Enter Service you wanna use:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. View Courses");
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                login Login = new login();
            }
            else if(n==2)
            {
                //Console.WriteLine("SignUp Hommie");
                SignUp signup = new SignUp();
            }
            else if(n==3)
            {
                var guest=new courses();

            }
            else
            {
                Console.WriteLine("Invalid Service");
            }
            
        }

        protected Dictionary<string,List<string>> cs=new Dictionary<string,List<string>>();
        protected Dictionary<string,List<string>> web=new Dictionary<string,List<string>>();
        protected Dictionary<string,List<string>> app=new Dictionary<string,List<string>>();

        void webapp.fetch(string name)
        {
            throw new NotImplementedException();
        }

        void computer.welcome(string s)
        {
            throw new NotImplementedException();
        }

        void computer.fetch(string name)
        {
            throw new NotImplementedException();
        }

        void computer.rev()
        {
            throw new NotImplementedException();
        }

        void webapp.getChoice()
        {
            throw new NotImplementedException();
        }

        void appdev.fetch(string name)
        {
            throw new NotImplementedException();
        }

        void appdev.getChoice()
        {
            throw new NotImplementedException();
        }
    }
}