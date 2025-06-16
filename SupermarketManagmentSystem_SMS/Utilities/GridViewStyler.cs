
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public static class GridViewStyler
{
    /// <summary>
    /// Call this once per form (e.g. in the constructor after InitializeComponent),
    /// or centrally from a BaseForm. It will walk the control tree and style every DataGridView.
    /// </summary>
    //public static void ApplyTheme(Control parent)
    //{
    //    foreach (var grid in parent.Controls.OfType<DataGridView>())
    //        Style(grid);

    //    // recurse into container controls
    //    foreach (Control child in parent.Controls)
    //        ApplyTheme(child);


    //}

    public static void Style(DataGridView grid)
    {
        // overall look
        grid.EnableHeadersVisualStyles = false;
        grid.BackgroundColor = Color.White;
        grid.GridColor = Color.LightGray;
        grid.BorderStyle = BorderStyle.None;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.RowHeadersVisible = false;

        // header style
        var hdr = grid.ColumnHeadersDefaultCellStyle;
        hdr.BackColor = Color.FromArgb(30, 144, 255);
        hdr.ForeColor = Color.White;
        hdr.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        hdr.Alignment = DataGridViewContentAlignment.MiddleCenter;
        hdr.Padding = new Padding(0, 6, 0, 6);

        // row style
        var row = grid.RowsDefaultCellStyle;
        row.BackColor = Color.White;
        row.ForeColor = Color.FromArgb(51, 51, 51);
        row.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        row.SelectionBackColor = Color.FromArgb(220, 235, 252);
        row.SelectionForeColor = Color.Black;

        // alternating rows
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

        // cell padding
        grid.DefaultCellStyle.Padding = new Padding(4);

        // auto-size
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        grid.AllowUserToResizeRows = false;
        grid.RowTemplate.Height = 32;
    }
}

