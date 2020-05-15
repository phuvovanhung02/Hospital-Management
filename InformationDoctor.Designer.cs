namespace RobotAssistant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lvDoctor = new System.Windows.Forms.ListView();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnRemoveDoctor = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvDoctor
            // 
            this.lvDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDoctor.HideSelection = false;
            this.lvDoctor.Location = new System.Drawing.Point(20, 101);
            this.lvDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.lvDoctor.Name = "lvDoctor";
            this.lvDoctor.Size = new System.Drawing.Size(603, 603);
            this.lvDoctor.TabIndex = 4;
            this.lvDoctor.UseCompatibleStateImageBehavior = false;
            this.lvDoctor.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(637, 101);
            this.btnAddDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(65, 27);
            this.btnAddDoctor.TabIndex = 5;
            this.btnAddDoctor.Text = "Add ";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveDoctor
            // 
            this.btnRemoveDoctor.Location = new System.Drawing.Point(637, 174);
            this.btnRemoveDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDoctor.Name = "btnRemoveDoctor";
            this.btnRemoveDoctor.Size = new System.Drawing.Size(65, 27);
            this.btnRemoveDoctor.TabIndex = 6;
            this.btnRemoveDoctor.Text = "Remove";
            this.btnRemoveDoctor.UseVisualStyleBackColor = true;
            this.btnRemoveDoctor.Click += new System.EventHandler(this.btnRemoveDoctor_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(637, 137);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 27);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 487);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemoveDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.lvDoctor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDoctor;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnRemoveDoctor;
        private System.Windows.Forms.Button btnUpdate;
    }
}

