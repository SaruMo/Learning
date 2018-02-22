namespace DataBindingWithLINQ
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.CBx_Test = new System.Windows.Forms.ComboBox();
            this.Btn_GetData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Data
            // 
            this.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Data.Location = new System.Drawing.Point(12, 55);
            this.DGV_Data.Name = "DGV_Data";
            this.DGV_Data.Size = new System.Drawing.Size(242, 195);
            this.DGV_Data.TabIndex = 0;
            // 
            // CBx_Test
            // 
            this.CBx_Test.FormattingEnabled = true;
            this.CBx_Test.Location = new System.Drawing.Point(13, 13);
            this.CBx_Test.Name = "CBx_Test";
            this.CBx_Test.Size = new System.Drawing.Size(148, 21);
            this.CBx_Test.TabIndex = 1;
            this.CBx_Test.SelectedIndexChanged += new System.EventHandler(this.CBx_Test_SelectedIndexChanged);
            // 
            // Btn_GetData
            // 
            this.Btn_GetData.Location = new System.Drawing.Point(201, 10);
            this.Btn_GetData.Name = "Btn_GetData";
            this.Btn_GetData.Size = new System.Drawing.Size(75, 23);
            this.Btn_GetData.TabIndex = 2;
            this.Btn_GetData.Text = "Get data";
            this.Btn_GetData.UseVisualStyleBackColor = true;
            this.Btn_GetData.Click += new System.EventHandler(this.Btn_GetData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Btn_GetData);
            this.Controls.Add(this.CBx_Test);
            this.Controls.Add(this.DGV_Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Data;
        private System.Windows.Forms.ComboBox CBx_Test;
        private System.Windows.Forms.Button Btn_GetData;
    }
}

