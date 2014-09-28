namespace CustomerCareProblemQueueApp
{
    partial class CustomerUI
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.waitingQueueListview = new System.Windows.Forms.ListView();
            this.serialNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.complainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dequeuePhoneTextBox = new System.Windows.Forms.TextBox();
            this.dequeueEmailTextBox = new System.Windows.Forms.TextBox();
            this.dequeuePhoneLabel = new System.Windows.Forms.Label();
            this.dequeueEmailLabel = new System.Windows.Forms.Label();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
            this.dequeueNameTextBox = new System.Windows.Forms.TextBox();
            this.dequeueSerialNoTextBox = new System.Windows.Forms.TextBox();
            this.dequeueComplainLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dequeueSerailNoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enqueuePhoneTextBox = new System.Windows.Forms.TextBox();
            this.enqueueEmailTextBox = new System.Windows.Forms.TextBox();
            this.enqueuePhoneLabel = new System.Windows.Forms.Label();
            this.enqueueEmailLabel = new System.Windows.Forms.Label();
            this.enqueueComplainTextBox = new System.Windows.Forms.TextBox();
            this.enqueueComplainLabel = new System.Windows.Forms.Label();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.enqueueNameTextBox = new System.Windows.Forms.TextBox();
            this.enqueueNameLable = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.waitingQueueListview);
            this.groupBox3.Location = new System.Drawing.Point(54, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 210);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Queue";
            // 
            // waitingQueueListview
            // 
            this.waitingQueueListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNoColumnHeader,
            this.emailColumnHeader,
            this.phoneColumnHeader,
            this.complainColumnHeader});
            this.waitingQueueListview.GridLines = true;
            this.waitingQueueListview.Location = new System.Drawing.Point(6, 19);
            this.waitingQueueListview.Name = "waitingQueueListview";
            this.waitingQueueListview.Size = new System.Drawing.Size(671, 185);
            this.waitingQueueListview.TabIndex = 0;
            this.waitingQueueListview.UseCompatibleStateImageBehavior = false;
            this.waitingQueueListview.View = System.Windows.Forms.View.Details;
            // 
            // serialNoColumnHeader
            // 
            this.serialNoColumnHeader.Text = "Serial No";
            // 
            // emailColumnHeader
            // 
            this.emailColumnHeader.Text = "Name";
            // 
            // phoneColumnHeader
            // 
            this.phoneColumnHeader.Text = "Phone";
            // 
            // complainColumnHeader
            // 
            this.complainColumnHeader.Text = "Complain";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dequeuePhoneTextBox);
            this.groupBox2.Controls.Add(this.dequeueEmailTextBox);
            this.groupBox2.Controls.Add(this.dequeuePhoneLabel);
            this.groupBox2.Controls.Add(this.dequeueEmailLabel);
            this.groupBox2.Controls.Add(this.dequeueButton);
            this.groupBox2.Controls.Add(this.dequeueComplainTextBox);
            this.groupBox2.Controls.Add(this.dequeueNameTextBox);
            this.groupBox2.Controls.Add(this.dequeueSerialNoTextBox);
            this.groupBox2.Controls.Add(this.dequeueComplainLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dequeueSerailNoLabel);
            this.groupBox2.Location = new System.Drawing.Point(416, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 242);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer";
            // 
            // dequeuePhoneTextBox
            // 
            this.dequeuePhoneTextBox.Location = new System.Drawing.Point(117, 115);
            this.dequeuePhoneTextBox.Name = "dequeuePhoneTextBox";
            this.dequeuePhoneTextBox.Size = new System.Drawing.Size(192, 20);
            this.dequeuePhoneTextBox.TabIndex = 11;
            // 
            // dequeueEmailTextBox
            // 
            this.dequeueEmailTextBox.Location = new System.Drawing.Point(117, 85);
            this.dequeueEmailTextBox.Name = "dequeueEmailTextBox";
            this.dequeueEmailTextBox.Size = new System.Drawing.Size(192, 20);
            this.dequeueEmailTextBox.TabIndex = 10;
            // 
            // dequeuePhoneLabel
            // 
            this.dequeuePhoneLabel.AutoSize = true;
            this.dequeuePhoneLabel.Location = new System.Drawing.Point(40, 120);
            this.dequeuePhoneLabel.Name = "dequeuePhoneLabel";
            this.dequeuePhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.dequeuePhoneLabel.TabIndex = 9;
            this.dequeuePhoneLabel.Text = "Phone";
            // 
            // dequeueEmailLabel
            // 
            this.dequeueEmailLabel.AutoSize = true;
            this.dequeueEmailLabel.Location = new System.Drawing.Point(46, 88);
            this.dequeueEmailLabel.Name = "dequeueEmailLabel";
            this.dequeueEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.dequeueEmailLabel.TabIndex = 8;
            this.dequeueEmailLabel.Text = "Email";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(210, 213);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 7;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(117, 141);
            this.dequeueComplainTextBox.Multiline = true;
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(192, 66);
            this.dequeueComplainTextBox.TabIndex = 6;
            // 
            // dequeueNameTextBox
            // 
            this.dequeueNameTextBox.Location = new System.Drawing.Point(117, 54);
            this.dequeueNameTextBox.Name = "dequeueNameTextBox";
            this.dequeueNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.dequeueNameTextBox.TabIndex = 5;
            // 
            // dequeueSerialNoTextBox
            // 
            this.dequeueSerialNoTextBox.Location = new System.Drawing.Point(117, 19);
            this.dequeueSerialNoTextBox.Name = "dequeueSerialNoTextBox";
            this.dequeueSerialNoTextBox.Size = new System.Drawing.Size(192, 20);
            this.dequeueSerialNoTextBox.TabIndex = 4;
            // 
            // dequeueComplainLabel
            // 
            this.dequeueComplainLabel.AutoSize = true;
            this.dequeueComplainLabel.Location = new System.Drawing.Point(28, 171);
            this.dequeueComplainLabel.Name = "dequeueComplainLabel";
            this.dequeueComplainLabel.Size = new System.Drawing.Size(50, 13);
            this.dequeueComplainLabel.TabIndex = 7;
            this.dequeueComplainLabel.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // dequeueSerailNoLabel
            // 
            this.dequeueSerailNoLabel.AutoSize = true;
            this.dequeueSerailNoLabel.Location = new System.Drawing.Point(28, 25);
            this.dequeueSerailNoLabel.Name = "dequeueSerailNoLabel";
            this.dequeueSerailNoLabel.Size = new System.Drawing.Size(50, 13);
            this.dequeueSerailNoLabel.TabIndex = 5;
            this.dequeueSerailNoLabel.Text = "Serial No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueuePhoneTextBox);
            this.groupBox1.Controls.Add(this.enqueueEmailTextBox);
            this.groupBox1.Controls.Add(this.enqueuePhoneLabel);
            this.groupBox1.Controls.Add(this.enqueueEmailLabel);
            this.groupBox1.Controls.Add(this.enqueueComplainTextBox);
            this.groupBox1.Controls.Add(this.enqueueComplainLabel);
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.enqueueNameTextBox);
            this.groupBox1.Controls.Add(this.enqueueNameLable);
            this.groupBox1.Location = new System.Drawing.Point(54, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // enqueuePhoneTextBox
            // 
            this.enqueuePhoneTextBox.Location = new System.Drawing.Point(127, 88);
            this.enqueuePhoneTextBox.Name = "enqueuePhoneTextBox";
            this.enqueuePhoneTextBox.Size = new System.Drawing.Size(204, 20);
            this.enqueuePhoneTextBox.TabIndex = 7;
            // 
            // enqueueEmailTextBox
            // 
            this.enqueueEmailTextBox.Location = new System.Drawing.Point(127, 54);
            this.enqueueEmailTextBox.Name = "enqueueEmailTextBox";
            this.enqueueEmailTextBox.Size = new System.Drawing.Size(204, 20);
            this.enqueueEmailTextBox.TabIndex = 6;
            // 
            // enqueuePhoneLabel
            // 
            this.enqueuePhoneLabel.AutoSize = true;
            this.enqueuePhoneLabel.Location = new System.Drawing.Point(46, 97);
            this.enqueuePhoneLabel.Name = "enqueuePhoneLabel";
            this.enqueuePhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.enqueuePhoneLabel.TabIndex = 5;
            this.enqueuePhoneLabel.Text = "Phone";
            // 
            // enqueueEmailLabel
            // 
            this.enqueueEmailLabel.AutoSize = true;
            this.enqueueEmailLabel.Location = new System.Drawing.Point(52, 63);
            this.enqueueEmailLabel.Name = "enqueueEmailLabel";
            this.enqueueEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.enqueueEmailLabel.TabIndex = 4;
            this.enqueueEmailLabel.Text = "Email";
            // 
            // enqueueComplainTextBox
            // 
            this.enqueueComplainTextBox.Location = new System.Drawing.Point(127, 126);
            this.enqueueComplainTextBox.Multiline = true;
            this.enqueueComplainTextBox.Name = "enqueueComplainTextBox";
            this.enqueueComplainTextBox.Size = new System.Drawing.Size(204, 68);
            this.enqueueComplainTextBox.TabIndex = 2;
            // 
            // enqueueComplainLabel
            // 
            this.enqueueComplainLabel.AutoSize = true;
            this.enqueueComplainLabel.Location = new System.Drawing.Point(34, 153);
            this.enqueueComplainLabel.Name = "enqueueComplainLabel";
            this.enqueueComplainLabel.Size = new System.Drawing.Size(50, 13);
            this.enqueueComplainLabel.TabIndex = 3;
            this.enqueueComplainLabel.Text = "Complain";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(258, 213);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 3;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // enqueueNameTextBox
            // 
            this.enqueueNameTextBox.Location = new System.Drawing.Point(127, 20);
            this.enqueueNameTextBox.Name = "enqueueNameTextBox";
            this.enqueueNameTextBox.Size = new System.Drawing.Size(206, 20);
            this.enqueueNameTextBox.TabIndex = 1;
            // 
            // enqueueNameLable
            // 
            this.enqueueNameLable.AutoSize = true;
            this.enqueueNameLable.Location = new System.Drawing.Point(49, 25);
            this.enqueueNameLable.Name = "enqueueNameLable";
            this.enqueueNameLable.Size = new System.Drawing.Size(35, 13);
            this.enqueueNameLable.TabIndex = 0;
            this.enqueueNameLable.Text = "Name";
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerUI";
            this.Text = "Customer Queue Management System";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView waitingQueueListview;
        private System.Windows.Forms.ColumnHeader serialNoColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader phoneColumnHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueNameTextBox;
        private System.Windows.Forms.TextBox dequeueSerialNoTextBox;
        private System.Windows.Forms.Label dequeueComplainLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dequeueSerailNoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox enqueueComplainTextBox;
        private System.Windows.Forms.Label enqueueComplainLabel;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox enqueueNameTextBox;
        private System.Windows.Forms.Label enqueueNameLable;
        private System.Windows.Forms.TextBox dequeuePhoneTextBox;
        private System.Windows.Forms.TextBox dequeueEmailTextBox;
        private System.Windows.Forms.Label dequeuePhoneLabel;
        private System.Windows.Forms.Label dequeueEmailLabel;
        private System.Windows.Forms.TextBox enqueuePhoneTextBox;
        private System.Windows.Forms.TextBox enqueueEmailTextBox;
        private System.Windows.Forms.Label enqueuePhoneLabel;
        private System.Windows.Forms.Label enqueueEmailLabel;
        private System.Windows.Forms.ColumnHeader complainColumnHeader;
    }
}

