namespace Radio.App
{
    partial class MainForm
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
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.tbxNumberLimit = new System.Windows.Forms.TextBox();
            this.btnEnterLimit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnterNumber = new System.Windows.Forms.Button();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(12, 9);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(123, 13);
            this.lblUpperLimit.TabIndex = 0;
            this.lblUpperLimit.Text = "Enter upper number limit:";
            // 
            // tbxNumberLimit
            // 
            this.tbxNumberLimit.Location = new System.Drawing.Point(142, 9);
            this.tbxNumberLimit.Name = "tbxNumberLimit";
            this.tbxNumberLimit.Size = new System.Drawing.Size(100, 20);
            this.tbxNumberLimit.TabIndex = 1;
            // 
            // btnEnterLimit
            // 
            this.btnEnterLimit.Location = new System.Drawing.Point(248, 7);
            this.btnEnterLimit.Name = "btnEnterLimit";
            this.btnEnterLimit.Size = new System.Drawing.Size(75, 23);
            this.btnEnterLimit.TabIndex = 2;
            this.btnEnterLimit.Text = "Enter";
            this.btnEnterLimit.UseVisualStyleBackColor = true;
            this.btnEnterLimit.Click += new System.EventHandler(this.btnEnterLimit_Click);
            // 
            // btnEnterNumber
            // 
            this.btnEnterNumber.Location = new System.Drawing.Point(248, 40);
            this.btnEnterNumber.Name = "btnEnterNumber";
            this.btnEnterNumber.Size = new System.Drawing.Size(75, 23);
            this.btnEnterNumber.TabIndex = 5;
            this.btnEnterNumber.Text = "Enter";
            this.btnEnterNumber.UseVisualStyleBackColor = true;
            this.btnEnterNumber.Click += new System.EventHandler(this.btnEnterNumber_Click);
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(142, 42);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 42);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(68, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Try to guess:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(329, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 262);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEnterNumber);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnEnterLimit);
            this.Controls.Add(this.tbxNumberLimit);
            this.Controls.Add(this.lblUpperLimit);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpperLimit;
        private System.Windows.Forms.TextBox tbxNumberLimit;
        private System.Windows.Forms.Button btnEnterLimit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnEnterNumber;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblStatus;
    }
}

