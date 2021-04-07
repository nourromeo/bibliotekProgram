
namespace bibliotekProgram
{
    partial class ManagementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.managementView = new System.Windows.Forms.DataGridView();
            this.mainSplitter = new System.Windows.Forms.SplitContainer();
            this.buttonSplitter = new System.Windows.Forms.SplitContainer();
            this.addBookButton = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managementView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).BeginInit();
            this.mainSplitter.Panel1.SuspendLayout();
            this.mainSplitter.Panel2.SuspendLayout();
            this.mainSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSplitter)).BeginInit();
            this.buttonSplitter.Panel1.SuspendLayout();
            this.buttonSplitter.Panel2.SuspendLayout();
            this.buttonSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // managementView
            // 
            this.managementView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managementView.Location = new System.Drawing.Point(0, 3);
            this.managementView.Name = "managementView";
            this.managementView.RowHeadersWidth = 62;
            this.managementView.RowTemplate.Height = 28;
            this.managementView.Size = new System.Drawing.Size(421, 717);
            this.managementView.TabIndex = 0;
            // 
            // mainSplitter
            // 
            this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitter.IsSplitterFixed = true;
            this.mainSplitter.Location = new System.Drawing.Point(0, 0);
            this.mainSplitter.Name = "mainSplitter";
            // 
            // mainSplitter.Panel1
            // 
            this.mainSplitter.Panel1.Controls.Add(this.buttonSplitter);
            this.mainSplitter.Panel1.Controls.Add(this.managementView);
            // 
            // mainSplitter.Panel2
            // 
            this.mainSplitter.Panel2.Controls.Add(this.descriptionTextBox);
            this.mainSplitter.Panel2.Controls.Add(this.isbnTextBox);
            this.mainSplitter.Panel2.Controls.Add(this.authorTextBox);
            this.mainSplitter.Panel2.Controls.Add(this.titleTextBox);
            this.mainSplitter.Panel2.Controls.Add(this.label4);
            this.mainSplitter.Panel2.Controls.Add(this.label3);
            this.mainSplitter.Panel2.Controls.Add(this.label2);
            this.mainSplitter.Panel2.Controls.Add(this.label1);
            this.mainSplitter.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSplitter.Size = new System.Drawing.Size(1337, 781);
            this.mainSplitter.SplitterDistance = 431;
            this.mainSplitter.TabIndex = 1;
            // 
            // buttonSplitter
            // 
            this.buttonSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSplitter.IsSplitterFixed = true;
            this.buttonSplitter.Location = new System.Drawing.Point(3, 726);
            this.buttonSplitter.Name = "buttonSplitter";
            // 
            // buttonSplitter.Panel1
            // 
            this.buttonSplitter.Panel1.Controls.Add(this.addBookButton);
            // 
            // buttonSplitter.Panel2
            // 
            this.buttonSplitter.Panel2.Controls.Add(this.removeBookButton);
            this.buttonSplitter.Size = new System.Drawing.Size(418, 52);
            this.buttonSplitter.SplitterDistance = 140;
            this.buttonSplitter.TabIndex = 3;
            // 
            // addBookButton
            // 
            this.addBookButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBookButton.Location = new System.Drawing.Point(0, 0);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(315, 176);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            // 
            // removeBookButton
            // 
            this.removeBookButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeBookButton.Location = new System.Drawing.Point(0, 0);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(617, 117);
            this.removeBookButton.TabIndex = 2;
            this.removeBookButton.Text = "Remove Book";
            this.removeBookButton.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(25, 178);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(858, 581);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.isbnTextBox.Location = new System.Drawing.Point(179, 99);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(704, 35);
            this.isbnTextBox.TabIndex = 6;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Location = new System.Drawing.Point(179, 58);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(704, 35);
            this.authorTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(179, 17);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(704, 35);
            this.titleTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // ManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitter);
            this.Name = "ManagementControl";
            this.Size = new System.Drawing.Size(1337, 781);
            ((System.ComponentModel.ISupportInitialize)(this.managementView)).EndInit();
            this.mainSplitter.Panel1.ResumeLayout(false);
            this.mainSplitter.Panel2.ResumeLayout(false);
            this.mainSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).EndInit();
            this.mainSplitter.ResumeLayout(false);
            this.buttonSplitter.Panel1.ResumeLayout(false);
            this.buttonSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSplitter)).EndInit();
            this.buttonSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView managementView;
        private System.Windows.Forms.SplitContainer mainSplitter;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.SplitContainer buttonSplitter;
    }
}
