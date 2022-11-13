using IronPython.Modules;
using System;
using System.Collections.Generic;

namespace GUI_LFU_new
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.credit = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Box_3 = new System.Windows.Forms.GroupBox();
            this.no_data_sim = new System.Windows.Forms.Label();
            this.Box_2 = new System.Windows.Forms.GroupBox();
            this.no_data_proc = new System.Windows.Forms.Label();
            this.Box_4 = new System.Windows.Forms.GroupBox();
            this.pan_main = new System.Windows.Forms.Panel();
            this.label_none_sim = new System.Windows.Forms.Label();
            this.Box_1 = new System.Windows.Forms.GroupBox();
            this.listView_hit = new System.Windows.Forms.ListView();
            this.index_h = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.page_hit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_fault = new System.Windows.Forms.ListView();
            this.index_f = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.page_f = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_data = new System.Windows.Forms.ListView();
            this.data_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.select_but = new System.Windows.Forms.Button();
            this.sim_but = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Box_3.SuspendLayout();
            this.Box_2.SuspendLayout();
            this.Box_4.SuspendLayout();
            this.Box_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.sim_but);
            this.panel1.Controls.Add(this.select_but);
            this.panel1.Controls.Add(this.credit);
            this.panel1.Controls.Add(this.insert_button);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 784);
            this.panel1.TabIndex = 0;
            // 
            // credit
            // 
            this.credit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.credit.FlatAppearance.BorderSize = 0;
            this.credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.White;
            this.credit.Location = new System.Drawing.Point(0, 719);
            this.credit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(295, 65);
            this.credit.TabIndex = 3;
            this.credit.Text = "Credit";
            this.credit.UseVisualStyleBackColor = true;
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // insert_button
            // 
            this.insert_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.insert_button.FlatAppearance.BorderSize = 0;
            this.insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.ForeColor = System.Drawing.Color.White;
            this.insert_button.Location = new System.Drawing.Point(0, 245);
            this.insert_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(295, 65);
            this.insert_button.TabIndex = 1;
            this.insert_button.Text = "Insert Data";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 245);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(17, 87);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 12);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Simulation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Least Frequently Used";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "LFU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.Box_3);
            this.panel2.Controls.Add(this.Box_2);
            this.panel2.Controls.Add(this.Box_4);
            this.panel2.Controls.Add(this.Box_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 784);
            this.panel2.TabIndex = 1;
            // 
            // Box_3
            // 
            this.Box_3.Controls.Add(this.no_data_sim);
            this.Box_3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_3.ForeColor = System.Drawing.Color.White;
            this.Box_3.Location = new System.Drawing.Point(672, 281);
            this.Box_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_3.Name = "Box_3";
            this.Box_3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_3.Size = new System.Drawing.Size(356, 201);
            this.Box_3.TabIndex = 3;
            this.Box_3.TabStop = false;
            this.Box_3.Text = "Simulate information";
            // 
            // no_data_sim
            // 
            this.no_data_sim.AutoSize = true;
            this.no_data_sim.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_data_sim.ForeColor = System.Drawing.Color.Yellow;
            this.no_data_sim.Location = new System.Drawing.Point(127, 89);
            this.no_data_sim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.no_data_sim.Name = "no_data_sim";
            this.no_data_sim.Size = new System.Drawing.Size(95, 37);
            this.no_data_sim.TabIndex = 1;
            this.no_data_sim.Text = "None";
            // 
            // Box_2
            // 
            this.Box_2.Controls.Add(this.no_data_proc);
            this.Box_2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_2.ForeColor = System.Drawing.Color.White;
            this.Box_2.Location = new System.Drawing.Point(672, 36);
            this.Box_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_2.Name = "Box_2";
            this.Box_2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_2.Size = new System.Drawing.Size(356, 230);
            this.Box_2.TabIndex = 2;
            this.Box_2.TabStop = false;
            this.Box_2.Text = "Information each process";
            // 
            // no_data_proc
            // 
            this.no_data_proc.AutoSize = true;
            this.no_data_proc.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_data_proc.ForeColor = System.Drawing.Color.Yellow;
            this.no_data_proc.Location = new System.Drawing.Point(127, 103);
            this.no_data_proc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.no_data_proc.Name = "no_data_proc";
            this.no_data_proc.Size = new System.Drawing.Size(95, 37);
            this.no_data_proc.TabIndex = 0;
            this.no_data_proc.Text = "None";
            this.no_data_proc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Box_4
            // 
            this.Box_4.Controls.Add(this.pan_main);
            this.Box_4.Controls.Add(this.label_none_sim);
            this.Box_4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_4.ForeColor = System.Drawing.Color.White;
            this.Box_4.Location = new System.Drawing.Point(28, 489);
            this.Box_4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_4.Name = "Box_4";
            this.Box_4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_4.Size = new System.Drawing.Size(1008, 281);
            this.Box_4.TabIndex = 1;
            this.Box_4.TabStop = false;
            this.Box_4.Text = "Simulation View";
            // 
            // pan_main
            // 
            this.pan_main.AutoScroll = true;
            this.pan_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_main.Location = new System.Drawing.Point(203, 23);
            this.pan_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pan_main.Name = "pan_main";
            this.pan_main.Size = new System.Drawing.Size(797, 249);
            this.pan_main.TabIndex = 3;
            // 
            // label_none_sim
            // 
            this.label_none_sim.AutoSize = true;
            this.label_none_sim.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_none_sim.ForeColor = System.Drawing.Color.Yellow;
            this.label_none_sim.Location = new System.Drawing.Point(51, 132);
            this.label_none_sim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_none_sim.Name = "label_none_sim";
            this.label_none_sim.Size = new System.Drawing.Size(95, 37);
            this.label_none_sim.TabIndex = 2;
            this.label_none_sim.Text = "None";
            // 
            // Box_1
            // 
            this.Box_1.Controls.Add(this.listView_hit);
            this.Box_1.Controls.Add(this.listView_fault);
            this.Box_1.Controls.Add(this.listView_data);
            this.Box_1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_1.ForeColor = System.Drawing.Color.White;
            this.Box_1.Location = new System.Drawing.Point(28, 36);
            this.Box_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_1.Name = "Box_1";
            this.Box_1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_1.Size = new System.Drawing.Size(619, 438);
            this.Box_1.TabIndex = 0;
            this.Box_1.TabStop = false;
            this.Box_1.Text = "Data Information";
            // 
            // listView_hit
            // 
            this.listView_hit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(245)))), ((int)(((byte)(143)))));
            this.listView_hit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index_h,
            this.page_hit});
            this.listView_hit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_hit.GridLines = true;
            this.listView_hit.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_hit.HideSelection = false;
            this.listView_hit.Location = new System.Drawing.Point(448, 32);
            this.listView_hit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_hit.Name = "listView_hit";
            this.listView_hit.Size = new System.Drawing.Size(148, 382);
            this.listView_hit.TabIndex = 2;
            this.listView_hit.UseCompatibleStateImageBehavior = false;
            this.listView_hit.View = System.Windows.Forms.View.Details;
            // 
            // index_h
            // 
            this.index_h.Text = "Index";
            this.index_h.Width = 50;
            // 
            // page_hit
            // 
            this.page_hit.Text = "Hits";
            // 
            // listView_fault
            // 
            this.listView_fault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(89)))), ((int)(((byte)(114)))));
            this.listView_fault.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index_f,
            this.page_f});
            this.listView_fault.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_fault.GridLines = true;
            this.listView_fault.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_fault.HideSelection = false;
            this.listView_fault.Location = new System.Drawing.Point(283, 32);
            this.listView_fault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_fault.Name = "listView_fault";
            this.listView_fault.Size = new System.Drawing.Size(143, 382);
            this.listView_fault.TabIndex = 1;
            this.listView_fault.UseCompatibleStateImageBehavior = false;
            this.listView_fault.View = System.Windows.Forms.View.Details;
            // 
            // index_f
            // 
            this.index_f.Text = "Index";
            this.index_f.Width = 50;
            // 
            // page_f
            // 
            this.page_f.Text = "Faults";
            // 
            // listView_data
            // 
            this.listView_data.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.data_1,
            this.data_2});
            this.listView_data.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_data.FullRowSelect = true;
            this.listView_data.GridLines = true;
            this.listView_data.HideSelection = false;
            this.listView_data.HoverSelection = true;
            this.listView_data.Location = new System.Drawing.Point(35, 32);
            this.listView_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_data.Name = "listView_data";
            this.listView_data.Size = new System.Drawing.Size(224, 382);
            this.listView_data.TabIndex = 0;
            this.listView_data.UseCompatibleStateImageBehavior = false;
            this.listView_data.View = System.Windows.Forms.View.Details;
            // 
            // data_1
            // 
            this.data_1.Text = "Index";
            // 
            // data_2
            // 
            this.data_2.Text = "Data";
            this.data_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.data_2.Width = 100;
            // 
            // select_but
            // 
            this.select_but.Dock = System.Windows.Forms.DockStyle.Top;
            this.select_but.FlatAppearance.BorderSize = 0;
            this.select_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_but.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_but.ForeColor = System.Drawing.Color.White;
            this.select_but.Location = new System.Drawing.Point(0, 310);
            this.select_but.Margin = new System.Windows.Forms.Padding(4);
            this.select_but.Name = "select_but";
            this.select_but.Size = new System.Drawing.Size(295, 65);
            this.select_but.TabIndex = 4;
            this.select_but.Text = "Select Algo";
            this.select_but.UseVisualStyleBackColor = true;
            this.select_but.Click += new System.EventHandler(this.select_but_Click);
            // 
            // sim_but
            // 
            this.sim_but.Dock = System.Windows.Forms.DockStyle.Top;
            this.sim_but.FlatAppearance.BorderSize = 0;
            this.sim_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sim_but.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim_but.ForeColor = System.Drawing.Color.White;
            this.sim_but.Location = new System.Drawing.Point(0, 375);
            this.sim_but.Margin = new System.Windows.Forms.Padding(4);
            this.sim_but.Name = "sim_but";
            this.sim_but.Size = new System.Drawing.Size(295, 65);
            this.sim_but.TabIndex = 5;
            this.sim_but.Text = "Simulate";
            this.sim_but.UseVisualStyleBackColor = true;
            this.sim_but.Click += new System.EventHandler(this.sim_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 784);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Least Frequently Used";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Box_3.ResumeLayout(false);
            this.Box_3.PerformLayout();
            this.Box_2.ResumeLayout(false);
            this.Box_2.PerformLayout();
            this.Box_4.ResumeLayout(false);
            this.Box_4.PerformLayout();
            this.Box_1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button credit;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Box_3;
        private System.Windows.Forms.GroupBox Box_2;
        private System.Windows.Forms.GroupBox Box_4;
        private System.Windows.Forms.GroupBox Box_1;
        private System.Windows.Forms.ListView listView_data;
        private System.Windows.Forms.ColumnHeader data_1;
        private System.Windows.Forms.ColumnHeader data_2;
        private System.Windows.Forms.ListView listView_hit;
        private System.Windows.Forms.ColumnHeader index_h;
        private System.Windows.Forms.ColumnHeader page_hit;
        private System.Windows.Forms.ListView listView_fault;
        private System.Windows.Forms.ColumnHeader index_f;
        private System.Windows.Forms.ColumnHeader page_f;
        private System.Windows.Forms.Label no_data_sim;
        private System.Windows.Forms.Label no_data_proc;
        private System.Windows.Forms.Panel pan_main;
        private System.Windows.Forms.Label label_none_sim;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button select_but;
        private System.Windows.Forms.Button sim_but;
    }
}

