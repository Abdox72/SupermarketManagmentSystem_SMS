using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagmentSystem_SMS
{
    public partial class Reports : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        private DateTime _startDate;
        private DateTime _endDate;
        private bool _isCustomDateRange = false;

        public Reports(ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            InitializeControls();
            GridViewStyler.Style(dgvSales);

        }

        private void InitializeControls()
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            _startDate = dtpStartDate.Value;
            _endDate = dtpEndDate.Value;

            dgvSales.AutoGenerateColumns = false;
            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SaleID",
                DataPropertyName = "رقم_العملية",
                HeaderText = "رقم العملية",
                Width = 100
            });
            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SaleDate",
                DataPropertyName = "التاريخ",
                HeaderText = "التاريخ",
                Width = 150
            });
            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                DataPropertyName = "المبلغ",
                HeaderText = "المبلغ",
                Width = 120
            });
            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cashier",
                DataPropertyName = "الكاشير",
                HeaderText = "الكاشير",
                Width = 200
            });

            LoadSales();
        }

        private void LoadSales()
        {
            try
            {
                var query = _dbContext.Sales
                    .Include(s => s.Cashier)
                    .AsQueryable();

                if (_isCustomDateRange)
                {
                    query = query.Where(s => s.SaleDate.Date >= _startDate.Date && s.SaleDate.Date <= _endDate.Date);
                }
                else
                {
                    query = query.Where(s => s.SaleDate.Date == DateTime.Today);
                }

                var sales = query.ToList();
                var total = sales.Sum(s => s.TotalAmount);

                lblTotal.Text = $"مجموع المبيعات: {total:N2} جنيه";
                lblTotal.ForeColor = Color.White;

                dgvSales.DataSource = sales.Select(s => new
                {
                    رقم_العملية = s.SaleID,
                    التاريخ = s.SaleDate.ToString("dd/MM/yyyy HH:mm"),
                    المبلغ = s.TotalAmount.ToString("N2"),
                    الكاشير = s.Cashier != null ? $"{s.Cashier.FirstName} {s.Cashier.LastName}" : "N/A"
                }).ToList();

                if (_isCustomDateRange)
                {
                    lblDateRange.Text = $"من {_startDate.ToString("dd/MM/yyyy")} إلى {_endDate.ToString("dd/MM/yyyy")}";
                }
                else
                {
                    lblDateRange.Text = $"تقرير اليوم: {DateTime.Today.ToString("dd/MM/yyyy")}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات المبيعات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            _isCustomDateRange = false;
            _startDate = DateTime.Today;
            _endDate = DateTime.Today;
            LoadSales();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            _isCustomDateRange = true;
            DateTime now = DateTime.Now;
            _startDate = new DateTime(now.Year, now.Month, 1);
            _endDate = _startDate.AddMonths(1).AddDays(-1);
            LoadSales();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            _isCustomDateRange = true;
            int year = DateTime.Now.Year;
            _startDate = new DateTime(year, 1, 1);
            _endDate = new DateTime(year, 12, 31);
            LoadSales();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            _isCustomDateRange = true;
            _startDate = dtpStartDate.Value;
            _endDate = dtpEndDate.Value;
            LoadSales();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += (s, ev) =>
                {
                    System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                    System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                    System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 10);
                    System.Drawing.Font totalFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);

                    string title = "تقرير المبيعات";
                    ev.Graphics.DrawString(title, titleFont, Brushes.Black, 350, 50);

                    ev.Graphics.DrawString(lblDateRange.Text, headerFont, Brushes.Black, 300, 80);

                    int y = 120;
                    string[] headers = { "رقم العملية", "التاريخ", "المبلغ", "الكاشير" };
                    int[] columnWidths = { 100, 150, 120, 200 };
                    int x = 50;

                    for (int i = 0; i < headers.Length; i++)
                    {
                        ev.Graphics.DrawString(headers[i], headerFont, Brushes.Black, x, y);
                        x += columnWidths[i];
                    }
                    y = 150;
                    foreach (DataGridViewRow row in dgvSales.Rows)
                    {
                        if (row.IsNewRow) continue;
                        x = 50;
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            ev.Graphics.DrawString(row.Cells[i].Value.ToString(), contentFont, Brushes.Black, x, y);
                            x += columnWidths[i];
                        }
                        y += 25;
                    }
                    y += 20;
                    ev.Graphics.DrawString(lblTotal.Text, totalFont, Brushes.Black, 50, y);
                    y += 40;
                    ev.Graphics.DrawString($"تم الطباعة في: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", contentFont, Brushes.Black, 50, y);
                };

                pd.Document = doc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                    MessageBox.Show("تم طباعة التقرير بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء طباعة التقرير", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "تصدير تقرير المبيعات",
                    FileName = $"تقرير_المبيعات_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.License.SetNonCommercialOrganization("SMS"); //This will also set the Company property to the organization name provided in the argument.
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("تقرير المبيعات");

                        worksheet.Cells[1, 1].Value = "تقرير المبيعات";
                        worksheet.Cells[1, 1, 1, 4].Merge = true;
                        worksheet.Cells[1, 1].Style.Font.Bold = true;
                        worksheet.Cells[1, 1].Style.Font.Size = 14;
                        worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        worksheet.Cells[2, 1].Value = lblDateRange.Text;
                        worksheet.Cells[2, 1, 2, 4].Merge = true;
                        worksheet.Cells[2, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        for (int i = 0; i < dgvSales.Columns.Count; i++)
                        {
                            worksheet.Cells[4, i + 1].Value = dgvSales.Columns[i].HeaderText;
                            worksheet.Cells[4, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[4, i + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        }

                        for (int i = 0; i < dgvSales.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvSales.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 5, j + 1].Value = dgvSales.Rows[i].Cells[j].Value?.ToString();
                                worksheet.Cells[i + 5, j + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                            }
                        }

                        int lastRow = dgvSales.Rows.Count + 6;
                        worksheet.Cells[lastRow, 1].Value = lblTotal.Text;
                        worksheet.Cells[lastRow, 1, lastRow, 4].Merge = true;
                        worksheet.Cells[lastRow, 1].Style.Font.Bold = true;
                        worksheet.Cells[lastRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        worksheet.Cells[lastRow + 1, 1].Value = $"تم التصدير في: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}";
                        worksheet.Cells[lastRow + 1, 1, lastRow + 1, 4].Merge = true;
                        worksheet.Cells[lastRow + 1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        package.SaveAs(new FileInfo(sfd.FileName));
                    }

                    MessageBox.Show("تم تصدير التقرير بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تصدير التقرير", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        public new void BringToFront()
        {
            base.BringToFront();
            this.LoadSales();
        }
    }
}
