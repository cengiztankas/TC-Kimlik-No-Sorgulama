using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikNoSorgulama_Soap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            long tc=long.Parse(txttc.Text);
            int yil = int.Parse(txtdogumyili.Text);
            bool durum = false;
            try
            {
                using(TcKimlikDogrulama.KPSPublicSoapClient tcService = new TcKimlikDogrulama.KPSPublicSoapClient { })
                {
                  durum=  tcService.TCKimlikNoDogrula(tc, txtad.Text, txtsoyad.Text, yil);
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
            if(durum)
            {
                MessageBox.Show("Bu Kullanıcı Sistemde Kayıtlı");
            }
            else
            {
                MessageBox.Show("!!! Bu Kullanıcı Sistemde Kayıtlı Değil");

            }
        }
    }
}
