using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freundin_State_Observ_Singelton
{
    public partial class Form1 : Form, IObserver
    {
        Freundin freundin;
        public Form1()
        {
            InitializeComponent();
            freundin = new Freundin(StatusNeutral.GetInstance());
            freundin.Attach(this);
        }

        private void BtnReden_Click(object sender, EventArgs e)
        {
            freundin.Reden();
        }

        private void BtnKuss_Click(object sender, EventArgs e)
        {
            freundin.Kussgeben();
        }

        private void BtnAergern_Click(object sender, EventArgs e)
        {
            freundin.Aergern();
        }

        void IObserver.Update()
        {
            if (freundin.GetStatus() == StatusLieb.GetInstance())
            {
                LbStatus.Text = "Ich Bin Lieb";
            }
            else if (freundin.GetStatus() == StatusNeutral.GetInstance())
            {
                LbStatus.Text = "Ich bin Neutral";
            }
            else if (freundin.GetStatus() == StatusBockig.GetInstance())
            {
                LbStatus.Text = "I Hate YOUUU";
            }
            else
            {
                LbStatus.Text = "ERROR";
            }
            Refresh();
        }
    }
}
