/*
####################################################### 
----------------Thiago da Costa Malcher---------------
####################################################### 
 
 */


using System;
using System.Windows.Forms;
using System.IO.Ports;


namespace Balança_3400
{
    public partial class Balança : Form
    {
      string peso;
        public Balança()
        {
            
            InitializeComponent();
            get_portas();
        }
        void get_portas()
        {
            string[] ports = SerialPort.GetPortNames();
            cbConectar.Items.AddRange(ports);
            cbConectar.SelectedIndex = 0;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (portBalanca.IsOpen == false)
            {
                try
                {

                    portBalanca.PortName = cbConectar.Items[cbConectar.SelectedIndex].ToString();
                    portBalanca.Open();
                }
                catch
                {
                    return;
                }

                if (portBalanca.IsOpen)
                {
                    btnConectar.Text = "Desconectar";
                    cbConectar.Enabled = false;

                }
            }
            else
            {

                try
                {
                    portBalanca.Close();
                    cbConectar.Enabled = true;
                    btnConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            if (portBalanca.IsOpen == true)
            {
                peso = portBalanca.ReadExisting();
                txtLer.Text = peso.Substring(0,10);//.Substring(4,6);
               }
        }
    }
}
