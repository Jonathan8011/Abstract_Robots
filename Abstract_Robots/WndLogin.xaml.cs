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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            CreateWorkers();
            CreateRobots();
            CreateMissions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }
        private void CreateWorkers()
        { 
            workers = new List<Worker>();

            workers.Add(new GeneralManager(name:"Jonathahn gamzu" ,id:"21",bDate:new DateTime(2006, 09, 21 ), passW:"123" , monthlySalary: 100000000 , workingRobots: 100));
            
            workers.Add(new OperationManager(name: "Kirillll", id: "331487484", bDate: new DateTime(2006, 08, 09), pass: "1234", SalaryPerH: 150, hours: 45, NumOfMissionSucceed: 15));
            workers.Add(new OperationManager(name: "Ron", id: "11", bDate: new DateTime(2006, 05, 02), pass: "1", SalaryPerH: 150, hours: 50, NumOfMissionSucceed: 10));

            workers.Add(new OperationalWorker(name: "andro", id: "2", bDate: new DateTime(2005, 10, 5), pass: "2", SalaryPerH: 75, hours: 50));
            workers.Add(new OperationalWorker(name: "avi", id: "764654443", bDate: new DateTime(2004, 12, 6), pass: "4321", SalaryPerH: 75, hours: 55));
            workers.Add(new OperationalWorker(name: "lior", id: "4364368789", bDate: new DateTime(2005, 04, 9), pass: "8765", SalaryPerH: 75, hours: 35));
        }
        private void CreateRobots()
        {
            activeRobots = new List<RobotSpy>();

            activeRobots.Add(new RobotFly(model: "AxI54" , creationDate: new DateTime(2023 , 09 , 18) , batteryStatus: 100));
            activeRobots.Add(new RobotFly(model: "AxI24" , creationDate: new DateTime(2023 , 01 , 24) , batteryStatus: 100));
            activeRobots.Add(new RobotFly(model: "AxI34" , creationDate: new DateTime(2020 , 02 , 09) , batteryStatus: 100));

            activeRobots.Add(new RobotQuad(model: "xZ302", creationDate: new DateTime(2005, 12, 09), batteryStatus: 100));
            activeRobots.Add(new RobotQuad(model: "xZ305", creationDate: new DateTime(2000, 09, 30), batteryStatus: 100));
            activeRobots.Add(new RobotQuad(model: "xZ3", creationDate: new DateTime(1995,05, 31), batteryStatus: 100));

            activeRobots.Add(new RobotWheels(model: "X5", creationDate: new DateTime(2000, 11, 12), batteryStatus: 100));      
            activeRobots.Add(new RobotWheels(model: "X10", creationDate: new DateTime(2023, 09, 15), batteryStatus: 100));      
        }

        private void CreateMissions()
        {
            activeMissions = new List<Mission>();

            activeMissions.Add(new Mission(dueDate: new DateTime(2023, 12, 25) , desc: "mission1"));
            activeMissions.Add(new Mission(dueDate: new DateTime(2024, 05, 10) , desc: "mission2"));
        }

        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            foreach (var w in workers)
            {
                if (w.IdNumber.Equals(tbxID.Text) && (w.Password.Equals(tbxPassword.Password))){ 
                    Worker worker = w;
                    WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                    return;
                }
            }
        }
    }
}
