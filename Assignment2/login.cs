using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class login : Form
    {
        private User user1;
        private User user2;
        private User user3;
        private User user4;
        private User user5;
        private List<User> users;
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new list of users.
            users = new List<User>();

            // Create predefined users and add them to the list.
            user1 = new User();
            user1.UserId = 1;
            user1.Username = "marah";
            user1.FullName = "marah alhurub";
            user1.Password = "111111";
            users.Add(user1);

            user2 = new User();
            user2.UserId = 2;
            user2.Username = "qamar";
            user2.FullName = "Qamar ali";
            user2.Password = "222222";
            users.Add(user2);

            user3 = new User();
            user3.UserId = 3;
            user3.Username = "nadeen";
            user3.FullName = "nadeen mohammad";
            user3.Password = "333333";
            users.Add(user3);

            user4 = new User();
            user4.UserId = 4;
            user4.Username = "shrooq";
            user4.FullName = "shrooq adnan";
            user4.Password = "444444";
            users.Add(user4);

            user5 = new User();
            user5.UserId = 5;
            user5.Username = "marwa";
            user5.FullName = "marwa saleh";
            user5.Password = "555555";
            users.Add(user5);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Check if the username and password match any of the predefined users.
            bool isUserFound = false;
            foreach (User user in users)
            {
                if (user.Username == txtusername.Text && user.Password == txtpassword.Text)
                {
                    // If there is a match, welcome the user with a message that includes their full name.
                    isUserFound = true;
                    MessageBox.Show("Welcome " + user.FullName);
                    break;
                }
            }

            // If there is no match, inform the user that the user does not exist or the password is incorrect.
            if (!isUserFound)
            {
                MessageBox.Show("User does not exist or wrong password");
            }
        }
    }

}

