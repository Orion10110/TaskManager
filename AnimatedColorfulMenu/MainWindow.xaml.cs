using AnimatedColorfulMenu.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AnimatedColorfulMenu
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int updateInterval = 3;

        private ObservableCollection<ProcessInfo> processes = new ObservableCollection<ProcessInfo>();
        private ObservableCollection<ProcessThread> threads = new ObservableCollection<ProcessThread>();
        private DispatcherTimer timer;
        private TimeSpan interval = TimeSpan.FromSeconds(updateInterval);
        private ProcessInfo selectedProcess = null;

        public MainWindow()
        {
            InitializeComponent();
            this.initTimer();
            this.listViewThreads.ItemsSource = this.threads;
            this.listViewProcess.ItemsSource = this.processes;
            this.let.DataContext = this.processes;
        }

        private void initTimer()
        {
            this.timer = new DispatcherTimer { Interval = interval };
            timer.Tick += this.update;
            timer.Start();
        }

        private void update(object sender, EventArgs e)
        {
            this.update();
        }
        private void update()
        {
            this.processes = this.getProcesses();
            this.listViewProcess.ItemsSource = this.processes;
            this.let.DataContext = this.processes;
        }

        internal ObservableCollection<ProcessInfo> Processes {
            get => processes;
            set {
                processes = value;
                this.listViewProcess.ItemsSource = this.processes;
                this.let.DataContext = this.processes;
            }
        }

        private ObservableCollection<ProcessInfo> getProcesses()
        {
            ObservableCollection<ProcessInfo> processes = new ObservableCollection<ProcessInfo>();

            foreach (Process process in Process.GetProcesses())
            {
                ProcessInfo processInfo = new ProcessInfo(process.Id, process.StartInfo.UserName, process.PrivateMemorySize64, process.BasePriority, process.Threads.Count, process.ProcessName, process.Threads);
                processes.Add(processInfo);
            }
            return processes;
        }

        private void listViewProcess_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedProcess = (ProcessInfo)this.listViewProcess.SelectedItem;
            if (this.selectedProcess == null) return;
            threads.Clear();
            for (int j = 0; j < this.selectedProcess.TreadsList.Count; j++)
                this.threads.Add(this.selectedProcess.TreadsList[j]);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.timer.Stop();
        }
    }
}
