namespace HospitalManagementSystem
{
    partial class frmDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrug));
            this.txtMinDose = new System.Windows.Forms.TextBox();
            this.txtMaxDose = new System.Windows.Forms.TextBox();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.drugIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescribesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMinDose
            // 
            this.txtMinDose.Location = new System.Drawing.Point(215, 107);
            this.txtMinDose.Name = "txtMinDose";
            this.txtMinDose.Size = new System.Drawing.Size(179, 20);
            this.txtMinDose.TabIndex = 43;
            // 
            // txtMaxDose
            // 
            this.txtMaxDose.Location = new System.Drawing.Point(215, 76);
            this.txtMaxDose.Name = "txtMaxDose";
            this.txtMaxDose.Size = new System.Drawing.Size(179, 20);
            this.txtMaxDose.TabIndex = 42;
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(215, 45);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(179, 20);
            this.txtDrugName.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Minimum Dose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "MaximumDose";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Drug Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 37);
            this.button3.TabIndex = 46;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 45;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 44;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugIdDataGridViewTextBoxColumn,
            this.drugNameDataGridViewTextBoxColumn,
            this.minimumDoseDataGridViewTextBoxColumn,
            this.maximumDoseDataGridViewTextBoxColumn,
            this.prescribesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.drugBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 250);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "* Must be in Integer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "* Must be in Integer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Add New Drug";
            // 
            // drugIdDataGridViewTextBoxColumn
            // 
            this.drugIdDataGridViewTextBoxColumn.DataPropertyName = "DrugId";
            this.drugIdDataGridViewTextBoxColumn.HeaderText = "DrugId";
            this.drugIdDataGridViewTextBoxColumn.Name = "drugIdDataGridViewTextBoxColumn";
            // 
            // drugNameDataGridViewTextBoxColumn
            // 
            this.drugNameDataGridViewTextBoxColumn.DataPropertyName = "DrugName";
            this.drugNameDataGridViewTextBoxColumn.HeaderText = "DrugName";
            this.drugNameDataGridViewTextBoxColumn.Name = "drugNameDataGridViewTextBoxColumn";
            // 
            // minimumDoseDataGridViewTextBoxColumn
            // 
            this.minimumDoseDataGridViewTextBoxColumn.DataPropertyName = "Minimum_Dose";
            this.minimumDoseDataGridViewTextBoxColumn.HeaderText = "Minimum_Dose";
            this.minimumDoseDataGridViewTextBoxColumn.Name = "minimumDoseDataGridViewTextBoxColumn";
            // 
            // maximumDoseDataGridViewTextBoxColumn
            // 
            this.maximumDoseDataGridViewTextBoxColumn.DataPropertyName = "Maximum_Dose";
            this.maximumDoseDataGridViewTextBoxColumn.HeaderText = "Maximum_Dose";
            this.maximumDoseDataGridViewTextBoxColumn.Name = "maximumDoseDataGridViewTextBoxColumn";
            // 
            // prescribesDataGridViewTextBoxColumn
            // 
            this.prescribesDataGridViewTextBoxColumn.DataPropertyName = "Prescribes";
            this.prescribesDataGridViewTextBoxColumn.HeaderText = "Prescribes";
            this.prescribesDataGridViewTextBoxColumn.Name = "prescribesDataGridViewTextBoxColumn";
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataSource = typeof(HospitalManagementSystem.Models.Drug);
            // 
            // frmDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 505);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMinDose);
            this.Controls.Add(this.txtMaxDose);
            this.Controls.Add(this.txtDrugName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDrug";
            this.Text = "Drug";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinDose;
        private System.Windows.Forms.TextBox txtMaxDose;
        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumDoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumDoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescribesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}