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

        bool isTopLeftTableCard = Parent is TableLayoutPanel table
            && table.GetPositionFromControl(this).Column == 0
            && table.GetPositionFromControl(this).Row == 0;

        if (!isTopLeftTableCard)
        {
            using var normalGradient = new LinearGradientBrush(
                ClientRectangle,
                ColorTop,
                ColorBottom,
                Angle);
            e.Graphics.FillRectangle(normalGradient, ClientRectangle);
            return;
        }

        using var b = new LinearGradientBrush(
            ClientRectangle,
            Color.FromArgb(26, 108, 68),
            Color.FromArgb(82, 180, 126),
            20f);
        e.Graphics.FillRectangle(b, ClientRectangle);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using var topLeftGlow = new SolidBrush(Color.FromArgb(26, Color.White));
        e.Graphics.FillEllipse(topLeftGlow, -62, -62, 170, 170);

        using var cardGlow = new SolidBrush(Color.FromArgb(34, Color.White));
        e.Graphics.FillEllipse(cardGlow, Width - 110, -60, 170, 170);
        e.Graphics.FillEllipse(cardGlow, Width - 190, Height - 50, 130, 130);

        using var accent = new Pen(Color.FromArgb(42, Color.White), 1.5F);
        for (int x = -Height; x < Math.Min(Width, 190); x += 28)
            e.Graphics.DrawLine(accent, x, 0, x + Height, Height);

        using var dots = new SolidBrush(Color.FromArgb(55, Color.White));
        for (int row = 0; row < 4; row++)
            for (int col = 0; col <= row; col++)
                e.Graphics.FillEllipse(dots, 14 + col * 11, 12 + row * 11, 3, 3);

        using var bottomAccent = new SolidBrush(Color.FromArgb(26, 90, 56));
        e.Graphics.FillRectangle(bottomAccent, 0, Height - 4, Width, 4);
    }
}
