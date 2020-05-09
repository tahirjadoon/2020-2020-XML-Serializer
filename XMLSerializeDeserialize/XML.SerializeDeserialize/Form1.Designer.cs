namespace XML.SerializeDeserialize
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSamplePath = new System.Windows.Forms.Label();
            this.btnSample1Deserialize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSample1Serialize = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSample2Path = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSample2Serialize = new System.Windows.Forms.Button();
            this.btnSample2Deserialize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 264);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(957, 437);
            this.txtResults.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sample XML: In the root as Sample.config. it gets copied to debug folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sample Path: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSamplePath
            // 
            this.lblSamplePath.AutoSize = true;
            this.lblSamplePath.Location = new System.Drawing.Point(101, 37);
            this.lblSamplePath.Name = "lblSamplePath";
            this.lblSamplePath.Size = new System.Drawing.Size(74, 13);
            this.lblSamplePath.TabIndex = 8;
            this.lblSamplePath.Text = "lblSamplePath";
            // 
            // btnSample1Deserialize
            // 
            this.btnSample1Deserialize.Location = new System.Drawing.Point(22, 62);
            this.btnSample1Deserialize.Name = "btnSample1Deserialize";
            this.btnSample1Deserialize.Size = new System.Drawing.Size(138, 23);
            this.btnSample1Deserialize.TabIndex = 9;
            this.btnSample1Deserialize.Text = "Read and Deserialize Config";
            this.btnSample1Deserialize.UseVisualStyleBackColor = true;
            this.btnSample1Deserialize.Click += new System.EventHandler(this.btnSample1Deserialize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSample1Serialize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSample1Deserialize);
            this.groupBox1.Controls.Add(this.lblSamplePath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample 1";
            // 
            // btnSample1Serialize
            // 
            this.btnSample1Serialize.Location = new System.Drawing.Point(195, 61);
            this.btnSample1Serialize.Name = "btnSample1Serialize";
            this.btnSample1Serialize.Size = new System.Drawing.Size(172, 23);
            this.btnSample1Serialize.TabIndex = 10;
            this.btnSample1Serialize.Text = "Build Object and Serialize";
            this.btnSample1Serialize.UseVisualStyleBackColor = true;
            this.btnSample1Serialize.Click += new System.EventHandler(this.btnSample1Serialize_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSample2Serialize);
            this.groupBox2.Controls.Add(this.btnSample2Deserialize);
            this.groupBox2.Controls.Add(this.lblSample2Path);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sample 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sample XML: In the root as ConnectionStrings.config. it gets copied to debug fold" +
    "er";
            // 
            // lblSample2Path
            // 
            this.lblSample2Path.AutoSize = true;
            this.lblSample2Path.Location = new System.Drawing.Point(100, 49);
            this.lblSample2Path.Name = "lblSample2Path";
            this.lblSample2Path.Size = new System.Drawing.Size(80, 13);
            this.lblSample2Path.TabIndex = 10;
            this.lblSample2Path.Text = "lblSample2Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sample Path: ";
            // 
            // btnSample2Serialize
            // 
            this.btnSample2Serialize.Location = new System.Drawing.Point(194, 70);
            this.btnSample2Serialize.Name = "btnSample2Serialize";
            this.btnSample2Serialize.Size = new System.Drawing.Size(172, 23);
            this.btnSample2Serialize.TabIndex = 12;
            this.btnSample2Serialize.Text = "Build Object and Serialize";
            this.btnSample2Serialize.UseVisualStyleBackColor = true;
            this.btnSample2Serialize.Click += new System.EventHandler(this.btnSample2Serialize_Click);
            // 
            // btnSample2Deserialize
            // 
            this.btnSample2Deserialize.Location = new System.Drawing.Point(21, 71);
            this.btnSample2Deserialize.Name = "btnSample2Deserialize";
            this.btnSample2Deserialize.Size = new System.Drawing.Size(138, 23);
            this.btnSample2Deserialize.TabIndex = 11;
            this.btnSample2Deserialize.Text = "Read and Deserialize Config";
            this.btnSample2Deserialize.UseVisualStyleBackColor = true;
            this.btnSample2Deserialize.Click += new System.EventHandler(this.btnSample2Deserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 713);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSamplePath;
        private System.Windows.Forms.Button btnSample1Deserialize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSample1Serialize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSample2Path;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSample2Serialize;
        private System.Windows.Forms.Button btnSample2Deserialize;
    }
}

