namespace Tyuiu.SeledkovNP.Sprint6.Task6.V22
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            Clik_fiels = new Button();
            Clik_open = new Button();
            Van = new Button();
            textBox1 = new TextBox();
            textVod = new TextBox();
            textVid = new TextBox();
            groupBoxIn = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxOut = new GroupBox();
            groupBoxIn.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Clik_fiels
            // 
            Clik_fiels.Image = (Image)resources.GetObject("Clik_fiels.Image");
            Clik_fiels.Location = new Point(12, 12);
            Clik_fiels.Name = "Clik_fiels";
            Clik_fiels.Size = new Size(53, 54);
            Clik_fiels.TabIndex = 1;
            toolTip1.SetToolTip(Clik_fiels, " Зугрузить файл из вашего устроства");
            Clik_fiels.UseVisualStyleBackColor = true;
            Clik_fiels.Click += Clik_fiels_Click;
            // 
            // Clik_open
            // 
            Clik_open.Image = (Image)resources.GetObject("Clik_open.Image");
            Clik_open.Location = new Point(71, 12);
            Clik_open.Name = "Clik_open";
            Clik_open.Size = new Size(62, 54);
            Clik_open.TabIndex = 2;
            toolTip1.SetToolTip(Clik_open, " Открыт ваш вайл ");
            Clik_open.UseVisualStyleBackColor = true;
            Clik_open.Click += Clik_open_Click;
            // 
            // Van
            // 
            Van.BackColor = SystemColors.ActiveCaption;
            Van.Image = (Image)resources.GetObject("Van.Image");
            Van.Location = new Point(733, 12);
            Van.Name = "Van";
            Van.Size = new Size(55, 54);
            Van.TabIndex = 3;
            toolTip1.SetToolTip(Van, " Eror 404");
            Van.UseVisualStyleBackColor = false;
            Van.Click += Van_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(1, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(800, 94);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textVod
            // 
            textVod.BackColor = SystemColors.Menu;
            textVod.BorderStyle = BorderStyle.None;
            textVod.ForeColor = Color.Black;
            textVod.Location = new Point(12, 118);
            textVod.Multiline = true;
            textVod.Name = "textVod";
            textVod.ReadOnly = true;
            textVod.Size = new Size(106, 17);
            textVod.TabIndex = 6;
            textVod.Text = "Ввод;";
            textVod.TextChanged += textVod_TextChanged;
            // 
            // textVid
            // 
            textVid.BackColor = SystemColors.Menu;
            textVid.BorderStyle = BorderStyle.None;
            textVid.ForeColor = Color.Black;
            textVid.Location = new Point(414, 118);
            textVid.Multiline = true;
            textVid.Name = "textVid";
            textVid.ReadOnly = true;
            textVid.Size = new Size(106, 17);
            textVid.TabIndex = 7;
            textVid.Text = "Вывод:";
            textVid.TextChanged += textVid_TextChanged;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxResult);
            groupBoxIn.Location = new Point(12, 141);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(377, 297);
            groupBoxIn.TabIndex = 8;
            groupBoxIn.TabStop = false;
            groupBoxIn.Enter += groupBox1_Enter;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(0, 77);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(371, 214);
            textBoxResult.TabIndex = 10;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Location = new Point(414, 141);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(374, 297);
            groupBoxOut.TabIndex = 9;
            groupBoxOut.TabStop = false;
            groupBoxOut.Enter += groupBox2_Enter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 473);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxIn);
            Controls.Add(textVid);
            Controls.Add(textVod);
            Controls.Add(Van);
            Controls.Add(Clik_open);
            Controls.Add(Clik_fiels);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Seledkov Nikita SMAPTb-24-1 / Task 6 V22";
            Load += FormMain_Load;
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private TextBox textBox1;
        private Button Clik_fiels;
        private Button Clik_open;
        private Button Van;
        private TextBox textVod;
        private TextBox textVid;
        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;
        private TextBox textBoxResult;
    }
}
