using System;
using System.Windows.Forms;


namespace ThucHanh3.UI
{
    public partial class FrmMain : Form
    {
         
     
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
           
        }
  
 

        private void btnAirportMgt_Click(object sender, EventArgs e)
        {

            FrmAirport frmAirpoirt = new FrmAirport();
            frmAirpoirt.Show();

        }
    }
}
