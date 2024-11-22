namespace CorromperFile
{
    partial class Form1
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
            button_examine = new Button();
            textBox_examine = new TextBox();
            button_Corromper = new Button();
            button_sanear = new Button();
            textBox_key = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_examine
            // 
            button_examine.Location = new Point(12, 56);
            button_examine.Name = "button_examine";
            button_examine.Size = new Size(75, 23);
            button_examine.TabIndex = 0;
            button_examine.Text = "Examine...";
            button_examine.UseVisualStyleBackColor = true;
            // 
            // textBox_examine
            // 
            textBox_examine.Location = new Point(104, 57);
            textBox_examine.Name = "textBox_examine";
            textBox_examine.Size = new Size(304, 23);
            textBox_examine.TabIndex = 1;
            // 
            // button_Corromper
            // 
            button_Corromper.Location = new Point(104, 99);
            button_Corromper.Name = "button_Corromper";
            button_Corromper.Size = new Size(127, 33);
            button_Corromper.TabIndex = 2;
            button_Corromper.Text = "Corromper";
            button_Corromper.UseVisualStyleBackColor = true;
            // 
            // button_sanear
            // 
            button_sanear.Location = new Point(281, 99);
            button_sanear.Name = "button_sanear";
            button_sanear.Size = new Size(127, 33);
            button_sanear.TabIndex = 3;
            button_sanear.Text = "Sanear";
            button_sanear.UseVisualStyleBackColor = true;
            // 
            // textBox_key
            // 
            textBox_key.Location = new Point(108, 12);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(181, 23);
            textBox_key.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "key corrupcion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 175);
            Controls.Add(label1);
            Controls.Add(textBox_key);
            Controls.Add(button_sanear);
            Controls.Add(button_Corromper);
            Controls.Add(textBox_examine);
            Controls.Add(button_examine);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_examine;
        private TextBox textBox_examine;
        private Button button_Corromper;
        private Button button_sanear;
        private TextBox textBox_key;
        private Label label1;
    }
}
