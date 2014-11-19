using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace DataBinding
{
    public partial class MainPage : PhoneApplicationPage
    {
        Person _currentPerson;
        Random _rand = new Random();

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded( object sender, RoutedEventArgs e )
        {
            SetDataContext();
            Next.Click += Next_Click;
            Change.Click += Change_Click;
        }

        void Change_Click( object sender, RoutedEventArgs e )
        {
            _currentPerson.Name = "Jacob";
        }

        private void SetDataContext()
        {
            GeneratePerson();
            ContentPanel.DataContext = _currentPerson;
        }

        void Next_Click( object sender, RoutedEventArgs e )
        {
            SetDataContext();
        }

        private void GeneratePerson()
        {

           _currentPerson = new Person
            {
                Beard = FlipCoin(),
                Favorite = FlipCoin(),
                Goatee = FlipCoin(),
                Height = _rand.NextDouble() + 1,
                Moustache = FlipCoin(),
                BirthDate = DateTime.Now - TimeSpan.FromDays(_rand.Next(1,365*20)),
                Name = names[_rand.Next( 0, names.Count - 1 )]
            };

        }
        private bool FlipCoin()
        {
            return _rand.Next( 1, 3 ) % 2 == 0;
        }
        private readonly List<string> names = new List<string>()
                    {
                       "Stacey",
                       "Robbie",
                       "Jess",
                       "Robin",
                       "Syd",
                       "J.J.",
                       "Terri",
                       "Moonunit",
                    };

    }
}