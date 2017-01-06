using System;
using System.Windows.Forms;

namespace rgr
{
    public partial class UpdatePopUp : Form
    {
        private MainWindow mWindow;

        public UpdatePopUp(MainWindow mWindow, Type valueType)
        {
            InitializeComponent();
            this.mWindow = mWindow;
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            mWindow.onUpdateFormClose(newValue.Text);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
