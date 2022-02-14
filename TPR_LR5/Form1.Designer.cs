
namespace TPR_LR5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAlts = new System.Windows.Forms.RichTextBox();
            this.rtbCrits = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlt = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbCrit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAlt = new System.Windows.Forms.Button();
            this.buttonCrit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTable = new System.Windows.Forms.Button();
            this.cbFunc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbS = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.cbRev = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbAlts
            // 
            this.rtbAlts.Location = new System.Drawing.Point(63, 29);
            this.rtbAlts.Name = "rtbAlts";
            this.rtbAlts.ReadOnly = true;
            this.rtbAlts.Size = new System.Drawing.Size(122, 221);
            this.rtbAlts.TabIndex = 0;
            this.rtbAlts.Text = "";
            // 
            // rtbCrits
            // 
            this.rtbCrits.Location = new System.Drawing.Point(281, 29);
            this.rtbCrits.Name = "rtbCrits";
            this.rtbCrits.ReadOnly = true;
            this.rtbCrits.Size = new System.Drawing.Size(156, 221);
            this.rtbCrits.TabIndex = 1;
            this.rtbCrits.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crits";
            // 
            // tbAlt
            // 
            this.tbAlt.Location = new System.Drawing.Point(63, 256);
            this.tbAlt.Name = "tbAlt";
            this.tbAlt.Size = new System.Drawing.Size(122, 20);
            this.tbAlt.TabIndex = 4;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(281, 282);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(77, 20);
            this.tbWeight.TabIndex = 5;
            this.tbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // tbCrit
            // 
            this.tbCrit.Location = new System.Drawing.Point(281, 256);
            this.tbCrit.Name = "tbCrit";
            this.tbCrit.Size = new System.Drawing.Size(156, 20);
            this.tbCrit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Weight";
            // 
            // buttonAlt
            // 
            this.buttonAlt.Location = new System.Drawing.Point(66, 318);
            this.buttonAlt.Name = "buttonAlt";
            this.buttonAlt.Size = new System.Drawing.Size(119, 23);
            this.buttonAlt.TabIndex = 10;
            this.buttonAlt.Text = "Add Alt";
            this.buttonAlt.UseVisualStyleBackColor = true;
            this.buttonAlt.Click += new System.EventHandler(this.buttonAlt_Click);
            // 
            // buttonCrit
            // 
            this.buttonCrit.Location = new System.Drawing.Point(281, 317);
            this.buttonCrit.Name = "buttonCrit";
            this.buttonCrit.Size = new System.Drawing.Size(156, 23);
            this.buttonCrit.TabIndex = 11;
            this.buttonCrit.Text = "Add Crit";
            this.buttonCrit.UseVisualStyleBackColor = true;
            this.buttonCrit.Click += new System.EventHandler(this.buttonCrit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(497, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 550);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonTable
            // 
            this.buttonTable.Location = new System.Drawing.Point(77, 519);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(108, 23);
            this.buttonTable.TabIndex = 13;
            this.buttonTable.Text = "Create table";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // cbFunc
            // 
            this.cbFunc.FormattingEnabled = true;
            this.cbFunc.Items.AddRange(new object[] {
            "Simple func",
            "U-func",
            "V-func",
            "Level-func",
            "V-func s porogami",
            "Gauss func"});
            this.cbFunc.Location = new System.Drawing.Point(281, 361);
            this.cbFunc.Name = "cbFunc";
            this.cbFunc.Size = new System.Drawing.Size(156, 21);
            this.cbFunc.TabIndex = 14;
            this.cbFunc.SelectionChangeCommitted += new System.EventHandler(this.cbFunc_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(278, 402);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(25, 13);
            this.labelQ.TabIndex = 16;
            this.labelQ.Text = "q = ";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(278, 429);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(21, 13);
            this.labelS.TabIndex = 17;
            this.labelS.Text = "s =";
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(309, 399);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(100, 20);
            this.tbQ.TabIndex = 18;
            this.tbQ.TextChanged += new System.EventHandler(this.tbQ_TextChanged);
            this.tbQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(309, 426);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 20);
            this.tbS.TabIndex = 19;
            this.tbS.TextChanged += new System.EventHandler(this.tbS_TextChanged);
            this.tbS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(281, 519);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 20;
            this.btnRes.Text = "Res";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // cbRev
            // 
            this.cbRev.AutoSize = true;
            this.cbRev.Location = new System.Drawing.Point(365, 284);
            this.cbRev.Name = "cbRev";
            this.cbRev.Size = new System.Drawing.Size(107, 17);
            this.cbRev.TabIndex = 21;
            this.cbRev.Text = "Reverse Headed";
            this.cbRev.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 591);
            this.Controls.Add(this.cbRev);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFunc);
            this.Controls.Add(this.buttonTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCrit);
            this.Controls.Add(this.buttonAlt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCrit);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbAlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbCrits);
            this.Controls.Add(this.rtbAlts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAlts;
        private System.Windows.Forms.RichTextBox rtbCrits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAlt;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbCrit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAlt;
        private System.Windows.Forms.Button buttonCrit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.CheckBox cbRev;
        public System.Windows.Forms.ComboBox cbFunc;
    }
}

