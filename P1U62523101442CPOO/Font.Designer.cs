namespace P1U62523101442CPOO
{
    partial class Font
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
            lblFont = new Label();
            txtFont = new TextBox();
            lbFonts = new ListBox();
            lblFontStyle = new Label();
            txtFontStyle = new TextBox();
            lbFontStyles = new ListBox();
            textBox1 = new TextBox();
            lblSize = new Label();
            lbSizes = new ListBox();
            gbExample = new GroupBox();
            label1 = new Label();
            btnCancel = new Button();
            btnAccept = new Button();
            gbExample.SuspendLayout();
            SuspendLayout();
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(12, 9);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(34, 15);
            lblFont.TabIndex = 0;
            lblFont.Text = "Font:";
            // 
            // txtFont
            // 
            txtFont.Location = new Point(12, 27);
            txtFont.Name = "txtFont";
            txtFont.Size = new Size(173, 23);
            txtFont.TabIndex = 1;
            // 
            // lbFonts
            // 
            lbFonts.FormattingEnabled = true;
            lbFonts.ItemHeight = 15;
            lbFonts.Location = new Point(12, 49);
            lbFonts.Name = "lbFonts";
            lbFonts.Size = new Size(173, 109);
            lbFonts.TabIndex = 2;
            // 
            // lblFontStyle
            // 
            lblFontStyle.AutoSize = true;
            lblFontStyle.Location = new Point(201, 9);
            lblFontStyle.Name = "lblFontStyle";
            lblFontStyle.Size = new Size(61, 15);
            lblFontStyle.TabIndex = 3;
            lblFontStyle.Text = "Font style:";
            // 
            // txtFontStyle
            // 
            txtFontStyle.Location = new Point(201, 27);
            txtFontStyle.Name = "txtFontStyle";
            txtFontStyle.Size = new Size(123, 23);
            txtFontStyle.TabIndex = 4;
            // 
            // lbFontStyles
            // 
            lbFontStyles.FormattingEnabled = true;
            lbFontStyles.ItemHeight = 15;
            lbFontStyles.Location = new Point(201, 49);
            lbFontStyles.Name = "lbFontStyles";
            lbFontStyles.Size = new Size(123, 109);
            lbFontStyles.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 23);
            textBox1.TabIndex = 6;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(341, 9);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(61, 15);
            lblSize.TabIndex = 7;
            lblSize.Text = "Font style:";
            // 
            // lbSizes
            // 
            lbSizes.FormattingEnabled = true;
            lbSizes.ItemHeight = 15;
            lbSizes.Location = new Point(341, 49);
            lbSizes.Name = "lbSizes";
            lbSizes.Size = new Size(70, 94);
            lbSizes.TabIndex = 8;
            // 
            // gbExample
            // 
            gbExample.Controls.Add(label1);
            gbExample.Location = new Point(201, 175);
            gbExample.Name = "gbExample";
            gbExample.Size = new Size(210, 80);
            gbExample.TabIndex = 9;
            gbExample.TabStop = false;
            gbExample.Text = "Example";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.Location = new Point(39, 31);
            label1.Name = "label1";
            label1.Size = new Size(126, 29);
            label1.TabIndex = 10;
            label1.Text = "AaBbYyZz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(339, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(258, 283);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 11;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // Font
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 318);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            Controls.Add(gbExample);
            Controls.Add(lblSize);
            Controls.Add(textBox1);
            Controls.Add(txtFontStyle);
            Controls.Add(lblFontStyle);
            Controls.Add(txtFont);
            Controls.Add(lblFont);
            Controls.Add(lbFonts);
            Controls.Add(lbFontStyles);
            Controls.Add(lbSizes);
            Name = "Font";
            Text = "Font";
            gbExample.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFont;
        private TextBox txtFont;
        private ListBox lbFonts;
        private Label lblFontStyle;
        private TextBox txtFontStyle;
        private ListBox lbFontStyles;
        private TextBox textBox1;
        private Label lblSize;
        private ListBox lbSizes;
        private GroupBox gbExample;
        private Label label1;
        private Button btnCancel;
        private Button btnAccept;
    }
}