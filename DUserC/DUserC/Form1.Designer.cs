namespace DUserC
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
            this.btnGetState = new System.Windows.Forms.Button();
            this.ucState1 = new DUserC.ucState();
            this.SuspendLayout();
            // 
            // btnGetState
            // 
            this.btnGetState.Location = new System.Drawing.Point(134, 186);
            this.btnGetState.Name = "btnGetState";
            this.btnGetState.Size = new System.Drawing.Size(75, 23);
            this.btnGetState.TabIndex = 1;
            this.btnGetState.Text = "State";
            this.btnGetState.UseVisualStyleBackColor = true;
            this.btnGetState.Click += new System.EventHandler(this.btnGetState_Click);
            // 
            // ucState1
            // 
            this.ucState1.Location = new System.Drawing.Point(18, 76);
            this.ucState1.Name = "ucState1";
            this.ucState1.Size = new System.Drawing.Size(347, 114);
            this.ucState1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 361);
            this.Controls.Add(this.btnGetState);
            this.Controls.Add(this.ucState1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ucState ucState1;
        private System.Windows.Forms.Button btnGetState;
    }
}

