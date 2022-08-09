
namespace WinFormsApp1
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnURL = new System.Windows.Forms.Button();
            this.lblRequestURI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Method = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJDSerialize = new System.Windows.Forms.Button();
            this.btnSerialise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(128, 69);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(581, 27);
            this.txtURL.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(128, 122);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(581, 255);
            this.txtOutput.TabIndex = 1;
            // 
            // btnURL
            // 
            this.btnURL.Location = new System.Drawing.Point(285, 23);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(94, 29);
            this.btnURL.TabIndex = 2;
            this.btnURL.Text = "Apply";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRequestURI
            // 
            this.lblRequestURI.AutoSize = true;
            this.lblRequestURI.Location = new System.Drawing.Point(20, 69);
            this.lblRequestURI.Name = "lblRequestURI";
            this.lblRequestURI.Size = new System.Drawing.Size(85, 20);
            this.lblRequestURI.TabIndex = 3;
            this.lblRequestURI.Text = "RequestURI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.comboBox1.Location = new System.Drawing.Point(128, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // Method
            // 
            this.Method.AutoSize = true;
            this.Method.Location = new System.Drawing.Point(36, 23);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(55, 20);
            this.Method.TabIndex = 6;
            this.Method.Text = "Output";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(130, 428);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 27);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quote";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(128, 461);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(213, 27);
            this.txtAuthor.TabIndex = 9;
            this.txtAuthor.Text = " ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 494);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 86);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Author";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = " Description";
            // 
            // btnJDSerialize
            // 
            this.btnJDSerialize.Location = new System.Drawing.Point(655, 17);
            this.btnJDSerialize.Name = "btnJDSerialize";
            this.btnJDSerialize.Size = new System.Drawing.Size(133, 33);
            this.btnJDSerialize.TabIndex = 14;
            this.btnJDSerialize.Text = "JsonDeserialize";
            this.btnJDSerialize.UseVisualStyleBackColor = true;
            this.btnJDSerialize.Click += new System.EventHandler(this.btnJDSerialize_Click);
            // 
            // btnSerialise
            // 
            this.btnSerialise.Location = new System.Drawing.Point(497, 18);
            this.btnSerialise.Name = "btnSerialise";
            this.btnSerialise.Size = new System.Drawing.Size(133, 33);
            this.btnSerialise.TabIndex = 15;
            this.btnSerialise.Text = " JsonSerialize";
            this.btnSerialise.UseVisualStyleBackColor = true;
            this.btnSerialise.Click += new System.EventHandler(this.btnSerialise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.btnSerialise);
            this.Controls.Add(this.btnJDSerialize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRequestURI);
            this.Controls.Add(this.btnURL);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.Label lblRequestURI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Method;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJDSerialize;
        private System.Windows.Forms.Button btnSerialise;
    }
}

