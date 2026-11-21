using System.Drawing.Drawing2D;
using System.Reflection;

public static class UiDataBarang
{
    static readonly Color Green = Color.FromArgb(46, 139, 87);
    static readonly Color GreenDark = Color.FromArgb(34, 110, 68);
    static readonly Color Mint = Color.FromArgb(234, 246, 239);
    static readonly Color Edge = Color.FromArgb(208, 232, 218);
    static readonly Color FocusMint = Color.FromArgb(240, 250, 244);

    static readonly Pen EdgePen = new Pen(Edge);
    static readonly SolidBrush GreenBrush = new SolidBrush(Green);
    static readonly SolidBrush DarkBrush = new SolidBrush(GreenDark);

    static TextureBrush _greenStripe;
    static TextureBrush _whiteStripe;
    static TextureBrush GreenStripe => _greenStripe ??= BuildStripe(Color.FromArgb(34, Green));
    static TextureBrush WhiteStripe => _whiteStripe ??= BuildStripe(Color.FromArgb(30, Color.White));

    static TextureBrush BuildStripe(Color color)
    {
        var bmp = new Bitmap(22, 22);
        using (var g = Graphics.FromImage(bmp))
        using (var pen = new Pen(color, 1f))
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
        ClearLabels(uc);

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

    static void BuildBackground(UserControl uc)
    {
        int w = uc.ClientSize.Width, h = uc.ClientSize.Height;
        if (w < 50 || h < 50) return;

        var bmp = new Bitmap(w, h);
        using (var g = Graphics.FromImage(bmp))
        {
            using (var br = new LinearGradientBrush(new Rectangle(0, 0, w, h),
                Color.FromArgb(247, 253, 249), Color.FromArgb(206, 234, 218), 35f))
                g.FillRectangle(br, 0, 0, w, h);

            using (var line = new Pen(Color.FromArgb(26, Green)))
            using (var plus = new SolidBrush(Color.FromArgb(80, Green)))
            {
                for (int x = 0; x < w; x += 40)
                    g.DrawLine(line, x, 0, x, h);
                for (int y = 0; y < h; y += 40)
                    g.DrawLine(line, 0, y, w, y);

                for (int x = 40; x < w; x += 40)
                    for (int y = 40; y < h; y += 40)
                    {
                        g.FillRectangle(plus, x - 4, y - 1, 9, 3);
                        g.FillRectangle(plus, x - 1, y - 4, 3, 9);
                    }
            }

            using (var box = new Pen(Color.FromArgb(46, Green), 2f))
            {
                g.DrawRectangle(box, w - 280, h - 280, 220, 220);
                g.DrawRectangle(box, w - 230, h - 230, 220, 220);
                g.DrawRectangle(box, -60, -60, 160, 160);
            }
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
                    WalkPanel(p, root, surface, gradient);
                    break;

                case Label l:
                    l.BackColor = gradient ? Color.Transparent : (surface ?? Color.Transparent);
                    if (gradient) l.ForeColor = Color.White;
                    break;

                case Button b:
                    StyleButton(b);
                    break;

                case TextBox or NumericUpDown or ComboBox:
                    StyleInput(c);
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

    static void WalkPanel(Panel p, Control root, Color? surface, bool gradient)
    {
        string tag = p.Tag as string;

        if (surface == null)
        {
            if (tag != "card" && (IsSpacer(p) || IsWrapper(p, root, tag)))
            {
                p.BackColor = Color.Transparent;
                Walk(p, root, null, false);
                return;
            }

            p.BackColor = Color.White;
            AddCardPaint(p);
            Walk(p, root, Color.White, false);
            return;
        }

        if (gradient)
        {
            p.BackColor = Color.Transparent;
            Walk(p, root, surface, true);
            return;
        }

        if (tag == "header" || IsGreen(p.BackColor))
        {
            p.BackColor = Green;
            AddHeaderPaint(p);
            Walk(p, root, Green, true);
            return;
        }

        if (IsStrip(p))
        {
            AddStripPaint(p);
            Walk(p, root, p.BackColor, false);
            return;
        }

        Color own = p.BackColor.A == 0 ? surface.Value : p.BackColor;
        Walk(p, root, own, false);
    }

    static bool IsSpacer(Panel p) => p.Width < 40 || p.Height < 40;

    static bool IsWrapper(Panel p, Control root, string tag) =>
        tag == "wrapper"
        || p is TableLayoutPanel
        || p is FlowLayoutPanel
        || (p.Width >= root.Width * 0.9 && p.Height >= root.Height * 0.9);

    static bool IsGreen(Color c) =>
        c.G > c.R + 25 && c.G > c.B + 10 && (c.R + c.G + c.B) / 3 < 200;

    static bool IsStrip(Panel p) =>
        p.Height <= 48 && p.Width > 200
        && p.BackColor.A != 0
        && p.BackColor.R > 225 && p.BackColor.R < 252 && p.BackColor.G > 240;

    static void AddCardPaint(Panel p)
    {
        p.Resize += (s, e) => p.Invalidate();
        p.Paint += (s, e) =>
        {
            var g = e.Graphics;
            int w = p.Width, h = p.Height;
            if (w < 4 || h < 4) return;

            g.DrawRectangle(EdgePen, 0, 0, w - 1, h - 1);
            g.FillRectangle(GreenBrush, 0, 0, w, 4);

            if (w > 200)
            {
                using (var a = new SolidBrush(Color.FromArgb(40, Green)))
                using (var b = new SolidBrush(Color.FromArgb(75, Green)))
                using (var c = new SolidBrush(Color.FromArgb(120, Green)))
                {
                    g.FillRectangle(a, w - 46, 10, 8, 8);
                    g.FillRectangle(b, w - 34, 10, 8, 8);
                    g.FillRectangle(c, w - 22, 10, 8, 8);
                }
            }
        };
    }

    static void AddHeaderPaint(Panel p)
    {
        p.Resize += (s, e) => p.Invalidate();
        p.Paint += (s, e) =>
        {
            var g = e.Graphics;
            var r = new Rectangle(0, 0, p.Width, p.Height);
            if (r.Width < 4 || r.Height < 4) return;

            using (var br = new LinearGradientBrush(r,
                Color.FromArgb(26, 108, 68), Color.FromArgb(90, 186, 132), 0f))
                g.FillRectangle(br, r);

            g.FillRectangle(WhiteStripe, r);

            var st = g.Save();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var c1 = new SolidBrush(Color.FromArgb(34, Color.White)))
            using (var c2 = new SolidBrush(Color.FromArgb(22, Color.White)))
            {
                g.FillEllipse(c1, r.Width - 100, -55, 150, 150);
                g.FillEllipse(c2, r.Width - 170, r.Height - 40, 110, 110);
            }
            g.Restore(st);

            g.FillRectangle(DarkBrush, 0, r.Height - 3, r.Width, 3);
        };
    }

    static void AddStripPaint(Panel p)
    {
        p.Resize += (s, e) => p.Invalidate();
        p.Paint += (s, e) =>
            e.Graphics.FillRectangle(GreenBrush, 0, p.Height - 2, p.Width, 2);
    }

    static void StyleButton(Button b)
    {
        b.FlatStyle = FlatStyle.Flat;
        b.FlatAppearance.BorderSize = 0;
        b.BackColor = Green;
        b.ForeColor = Color.White;
        b.Cursor = Cursors.Hand;
        b.MouseEnter += (s, e) => b.BackColor = GreenDark;
        b.MouseLeave += (s, e) => b.BackColor = Green;
    }

    static void StyleInput(Control c)
    {
        if (c is TextBox tb && tb.ReadOnly)
        {
            c.BackColor = Color.FromArgb(241, 246, 243);
            return;
        }

        if (c is ComboBox cb)
            cb.Enter += (s, e) => cb.BeginInvoke(new Action(() => cb.SelectionLength = 0));
        c.BackColor = Color.White;
        c.Enter += (s, e) => c.BackColor = FocusMint;
        c.Leave += (s, e) => c.BackColor = Color.White;
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
                PaintEmptyArea(e.Graphics, new Rectangle(0, used, d.ClientSize.Width, h),
                               d.Rows.Count == 0, d.Font);
        };
        d.RowsAdded += (s, e) => d.Invalidate();
        d.RowsRemoved += (s, e) => d.Invalidate();
        d.Resize += (s, e) => d.Invalidate();
    }

    static void PaintEmptyArea(Graphics g, Rectangle r, bool empty, Font font)
    {
        var st = g.Save();
        g.SetClip(r);

        using (var grad = new LinearGradientBrush(r, Color.White, Color.FromArgb(222, 242, 231), 90f))
            g.FillRectangle(grad, r);

        g.FillRectangle(GreenStripe, r);

        g.SmoothingMode = SmoothingMode.AntiAlias;
        using (var c = new SolidBrush(Color.FromArgb(26, Green)))
        {
            g.FillEllipse(c, r.Right - 260, r.Bottom - 200, 380, 380);
            g.FillEllipse(c, r.Left - 120, r.Bottom - 120, 240, 240);
        }

        if (empty && r.Height > 170 && r.Width > 240)
            DrawEmptyState(g, r, font);

        g.Restore(st);
    }

    static void DrawEmptyState(Graphics g, Rectangle r, Font font)
    {
        int cx = r.Left + r.Width / 2;
        int cy = r.Top + r.Height / 2 - 30;

        using (var top = new SolidBrush(Color.FromArgb(191, 227, 207)))
        using (var left = new SolidBrush(Color.FromArgb(143, 205, 170)))
        using (var right = new SolidBrush(Color.FromArgb(109, 184, 143)))
        {
            g.FillPolygon(top, new[] {
                new Point(cx, cy - 45), new Point(cx + 50, cy - 22),
                new Point(cx, cy + 1), new Point(cx - 50, cy - 22) });
            g.FillPolygon(left, new[] {
                new Point(cx - 50, cy - 22), new Point(cx, cy + 1),
                new Point(cx, cy + 55), new Point(cx - 50, cy + 32) });
            g.FillPolygon(right, new[] {
                new Point(cx, cy + 1), new Point(cx + 50, cy - 22),
                new Point(cx + 50, cy + 32), new Point(cx, cy + 55) });
        }

        using (var bold = new Font(font, FontStyle.Bold))
        using (var title = new SolidBrush(Color.FromArgb(24, 86, 56)))
        using (var sub = new SolidBrush(Color.FromArgb(92, 122, 107)))
        using (var sf = new StringFormat { Alignment = StringAlignment.Center })
        {
            g.DrawString("Belum ada data", bold, title, cx, cy + 70, sf);
            g.DrawString("Data akan tampil di sini", font, sub, cx, cy + 94, sf);
        }
    }

    static void DoubleBuffer(Control c)
    {
        typeof(Control)
            .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
            ?.SetValue(c, true);
    }

    static void ClearLabels(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            if (c is Label l) l.BackColor = Color.Transparent;
            if (c.HasChildren) ClearLabels(c);
        }
    }
}