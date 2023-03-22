namespace WindowsFormsApplication1
{
    partial class survey
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
            this.JapanCheck = new System.Windows.Forms.CheckBox();
            this.surveyName = new System.Windows.Forms.Label();
            this.questionOne = new System.Windows.Forms.Label();
            this.PhilippinesCheck = new System.Windows.Forms.CheckBox();
            this.americaCheck = new System.Windows.Forms.CheckBox();
            this.othersText = new System.Windows.Forms.Label();
            this.othersBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.chinaCheck = new System.Windows.Forms.CheckBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.othersTwo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // JapanCheck
            // 
            this.JapanCheck.AutoSize = true;
            this.JapanCheck.Location = new System.Drawing.Point(158, 152);
            this.JapanCheck.Name = "JapanCheck";
            this.JapanCheck.Size = new System.Drawing.Size(55, 17);
            this.JapanCheck.TabIndex = 0;
            this.JapanCheck.Text = "Japan";
            this.JapanCheck.UseVisualStyleBackColor = true;
            this.JapanCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // surveyName
            // 
            this.surveyName.AutoSize = true;
            this.surveyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyName.Location = new System.Drawing.Point(153, 45);
            this.surveyName.Name = "surveyName";
            this.surveyName.Size = new System.Drawing.Size(79, 25);
            this.surveyName.TabIndex = 1;
            this.surveyName.Text = "Survey";
            // 
            // questionOne
            // 
            this.questionOne.AutoSize = true;
            this.questionOne.Location = new System.Drawing.Point(152, 112);
            this.questionOne.Name = "questionOne";
            this.questionOne.Size = new System.Drawing.Size(180, 13);
            this.questionOne.TabIndex = 2;
            this.questionOne.Text = "What country would you like to visit?";
            // 
            // PhilippinesCheck
            // 
            this.PhilippinesCheck.AutoSize = true;
            this.PhilippinesCheck.Location = new System.Drawing.Point(158, 186);
            this.PhilippinesCheck.Name = "PhilippinesCheck";
            this.PhilippinesCheck.Size = new System.Drawing.Size(76, 17);
            this.PhilippinesCheck.TabIndex = 3;
            this.PhilippinesCheck.Text = "Philippines";
            this.PhilippinesCheck.UseVisualStyleBackColor = true;
            // 
            // americaCheck
            // 
            this.americaCheck.AutoSize = true;
            this.americaCheck.Location = new System.Drawing.Point(268, 152);
            this.americaCheck.Name = "americaCheck";
            this.americaCheck.Size = new System.Drawing.Size(64, 17);
            this.americaCheck.TabIndex = 4;
            this.americaCheck.Text = "America";
            this.americaCheck.UseVisualStyleBackColor = true;
            // 
            // othersText
            // 
            this.othersText.AutoSize = true;
            this.othersText.Location = new System.Drawing.Point(155, 259);
            this.othersText.Name = "othersText";
            this.othersText.Size = new System.Drawing.Size(123, 13);
            this.othersText.TabIndex = 5;
            this.othersText.Text = "If Others, Please Specify";
            // 
            // othersBox
            // 
            this.othersBox.Location = new System.Drawing.Point(158, 284);
            this.othersBox.Name = "othersBox";
            this.othersBox.Size = new System.Drawing.Size(177, 20);
            this.othersBox.TabIndex = 6;
            this.othersBox.TextChanged += new System.EventHandler(this.othersBox_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(210, 345);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // chinaCheck
            // 
            this.chinaCheck.AutoSize = true;
            this.chinaCheck.Location = new System.Drawing.Point(268, 186);
            this.chinaCheck.Name = "chinaCheck";
            this.chinaCheck.Size = new System.Drawing.Size(53, 17);
            this.chinaCheck.TabIndex = 8;
            this.chinaCheck.Text = "China";
            this.chinaCheck.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(48, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // othersTwo
            // 
            this.othersTwo.AutoSize = true;
            this.othersTwo.Location = new System.Drawing.Point(158, 218);
            this.othersTwo.Name = "othersTwo";
            this.othersTwo.Size = new System.Drawing.Size(57, 17);
            this.othersTwo.TabIndex = 10;
            this.othersTwo.Text = "Others";
            this.othersTwo.UseVisualStyleBackColor = true;
            this.othersTwo.CheckedChanged += new System.EventHandler(this.othersTwo_CheckedChanged);
            // 
            // survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.othersTwo);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.chinaCheck);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.othersBox);
            this.Controls.Add(this.othersText);
            this.Controls.Add(this.americaCheck);
            this.Controls.Add(this.PhilippinesCheck);
            this.Controls.Add(this.questionOne);
            this.Controls.Add(this.surveyName);
            this.Controls.Add(this.JapanCheck);
            this.Name = "survey";
            this.Text = "Survey Parawan";
            this.Load += new System.EventHandler(this.survey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox JapanCheck;
        private System.Windows.Forms.Label surveyName;
        private System.Windows.Forms.Label questionOne;
        private System.Windows.Forms.CheckBox PhilippinesCheck;
        private System.Windows.Forms.CheckBox americaCheck;
        private System.Windows.Forms.Label othersText;
        private System.Windows.Forms.TextBox othersBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.CheckBox chinaCheck;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.CheckBox othersTwo;
    }
}

