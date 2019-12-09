using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sdwEncDec
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        #region Button Click Functions
        private void btnAESEnc_Click(object sender, EventArgs e)
        {
            AESEncDec aesEncDec = new AESEncDec();
            byte[] data = Encoding.Unicode.GetBytes(textBox1.Text);
            data = aesEncDec.Encrypt(data, null, null);
            textBox2.Text = Convert.ToBase64String(data);
            return;
        }
        private void btnAESDec_Click(object sender, EventArgs e)
        {
            AESEncDec dc = new AESEncDec();
            byte[] data = Convert.FromBase64String(textBox1.Text);
            data = dc.Decrypt(data, null, null);
            textBox2.Text = Encoding.Unicode.GetString(data);
            return;
        }
        private void btnDESEnc_Click(object sender, EventArgs e)
        {
            DESEncDec desEncDec = new DESEncDec();
            string plain = textBox1.Text;
            string encrypted = desEncDec.Encrypt(plain);
            textBox2.Text = encrypted;
            return;
        }
        
        private void btnDESDec_Click(object sender, EventArgs e)
        {
            DESEncDec desEncDec = new DESEncDec();
            string str = textBox1.Text;
            textBox2.Text = desEncDec.Decrypt(str);
            return;
        }
        private void btnRC2Enc_Click(object sender, EventArgs e)
        {
            RC2EncDec _rc2 = new RC2EncDec();
            string str = textBox1.Text;
            textBox2.Text = _rc2.Encrypt(str);
            return;
        }

        private void btnRC2Dec_Click(object sender, EventArgs e)
        {
            RC2EncDec _rc2 = new RC2EncDec();
            string str = textBox1.Text;
            textBox2.Text = _rc2.Decrypt(str);
            return;
        }
        private void btnTriDesEnc_Click(object sender, EventArgs e)
        {
            TripleDESEncDec _tri = new TripleDESEncDec();
            string str = textBox1.Text;
            textBox2.Text = _tri.Encrypt(str,false);
            return;
        }

        private void btnTriDESDec_Click(object sender, EventArgs e)
        {
            TripleDESEncDec _tri = new TripleDESEncDec();
            string str = textBox1.Text;
            textBox2.Text = _tri.Decrypt(str, false);
        }
        #endregion

    }
}
