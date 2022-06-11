
namespace TRBD_LR_4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecutionData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BrandText = new System.Windows.Forms.TextBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractNumber,
            this.CarBrand,
            this.CarModel,
            this.Namee,
            this.SurName,
            this.OrderData,
            this.ExecutionData});
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // ContractNumber
            // 
            this.ContractNumber.HeaderText = "ContractNumber";
            this.ContractNumber.MinimumWidth = 7;
            this.ContractNumber.Name = "ContractNumber";
            // 
            // CarBrand
            // 
            this.CarBrand.HeaderText = "CarBrand";
            this.CarBrand.MinimumWidth = 8;
            this.CarBrand.Name = "CarBrand";
            // 
            // CarModel
            // 
            this.CarModel.HeaderText = "CarModel";
            this.CarModel.MinimumWidth = 8;
            this.CarModel.Name = "CarModel";
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Name";
            this.Namee.MinimumWidth = 8;
            this.Namee.Name = "Namee";
            // 
            // SurName
            // 
            this.SurName.HeaderText = "SurName";
            this.SurName.MinimumWidth = 8;
            this.SurName.Name = "SurName";
            // 
            // OrderData
            // 
            this.OrderData.HeaderText = "OrderData";
            this.OrderData.MinimumWidth = 8;
            this.OrderData.Name = "OrderData";
            // 
            // ExecutionData
            // 
            this.ExecutionData.HeaderText = "ExecutionData";
            this.ExecutionData.MinimumWidth = 8;
            this.ExecutionData.Name = "ExecutionData";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(833, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "7.1.\tОставить записи, в которых марка и модель автомобиля соответствуют указанным" +
    ";";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(833, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "7.2.\tОставить записи, в которых договор был заключён после указанной даты;";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(833, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "7.3.\tОставить записи, в которых автомобиль ещё находится на этапе ремонта.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BrandText
            // 
            this.BrandText.Location = new System.Drawing.Point(12, 12);
            this.BrandText.Name = "BrandText";
            this.BrandText.Size = new System.Drawing.Size(150, 31);
            this.BrandText.TabIndex = 4;
            this.BrandText.Text = "Ford";
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(168, 12);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(150, 31);
            this.ModelText.TabIndex = 5;
            this.ModelText.Text = "Focus";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModelText);
            this.Controls.Add(this.BrandText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox BrandText;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutionData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

