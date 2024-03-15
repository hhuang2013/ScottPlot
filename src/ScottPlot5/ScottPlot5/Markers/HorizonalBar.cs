﻿namespace ScottPlot.Markers;

internal class HorizontalBar : IMarker
{
    public bool Fill { get; set; } = false;
    public bool Outline { get; set; } = true;

    public void Render(SKCanvas canvas, SKPaint paint, Pixel center, float size, FillStyle fill, LineStyle outline)
    {
        if (!Outline)
            return;

        float offset = size / 2;

        var path = new SKPath();
        path.MoveTo(center.X + offset, center.Y);
        path.LineTo(center.X - offset, center.Y);

        outline.ApplyToPaint(paint);
        canvas.DrawPath(path, paint);
    }
}
