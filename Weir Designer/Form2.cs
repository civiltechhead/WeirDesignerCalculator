using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weir_Designer
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            results.Text = "==WEIR CALCULATOR RESULTS==";
            results.AppendText(Environment.NewLine + "Flow: " + Form1.instance.flow_local + " m^3/s");
            results.AppendText(Environment.NewLine + "Froude's number: " + Form1.instance.froude_local);
            results.AppendText(Environment.NewLine + "Area: " + Form1.instance.area_local + " m^2");
            results.AppendText(Environment.NewLine + "Perimeter: " + Form1.instance.perimeter_local + " m");
            results.AppendText(Environment.NewLine + "Freeboard: " + Form1.instance.freeboard_local + " m");
            results.AppendText(Environment.NewLine + "Curvature: " + Form1.instance.curvature_local + " m");
            results.AppendText(Environment.NewLine + "Flow velocity: " + Form1.instance.fvelocity_local + " m/s");
            results.AppendText(Environment.NewLine + "Water rise: " + Form1.instance.water_rise_local + " m");
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            string filename = "";

            saveDlg.Filter = "Rich text file (*.rtf) | *.rtf | Plain Text File (*.txt) | *.txt";
            saveDlg.DefaultExt = "*.rtf";
            saveDlg.FilterIndex = 1;
            saveDlg.Title = "Save the contents";

            DialogResult retval = saveDlg.ShowDialog();
            if (retval == DialogResult.OK)
            {
                filename = saveDlg.FileName;
            }
            else
            {
                return;
            }

            RichTextBoxStreamType stream_type;
            if (saveDlg.FilterIndex == 2)
            {
                stream_type = RichTextBoxStreamType.PlainText;
            }
            else
            {
                stream_type = RichTextBoxStreamType.RichText;
            }

            results.SaveFile(filename, stream_type);
        }
    }
}
