using MVC_app.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MVC_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , OnPowerChanged, OnDoorChanged, OnCarEngineStateChanged
    {
        private car nextcar;

        public MainWindow()
        {
            InitializeComponent();

            AccubatteryController accubatteryController = new AccubatteryController(this);
            DoorController doorController = new DoorController(this);

            nextcar = new car(doorController, accubatteryController, this);

        }

        private void OnStartButtonCliked(object sender, RoutedEventArgs e)
        {
            this.nextcar.startEngine();
        }

        private void OnDoorOpenButtonCliked(object sender, RoutedEventArgs e)
        {
            this.nextcar.toggleTheOpendoorButton();
        }

        private void OnLookDoorButtonCliked(object sender, RoutedEventArgs e)
        {
            this.nextcar.toggleTheLockdoorButton();
        }

        private void OnAccuButtonCliked(object sender, RoutedEventArgs e)
        {
            this.nextcar.togglePowerButton();
        }

        public void onPowerChangedStatus(string value, string message)
        {
            AccuState.Content = message;
            AccuButton.Content = value;
        }

        public void onLockDoorstatechanged(string value, string message)
        {
            DoorLockState.Content = message;
            LookDoorButton.Content = value;
        }

        public void onDoorOpenStatechanged(string value, string message)
        {
            DoorOpenState.Content = message;
            DoorOpenButton.Content = value;
        }

        public void onCarEngineStatechanged(string value, string message)
        {
            Status.Content = message;
            startButton.Content = value;
        }
    }
}
