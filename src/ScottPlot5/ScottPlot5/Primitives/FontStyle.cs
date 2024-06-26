﻿using System.Runtime.InteropServices.ComTypes;

namespace ScottPlot;

/// <summary>
/// This configuration object (reference type) permanently lives inside objects which require styling.
/// It is recommended to use this object as an init-only property.
/// </summary>
public class FontStyle
{
    /* Typefaces are cached to improve performance.
     * https://github.com/ScottPlot/ScottPlot/issues/2833
     * https://github.com/ScottPlot/ScottPlot/pull/2848
     */

    private SKTypeface? CachedTypeface = null;

    // TODO: use a class for cached typeface management
    public SKTypeface Typeface => CachedTypeface ??= CreateTypefaceFromName(Name, Bold, Italic);

    private string _name = Fonts.Default;
    public string Name
    {
        get => _name;
        set
        {
            bool fieldChanged = string.Compare(_name, value, StringComparison.InvariantCultureIgnoreCase) != 0;

            if (fieldChanged)
                ClearCachedTypeface();

            _name = value;
        }
    }

    private bool _bold = false;
    public bool Bold
    {
        get => _bold;
        set
        {
            bool fieldChanged = _bold != value;

            if (fieldChanged)
                ClearCachedTypeface();

            _bold = value;
        }
    }

    private bool _italic = false;
    public bool Italic
    {
        get => _italic;
        set
        {
            bool fieldChanged = (_italic != value);

            if (fieldChanged)
                ClearCachedTypeface();

            _italic = value;
        }
    }

    // TODO: consider whether color really belongs here...
    public Color Color { get; set; } = Colors.Black;
    public float Size { get; set; } = 12;
    public bool AntiAlias { get; set; } = true;

    public override string ToString()
    {
        return $"{Name}, Size {Size}, {Color}";
    }

    private void ClearCachedTypeface()
    {
        CachedTypeface = null;
    }

    public static SKTypeface CreateTypefaceFromName(string font, bool bold, bool italic)
    {
        SKFontStyleWeight weight = bold ? SKFontStyleWeight.Bold : SKFontStyleWeight.Normal;
        SKFontStyleSlant slant = italic ? SKFontStyleSlant.Italic : SKFontStyleSlant.Upright;
        SKFontStyleWidth width = SKFontStyleWidth.Normal;
        SKFontStyle style = new(weight, width, slant);
        return SKTypeface.FromFamilyName(font, style);
    }

    public static SKTypeface CreateTypefaceFromFile(string path)
    {
        path = Path.GetFullPath(path);
        if (!File.Exists(path))
            throw new FileNotFoundException(path);
        return SKTypeface.FromFile(path);
    }

    /// <summary>
    /// Use the characters in <paramref name="text"/> to determine an installed 
    /// system font most likely to support this character set.
    /// </summary>
    public void SetBestFont(string text)
    {
        Name = Fonts.Detect(text);
    }

    public FontStyle Clone()
    {
        return new FontStyle()
        {
            Name = Name,
            Bold = Bold,
            Italic = Italic,
            Color = Color,
            Size = Size,
            AntiAlias = AntiAlias,
        };
    }

    public void ApplyToPaint(SKPaint paint)
    {
        paint.Shader = null;
        paint.IsStroke = false;
        paint.Typeface = Typeface;
        paint.TextSize = Size;
        paint.Color = Color.ToSKColor();
        paint.IsAntialias = AntiAlias;
        paint.FakeBoldText = Bold;
    }

}
