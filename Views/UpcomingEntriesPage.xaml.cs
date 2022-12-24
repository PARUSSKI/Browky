using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;
using VelvetEyebrows.Models;

namespace VelvetEyebrows.Views
{
    /// <summary>
    /// Логика взаимодействия для UpcomingEntriesPage.xaml
    /// </summary>
    public partial class UpcomingEntriesPage : Page
    {
        public List<ClientService> Services { get; set; }
        private DispatcherTimer timer = new DispatcherTimer();
        private int increment = 0;
        void UpdateTimer()
        {
            InitializeComponent();
            Services = Session.Instance.Context.ClientServices.OrderBy(cs => cs.StartTime).Where(cs => cs.StartTime < DateTime.Now.AddDays(2) && cs.StartTime > DateTime.Now).Include(cs => cs.Client).Include(cs => cs.Service).ToList();
            DataContext = this;            
        }

        public UpcomingEntriesPage()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Ticker;
            timer.Start();
            UpdateTimer();
        }

        private void Ticker (object? sender, EventArgs e)
        {
            increment++;
            if (increment % 5 == 0)
            {
                DataContext = null;
                UpdateTimer();
            }
        }
    }
}
