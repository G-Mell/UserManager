using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace KR
{
    class UserManager
        
    {
        public Users users = new Users();
        private static UserManager instance;
            public string Login { get; private set; }
    public string Password { get; private set; }
        private static object syncRoot = new Object();
        
        //loginTextBox=string ltB;
        class Akk
       { 
            public string login { get; private set; }
            public string password { get; private set; }
           public  Akk(string login,string password)
        {
                this.password = password;
               this.login = login;
        }
    // public string password { get; private set; }
    //public string Akk(string login,string password)

   // public List<string,string> Akk = new List<string>();
    List<Akk> akks = new List<Akk>();

            //  public List<string> Passwords = new List<string>();


            public void Login()
        {



          //  for (int i = 0; i < akks.Count; i++)
                
                    if(tb!=akks.Count)
            {
                akks.Add(tb);//добавить условие if 
                            


                   
            }

        }
       

        }
        protected UserManager(string Login,string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }

        public static UserManager getInstance(string login, string password)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new UserManager(login,password);
                }
            }
            return instance;
        }


    }
}

