namespace HCIMorseProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelTriggerTime = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelOutOf = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.buttonDTTime = new System.Windows.Forms.Button();
            this.labelDotTime = new System.Windows.Forms.Label();
            this.labelDetectedWord = new System.Windows.Forms.Label();
            this.labelDetectedLetter = new System.Windows.Forms.Label();
            this.labelDashTime = new System.Windows.Forms.Label();
            this.buttonDash = new System.Windows.Forms.Button();
            this.textBoxTimeSet = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelDetectedMorse = new System.Windows.Forms.Label();
            this.buttonWordMake = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(277, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 34);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current LightValue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set LightValues";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Location = new System.Drawing.Point(279, 202);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(41, 17);
            this.labelLow.TabIndex = 3;
            this.labelLow.Text = "Low: ";
            this.labelLow.Click += new System.EventHandler(this.LabelLow_Click);
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(367, 202);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(45, 17);
            this.labelHigh.TabIndex = 4;
            this.labelHigh.Text = "High: ";
            this.labelHigh.Click += new System.EventHandler(this.LabelHigh_Click);
            // 
            // labelTriggerTime
            // 
            this.labelTriggerTime.AutoSize = true;
            this.labelTriggerTime.Location = new System.Drawing.Point(282, 77);
            this.labelTriggerTime.Name = "labelTriggerTime";
            this.labelTriggerTime.Size = new System.Drawing.Size(83, 17);
            this.labelTriggerTime.TabIndex = 6;
            this.labelTriggerTime.Text = "Value Time:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Light on?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelOutOf
            // 
            this.labelOutOf.AutoSize = true;
            this.labelOutOf.Location = new System.Drawing.Point(337, 181);
            this.labelOutOf.Name = "labelOutOf";
            this.labelOutOf.Size = new System.Drawing.Size(28, 17);
            this.labelOutOf.TabIndex = 8;
            this.labelOutOf.Text = "0/3";
            this.labelOutOf.Click += new System.EventHandler(this.LabelOutOf_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 12);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(260, 426);
            this.dataView.TabIndex = 9;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            // 
            // buttonDTTime
            // 
            this.buttonDTTime.Location = new System.Drawing.Point(521, 13);
            this.buttonDTTime.Name = "buttonDTTime";
            this.buttonDTTime.Size = new System.Drawing.Size(114, 37);
            this.buttonDTTime.TabIndex = 10;
            this.buttonDTTime.Text = "See DotTime";
            this.buttonDTTime.UseVisualStyleBackColor = true;
            this.buttonDTTime.Click += new System.EventHandler(this.ButtonDTTime_Click);
            // 
            // labelDotTime
            // 
            this.labelDotTime.AutoSize = true;
            this.labelDotTime.Location = new System.Drawing.Point(641, 23);
            this.labelDotTime.Name = "labelDotTime";
            this.labelDotTime.Size = new System.Drawing.Size(81, 17);
            this.labelDotTime.TabIndex = 11;
            this.labelDotTime.Text = "Dot Time: 0";
            // 
            // labelDetectedWord
            // 
            this.labelDetectedWord.AutoSize = true;
            this.labelDetectedWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDetectedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetectedWord.Location = new System.Drawing.Point(278, 394);
            this.labelDetectedWord.Name = "labelDetectedWord";
            this.labelDetectedWord.Size = new System.Drawing.Size(306, 44);
            this.labelDetectedWord.TabIndex = 12;
            this.labelDetectedWord.Text = "_____________";
            // 
            // labelDetectedLetter
            // 
            this.labelDetectedLetter.AutoSize = true;
            this.labelDetectedLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetectedLetter.Location = new System.Drawing.Point(277, 318);
            this.labelDetectedLetter.Name = "labelDetectedLetter";
            this.labelDetectedLetter.Size = new System.Drawing.Size(189, 29);
            this.labelDetectedLetter.TabIndex = 13;
            this.labelDetectedLetter.Text = "Detected Letter: ";
            // 
            // labelDashTime
            // 
            this.labelDashTime.AutoSize = true;
            this.labelDashTime.Location = new System.Drawing.Point(641, 67);
            this.labelDashTime.Name = "labelDashTime";
            this.labelDashTime.Size = new System.Drawing.Size(92, 17);
            this.labelDashTime.TabIndex = 14;
            this.labelDashTime.Text = "Dash Time: 0";
            // 
            // buttonDash
            // 
            this.buttonDash.Location = new System.Drawing.Point(521, 57);
            this.buttonDash.Name = "buttonDash";
            this.buttonDash.Size = new System.Drawing.Size(114, 37);
            this.buttonDash.TabIndex = 15;
            this.buttonDash.Text = "See DashTime";
            this.buttonDash.UseVisualStyleBackColor = true;
            this.buttonDash.Click += new System.EventHandler(this.ButtonDash_Click);
            // 
            // textBoxTimeSet
            // 
            this.textBoxTimeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeSet.Location = new System.Drawing.Point(521, 100);
            this.textBoxTimeSet.Name = "textBoxTimeSet";
            this.textBoxTimeSet.Size = new System.Drawing.Size(133, 34);
            this.textBoxTimeSet.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 17;
            this.button2.Text = "Set Dot Time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 34);
            this.button3.TabIndex = 18;
            this.button3.Text = "Clear String";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // labelDetectedMorse
            // 
            this.labelDetectedMorse.AutoSize = true;
            this.labelDetectedMorse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDetectedMorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetectedMorse.Location = new System.Drawing.Point(278, 347);
            this.labelDetectedMorse.Name = "labelDetectedMorse";
            this.labelDetectedMorse.Size = new System.Drawing.Size(306, 44);
            this.labelDetectedMorse.TabIndex = 19;
            this.labelDetectedMorse.Text = "_____________";
            // 
            // buttonWordMake
            // 
            this.buttonWordMake.Location = new System.Drawing.Point(602, 404);
            this.buttonWordMake.Name = "buttonWordMake";
            this.buttonWordMake.Size = new System.Drawing.Size(168, 34);
            this.buttonWordMake.TabIndex = 20;
            this.buttonWordMake.Text = "Create Word";
            this.buttonWordMake.UseVisualStyleBackColor = true;
            this.buttonWordMake.Click += new System.EventHandler(this.ButtonWordMake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWordMake);
            this.Controls.Add(this.labelDetectedMorse);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxTimeSet);
            this.Controls.Add(this.buttonDash);
            this.Controls.Add(this.labelDashTime);
            this.Controls.Add(this.labelDetectedLetter);
            this.Controls.Add(this.labelDetectedWord);
            this.Controls.Add(this.labelDotTime);
            this.Controls.Add(this.buttonDTTime);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.labelOutOf);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelTriggerTime);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelTriggerTime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelOutOf;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button buttonDTTime;
        private System.Windows.Forms.Label labelDotTime;
        private System.Windows.Forms.Label labelDetectedWord;
        private System.Windows.Forms.Label labelDetectedLetter;
        private System.Windows.Forms.Label labelDashTime;
        private System.Windows.Forms.Button buttonDash;
        private System.Windows.Forms.TextBox textBoxTimeSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelDetectedMorse;
        private System.Windows.Forms.Button buttonWordMake;
    }
}

