using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFIU_REPORT
{
    public partial class Form1 : Form
    {
        int currentTabCount = 0;
        int lastTabCount =0;
        int newTabCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            currentTabCount = Convert.ToInt32(deviceCountNumericUpDown.Value);


            if (currentTabCount > lastTabCount)
            {
                lastTabCount = currentTabCount;

                for (int n = lastTabCount; n <= currentTabCount; n++)
                {
                    mainTabPage.TabPages.Add((n).ToString(),"Device " + (n).ToString());
                    
           

                }
            }
            if (currentTabCount < lastTabCount)
            {
                
                for (int n = lastTabCount; n >= currentTabCount; n--)
                {
                    mainTabPage.TabPages.RemoveByKey((n).ToString());
                }
                lastTabCount = currentTabCount;
            }



            }
        
    }
}


/*            if (!string.IsNullOrWhiteSpace(deviceCountTextBox.Text))
            { 
            deviceCount= Convert.ToInt16(deviceCountTextBox.Text);
            }
            string tabName;

            if (deviceCount == 0)
                MessageBox.Show("invalid");
            else
            {
                for (int n = 0; n <= deviceCount; n++)
                {
                    tabName = "Device " + (n).ToString();
mainTabPage.TabPages.Add(tabName);
                }
            }
            8 */
            