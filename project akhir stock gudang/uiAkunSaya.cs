using System.Drawing.Drawing2D;
using System.Reflection;

public static class UiAkunSaya
{
    static readonly Color Green = Color.FromArgb(46, 139, 87);
    static readonly Color GreenDark = Color.FromArgb(34, 110, 68);
    static readonly Color Mint = Color.FromArgb(234, 246, 239);
    static readonly Color Edge = Color.FromArgb(208, 232, 218);
    static readonly Color FocusMint = Color.FromArgb(240, 250, 244);

    static readonly Pen EdgePen = new Pen(Edge);
    static readonly SolidBrush GreenBrush = new SolidBrush(Green);
    static readonly SolidBrush DarkBrush = new SolidBrush(GreenDark);

    static TextureBrush _stripe;
    static TextureBrush Stripe => _stripe ??= BuildStripe();

    static TextureBrush BuildStripe()
    {
        var bmp = new Bitmap(22, 22);
        using (var g = Graphics.FromImage(bmp))
        using (var pen = new Pen(Color.FromArgb(36, Green), 1f))
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

    static void ClearLabels(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            if (c is Label l) l.BackColor = Color.Transparent;
            if (c.HasChildren) ClearLabels(c);
        }
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

            using (var dot = new SolidBrush(Color.FromArgb(44, Green)))
                for (int x = 16; x < w; x += 30)
                    for (int y = 16; y < h; y += 30)
                        g.FillRectangle(dot, x, y, 3, 3);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var circle = new SolidBrush(Color.FromArgb(22, Green)))
                g.FillEllipse(circle, w - 300, -150, 460, 460);

            if (w > 700 && h > 520)
                DrawShield(g, w - 360, h - 420, 300, 360);
        }

        var old = uc.BackgroundImage;
        uc.BackgroundImageLayout = ImageLayout.None;
        uc.BackgroundImage = bmp;
        old?.Dispose();
    }

    static void DrawShield(Graphics g, int x, int y, int sw, int sh)
    {
        var outer = new[]
        {
            new Point(x + sw / 2, y),
            new Point(x + sw, y + (int)(sh * 0.18)),
            new Point(x + sw, y + (int)(sh * 0.5)),
            new Point(x + sw / 2, y + sh),
            new Point(x, y + (int)(sh * 0.5)),
            new Point(x, y + (int)(sh * 0.18))
        };

        int ix = x + (int)(sw * 0.1), iy = y + (int)(sh * 0.1);
        int iw = (int)(sw * 0.8), ih = (int)(sh * 0.8);
        var inner = new[]
        {
            new Point(ix + iw / 2, iy),
            new Point(ix + iw, iy + (int)(ih * 0.18)),
            new Point(ix + iw, iy + (int)(ih * 0.5)),
            new Point(ix + iw / 2, iy + ih),
            new Point(ix, iy + (int)(ih * 0.5)),
            new Point(ix, iy + (int)(ih * 0.18))
        };

        using (var fill = new SolidBrush(Color.FromArgb(26, Green)))
            g.FillPolygon(fill, outer);

        using (var line = new Pen(Color.FromArgb(56, Green), 3f))
            g.DrawPolygon(line, inner);

        using (var check = new Pen(Color.FromArgb(76, Green), 14f))
        {
            check.LineJoin = LineJoin.Miter;
            g.DrawLines(check, new[]
            {
                new Point(x + (int)(sw * 0.3), y + (int)(sh * 0.5)),
                new Point(x + (int)(sw * 0.45), y + (int)(sh * 0.62)),
                new Point(x + (int)(sw * 0.72), y + (int)(sh * 0.36))
            });
        }
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
                    l.BackColor = Color.Transparent;
                    if (gradient) l.ForeColor = Color.White;
                    break;

                case Button b:
                    StyleButton(b);
                    break;

                case TextBox or NumericUpDown or ComboBox:
                    StyleInput(c);
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
            if (tag != "card" && (IsSpacer(p) || IsWrapper(p, root, tag) || !IsCardColor(p.BackColor)))
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

        if (IsNote(p))
        {
            AddNotePaint(p);
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

    static bool IsNote(Panel p) =>
        p.BackColor.A != 0
        && p.Height > 40 && p.Width > 100
        && p.BackColor.ToArgb() != Color.White.ToArgb()
        && p.BackColor.R > 225;

    static void AddCardPaint(Panel p)
    {
        p.Resize += (s, e) => p.Invalidate();
        p.Paint += (s, e) =>
        {
            var g = e.Graphics;
            int w = p.Width, h = p.Height;
            if (w < 4 || h < 4) return;

            if (w > 260 && h > 220)
                DrawPadlock(g, w - 84, h - 70);

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

    static void DrawPadlock(Graphics g, int x, int y)
    {
        using (var body = new SolidBrush(Color.FromArgb(34, Green)))
        using (var hole = new SolidBrush(Color.FromArgb(150, Color.White)))
        using (var shackle = new Pen(Color.FromArgb(34, Green), 8f))
        {
            g.FillRectangle(body, x, y, 52, 40);
            g.FillRectangle(hole, x + 23, y + 12, 6, 14);
            g.DrawLine(shackle, x + 11, y, x + 11, y - 18);
            g.DrawLine(shackle, x + 41, y, x + 41, y - 18);
            g.DrawLine(shackle, x + 7, y - 18, x + 45, y - 18);
        }
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

            var st = g.Save();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var c1 = new SolidBrush(Color.FromArgb(34, Color.White)))
            using (var c2 = new SolidBrush(Color.FromArgb(22, Color.White)))
            {
                g.FillEllipse(c1, r.Width - 110, -60, 160, 160);
                g.FillEllipse(c2, r.Width - 190, r.Height - 40, 120, 120);
            }
            g.Restore(st);

            int size = Math.Min(r.Height - 24, 56);
            if (size > 24 && r.Width > 180)
                DrawAvatar(g, r.Width - size - 16, (r.Height - size) / 2, size);

            g.FillRectangle(DarkBrush, 0, r.Height - 3, r.Width, 3);
        };
    }

    static void DrawAvatar(Graphics g, int x, int y, int size)
    {
        var box = new Rectangle(x, y, size, size);
        var st = g.Save();
        g.SetClip(box);
        g.SmoothingMode = SmoothingMode.AntiAlias;

        using (var bg = new SolidBrush(Color.FromArgb(64, Color.White)))
        using (var fg = new SolidBrush(Color.FromArgb(220, Color.White)))
        {
            g.FillRectangle(bg, box);
            int head = size / 3;
            g.FillEllipse(fg, x + (size - head) / 2, y + size / 6, head, head);
            g.FillEllipse(fg, x + size / 6, y + (int)(size * 0.58), (int)(size * 0.67), size);
        }

        g.Restore(st);
    }

    static void AddNotePaint(Panel p)
    {
        p.Resize += (s, e) => p.Invalidate();
        p.Paint += (s, e) =>
        {
            var g = e.Graphics;
            g.FillRectangle(Stripe, 4, 0, p.Width - 4, p.Height);
            g.FillRectangle(GreenBrush, 0, 0, 4, p.Height);
        };
    }

    static void StyleButton(Button b)
    {
        bool secondary = b.BackColor.ToArgb() == Color.White.ToArgb();

        b.FlatStyle = FlatStyle.Flat;
        b.Cursor = Cursors.Hand;

        if (secondary)
        {
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = Green;
            b.BackColor = Color.White;
            b.ForeColor = GreenDark;
            b.MouseEnter += (s, e) => b.BackColor = FocusMint;
            b.MouseLeave += (s, e) => b.BackColor = Color.White;
        }
        else
        {
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Green;
            b.ForeColor = Color.White;
            b.MouseEnter += (s, e) => b.BackColor = GreenDark;
            b.MouseLeave += (s, e) => b.BackColor = Green;
        }
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

    static void DoubleBuffer(Control c)
    {
        typeof(Control)
            .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
            ?.SetValue(c, true);
    }

    static bool IsCardColor(Color c) =>
    c.A == 255 && ((c.R > 250 && c.G > 250 && c.B > 250) || IsGreen(c));
}
