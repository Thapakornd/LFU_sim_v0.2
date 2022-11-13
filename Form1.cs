using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.VisualBasic;

namespace GUI_LFU_new
{
    public partial class Form1 : Form
    {
        private string[] data_excel;
        private dynamic py_1 = Python.CreateEngine().ExecuteFile("LFU/LFU_algo.py");
        private dynamic py_2 = Python.CreateEngine().ExecuteFile("LFU/new_LFU_algo.py");
        private IList<object> data_simulated;   // Make result to list to used.
        private int input_frame_inused, selected_algo;
        private dynamic data_h_f,LFU;

        public Form1()
        {
            InitializeComponent();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {

            //MessageBox.Show()
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileExt = Path.GetExtension(ofd.FileName);
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        data_excel = ExcelFileReader(ofd.FileName); // Set Excel read file to string[]
                        listView_data.Items.Clear();  // Clear data before add new data
                        for (int i = 0; i < data_excel.Count(); i++) // <-- Use Data send to DataViewList
                        {
                            ListViewItem view_excel = new ListViewItem((i + 1).ToString());
                            view_excel.SubItems.Add(data_excel[i]);
                            listView_data.Items.Add(view_excel);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Pls chose correct");
                }
            }
        }

        private string[] ExcelFileReader(string path) 
        {
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();

            List<string> list_1 = new List<string>();
            foreach (DataRow row in result.Tables[0].Rows) 
            {
                list_1.Add(row.ItemArray[0].ToString());
            }

            string[] data_num = list_1.ToArray();
            return data_num;
        }

        // Show Informaion each process
        private void show_infomation(object sender, EventArgs e) 
        {
            Button btn = (Button)sender;
            int frame_index = int.Parse(btn.Parent.Name);   // Set address of frame index
            string proc_index = btn.Text;                   // Set address of data index
            IList<object> frame_select = (IList<object>) data_simulated[frame_index];    // Set address into all data
            Box_2.Controls.Clear();
          
            for (int i = 0; i < input_frame_inused; i++) 
            {
                IList<object> new_info = (IList<object>) frame_select[i];
                if (new_info == null)
                {
                    break;
                }
                else if (new_info[0] == null) 
                {
                    break;
                }
                else if (new_info[0].ToString() == proc_index)
                {
                    Box_2.Controls.Clear();
                    TextBox data_s_text = new TextBox();
                    data_s_text.BackColor = SystemColors.InactiveCaption;
                    data_s_text.BorderStyle = BorderStyle.None;
                    data_s_text.Location = new Point(15, 36);
                    data_s_text.Margin = new Padding(4);
                    data_s_text.Multiline = true;
                    data_s_text.ReadOnly = true;
                    data_s_text.ScrollBars = ScrollBars.Vertical;
                    data_s_text.Size = new Size(230, 120);
                    if (selected_algo == 1)
                    {
                        data_s_text.Text = "Data process: " + new_info[0].ToString() +
                        "\r\n\r\nFrequently : " + new_info[1].ToString() +
                        "\r\n\r\nLong time place : " + new_info[2].ToString();
                    }
                    else
                    {
                        IList<object> freq_frame = (IList<object>)data_h_f[3][frame_index];
                        data_s_text.Text = "Data process: " + new_info[0].ToString() +
                            "\r\n\r\nLong time place : " + new_info[1].ToString() +
                            "\r\n\r\nFrequently : " + get_freq(freq_frame);
                    }
                    
                    Box_2.Controls.Add(data_s_text);
                    break;
                }
            }
            
        }

        private string get_freq(IList<object> data_freq) 
        {
            List<string> freq = new List<string>();
            for (int i = 0; i < data_freq.Count(); i++)
            {
                IList<object> ref_data = (IList<object>)data_freq[i];
                freq.Add(ref_data[0].ToString() + ":" + ref_data[1].ToString());
            }
            string[] new_data = freq.ToArray();
            string new_data_1 = string.Join(", ", new_data);
            return new_data_1;
        }

        private void credit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by AlanWake and Gausubald", "Credit");
        }

        private void sim_but_Click(object sender, EventArgs e)
        {
            pan_main.Controls.Clear();
            try
            {
                string input_frame = Interaction.InputBox("Enter frame to comput.", "Frame Input", "Frame that you want");

                try
                {
                    input_frame_inused = int.Parse(input_frame);
                }
                catch
                {
                    MessageBox.Show("Pls enter correct value!");
                    return;
                }

                // Condition Check selected algo
                if (selected_algo == 1)
                {
                    LFU = py_1.LFU();  // <-- Used python algorithm  Gus
                    data_h_f = LFU.main_func(input_frame_inused, data_excel);  // func ( INPUT , DATA_EXCEL )
                }
                else if (selected_algo == 2) 
                {
                    LFU = py_2.LFU();  // <-- Used python algorithm  Alan
                    data_h_f = LFU.mainfunc(input_frame_inused, data_excel);  // func ( INPUT , DATA_EXCEL )
                }

                listView_fault.Items.Clear();  // Clear data in list view hit and faluts
                listView_hit.Items.Clear();
                label_none_sim.Text = "Frame used\n" + input_frame;
                label_none_sim.TextAlign = ContentAlignment.MiddleCenter;   // Set new text simulation
                label_none_sim.Location = new Point(3, 80);
                Box_3.Controls.Clear();

                data_simulated = data_h_f[0];
                IList<object> ref_f = data_h_f[1];   // Make listview to show
                IList<object> ref_h = data_h_f[2];

                for (int i = 0; i < ref_f.Count(); i++)  // Show faults page
                {
                    ListViewItem view_fault = new ListViewItem((i + 1).ToString());
                    view_fault.SubItems.Add(ref_f[i].ToString());
                    listView_fault.Items.Add(view_fault);
                }

                for (int i = 0; i < ref_h.Count(); i++)  // Show hit page
                {
                    ListViewItem view_hits = new ListViewItem((i + 1).ToString());
                    view_hits.SubItems.Add(ref_h[i].ToString());
                    listView_hit.Items.Add(view_hits);
                }

                int first = 3;
                int first_text = 30;
                for (int i = 0; i < data_simulated.Count(); i++)  // Create simulated table 
                {
                    Panel new_panel = new Panel();
                    Label for_num_show = new Label();
                    IList<object> data_index_i = (IList<object>)data_simulated[i];
                    int first_but = 3;

                    for (int j = 0; j < input_frame_inused; j++)
                    {
                        IList<object> data_inside_i = (IList<object>)data_index_i[j];
                        Button new_button = new Button();
                        if (data_inside_i == null)
                        {
                            new_button.Text = "None";
                        }
                        else if (data_inside_i[0] == null) 
                        {
                            new_button.Text = "None";
                        }
                        else
                        {
                            new_button.Text = data_inside_i[0].ToString();
                        }

                        // Set frame in timeline to button
                        new_button.Size = new Size(70, 30);
                        new_button.Location = new Point(3, first_but);
                        new_button.BackColor = Color.Black;
                        new_button.Click += show_infomation;
                        new_panel.Controls.Add(new_button);
                        first_but += 30;
                    }
                    // Set Text to tell what index in timeframe
                    if (i > 0)
                    {
                        for_num_show.Text = data_excel[i - 1].ToString();  // Set number value in time frame
                    }
                    else
                    {
                        for_num_show.Text = "None";  // Set number value in time frame
                    }
                    for_num_show.Location = new Point(first_text - i * 10, 20);
                    for_num_show.ForeColor = Color.Yellow;

                    new_panel.Name = i.ToString();
                    new_panel.AutoScroll = true;
                    new_panel.Size = new Size(100, 120);
                    new_panel.BackColor = Color.FromArgb(46, 126, 244);
                    new_panel.Location = new Point(first, 60);
                    pan_main.Controls.Add(new_panel);
                    pan_main.Controls.Add(for_num_show);

                    first_text += 120;
                    first += 110;
                }

                // Create panel result simulation
                Panel panel_sim_result = new Panel();
                panel_sim_result.BackColor = SystemColors.Desktop;
                panel_sim_result.Location = new Point(22, 32);
                panel_sim_result.Size = new Size(215, 115);
                panel_sim_result.TabIndex = 2;

                // Label Hit result
                Label hit_lable = new Label();
                hit_lable.Font = new Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                hit_lable.ForeColor = Color.Green;
                hit_lable.Location = new Point(14, 26);
                hit_lable.Size = new Size(129, 37);
                hit_lable.TabIndex = 0;
                hit_lable.Text = "Hit : " + ref_h.Count.ToString();

                // Label Fault result
                Label fault_lable = new Label();
                fault_lable.Font = new Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                fault_lable.ForeColor = Color.FromArgb(255, 6, 6);
                fault_lable.Location = new Point(14, 82);
                fault_lable.Size = new Size(129, 37);
                fault_lable.TabIndex = 0;
                fault_lable.Text = "Fault : " + ref_f.Count.ToString();

                panel_sim_result.Controls.Add(hit_lable);
                panel_sim_result.Controls.Add(fault_lable);
                Box_3.Controls.Add(panel_sim_result);

            }
            catch
            {
                MessageBox.Show("Something went wrong pls check your data is insert.");
            }

        }

        private void select_but_Click(object sender, EventArgs e)
        {
            try
            {
                string input_select = Interaction.InputBox("Select '1' or '2'\n\n 1 : Reset Frequently every new Data\n\n 2 : Non-reset Frequently every new Data)","Least Frequently Used");
                selected_algo = int.Parse(input_select);
                
            }
            catch 
            {
                MessageBox.Show("Something went wrong! Pls input correct word");
            }
        }
    }
}
