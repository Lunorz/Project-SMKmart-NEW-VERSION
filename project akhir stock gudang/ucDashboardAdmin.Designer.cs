namespace project_akhir_stock_gudang
{
    partial class ucDashboardAdmin
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
            pnlPage = new Panel();
            tlpKartu = new TableLayoutPanel();
            pnlKartuJual = new GradientPanel();
            pnlKartuTrx = new Panel();
            pnlKartuTrxDalam = new Panel();
            pnlKartuUser = new Panel();
            pnlKartuUserDalam = new Panel();
            pnlKartuStok = new Panel();
            pnlKartuStokDalam = new Panel();
            pnlPage.SuspendLayout();
            tlpKartu.SuspendLayout();
            pnlKartuUser.SuspendLayout();
            pnlKartuStok.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPage
            // 
            pnlPage.Controls.Add(tlpKartu);
            pnlPage.Controls.Add(pnlKartuTrxDalam);
            pnlPage.Dock = DockStyle.Fill;
            pnlPage.Location = new Point(0, 0);
            pnlPage.Name = "pnlPage";
            pnlPage.Padding = new Padding(28, 29, 28, 29);
            pnlPage.Size = new Size(1320, 840);
            pnlPage.TabIndex = 0;
            // 
            // tlpKartu
            // 
            tlpKartu.BackColor = Color.Transparent;
            tlpKartu.ColumnCount = 4;
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.Controls.Add(pnlKartuJual, 0, 0);
            tlpKartu.Controls.Add(pnlKartuTrx, 1, 0);
            tlpKartu.Controls.Add(pnlKartuUser, 2, 0);
            tlpKartu.Controls.Add(pnlKartuStok, 3, 0);
            tlpKartu.Dock = DockStyle.Top;
            tlpKartu.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlpKartu.Location = new Point(28, 29);
            tlpKartu.Name = "tlpKartu";
            tlpKartu.RowCount = 1;
            tlpKartu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKartu.Size = new Size(1264, 100);
            tlpKartu.TabIndex = 0;
            // 
            // pnlKartuJual
            // 
            pnlKartuJual.Angle = 45F;
            pnlKartuJual.BackColor = Color.FromArgb(31, 107, 66);
            pnlKartuJual.ColorBottom = Color.FromArgb(62, 156, 106);
            pnlKartuJual.ColorTop = Color.FromArgb(31, 107, 66);
            pnlKartuJual.Dock = DockStyle.Fill;
            pnlKartuJual.Location = new Point(0, 0);
            pnlKartuJual.Margin = new Padding(0, 0, 16, 0);
            pnlKartuJual.Name = "pnlKartuJual";
            pnlKartuJual.Size = new Size(300, 100);
            pnlKartuJual.TabIndex = 0;
            // 
            // pnlKartuTrx
            // 
            pnlKartuTrx.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTrx.Dock = DockStyle.Fill;
            pnlKartuTrx.Location = new Point(316, 0);
            pnlKartuTrx.Margin = new Padding(0, 0, 16, 0);
            pnlKartuTrx.Name = "pnlKartuTrx";
            pnlKartuTrx.Padding = new Padding(1);
            pnlKartuTrx.Size = new Size(300, 100);
            pnlKartuTrx.TabIndex = 1;
            // 
            // pnlKartuTrxDalam
            // 
            pnlKartuTrxDalam.BackColor = Color.White;
            pnlKartuTrxDalam.Dock = DockStyle.Fill;
            pnlKartuTrxDalam.Location = new Point(28, 29);
            pnlKartuTrxDalam.Name = "pnlKartuTrxDalam";
            pnlKartuTrxDalam.Size = new Size(1264, 782);
            pnlKartuTrxDalam.TabIndex = 2;
            // 
            // pnlKartuUser
            // 
            pnlKartuUser.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuUser.Controls.Add(pnlKartuUserDalam);
            pnlKartuUser.Dock = DockStyle.Fill;
            pnlKartuUser.Location = new Point(632, 0);
            pnlKartuUser.Margin = new Padding(0, 0, 16, 0);
            pnlKartuUser.Name = "pnlKartuUser";
            pnlKartuUser.Padding = new Padding(1);
            pnlKartuUser.Size = new Size(300, 100);
            pnlKartuUser.TabIndex = 2;
            // 
            // pnlKartuUserDalam
            // 
            pnlKartuUserDalam.BackColor = Color.White;
            pnlKartuUserDalam.Dock = DockStyle.Fill;
            pnlKartuUserDalam.Location = new Point(1, 1);
            pnlKartuUserDalam.Name = "pnlKartuUserDalam";
            pnlKartuUserDalam.Size = new Size(298, 98);
            pnlKartuUserDalam.TabIndex = 0;
            // 
            // pnlKartuStok
            // 
            pnlKartuStok.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuStok.Controls.Add(pnlKartuStokDalam);
            pnlKartuStok.Dock = DockStyle.Fill;
            pnlKartuStok.Location = new Point(951, 3);
            pnlKartuStok.Name = "pnlKartuStok";
            pnlKartuStok.Padding = new Padding(1);
            pnlKartuStok.Size = new Size(310, 94);
            pnlKartuStok.TabIndex = 3;
            // 
            // pnlKartuStokDalam
            // 
            pnlKartuStokDalam.BackColor = Color.White;
            pnlKartuStokDalam.Dock = DockStyle.Fill;
            pnlKartuStokDalam.Location = new Point(1, 1);
            pnlKartuStokDalam.Name = "pnlKartuStokDalam";
            pnlKartuStokDalam.Size = new Size(308, 92);
            pnlKartuStokDalam.TabIndex = 0;
            // 
            // ucDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPage);
            Font = new Font("Leelawadee UI", 10.5F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucDashboardAdmin";
            Size = new Size(1320, 840);
            pnlPage.ResumeLayout(false);
            tlpKartu.ResumeLayout(false);
            pnlKartuUser.ResumeLayout(false);
            pnlKartuStok.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPage;
        private TableLayoutPanel tlpKartu;
        private GradientPanel pnlKartuJual;
        private Panel pnlKartuTrx;
        private Panel pnlKartuUser;
        private Panel pnlKartuTrxDalam;
        private Panel pnlKartuUserDalam;
        private Panel pnlKartuStok;
        private Panel pnlKartuStokDalam;
    }
}
