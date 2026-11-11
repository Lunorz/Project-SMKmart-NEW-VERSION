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
    }
}
