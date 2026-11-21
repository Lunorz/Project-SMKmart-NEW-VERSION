using System.Drawing.Drawing2D;
using System.Reflection;

public static class UiTheme
{
    public static readonly Color SeaGreen = Color.FromArgb(46, 139, 87);
    public static readonly Color SeaGreenDark = Color.FromArgb(34, 110, 68);
    public static readonly Color Mint = Color.FromArgb(234, 246, 239);
    public static readonly Color CardBorder = Color.FromArgb(208, 232, 218);

    static readonly Pen BorderPen = new Pen(CardBorder);
    static readonly SolidBrush GreenBrush = new SolidBrush(SeaGreen);
    static readonly SolidBrush DarkBrush = new SolidBrush(SeaGreenDark);
    static readonly SolidBrush CornerDot = new SolidBrush(Color.FromArgb(70, SeaGreen));

    static TextureBrush _stripe;
    static TextureBrush Stripe => _stripe ??= BuildStripe();

    static TextureBrush BuildStripe()
    {
        var bmp = new Bitmap(22, 22);
        using (var g = Graphics.FromImage(bmp))
        using (var pen = new Pen(Color.FromArgb(34, SeaGreen), 1f))
        {
            g.DrawLine(pen, 0, 22, 22, 0);
        }
        return new TextureBrush(bmp, WrapMode.Tile);
    }

    public static void Apply(UserControl uc)
    {
        uc.SuspendLayout();

        uc.BackColor = Mint;
        DoubleBuffer(uc);
        Walk(uc, uc, null, false);

        var timer = new System.Windows.Forms.Timer { Interval = 150 };
        timer.Tick += (s, e) => { timer.Stop(); BuildBackground(uc); };
        uc.SizeChanged += (s, e) => { timer.Stop(); timer.Start(); };
        uc.Disposed += (s, e) =>
        {
            timer.Dispose();
            var old = uc.BackgroundImage;
            uc.BackgroundImage = null;
            old?.Dispose();
        };
        BuildBackground(uc);

        uc.ResumeLayout(true);
    }

    public static void DecorateHeader(Panel header)
    {
        DoubleBuffer(header);
        header.BackColor = Color.White;
        foreach (Control c in header.Controls)
            if (c is Label l) l.BackColor = Color.Transparent;

        header.Resize += (s, e) => header.Invalidate();
        header.Paint += (s, e) =>
        {
            var g = e.Graphics;
            var r = header.ClientRectangle;
            if (r.Width < 4 || r.Height < 4) return;

            using (var br = new LinearGradientBrush(r, Color.White, Color.FromArgb(214, 238, 224), 0f))
                g.FillRectangle(br, r);

            g.FillRectangle(Stripe, r.Width / 2, 0, r.Width - r.Width / 2, r.Height);
            g.FillRectangle(GreenBrush, 0, r.Height - 3, r.Width, 3);
        };
    }

    static void BuildBackground(UserControl uc)
    {
        int w = uc.ClientSize.Width, h = uc.ClientSize.Height;
        if (w < 50 || h < 50) return;

        var bmp = new Bitmap(w, h);
        using (var g = Graphics.FromImage(bmp))
        {
            using (var br = new LinearGradientBrush(new Rectangle(0, 0, w, h),
                Color.FromArgb(247, 253, 249), Color.FromArgb(204, 233, 217), 35f))
                g.FillRectangle(br, 0, 0, w, h);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var circle = new SolidBrush(Color.FromArgb(24, SeaGreen)))
            {
                g.FillEllipse(circle, w - 300, -150, 460, 460);
                g.FillEllipse(circle, -170, h - 250, 400, 400);
            }

            g.SmoothingMode = SmoothingMode.None;
            using (var dot = new SolidBrush(Color.FromArgb(48, SeaGreen)))
                for (int x = 14; x < w; x += 26)
                    for (int y = 14; y < h; y += 26)
                        g.FillRectangle(dot, x, y, 3, 3);
        }

        var old = uc.BackgroundImage;
        uc.BackgroundImageLayout = ImageLayout.None;
        uc.BackgroundImage = bmp;
        old?.Dispose();
    }

    static void Walk(Control parent, Control root, Color? surface, bool gradient)
    {
        foreach (Control c in parent.Controls)
        {
            if ((c.Tag as string) == "skip") continue;

            switch (c)
            {
                case Panel p:
                    DoubleBuffer(p);

                    if (surface == null)
                    {
                        bool forceCard = (p.Tag as string) == "card";

                        if (!forceCard && (IsSpacer(p) || IsWrapper(p, root)))
                        {
                            p.BackColor = Color.Transparent;
                            Walk(p, root, null, false);
                        }
                        else
                        {
                            bool green = IsGreen(p.BackColor);
                            p.BackColor = green ? SeaGreen : Color.White;
                            AddCardPaint(p, green);
                            Walk(p, root, p.BackColor, green);
                        }
                    }
                    else
                    {
                        if (gradient) p.BackColor = Color.Transparent;
                        Color own = (gradient || p.BackColor.A == 0) ? surface.Value : p.BackColor;
                        Walk(p, root, own, gradient);
                    }
                    break;

                case Label l:
                    l.BackColor = gradient ? Color.Transparent : (surface ?? Color.Transparent);
                    break;

                case Button b:
                    StyleButton(b);
                    break;

                case DataGridView d:
                    DoubleBuffer(d);
                    StyleGrid(d);
                    break;

                default:
                    if (c.HasChildren) Walk(c, root, surface, gradient);
                    break;
            }
        }
    }

    static bool IsSpacer(Panel p) => p.Width < 40 || p.Height < 40;

    static bool IsWrapper(Panel p, Control root) =>
        (p.Tag as string) == "wrapper"
        || p is TableLayoutPanel
        || p is FlowLayoutPanel
        || (p.Width >= root.Width * 0.9 && p.Height >= root.Height * 0.9);

    static bool IsGreen(Color c) =>
        c.G > c.R + 25 && c.G > c.B + 10 && (c.R + c.G + c.B) / 3 < 200;

    static void AddCardPaint(Panel p, bool green)
    {
        p.Resize += (s, e) => p.Invalidate();

        p.Paint += (s, e) =>
        {
            var g = e.Graphics;
            int w = p.Width, h = p.Height;
            if (w < 4 || h < 4) return;

            if (green)
            {
                var r = new Rectangle(0, 0, w, h);
                using (var br = new LinearGradientBrush(r,
                    Color.FromArgb(26, 108, 68), Color.FromArgb(82, 180, 126), 20f))
                    g.FillRectangle(br, r);

                var st = g.Save();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var c1 = new SolidBrush(Color.FromArgb(34, Color.White)))
                using (var c2 = new SolidBrush(Color.FromArgb(22, Color.White)))
                {
                    g.FillEllipse(c1, w - 110, -60, 170, 170);
                    g.FillEllipse(c2, w - 190, h - 50, 130, 130);
                }
                g.Restore(st);

                g.FillRectangle(DarkBrush, 0, h - 4, w, 4);
            }
            else
            {
                g.DrawRectangle(BorderPen, 0, 0, w - 1, h - 1);
                g.FillRectangle(GreenBrush, 0, 0, w, 4);

                if (w > 120)
                    for (int row = 0; row < 5; row++)
                        for (int col = 0; col <= row; col++)
                            g.FillRectangle(CornerDot, w - 14 - col * 10, 12 + row * 10, 3, 3);
            }
        };
    }

    static void StyleButton(Button b)
    {
        b.FlatStyle = FlatStyle.Flat;
        b.FlatAppearance.BorderSize = 0;
        b.BackColor = SeaGreen;
        b.ForeColor = Color.White;
        b.Cursor = Cursors.Hand;
        b.MouseEnter += (s, e) => b.BackColor = SeaGreenDark;
        b.MouseLeave += (s, e) => b.BackColor = SeaGreen;
    }

    static void StyleGrid(DataGridView d)
    {
        d.BorderStyle = BorderStyle.None;
        d.EnableHeadersVisualStyles = false;
        d.BackgroundColor = Color.White;
        d.GridColor = Color.FromArgb(230, 242, 235);
        d.RowHeadersVisible = false;
        d.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        d.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 246, 238);
        d.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(24, 86, 56);
        d.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 232, 214);
        d.DefaultCellStyle.SelectionForeColor = Color.Black;
        d.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 252, 250);

        d.Paint += (s, e) =>
        {
            int used = (d.ColumnHeadersVisible ? d.ColumnHeadersHeight : 0)
                     + d.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int h = d.ClientSize.Height - used;
            if (h > 2)
                PaintEmptyArea(e.Graphics, new Rectangle(0, used, d.ClientSize.Width, h));
        };
        d.RowsAdded += (s, e) => d.Invalidate();
        d.RowsRemoved += (s, e) => d.Invalidate();
        d.Resize += (s, e) => d.Invalidate();
    }

    static void PaintEmptyArea(Graphics g, Rectangle r)
    {
        var st = g.Save();
        g.SetClip(r);

        using (var grad = new LinearGradientBrush(r, Color.White, Color.FromArgb(222, 242, 231), 90f))
            g.FillRectangle(grad, r);

        g.FillRectangle(Stripe, r);

        g.SmoothingMode = SmoothingMode.AntiAlias;
        using (var c = new SolidBrush(Color.FromArgb(26, SeaGreen)))
        {
            g.FillEllipse(c, r.Right - 260, r.Bottom - 200, 380, 380);
            g.FillEllipse(c, r.Left - 120, r.Bottom - 120, 240, 240);
        }

        g.Restore(st);
    }

    static void DoubleBuffer(Control c)
    {
        typeof(Control)
            .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
            ?.SetValue(c, true);
    }
}