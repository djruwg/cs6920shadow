namespace BBB.Views
{
    partial class RestWorkSpace
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
            tableLayoutPanel1 = new TableLayoutPanel();
            sendLabel = new Label();
            sendTextBox = new TextBox();
            returnLabel = new Label();
            returnTextBox = new TextBox();
            jsonLabel = new Label();
            jsonTextBox = new TextBox();
            testDataTextBox = new TextBox();
            testDataLabel = new Label();
            send2Label = new Label();
            return2Label = new Label();
            send2TextBox = new TextBox();
            return2TextBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            resetButton = new Button();
            updateButton = new Button();
            getButton = new Button();
            putButton = new Button();
            postButton = new Button();
            button1 = new Button();
            testData2TextBox = new TextBox();
            data2Label = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 542F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(sendLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(sendTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(returnLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(returnTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(jsonLabel, 0, 7);
            tableLayoutPanel1.Controls.Add(jsonTextBox, 1, 7);
            tableLayoutPanel1.Controls.Add(testDataTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(testDataLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(send2Label, 0, 9);
            tableLayoutPanel1.Controls.Add(return2Label, 0, 11);
            tableLayoutPanel1.Controls.Add(send2TextBox, 1, 9);
            tableLayoutPanel1.Controls.Add(return2TextBox, 1, 11);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 21);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(testData2TextBox, 1, 13);
            tableLayoutPanel1.Controls.Add(data2Label, 0, 13);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 22;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(2706, 2119);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sendLabel
            // 
            sendLabel.Anchor = AnchorStyles.Left;
            sendLabel.AutoSize = true;
            sendLabel.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendLabel.Location = new Point(3, 102);
            sendLabel.Name = "sendLabel";
            sendLabel.Size = new Size(179, 42);
            sendLabel.TabIndex = 0;
            sendLabel.Text = "send time";
            // 
            // sendTextBox
            // 
            sendTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sendTextBox.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendTextBox.Location = new Point(545, 98);
            sendTextBox.Margin = new Padding(3, 4, 3, 4);
            sendTextBox.Name = "sendTextBox";
            sendTextBox.Size = new Size(2158, 49);
            sendTextBox.TabIndex = 1;
            // 
            // returnLabel
            // 
            returnLabel.Anchor = AnchorStyles.Left;
            returnLabel.AutoSize = true;
            returnLabel.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnLabel.Location = new Point(3, 266);
            returnLabel.Name = "returnLabel";
            returnLabel.Size = new Size(194, 42);
            returnLabel.TabIndex = 2;
            returnLabel.Text = "return time";
            // 
            // returnTextBox
            // 
            returnTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            returnTextBox.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnTextBox.Location = new Point(545, 262);
            returnTextBox.Margin = new Padding(3, 4, 3, 4);
            returnTextBox.Name = "returnTextBox";
            returnTextBox.Size = new Size(2158, 49);
            returnTextBox.TabIndex = 3;
            // 
            // jsonLabel
            // 
            jsonLabel.Anchor = AnchorStyles.Left;
            jsonLabel.AutoSize = true;
            jsonLabel.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jsonLabel.Location = new Point(3, 594);
            jsonLabel.Name = "jsonLabel";
            jsonLabel.Size = new Size(278, 42);
            jsonLabel.TabIndex = 4;
            jsonLabel.Text = "BBBPing JSON";
            // 
            // jsonTextBox
            // 
            jsonTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            jsonTextBox.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jsonTextBox.Location = new Point(545, 590);
            jsonTextBox.Margin = new Padding(3, 4, 3, 4);
            jsonTextBox.Name = "jsonTextBox";
            jsonTextBox.Size = new Size(2158, 49);
            jsonTextBox.TabIndex = 5;
            // 
            // testDataTextBox
            // 
            testDataTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            testDataTextBox.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            testDataTextBox.Location = new Point(545, 426);
            testDataTextBox.Margin = new Padding(3, 4, 3, 4);
            testDataTextBox.Name = "testDataTextBox";
            testDataTextBox.Size = new Size(2158, 49);
            testDataTextBox.TabIndex = 6;
            // 
            // testDataLabel
            // 
            testDataLabel.Anchor = AnchorStyles.Left;
            testDataLabel.AutoSize = true;
            testDataLabel.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            testDataLabel.Location = new Point(3, 430);
            testDataLabel.Name = "testDataLabel";
            testDataLabel.Size = new Size(161, 42);
            testDataLabel.TabIndex = 7;
            testDataLabel.Text = "test data";
            // 
            // send2Label
            // 
            send2Label.AutoSize = true;
            send2Label.Dock = DockStyle.Fill;
            send2Label.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            send2Label.Location = new Point(3, 738);
            send2Label.Name = "send2Label";
            send2Label.Size = new Size(536, 82);
            send2Label.TabIndex = 8;
            send2Label.Text = "send time";
            // 
            // return2Label
            // 
            return2Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            return2Label.AutoSize = true;
            return2Label.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            return2Label.Location = new Point(3, 922);
            return2Label.Name = "return2Label";
            return2Label.Size = new Size(536, 42);
            return2Label.TabIndex = 9;
            return2Label.Text = "return time";
            // 
            // send2TextBox
            // 
            send2TextBox.Dock = DockStyle.Fill;
            send2TextBox.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            send2TextBox.Location = new Point(545, 742);
            send2TextBox.Margin = new Padding(3, 4, 3, 4);
            send2TextBox.Name = "send2TextBox";
            send2TextBox.Size = new Size(2158, 49);
            send2TextBox.TabIndex = 10;
            // 
            // return2TextBox
            // 
            return2TextBox.Dock = DockStyle.Fill;
            return2TextBox.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            return2TextBox.Location = new Point(545, 906);
            return2TextBox.Margin = new Padding(3, 4, 3, 4);
            return2TextBox.Name = "return2TextBox";
            return2TextBox.Size = new Size(2158, 49);
            return2TextBox.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(resetButton);
            flowLayoutPanel1.Controls.Add(updateButton);
            flowLayoutPanel1.Controls.Add(getButton);
            flowLayoutPanel1.Controls.Add(putButton);
            flowLayoutPanel1.Controls.Add(postButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(545, 1726);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(2158, 609);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // resetButton
            // 
            resetButton.AutoSize = true;
            resetButton.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(3, 4);
            resetButton.Margin = new Padding(3, 4, 3, 4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(120, 67);
            resetButton.TabIndex = 0;
            resetButton.Text = "reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // updateButton
            // 
            updateButton.AutoSize = true;
            updateButton.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(129, 4);
            updateButton.Margin = new Padding(3, 4, 3, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(166, 67);
            updateButton.TabIndex = 1;
            updateButton.Text = "update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // getButton
            // 
            getButton.AutoSize = true;
            getButton.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getButton.Location = new Point(301, 4);
            getButton.Margin = new Padding(3, 4, 3, 4);
            getButton.Name = "getButton";
            getButton.Size = new Size(114, 67);
            getButton.TabIndex = 2;
            getButton.Text = "get";
            getButton.UseVisualStyleBackColor = true;
            getButton.Click += getButton_Click;
            // 
            // putButton
            // 
            putButton.Anchor = AnchorStyles.Left;
            putButton.AutoSize = true;
            putButton.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            putButton.Location = new Point(421, 4);
            putButton.Margin = new Padding(3, 4, 3, 4);
            putButton.Name = "putButton";
            putButton.Size = new Size(87, 67);
            putButton.TabIndex = 1;
            putButton.Text = "put";
            putButton.UseVisualStyleBackColor = true;
            putButton.Click += putButton_Click;
            // 
            // postButton
            // 
            postButton.Anchor = AnchorStyles.Left;
            postButton.AutoSize = true;
            postButton.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postButton.Location = new Point(514, 4);
            postButton.Margin = new Padding(3, 4, 3, 4);
            postButton.Name = "postButton";
            postButton.Size = new Size(107, 67);
            postButton.TabIndex = 3;
            postButton.Text = "post";
            postButton.UseVisualStyleBackColor = true;
            postButton.Click += postButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // testData2TextBox
            // 
            testData2TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            testData2TextBox.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            testData2TextBox.Location = new Point(545, 1082);
            testData2TextBox.Margin = new Padding(3, 4, 3, 4);
            testData2TextBox.Name = "testData2TextBox";
            testData2TextBox.Size = new Size(2158, 49);
            testData2TextBox.TabIndex = 15;
            // 
            // data2Label
            // 
            data2Label.Anchor = AnchorStyles.Left;
            data2Label.AutoSize = true;
            data2Label.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            data2Label.Location = new Point(3, 1086);
            data2Label.Name = "data2Label";
            data2Label.Size = new Size(161, 42);
            data2Label.TabIndex = 16;
            data2Label.Text = "test data";
            // 
            // RestWorkSpace
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2706, 2119);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RestWorkSpace";
            Text = "RestWorkSpace";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.TextBox returnTextBox;
        private System.Windows.Forms.Label jsonLabel;
        private System.Windows.Forms.TextBox jsonTextBox;
        private System.Windows.Forms.TextBox testDataTextBox;
        private System.Windows.Forms.Label testDataLabel;
        private System.Windows.Forms.Label send2Label;
        private System.Windows.Forms.Label return2Label;
        private System.Windows.Forms.TextBox send2TextBox;
        private System.Windows.Forms.TextBox return2TextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox testData2TextBox;
        private System.Windows.Forms.Label data2Label;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.Button postButton;
    }
}