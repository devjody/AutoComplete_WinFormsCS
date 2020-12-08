
namespace WindowsFormsApp1
{
    partial class MyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbdesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbNEW = new System.Windows.Forms.TextBox();
            this.buttonADDNAME = new System.Windows.Forms.Button();
            this.AddedNamesLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.AutoCompleteCustomSource.AddRange(new string[] {
            "Kent",
            "Cyrus",
            "Gena",
            "Ernesto",
            "Eddy",
            "Yee",
            "Meda",
            "Irvin",
            "Ardath",
            "Randi",
            "Tamekia",
            "Rufus",
            "Leandro",
            "Estell",
            "Kimberly",
            "Marina",
            "Gertie",
            "Larita",
            "Sharla",
            "Epifania"});
            this.tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb.BackColor = System.Drawing.Color.Azure;
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb.Location = new System.Drawing.Point(15, 44);
            this.tb.Margin = new System.Windows.Forms.Padding(6);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(172, 31);
            this.tb.TabIndex = 0;
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auto Complete From Defined Collection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono Italic", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(11, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 80);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kent  \r\nCyrus  \r\nGena  \r\nErnesto  \r\nEddy  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Italic", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(94, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 80);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yee  \r\nMeda  \r\nIrvin  \r\nArdath  \r\nRandi  \r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Italic", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(177, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 80);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tamekia  \r\nRufus  \r\nLeandro  \r\nEstell  \r\nKimberly  \r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono Italic", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.label6.Location = new System.Drawing.Point(260, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 80);
            this.label6.TabIndex = 2;
            this.label6.Text = "Marina  \r\nGertie  \r\nLarita  \r\nSharla  \r\nEpifania ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(17, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 274);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(201)))));
            this.panel2.Controls.Add(this.tbdesc);
            this.panel2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(14, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 113);
            this.panel2.TabIndex = 4;
            // 
            // tbdesc
            // 
            this.tbdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(201)))));
            this.tbdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbdesc.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdesc.ForeColor = System.Drawing.Color.Black;
            this.tbdesc.Location = new System.Drawing.Point(7, 11);
            this.tbdesc.Multiline = true;
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(299, 92);
            this.tbdesc.TabIndex = 23;
            this.tbdesc.TabStop = false;
            this.tbdesc.Text = "Make a selection to see how the different AutoCompleteModes work!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.label7.Location = new System.Drawing.Point(74, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Custom Source Data List";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(15, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 114);
            this.panel3.TabIndex = 5;
            // 
            // cb1
            // 
            this.cb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "None",
            "Suggest",
            "Append",
            "SuggestAppend"});
            this.cb1.Location = new System.Drawing.Point(196, 44);
            this.cb1.MaxDropDownItems = 4;
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(166, 29);
            this.cb1.TabIndex = 1;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel4.Location = new System.Drawing.Point(20, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 272);
            this.panel4.TabIndex = 6;
            // 
            // tbNEW
            // 
            this.tbNEW.BackColor = System.Drawing.Color.Azure;
            this.tbNEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNEW.Location = new System.Drawing.Point(17, 369);
            this.tbNEW.Name = "tbNEW";
            this.tbNEW.Size = new System.Drawing.Size(170, 31);
            this.tbNEW.TabIndex = 2;
            this.tbNEW.TextChanged += new System.EventHandler(this.tbNEW_TextChanged);
            // 
            // buttonADDNAME
            // 
            this.buttonADDNAME.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADDNAME.Location = new System.Drawing.Point(196, 369);
            this.buttonADDNAME.Name = "buttonADDNAME";
            this.buttonADDNAME.Size = new System.Drawing.Size(166, 31);
            this.buttonADDNAME.TabIndex = 3;
            this.buttonADDNAME.Text = "Add Name";
            this.buttonADDNAME.UseVisualStyleBackColor = true;
            this.buttonADDNAME.Click += new System.EventHandler(this.buttonADDNAME_Click);
            // 
            // AddedNamesLabel
            // 
            this.AddedNamesLabel.AutoSize = true;
            this.AddedNamesLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddedNamesLabel.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedNamesLabel.ForeColor = System.Drawing.Color.MintCream;
            this.AddedNamesLabel.Location = new System.Drawing.Point(13, 12);
            this.AddedNamesLabel.Name = "AddedNamesLabel";
            this.AddedNamesLabel.Size = new System.Drawing.Size(21, 19);
            this.AddedNamesLabel.TabIndex = 5;
            this.AddedNamesLabel.Text = "...";
            this.AddedNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddedNamesLabel.Click += new System.EventHandler(this.AddedNamesLabel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.AddedNamesLabel);
            this.panel5.Location = new System.Drawing.Point(-1, 406);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 46);
            this.panel5.TabIndex = 10;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.LightCyan;
            this.toolTip1.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Click to remove!";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 448);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonADDNAME);
            this.Controls.Add(this.tbNEW);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Complete Program by Jody B";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbdesc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbNEW;
        private System.Windows.Forms.Button buttonADDNAME;
        private System.Windows.Forms.Label AddedNamesLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

