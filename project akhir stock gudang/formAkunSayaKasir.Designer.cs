namespace project_akhir_stock_gudang
{
    partial class formAkunSayaKasir
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
            ucAkunSayaKasir1 = new ucAkunSayaKasir();
            SuspendLayout();
            // 
            // ucAkunSayaKasir1
            // 
            ucAkunSayaKasir1.Dock = DockStyle.Fill;
            ucAkunSayaKasir1.Location = new Point(0, 0);
            ucAkunSayaKasir1.Name = "ucAkunSayaKasir1";
            ucAkunSayaKasir1.Size = new Size(1082, 653);
            ucAkunSayaKasir1.TabIndex = 0;
            // 
            // formAkunSayaKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(ucAkunSayaKasir1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "formAkunSayaKasir";
            Text = "formAkunSayaKasir";
            FormClosed += formAkunSayaKasir_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private ucAkunSayaKasir ucAkunSayaKasir1;
    }
}