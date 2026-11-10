using Restaurant_management.User_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management.Usercontrol
{
    public partial class UC_Dashboard : UserControl
    {
        private readonly CultureInfo vi =
            CultureInfo.GetCultureInfo("vi-VN");

        private readonly Dictionary<string, Label> kpiLabels =
            new Dictionary<string, Label>();

        private readonly List<DailyRevenue> chartData =
            new List<DailyRevenue>();

        private readonly Color primary =
            Color.FromArgb(37, 99, 235);

        private readonly Color dark =
            Color.FromArgb(16, 42, 67);

        private readonly Color muted =
            Color.FromArgb(100, 116, 139);

        private Panel chartArea = null!;
        private TableLayoutPanel topDishesRows = null!;
        private Label lblStatus = null!;

        public UC_Dashboard()
        {
            InitializeComponent();

            // Giao diện tự chia kích thước theo vùng chứa.
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(241, 245, 249);
            AutoScaleMode = AutoScaleMode.Font;

            BuildDashboard();

            Load += UC_Dashboard_Load;
        }


        private void BuildDashboard()
        {
            Controls.Clear();

            TableLayoutPanel root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(241, 245, 249),
                Padding = new Padding(18),
                Margin = new Padding(0),
                ColumnCount = 1,
                RowCount = 3
            };

            root.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            // Header: đủ chỗ cho 3 dòng
            root.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 145F));

            // KPI: hai hàng thẻ
            root.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 290F));

            // Biểu đồ và top món
            root.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            Controls.Add(root);

            BuildHeader(root);
            BuildKpiCards(root);
            BuildBottomSections(root);
        }



        private void BuildHeader(TableLayoutPanel root)
        {
            TableLayoutPanel header = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Margin = new Padding(0, 0, 0, 10)
            };

            header.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            header.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 155F));

            TableLayoutPanel texts = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                Margin = new Padding(0)
            };

            texts.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            // Chiều cao rõ ràng cho từng dòng
            texts.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 66F));

            texts.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 32F));

            texts.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            Label title = new Label
            {
                Text = "TỔNG QUAN NHÀ HÀNG",
                Dock = DockStyle.Fill,
                AutoSize = false,
                Font = new Font(
                    "Segoe UI", 18F, FontStyle.Bold),
                ForeColor = dark,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
                AutoEllipsis = false
            };

            Label subtitle = new Label
            {
                Text = "Theo dõi hoạt động và doanh thu",
                Dock = DockStyle.Fill,
                AutoSize = false,
                Font = new Font("Segoe UI", 10F),
                ForeColor = muted,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0)
            };

            lblStatus = new Label
            {
                Text = "Đang chuẩn bị dữ liệu...",
                Dock = DockStyle.Fill,
                AutoSize = false,
                Font = new Font("Segoe UI", 9F),
                ForeColor = muted,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0)
            };

            texts.Controls.Add(title, 0, 0);
            texts.Controls.Add(subtitle, 0, 1);
            texts.Controls.Add(lblStatus, 0, 2);

            Button btnRefresh = new Button
            {
                Text = "Làm mới",
                Dock = DockStyle.Top,
                Height = 46,
                Margin = new Padding(0, 14, 0, 0),
                BackColor = primary,
                ForeColor = Color.White,
                Font = new Font(
                    "Segoe UI", 10F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };

            btnRefresh.FlatAppearance.BorderSize = 0;

            // Giữ nguyên hành động làm mới
            btnRefresh.Click += (s, e) =>
                RefreshDashboard();

            header.Controls.Add(texts, 0, 0);
            header.Controls.Add(btnRefresh, 1, 0);

            root.Controls.Add(header, 0, 0);
        }


        private void BuildKpiCards(TableLayoutPanel root)
        {
            // 6 cột chia đều để bố trí 3 + 2 thẻ
            TableLayoutPanel cards = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 6,
                RowCount = 2,
                Margin = new Padding(0, 0, 0, 14),
                Padding = new Padding(0),
                BackColor = Color.Transparent
            };

            for (int i = 0; i < 6; i++)
            {
                cards.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100F / 6F));
            }

            cards.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50F));

            cards.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50F));

            Control today = CreateKpi(
                "today",
                "DOANH THU HÔM NAY",
                Color.FromArgb(37, 99, 235));

            Control month = CreateKpi(
                "month",
                "DOANH THU THÁNG",
                Color.FromArgb(8, 145, 178));

            Control sold = CreateKpi(
                "sold",
                "MÓN BÁN HÔM NAY",
                Color.FromArgb(15, 118, 110));

            Control tables = CreateKpi(
                "tables",
                "BÀN ĐANG PHỤC VỤ",
                Color.FromArgb(124, 58, 237));

            Control dishes = CreateKpi(
                "dishes",
                "MÓN TRONG THỰC ĐƠN",
                Color.FromArgb(217, 119, 6));

            // Hàng đầu: 3 thẻ, mỗi thẻ chiếm 2 cột
            cards.Controls.Add(today, 0, 0);
            cards.SetColumnSpan(today, 2);

            cards.Controls.Add(month, 2, 0);
            cards.SetColumnSpan(month, 2);

            cards.Controls.Add(sold, 4, 0);
            cards.SetColumnSpan(sold, 2);

            // Hàng dưới: 2 thẻ, mỗi thẻ chiếm 3 cột
            cards.Controls.Add(tables, 0, 1);
            cards.SetColumnSpan(tables, 3);

            cards.Controls.Add(dishes, 3, 1);
            cards.SetColumnSpan(dishes, 3);

            root.Controls.Add(cards, 0, 1);
        }


        private Control CreateKpi(
            string key,
            string caption,
            Color accent)
        {
            TableLayoutPanel card = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(5),
                Padding = new Padding(14, 8, 14, 10),
                ColumnCount = 1,
                RowCount = 3
            };

            card.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            card.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 5F));

            card.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 43F));

            card.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            Panel line = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = accent,
                Margin = new Padding(0)
            };

            Label lblCaption = new Label
            {
                Text = caption,
                Dock = DockStyle.Fill,
                AutoSize = false,
                Font = new Font(
                    "Segoe UI", 9F, FontStyle.Bold),
                ForeColor = muted,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0, 5, 0, 0)
            };


            Label lblValue = new Label
            {
                Text = "—",
                Dock = DockStyle.Fill,
                AutoSize = false,

                // Giảm font mặc định để số dài dễ hiển thị
                Font = new Font(
                    "Segoe UI", 13F, FontStyle.Bold),

                ForeColor = accent,
                TextAlign = ContentAlignment.MiddleLeft,

                Margin = new Padding(0),
                Padding = new Padding(0),

                // Không tự động thêm dấu ...
                AutoEllipsis = false,

                // Chỉ hiển thị trên một dòng
                UseMnemonic = false
            };

            // Tự động điều chỉnh font khi dữ liệu thay đổi
            lblValue.TextChanged += (s, e) =>
            {
                FitKpiFont(lblValue);
            };

            lblValue.SizeChanged += (s, e) =>
            {
                FitKpiFont(lblValue);
            };


            lblValue.TextChanged += (s, e) =>
                FitKpiFont(lblValue);

            lblValue.SizeChanged += (s, e) =>
                FitKpiFont(lblValue);

            card.Controls.Add(line, 0, 0);
            card.Controls.Add(lblCaption, 0, 1);
            card.Controls.Add(lblValue, 0, 2);

            kpiLabels[key] = lblValue;

            return card;
        }



        
private void FitKpiFont(Label label)
{
    if (label.ClientSize.Width <= 0 ||
        label.ClientSize.Height <= 0)
        return;

    // Chừa khoảng trống tránh cắt ký tự cuối
    int maxWidth = Math.Max(
        1, label.ClientSize.Width - 16);

    int maxHeight = Math.Max(
        1, label.ClientSize.Height - 6);

    float fontSize = 13F;

    while (fontSize >= 6F)
    {
        using Font testFont = new Font(
            "Segoe UI",
            fontSize,
            FontStyle.Bold);

        Size textSize = TextRenderer.MeasureText(
            label.Text,
            testFont,
            new Size(int.MaxValue, int.MaxValue),
            TextFormatFlags.SingleLine |
            TextFormatFlags.NoPadding);

        if (textSize.Width <= maxWidth &&
            textSize.Height <= maxHeight)
        {
            if (Math.Abs(label.Font.Size - fontSize) > 0.01F)
            {
                Font oldFont = label.Font;

                label.Font = new Font(
                    "Segoe UI",
                    fontSize,
                    FontStyle.Bold);

                oldFont.Dispose();
            }

            return;
        }

        fontSize -= 0.5F;
    }

    // Phương án dự phòng cho số tiền rất dài
    if (Math.Abs(label.Font.Size - 6F) > 0.01F)
    {
        Font oldFont = label.Font;

        label.Font = new Font(
            "Segoe UI",
            6F,
            FontStyle.Bold);

        oldFont.Dispose();
    }
}



        private void BuildBottomSections(
            TableLayoutPanel root)
        {
            TableLayoutPanel bottom =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 2,
                    RowCount = 1,
                    Margin = new Padding(0)
                };

            bottom.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 62));

            bottom.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 38));

            // Biểu đồ
            TableLayoutPanel chartCard = CreateSection(
                "DOANH THU 7 NGÀY GẦN NHẤT");

            chartCard.Margin =
                new Padding(5, 0, 10, 5);

            chartArea = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(12, 5, 12, 12)
            };

            chartArea.Paint += ChartArea_Paint;
            chartCard.Controls.Add(chartArea, 0, 1);

            // Top món
            TableLayoutPanel dishesCard = CreateSection(
                "TOP 5 MÓN BÁN CHẠY");

            dishesCard.Margin =
                new Padding(10, 0, 5, 5);

            topDishesRows = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                BackColor = Color.White,
                Padding = new Padding(12, 6, 12, 12),
                Margin = new Padding(0)
            };

            for (int i = 0; i < 5; i++)
            {
                topDishesRows.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 20));
            }

            topDishesRows.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100));

            dishesCard.Controls.Add(topDishesRows, 0, 1);

            bottom.Controls.Add(chartCard, 0, 0);
            bottom.Controls.Add(dishesCard, 1, 0);

            root.Controls.Add(bottom, 0, 2);
        }

        private TableLayoutPanel CreateSection(string title)
        {
            TableLayoutPanel section =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.White,
                    ColumnCount = 1,
                    RowCount = 2,
                    Padding = new Padding(10)
                };

            section.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 55));

            section.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100));

            Label header = new Label
            {
                Text = title,
                Dock = DockStyle.Fill,
                Font = new Font(
                    "Segoe UI", 12F, FontStyle.Bold),
                ForeColor = dark,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            section.Controls.Add(header, 0, 0);
            return section;
        }

        private void UC_Dashboard_Load(
            object? sender, EventArgs e)
        {
            if (DesignMode) return;
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                lblStatus.Text = "Đang tải dữ liệu...";

                DashboardDataService service =
                    new DashboardDataService();

                DashboardData data =
                    service.GetDashboardData();

                kpiLabels["today"].Text =
                    Money(data.TodayRevenue);

                kpiLabels["month"].Text =
                    Money(data.MonthRevenue);

                kpiLabels["sold"].Text =
                    data.TodayItemsSold.ToString("N0", vi);

                kpiLabels["tables"].Text =
                    $"{data.OccupiedTables}/{data.TotalTables}";

                kpiLabels["dishes"].Text =
                    data.TotalDishes.ToString("N0", vi);

                chartData.Clear();
                chartData.AddRange(data.WeeklyRevenue);
                chartArea.Invalidate();

                RenderTopDishes(data.BestSellingDishes);

                lblStatus.Text =
                    "Cập nhật lúc " +
                    DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Không thể tải dữ liệu";

                MessageBox.Show(
                    "Không thể tải Dashboard:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string Money(decimal amount)
        {
            return amount.ToString("N0", vi) + "đ";
        }

        private void RenderTopDishes(
            List<BestSellingDish> dishes)
        {
            topDishesRows.Controls.Clear();

            for (int i = 0; i < 5; i++)
            {
                if (i >= dishes.Count)
                    break;

                BestSellingDish dish = dishes[i];

                TableLayoutPanel row = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 2,
                    RowCount = 1,
                    Margin = new Padding(0, 3, 0, 3),
                    BackColor = i % 2 == 0
                        ? Color.FromArgb(248, 250, 252)
                        : Color.White
                };

                row.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100));

                row.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Absolute, 165));

                Label name = new Label
                {
                    Text = $"{i + 1}. {dish.Name}",
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 9.5F),
                    ForeColor = dark,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoEllipsis = false,
                    Padding = new Padding(8, 0, 0, 0)
                };


                Label quantity = new Label
                {
                    Text = dish.Quantity.ToString("N0", vi),
                    Dock = DockStyle.Fill,
                    Font = new Font(
                        "Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = primary,
                    TextAlign = ContentAlignment.MiddleRight,
                    Padding = new Padding(0, 0, 8, 0),
                    Margin = new Padding(0),
                    AutoEllipsis = false,
                    AutoSize = false
                };


                row.Controls.Add(name, 0, 0);
                row.Controls.Add(quantity, 1, 0);

                topDishesRows.Controls.Add(row, 0, i);
            }

            if (dishes.Count == 0)
            {
                Label empty = new Label
                {
                    Text = "Chưa có dữ liệu món bán chạy",
                    Dock = DockStyle.Fill,
                    ForeColor = muted,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                topDishesRows.Controls.Add(empty, 0, 0);
            }
        }

        private void ChartArea_Paint(
            object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (chartData.Count == 0)
                return;

            int left = 65;
            int right = chartArea.ClientSize.Width - 18;
            int top = 30;
            int bottom = chartArea.ClientSize.Height - 45;

            if (right <= left || bottom <= top)
                return;

            decimal max = 0;

            foreach (DailyRevenue item in chartData)
            {
                if (item.Amount > max)
                    max = item.Amount;
            }

            if (max <= 0)
            {
                using Font emptyFont =
                    new Font("Segoe UI", 11F);

                using SolidBrush emptyBrush =
                    new SolidBrush(muted);

                string message =
                    "Chưa có doanh thu trong 7 ngày gần nhất";

                SizeF size =
                    g.MeasureString(message, emptyFont);

                g.DrawString(
                    message,
                    emptyFont,
                    emptyBrush,
                    (chartArea.Width - size.Width) / 2,
                    chartArea.Height / 2 - 15);
            }

            decimal scaleMax = max <= 0 ? 1 : max;
            int plotHeight = bottom - top;

            using Font font = new Font("Segoe UI", 8.5F);
            using Pen grid = new Pen(
                Color.FromArgb(226, 232, 240));
            using SolidBrush brush = new SolidBrush(primary);
            using SolidBrush textBrush = new SolidBrush(muted);

            // Trục ngang và mức doanh thu
            for (int i = 0; i <= 4; i++)
            {
                int y = bottom - i * plotHeight / 4;

                g.DrawLine(grid, left, y, right, y);

                decimal amount = max * i / 4m;

                string label = amount >= 1000000m
                    ? (amount / 1000000m).ToString("0.#", vi)
                        + "tr"
                    : (amount / 1000m).ToString("0", vi)
                        + "k";

                g.DrawString(
                    label, font, textBrush, 3, y - 9);
            }

            int slot = (right - left) / 7;
            int barWidth = Math.Max(
                8, Math.Min(46, slot - 14));

            for (int i = 0; i < chartData.Count; i++)
            {
                DailyRevenue item = chartData[i];

                int height = (int)(
                    item.Amount / scaleMax * plotHeight);

                int x = left + i * slot
                    + (slot - barWidth) / 2;

                if (height > 0)
                {
                    g.FillRectangle(
                        brush, x, bottom - height,
                        barWidth, height);
                }

                string day = item.Date.ToString("dd/MM");

                SizeF labelSize = g.MeasureString(day, font);

                g.DrawString(
                    day, font, textBrush,
                    x + (barWidth - labelSize.Width) / 2,
                    bottom + 13);
            }
        }
    }
}
