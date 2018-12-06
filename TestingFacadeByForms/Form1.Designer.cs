namespace TestingFacadeByForms
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
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.DisplayAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGrid
            // 
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Location = new System.Drawing.Point(12, 197);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.RowTemplate.Height = 24;
            this.StudentGrid.Size = new System.Drawing.Size(776, 241);
            this.StudentGrid.TabIndex = 0;
            // 
            // DisplayAllBtn
            // 
            this.DisplayAllBtn.Location = new System.Drawing.Point(127, 102);
            this.DisplayAllBtn.Name = "DisplayAllBtn";
            this.DisplayAllBtn.Size = new System.Drawing.Size(93, 40);
            this.DisplayAllBtn.TabIndex = 1;
            this.DisplayAllBtn.Text = "Display All";
            this.DisplayAllBtn.UseVisualStyleBackColor = true;
            this.DisplayAllBtn.Click += new System.EventHandler(this.DisplayAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayAllBtn);
            this.Controls.Add(this.StudentGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.Button DisplayAllBtn;
    }
}

