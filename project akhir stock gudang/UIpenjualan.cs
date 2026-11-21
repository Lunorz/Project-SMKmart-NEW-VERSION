using System.Drawing.Drawing2D;
using System.Reflection;

namespace project_akhir_stock_gudang;

public sealed class UIpenjualan : IDisposable
{
    private readonly Control _target;
    private Pen? _hatchPen;
    private SolidBrush? _dotBrush;
    private SolidBrush? _circleBrush;

    public Color GradientTop { get; set; } = Color.FromArgb(234, 247, 238);
    public Color GradientBottom { get; set; } = Color.FromArgb(214, 236, 223);
    public Color HatchColor { get; set; } = Color.FromArgb(40, 46, 125, 80);
    public Color DotColor { get; set; } = Color.FromArgb(70, 46, 125, 80);
    public Color CircleColor { get; set; } = Color.FromArgb(70, 120, 190, 150);

    public int HatchSpacing { get; set; } = 14;
    public int DotSpacing { get; set; } = 24;
    public bool ShowHatch { get; set; } = true;
    public bool ShowDots { get; set; } = true;
    public bool ShowCircles { get; set; } = true;

    private UIpenjualan(Control target)
    {
        _target = target;
        EnableDoubleBuffer(_target);
        _target.Paint += OnPaint;
        _target.Resize += OnResize;
    }

    public static UIpenjualan Attach(Control target) => new(target);

    public static void MakeTransparent(params Control[] controls)
    {
        foreach (var c in controls)
            c.BackColor = Color.Transparent;
    }

    private void OnResize(object? sender, EventArgs e) => _target.Invalidate();

    private void OnPaint(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        var rect = _target.ClientRectangle;
        if (rect.Width <= 0 || rect.Height <= 0) return;

        using (var bg = new LinearGradientBrush(rect, GradientTop, GradientBottom, 90f))
            g.FillRectangle(bg, rect);

        var oldSmoothing = g.SmoothingMode;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        if (ShowHatch)
        {
            _hatchPen ??= new Pen(HatchColor, 1f);
            _hatchPen.Color = HatchColor;

            int h = rect.Height;
            for (int x = -h; x < rect.Width; x += Math.Max(4, HatchSpacing))
                g.DrawLine(_hatchPen, x, h, x + h, 0);
        }

        if (ShowDots)
        {
            _dotBrush ??= new SolidBrush(DotColor);
            _dotBrush.Color = DotColor;

            int step = Math.Max(8, DotSpacing);
            for (int y = step / 2; y < rect.Height; y += step)
                for (int x = step / 2; x < rect.Width; x += step)
                    g.FillEllipse(_dotBrush, x, y, 2, 2);
        }

        if (ShowCircles)
        {
            _circleBrush ??= new SolidBrush(CircleColor);
            _circleBrush.Color = CircleColor;

            int big = (int)(Math.Min(rect.Width, rect.Height) * 0.45f);
            g.FillEllipse(_circleBrush,
                rect.Right - (int)(big * 0.75f), rect.Bottom - (int)(big * 0.65f), big, big);

            int small = (int)(big * 0.45f);
            g.FillEllipse(_circleBrush,
                rect.Left - (int)(small * 0.45f), rect.Bottom - (int)(small * 0.6f), small, small);
        }

        g.SmoothingMode = oldSmoothing;
    }

    private static void EnableDoubleBuffer(Control c)
    {
        typeof(Control).GetProperty("DoubleBuffered",
            BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(c, true);
        typeof(Control).GetMethod("SetStyle",
            BindingFlags.Instance | BindingFlags.NonPublic)?
            .Invoke(c, new object[] { ControlStyles.ResizeRedraw, true });
    }

    public void Dispose()
    {
        _target.Paint -= OnPaint;
        _target.Resize -= OnResize;
        _hatchPen?.Dispose();
        _dotBrush?.Dispose();
        _circleBrush?.Dispose();
    }
}