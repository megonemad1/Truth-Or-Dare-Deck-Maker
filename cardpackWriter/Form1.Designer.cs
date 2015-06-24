namespace cardpackWriter
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
            this.RtbQuestion = new System.Windows.Forms.RichTextBox();
            this.NmrPointsValue = new System.Windows.Forms.NumericUpDown();
            this.ChkFemale = new System.Windows.Forms.CheckBox();
            this.ChkMale = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CmbCurrentlyCreated = new System.Windows.Forms.ComboBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NmrPointsValue)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RtbQuestion
            // 
            this.RtbQuestion.Location = new System.Drawing.Point(12, 22);
            this.RtbQuestion.Name = "RtbQuestion";
            this.RtbQuestion.Size = new System.Drawing.Size(168, 141);
            this.RtbQuestion.TabIndex = 0;
            this.RtbQuestion.Text = "";
            this.toolTip1.SetToolTip(this.RtbQuestion, "This is the question every one will see, use /p and a number to denote players nu" +
        "mbers used must be consecitive and start at zero where /p0 is always the target " +
        "of the question");
            // 
            // NmrPointsValue
            // 
            this.NmrPointsValue.Location = new System.Drawing.Point(3, 42);
            this.NmrPointsValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NmrPointsValue.Name = "NmrPointsValue";
            this.NmrPointsValue.Size = new System.Drawing.Size(49, 20);
            this.NmrPointsValue.TabIndex = 1;
            this.NmrPointsValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ChkFemale
            // 
            this.ChkFemale.AutoSize = true;
            this.ChkFemale.Location = new System.Drawing.Point(3, 117);
            this.ChkFemale.Name = "ChkFemale";
            this.ChkFemale.Size = new System.Drawing.Size(46, 17);
            this.ChkFemale.TabIndex = 2;
            this.ChkFemale.Text = "Girls";
            this.ChkFemale.UseVisualStyleBackColor = true;
            // 
            // ChkMale
            // 
            this.ChkMale.AutoSize = true;
            this.ChkMale.Location = new System.Drawing.Point(3, 94);
            this.ChkMale.Name = "ChkMale";
            this.ChkMale.Size = new System.Drawing.Size(50, 17);
            this.ChkMale.TabIndex = 3;
            this.ChkMale.Text = "Guys";
            this.ChkMale.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.NmrPointsValue);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.ChkMale);
            this.flowLayoutPanel1.Controls.Add(this.ChkFemale);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(186, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(86, 141);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "how many points is it worth?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "who can answer this?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Truth Or Dare Question";
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(15, 169);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(165, 23);
            this.BtnNext.TabIndex = 6;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(186, 169);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(86, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save Deck";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CmbCurrentlyCreated
            // 
            this.CmbCurrentlyCreated.FormattingEnabled = true;
            this.CmbCurrentlyCreated.Location = new System.Drawing.Point(105, 200);
            this.CmbCurrentlyCreated.Name = "CmbCurrentlyCreated";
            this.CmbCurrentlyCreated.Size = new System.Drawing.Size(167, 21);
            this.CmbCurrentlyCreated.TabIndex = 8;
            this.CmbCurrentlyCreated.SelectedIndexChanged += new System.EventHandler(this.CmbCurrentlyCreated_SelectedIndexChanged);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(15, 198);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.Text = "Deleat";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Json files (*.json)|*.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 230);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.CmbCurrentlyCreated);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.RtbQuestion);
            this.Name = "Form1";
            this.Text = "Question Formatter";
            ((System.ComponentModel.ISupportInitialize)(this.NmrPointsValue)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbQuestion;
        private System.Windows.Forms.NumericUpDown NmrPointsValue;
        private System.Windows.Forms.CheckBox ChkFemale;
        private System.Windows.Forms.CheckBox ChkMale;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CmbCurrentlyCreated;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

