namespace PrintData
{
    partial class FormDataManager
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
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnCreateDocument = new System.Windows.Forms.Button();
            this.checkBoxTxt = new System.Windows.Forms.CheckBox();
            this.checkBoxWord = new System.Windows.Forms.CheckBox();
            this.checkBoxExcel = new System.Windows.Forms.CheckBox();
            this.checkBoxPDF = new System.Windows.Forms.CheckBox();
            this.groupBoxWork = new System.Windows.Forms.GroupBox();
            this.lbxShowData = new System.Windows.Forms.ListBox();
            this.btnSortByID = new System.Windows.Forms.Button();
            this.btnSortByBal = new System.Windows.Forms.Button();
            this.groupBoxWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowData
            // 
            this.btnShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowData.Location = new System.Drawing.Point(13, 40);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(90, 26);
            this.btnShowData.TabIndex = 0;
            this.btnShowData.Text = "Show data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnCreateDocument
            // 
            this.btnCreateDocument.Enabled = false;
            this.btnCreateDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateDocument.Location = new System.Drawing.Point(369, 194);
            this.btnCreateDocument.Name = "btnCreateDocument";
            this.btnCreateDocument.Size = new System.Drawing.Size(118, 31);
            this.btnCreateDocument.TabIndex = 1;
            this.btnCreateDocument.Text = "Create";
            this.btnCreateDocument.UseVisualStyleBackColor = true;
            this.btnCreateDocument.Click += new System.EventHandler(this.btnCreateDocument_Click);
            // 
            // checkBoxTxt
            // 
            this.checkBoxTxt.AutoSize = true;
            this.checkBoxTxt.Location = new System.Drawing.Point(6, 19);
            this.checkBoxTxt.Name = "checkBoxTxt";
            this.checkBoxTxt.Size = new System.Drawing.Size(99, 17);
            this.checkBoxTxt.TabIndex = 3;
            this.checkBoxTxt.Text = "Text Document";
            this.checkBoxTxt.UseVisualStyleBackColor = true;
            // 
            // checkBoxWord
            // 
            this.checkBoxWord.AutoSize = true;
            this.checkBoxWord.Location = new System.Drawing.Point(6, 42);
            this.checkBoxWord.Name = "checkBoxWord";
            this.checkBoxWord.Size = new System.Drawing.Size(104, 17);
            this.checkBoxWord.TabIndex = 4;
            this.checkBoxWord.Text = "Word Document";
            this.checkBoxWord.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcel
            // 
            this.checkBoxExcel.AutoSize = true;
            this.checkBoxExcel.Location = new System.Drawing.Point(6, 65);
            this.checkBoxExcel.Name = "checkBoxExcel";
            this.checkBoxExcel.Size = new System.Drawing.Size(104, 17);
            this.checkBoxExcel.TabIndex = 5;
            this.checkBoxExcel.Text = "Excel Document";
            this.checkBoxExcel.UseVisualStyleBackColor = true;
            // 
            // checkBoxPDF
            // 
            this.checkBoxPDF.AutoSize = true;
            this.checkBoxPDF.Location = new System.Drawing.Point(6, 88);
            this.checkBoxPDF.Name = "checkBoxPDF";
            this.checkBoxPDF.Size = new System.Drawing.Size(99, 17);
            this.checkBoxPDF.TabIndex = 6;
            this.checkBoxPDF.Text = "PDF Document";
            this.checkBoxPDF.UseVisualStyleBackColor = true;
            // 
            // groupBoxWork
            // 
            this.groupBoxWork.Controls.Add(this.checkBoxTxt);
            this.groupBoxWork.Controls.Add(this.checkBoxPDF);
            this.groupBoxWork.Controls.Add(this.checkBoxWord);
            this.groupBoxWork.Controls.Add(this.checkBoxExcel);
            this.groupBoxWork.Location = new System.Drawing.Point(369, 74);
            this.groupBoxWork.Name = "groupBoxWork";
            this.groupBoxWork.Size = new System.Drawing.Size(118, 114);
            this.groupBoxWork.TabIndex = 7;
            this.groupBoxWork.TabStop = false;
            this.groupBoxWork.Text = "Document Type";
            // 
            // lbxShowData
            // 
            this.lbxShowData.FormattingEnabled = true;
            this.lbxShowData.Location = new System.Drawing.Point(13, 72);
            this.lbxShowData.Name = "lbxShowData";
            this.lbxShowData.Size = new System.Drawing.Size(350, 342);
            this.lbxShowData.TabIndex = 8;
            // 
            // btnSortByID
            // 
            this.btnSortByID.Enabled = false;
            this.btnSortByID.Location = new System.Drawing.Point(149, 41);
            this.btnSortByID.Name = "btnSortByID";
            this.btnSortByID.Size = new System.Drawing.Size(104, 25);
            this.btnSortByID.TabIndex = 9;
            this.btnSortByID.Text = "Sort by ID";
            this.btnSortByID.UseVisualStyleBackColor = true;
            this.btnSortByID.Click += new System.EventHandler(this.btnSortByID_Click);
            // 
            // btnSortByBal
            // 
            this.btnSortByBal.Enabled = false;
            this.btnSortByBal.Location = new System.Drawing.Point(259, 41);
            this.btnSortByBal.Name = "btnSortByBal";
            this.btnSortByBal.Size = new System.Drawing.Size(104, 25);
            this.btnSortByBal.TabIndex = 10;
            this.btnSortByBal.Text = "Sort by Balance";
            this.btnSortByBal.UseVisualStyleBackColor = true;
            this.btnSortByBal.Click += new System.EventHandler(this.btnSortByBal_Click);
            // 
            // FormDataManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 425);
            this.Controls.Add(this.btnSortByBal);
            this.Controls.Add(this.btnSortByID);
            this.Controls.Add(this.lbxShowData);
            this.Controls.Add(this.groupBoxWork);
            this.Controls.Add(this.btnCreateDocument);
            this.Controls.Add(this.btnShowData);
            this.Name = "FormDataManager";
            this.Text = "Data Manager";
            this.groupBoxWork.ResumeLayout(false);
            this.groupBoxWork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnCreateDocument;
        private System.Windows.Forms.CheckBox checkBoxTxt;
        private System.Windows.Forms.CheckBox checkBoxWord;
        private System.Windows.Forms.CheckBox checkBoxExcel;
        private System.Windows.Forms.CheckBox checkBoxPDF;
        private System.Windows.Forms.GroupBox groupBoxWork;
        private System.Windows.Forms.ListBox lbxShowData;
        private System.Windows.Forms.Button btnSortByID;
        private System.Windows.Forms.Button btnSortByBal;
    }
}

