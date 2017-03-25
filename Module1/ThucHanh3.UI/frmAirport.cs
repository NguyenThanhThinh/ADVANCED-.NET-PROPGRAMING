using System;
using System.Data;
using System.Windows.Forms;
using ThucHanh3.DAL;
using ThucHanh3.DTO;

namespace ThucHanh3.UI
{
    public partial class FrmAirport : Form
    {
        public  DBConnection db;
        public DataSet dsAirport, dsCountry;
        public BindingSource bindingSourceAirport;
        public FrmAirport()
        {
            InitializeComponent();
        }

        private void frmAirport_Load(object sender, EventArgs e)
        {
            LoadCountryList();
              
        }

        public void LoadAirportList(string country)
        {
            AirportDAL aDAO = new AirportDAL();
            dsAirport = aDAO.GetAirportByCountryDataset(country);
             

            bindingSourceAirport = new BindingSource();
            bindingSourceAirport.DataSource = dsAirport;
            bindingSourceAirport.DataMember = "Airport";

            dgvAirport.DataSource = null;
            dgvAirport.DataSource = bindingSourceAirport;

            BindingControls();

            dgvAirport.RowTemplate.Height = 24;
            dgvAirport.Columns["code"].Width = 40;
            dgvAirport.Columns["name"].Width = 220;
            dgvAirport.Columns["city"].Width = 120;
            dgvAirport.Columns["state"].Width = 120;
            dgvAirport.Columns["country"].Width = 120;
            dgvAirport.Columns["utc_time"].Width = 80;

            dgvAirport.RowHeadersVisible = false;
            dgvAirport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAirport.Columns["deleted"].Visible = false;
            dgvAirport.Columns["openning"].Visible = false;
            dgvAirport.Refresh();

        }

        private void lsbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = lsbCountry.GetItemText(lsbCountry.SelectedItem);
            LoadAirportList(country);
            
        }

        public void BindingControls()
        {
            txtCode.DataBindings.Clear();
            txtCode.DataBindings.Add("Text", bindingSourceAirport, "code");
            txtCode.Refresh();

            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", bindingSourceAirport, "name");
            txtName.Refresh();

            txtCity.DataBindings.Clear();
            txtCity.DataBindings.Add("Text", bindingSourceAirport, "city");
            txtCity.Refresh();

            txtState.DataBindings.Clear();
            txtState.DataBindings.Add("Text", bindingSourceAirport, "state");
            txtState.Refresh();

            txtCountry.DataBindings.Clear();
            txtCountry.DataBindings.Add("Text", bindingSourceAirport, "country");
            txtCountry.Refresh();

            txtUTCTime.DataBindings.Clear();
            txtUTCTime.DataBindings.Add("Text", bindingSourceAirport, "utc_time");
            txtUTCTime.Refresh();

            chkClosed.DataBindings.Clear();
          

            Binding argBinding = new Binding("checked", bindingSourceAirport, "openning", false, DataSourceUpdateMode.OnPropertyChanged);
            argBinding.Format += new ConvertEventHandler(Binding_Format_BooleanInverse);
            chkClosed.DataBindings.Add(argBinding);
        }

        void Binding_Format_BooleanInverse(object sender, ConvertEventArgs e)
        {
            bool boolValue = (bool)e.Value;
            e.Value = !boolValue;
        }

        int curnetRow = -1;
        private void dgvAirport_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAirport.CurrentRow.Index != curnetRow)
            {
                
            }

        }

        public void LockControls(bool isReadonly)
        {
            txtCode.ReadOnly = isReadonly;
            txtName.ReadOnly = isReadonly;
            txtCity.ReadOnly = isReadonly;
            txtState.ReadOnly = isReadonly;
            //txtCountry.ReadOnly = isReadonly;
            txtUTCTime.ReadOnly = isReadonly;
            chkClosed.Enabled = !isReadonly;
        }

        public void ClearBindingControls()
        {
            // clear Binding
            txtCode.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtState.DataBindings.Clear();
            //txtCountry.DataBindings.Clear();
            txtUTCTime.DataBindings.Clear();
            chkClosed.DataBindings.Clear();
        }

        public void ClearControls()
        {
            // set empty
            txtCode.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            //txtCountry.Text = "";
            txtUTCTime.Text = "";
            chkClosed.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Add"))
            {
                btnAdd.Text = "Save";
                LockControls(false);

                ClearBindingControls();

                ClearControls();

            }else if (btnAdd.Text.Equals("Save"))
            {
                AirportEntity ae = new AirportEntity();
                ae.Code = txtCode.Text;
                ae.Name = txtName.Text;
                ae.City = txtCity.Text;
                ae.State = txtState.Text;
                ae.Country = txtCountry.Text;
                ae.UtcTime = txtUTCTime.Text;
                ae.Openning = chkClosed.Checked;
                ae.Deleted = false;

                AirportDAL ado = new AirportDAL();
                
                if (!ado.AddNewAirport(ae))
                {
                    MessageBox.Show("Can not insert new Airport. Please check again.", "Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }else
                {
                    DataRow newRow = dsAirport.Tables["Airport"].NewRow();
                    newRow["code"] = ae.Code;
                    newRow["name"] = ae.Name;
                    newRow["city"] = ae.City;
                    newRow["state"] = ae.State;
                    newRow["country"] = ae.Country;
                    newRow["utc_time"] = ae.UtcTime;
                    newRow["openning"] = ae.Openning;
                    newRow["deleted"] = ae.Deleted;

                    dsAirport.Tables["Airport"].Rows.Add(newRow);

                    BindingControls();
                    ClearControls();
                    LockControls(true);
                   // LoadAirportList(lsbCountry.GetItemText(lsbCountry.SelectedItem));
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals(""))
            {
                MessageBox.Show("Please select an airport to delete.");
            }
            else
            {
                DialogResult isDelete = MessageBox.Show("Do you want to delete the Aiport " + txtName.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isDelete == DialogResult.Yes)
                {
                    AirportDAL aDAO = new AirportDAL();
                    if (aDAO.DeleteAirport(txtCode.Text))
                    {
                        
                        LoadAirportList(lsbCountry.GetItemText(lsbCountry.SelectedItem));

                    }
                }
            }
        }

        public void LoadCountryList()
        {

            AirportDAL aDAO = new AirportDAL();
            dsCountry = aDAO.GetUniqueCountryDataset();

            DataTable dt = new DataTable();
            
            dt = dsCountry.Tables["Country"];
            dt.DefaultView.Sort = "Country ASC";

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            //bindingSource.DataMember = "Country";
             
            lsbCountry.DataSource = bindingSource;
            lsbCountry.DisplayMember = "Country";
            lsbCountry.ValueMember = "Country";
           
            
        }
    }
}
