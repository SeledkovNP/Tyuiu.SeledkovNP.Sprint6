namespace Tyuiu.SeledkovNP.Sprint6.Task1.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBox_Test = new PictureBox();
            button_res = new Button();
            button_Help = new Button();
            textBoxOutputData = new TextBox();
            textBoxResult = new TextBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Test).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Test
            // 
            pictureBox_Test.Image = (Image)resources.GetObject("pictureBox_Test.Image");
            pictureBox_Test.Location = new Point(12, 12);
            pictureBox_Test.Name = "pictureBox_Test";
            pictureBox_Test.Size = new Size(631, 208);
            pictureBox_Test.TabIndex = 0;
            pictureBox_Test.TabStop = false;
            // 
            // button_res
            // 
            button_res.Location = new Point(548, 380);
            button_res.Name = "button_res";
            button_res.Size = new Size(128, 58);
            button_res.TabIndex = 1;
            button_res.Text = "Завершит";
            button_res.UseVisualStyleBackColor = true;
            button_res.Click += button_res_Click;
            // 
            // button_Help
            // 
            button_Help.Location = new Point(503, 406);
            button_Help.Name = "button_Help";
            button_Help.Size = new Size(39, 32);
            button_Help.TabIndex = 2;
            button_Help.Text = "?";
            button_Help.UseVisualStyleBackColor = true;
            button_Help.Click += button_Help_Click;
            // 
            // textBoxOutputData
            // 
            textBoxOutputData.Location = new Point(12, 12);
            textBoxOutputData.Multiline = true;
            textBoxOutputData.Name = "textBoxOutputData";
            textBoxOutputData.Size = new Size(631, 208);
            textBoxOutputData.TabIndex = 3;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(708, 12);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(327, 426);
            textBoxResult.TabIndex = 4;
            textBoxResult.TextChanged += this.textBoxResult_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 397);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(115, 41);
            textBoxStart.TabIndex = 5;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(167, 397);
            textBoxStop.Multiline = true;
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(115, 41);
            textBoxStop.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 450);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxResult);
            Controls.Add(button_Help);
            Controls.Add(button_res);
            Controls.Add(pictureBox_Test);
            Controls.Add(textBoxOutputData);
            Name = "FormMain";
            Text = "Спринт 6 / Таск 1 / Вариант 25 / Селедков Н. П.";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Test).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Test;
        private Button button_res;
        private Button button_Help;
        private TextBox textBoxOutputData;
        private TextBox textBoxResult;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
    }
}
