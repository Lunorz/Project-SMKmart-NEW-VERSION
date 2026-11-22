using System.ComponentModel;
using System.Drawing.Drawing2D;
namespace project_akhir_stock_gudang;

public class GradientPanel : Panel
{
    public GradientPanel() { DoubleBuffered = true; ResizeRedraw = true; }

    [Category("Gradient")] public Color ColorTop { get; set; } = Color.FromArgb(38, 119, 74);
    [Category("Gradient")] public Color ColorBottom { get; set; } = Color.FromArgb(26, 90, 56);
    [Category("Gradient")] public float Angle { get; set; } = 90f;

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        if (Width == 0 || Height == 0) return;
        using var b = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, Angle);
        e.Graphics.FillRectangle(b, ClientRectangle);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using var glow = new SolidBrush(Color.FromArgb(30, Color.White));
        e.Graphics.FillEllipse(glow, -58, -58, 158, 158);

        using var accent = new Pen(Color.FromArgb(42, Color.White), 1.5F);
        for (int x = -Height; x < Math.Min(Width, 190); x += 28)
            e.Graphics.DrawLine(accent, x, 0, x + Height, Height);

        using var dots = new SolidBrush(Color.FromArgb(55, Color.White));
        for (int row = 0; row < 4; row++)
            for (int col = 0; col <= row; col++)
                e.Graphics.FillEllipse(dots, 14 + col * 11, 12 + row * 11, 3, 3);
    }
}
