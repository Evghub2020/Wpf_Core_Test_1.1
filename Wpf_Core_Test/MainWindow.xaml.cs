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
using Wpf_Core_Test.Models;

namespace Wpf_Core_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }


        private void initdb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта Role
                Role rol1 = new Role { NameRole = "директор" };
                Role rol2 = new Role { NameRole = "бухгалтер" };
                Role rol3 = new Role { NameRole = "менеджер" };
                db.Roles.Add(rol1);
                db.Roles.Add(rol2);
                db.Roles.Add(rol3);
                db.SaveChanges();
                // создаем два объекта Person
                Person per1 = new Person
                {
                    FirstName = "Иван",
                    LastName = "Иванов",
                    Birthday = new DateTime(1985, 05, 20),
                    Role = rol1
                };
                Person per2 = new Person
                {
                    FirstName = "Петр",
                    LastName = "Петров",
                    Birthday = new DateTime(1980, 03, 25),
                    Role = rol2
                };
                Person per3 = new Person
                {
                    FirstName = "Степан",
                    LastName = "Степанов",
                    Birthday = new DateTime(1999, 01, 30),
                    Role = rol3
                };
                // добавляем их в БД
                db.Persons.Add(per1);
                db.Persons.Add(per2);
                db.Persons.Add(per3);
                db.SaveChanges();
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            initdb();
            textBlock.Text = "База данных создана. Объекты успешно сохранены. ";
        }
    }


}
