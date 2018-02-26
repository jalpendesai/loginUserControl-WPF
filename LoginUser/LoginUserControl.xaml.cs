using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginUser
{
    /// <summary>
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        //Login Name Interaction logic
        public string LoginName
        {
            get { return (string)GetValue(LoginNameProperty); }
            set { SetValue(LoginNameProperty, value); }
        }

        public static DependencyProperty LoginNameProperty =
            DependencyProperty.Register(nameof(LoginName), typeof(string),
                typeof(LoginUserControl), new PropertyMetadata("Login Name"));


        //UserName Interaction logic
        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        public static DependencyProperty UserNameProperty =
            DependencyProperty.Register(nameof(UserName), typeof(string),
                typeof(LoginUserControl), new PropertyMetadata("User Name Enter"));

        //Password Interaction logic
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public static DependencyProperty PasswordProperty =
            DependencyProperty.Register(nameof(Password), typeof(string),
                typeof(LoginUserControl), new PropertyMetadata("Password Enter"));
    }
}
