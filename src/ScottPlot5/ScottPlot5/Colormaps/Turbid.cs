//This is a cmocean colormap
//All credit to Kristen Thyng
//This colormap is under the MIT License
//All cmocean colormaps are available at https://github.com/matplotlib/cmocean/tree/master/cmocean/rgb


namespace ScottPlot.Colormaps;

public class Turbid : IColormap
{
    public string Name => "Turbid";
    readonly CustomPalette Colormap;
    public Color GetColor(double position) => Colormap.GetColor(position);

    public Turbid()
    {
        Color[] colors =
        [
            new( 233, 246, 171 ),
            new( 232, 245, 170 ),
            new( 232, 243, 168 ),
            new( 231, 242, 167 ),
            new( 230, 241, 165 ),
            new( 230, 240, 164 ),
            new( 229, 239, 162 ),
            new( 229, 238, 161 ),
            new( 228, 236, 159 ),
            new( 228, 235, 158 ),
            new( 227, 234, 156 ),
            new( 227, 233, 155 ),
            new( 226, 232, 154 ),
            new( 226, 231, 152 ),
            new( 225, 229, 151 ),
            new( 224, 228, 149 ),
            new( 224, 227, 148 ),
            new( 223, 226, 146 ),
            new( 223, 225, 145 ),
            new( 222, 224, 143 ),
            new( 222, 223, 142 ),
            new( 221, 221, 141 ),
            new( 221, 220, 139 ),
            new( 220, 219, 138 ),
            new( 220, 218, 136 ),
            new( 219, 217, 135 ),
            new( 219, 216, 134 ),
            new( 218, 215, 132 ),
            new( 218, 213, 131 ),
            new( 217, 212, 130 ),
            new( 217, 211, 128 ),
            new( 217, 210, 127 ),
            new( 216, 209, 126 ),
            new( 216, 208, 124 ),
            new( 215, 207, 123 ),
            new( 215, 206, 122 ),
            new( 214, 204, 120 ),
            new( 214, 203, 119 ),
            new( 213, 202, 118 ),
            new( 213, 201, 116 ),
            new( 212, 200, 115 ),
            new( 212, 199, 114 ),
            new( 211, 198, 113 ),
            new( 211, 197, 111 ),
            new( 211, 195, 110 ),
            new( 210, 194, 109 ),
            new( 210, 193, 108 ),
            new( 209, 192, 107 ),
            new( 209, 191, 105 ),
            new( 208, 190, 104 ),
            new( 208, 189, 103 ),
            new( 207, 188, 102 ),
            new( 207, 187, 101 ),
            new( 207, 186, 100 ),
            new( 206, 184, 98 ),
            new( 206, 183, 97 ),
            new( 205, 182, 96 ),
            new( 205, 181, 95 ),
            new( 204, 180, 94 ),
            new( 204, 179, 93 ),
            new( 203, 178, 92 ),
            new( 203, 177, 91 ),
            new( 202, 176, 90 ),
            new( 202, 175, 89 ),
            new( 202, 174, 88 ),
            new( 201, 172, 87 ),
            new( 201, 171, 86 ),
            new( 200, 170, 85 ),
            new( 200, 169, 84 ),
            new( 199, 168, 83 ),
            new( 199, 167, 82 ),
            new( 198, 166, 81 ),
            new( 198, 165, 81 ),
            new( 197, 164, 80 ),
            new( 197, 163, 79 ),
            new( 196, 162, 78 ),
            new( 196, 161, 77 ),
            new( 195, 160, 77 ),
            new( 195, 159, 76 ),
            new( 194, 158, 75 ),
            new( 194, 156, 74 ),
            new( 193, 155, 74 ),
            new( 193, 154, 73 ),
            new( 192, 153, 72 ),
            new( 192, 152, 72 ),
            new( 191, 151, 71 ),
            new( 191, 150, 71 ),
            new( 190, 149, 70 ),
            new( 189, 148, 69 ),
            new( 189, 147, 69 ),
            new( 188, 146, 68 ),
            new( 188, 145, 68 ),
            new( 187, 144, 67 ),
            new( 187, 143, 67 ),
            new( 186, 142, 66 ),
            new( 185, 141, 66 ),
            new( 185, 140, 66 ),
            new( 184, 139, 65 ),
            new( 183, 138, 65 ),
            new( 183, 137, 64 ),
            new( 182, 137, 64 ),
            new( 182, 136, 64 ),
            new( 181, 135, 64 ),
            new( 180, 134, 63 ),
            new( 179, 133, 63 ),
            new( 179, 132, 63 ),
            new( 178, 131, 62 ),
            new( 177, 130, 62 ),
            new( 177, 129, 62 ),
            new( 176, 128, 62 ),
            new( 175, 127, 61 ),
            new( 175, 126, 61 ),
            new( 174, 125, 61 ),
            new( 173, 125, 61 ),
            new( 172, 124, 61 ),
            new( 172, 123, 61 ),
            new( 171, 122, 60 ),
            new( 170, 121, 60 ),
            new( 169, 120, 60 ),
            new( 168, 119, 60 ),
            new( 168, 119, 60 ),
            new( 167, 118, 60 ),
            new( 166, 117, 60 ),
            new( 165, 116, 60 ),
            new( 164, 115, 59 ),
            new( 164, 114, 59 ),
            new( 163, 114, 59 ),
            new( 162, 113, 59 ),
            new( 161, 112, 59 ),
            new( 160, 111, 59 ),
            new( 159, 110, 59 ),
            new( 158, 110, 59 ),
            new( 158, 109, 59 ),
            new( 157, 108, 59 ),
            new( 156, 107, 59 ),
            new( 155, 107, 59 ),
            new( 154, 106, 59 ),
            new( 153, 105, 59 ),
            new( 152, 104, 59 ),
            new( 151, 104, 58 ),
            new( 150, 103, 58 ),
            new( 150, 102, 58 ),
            new( 149, 101, 58 ),
            new( 148, 101, 58 ),
            new( 147, 100, 58 ),
            new( 146, 99, 58 ),
            new( 145, 98, 58 ),
            new( 144, 98, 58 ),
            new( 143, 97, 58 ),
            new( 142, 96, 58 ),
            new( 141, 96, 58 ),
            new( 140, 95, 58 ),
            new( 139, 94, 58 ),
            new( 138, 94, 58 ),
            new( 137, 93, 58 ),
            new( 136, 92, 58 ),
            new( 135, 92, 57 ),
            new( 134, 91, 57 ),
            new( 133, 90, 57 ),
            new( 132, 90, 57 ),
            new( 131, 89, 57 ),
            new( 130, 88, 57 ),
            new( 129, 88, 57 ),
            new( 128, 87, 57 ),
            new( 127, 86, 57 ),
            new( 126, 86, 57 ),
            new( 125, 85, 56 ),
            new( 124, 84, 56 ),
            new( 123, 84, 56 ),
            new( 122, 83, 56 ),
            new( 121, 83, 56 ),
            new( 120, 82, 56 ),
            new( 119, 81, 56 ),
            new( 118, 81, 56 ),
            new( 117, 80, 55 ),
            new( 116, 79, 55 ),
            new( 115, 79, 55 ),
            new( 114, 78, 55 ),
            new( 113, 78, 55 ),
            new( 112, 77, 55 ),
            new( 111, 76, 54 ),
            new( 110, 76, 54 ),
            new( 109, 75, 54 ),
            new( 108, 75, 54 ),
            new( 107, 74, 53 ),
            new( 106, 73, 53 ),
            new( 105, 73, 53 ),
            new( 103, 72, 53 ),
            new( 102, 72, 53 ),
            new( 101, 71, 52 ),
            new( 100, 70, 52 ),
            new( 99, 70, 52 ),
            new( 98, 69, 52 ),
            new( 97, 69, 51 ),
            new( 96, 68, 51 ),
            new( 95, 67, 51 ),
            new( 94, 67, 51 ),
            new( 93, 66, 50 ),
            new( 92, 66, 50 ),
            new( 91, 65, 50 ),
            new( 90, 65, 49 ),
            new( 89, 64, 49 ),
            new( 88, 63, 49 ),
            new( 87, 63, 48 ),
            new( 86, 62, 48 ),
            new( 85, 62, 48 ),
            new( 84, 61, 48 ),
            new( 83, 60, 47 ),
            new( 82, 60, 47 ),
            new( 81, 59, 47 ),
            new( 80, 59, 46 ),
            new( 79, 58, 46 ),
            new( 78, 57, 46 ),
            new( 77, 57, 45 ),
            new( 75, 56, 45 ),
            new( 74, 56, 44 ),
            new( 73, 55, 44 ),
            new( 72, 54, 44 ),
            new( 71, 54, 43 ),
            new( 70, 53, 43 ),
            new( 69, 53, 43 ),
            new( 68, 52, 42 ),
            new( 67, 51, 42 ),
            new( 66, 51, 41 ),
            new( 65, 50, 41 ),
            new( 64, 50, 41 ),
            new( 63, 49, 40 ),
            new( 62, 48, 40 ),
            new( 61, 48, 39 ),
            new( 60, 47, 39 ),
            new( 59, 47, 39 ),
            new( 58, 46, 38 ),
            new( 57, 45, 38 ),
            new( 56, 45, 37 ),
            new( 55, 44, 37 ),
            new( 54, 43, 36 ),
            new( 53, 43, 36 ),
            new( 52, 42, 36 ),
            new( 51, 42, 35 ),
            new( 50, 41, 35 ),
            new( 49, 40, 34 ),
            new( 48, 40, 34 ),
            new( 47, 39, 33 ),
            new( 46, 38, 33 ),
            new( 45, 38, 32 ),
            new( 44, 37, 32 ),
            new( 43, 36, 31 ),
            new( 42, 36, 31 ),
            new( 41, 35, 31 ),
            new( 40, 35, 30 ),
            new( 39, 34, 30 ),
            new( 38, 33, 29 ),
            new( 37, 33, 29 ),
            new( 36, 32, 28 ),
            new( 35, 31, 28 ),
            new( 34, 31, 27 ),
        ];
        Colormap = new CustomPalette(colors);
    }
}

