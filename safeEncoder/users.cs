using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace safeEncoder
{
    class users
    {
        private string login {get; set;}
        private string password { get; set;}
        private string encodedPassword { get; set;}

        public users (string login, string password)
        {
            this.login = login;
            this.password = password;
            addUserToUsersList(login);
        }

        public users()
        {

        }

        public List<string> getUsers()
        {
            List<string> userlist = new List<string>();
            try
            {
                string line;                
                StreamReader readUsersList = new StreamReader("safe/userlist");
                while ((line=readUsersList.ReadLine()) != null)
                {
                    userlist.Add(line);
                }
                readUsersList.Close();
            }

            catch
            {

            }

            return userlist;
        }

        private string getSHA256code (string input)
        {

            return null;
        }

        private void addUserToUsersList(string nickname)
        {
            try
            {
                StreamWriter userListFile = new StreamWriter("safe/userlist", true);                
                userListFile.WriteLineAsync(nickname);
                userListFile.Close();
            }
                
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory("safe");
                addUserToUsersList(nickname);
            }

            catch (FileNotFoundException) 
            {

                File.Create("safe/userlist").Close();
                addUserToUsersList(nickname);
            }

            catch (Exception e)
            {
                //StreamWriter file = new StreamWriter("safe/userlist");
                //file.WriteLine(nickname);
                //file.Close();
                MessageBox.Show(e.ToString());
            }
        }
    }
}
