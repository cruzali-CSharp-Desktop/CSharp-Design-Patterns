using Design_Patterns.Views.Observer;
using System;
using System.Windows.Forms;

namespace Design_Patterns.Views
{
    // Works like Observer
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnObserver_Click(object sender, EventArgs e)
        {
            Observable observer = new Observable();
            observer.LoadCompleted += Observable_LoadCompleted;
            observer.Show();

            ObservableTwo observableTwo = new ObservableTwo();
            ObserverTwo observerTwo = new ObserverTwo();

            observableTwo.PasoAlgo += observerTwo.HandleEvent;
            observableTwo.HazAlgo();

        }

        private void Observable_LoadCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("LOADED FROM Observable");
        }

    }

    class ObservableTwo
    {
        public event EventHandler PasoAlgo;

        public void HazAlgo() =>
            PasoAlgo?.Invoke(this, EventArgs.Empty);
    }


    class ObserverTwo
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Paso algo a " + sender);
        }
    }




}
