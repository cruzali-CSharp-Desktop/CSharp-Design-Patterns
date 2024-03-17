using System;
using System.Windows.Forms;

namespace Design_Patterns.Views.Observer
{
    public partial class Observable : Form
    {

        public event EventHandler LoadCompleted;
        public Observable()
        {
            InitializeComponent();
        }

        private void Observable_Load(object sender, EventArgs e)
        {
            // Do Something

            OnLoadCompleted(EventArgs.Empty);
        }

        protected virtual void OnLoadCompleted(EventArgs e)
        {
            LoadCompleted?.Invoke(this, e);
        }

        public void HazAlgo() =>
            LoadCompleted?.Invoke(this, EventArgs.Empty);




    }
}
