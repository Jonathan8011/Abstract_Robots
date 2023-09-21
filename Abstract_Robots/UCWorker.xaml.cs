using System;
using System.Collections.Generic;
using System.Data;
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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for UCWorker.xaml
    /// </summary>
    public partial class UCWorker : UserControl
    {
        public UCWorker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker;// Binding 
            lbId.Content = worker.IdNumber;
            if (worker.BirthDate.Month.Equals(DateTime.Today.Month) && worker.BirthDate.Day.Equals(DateTime.Today.Day))
                lbBday.Content = worker.BirthDate.ToShortDateString() + "🎂 Happy Birthday! 🎁";
            else
            lbBday.Content = worker.BirthDate.ToShortDateString();
            if (worker is GeneralManager)
                lbRole.Content = "CEO";
            else if ((worker is OperationManager))
                lbRole.Content = "Manager";
            else lbRole.Content = "Worker";
        }
    }
}
