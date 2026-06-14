using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApplicantSystem.Helpers
{
    // Helpers/UITheme.cs
    using System.Drawing;
    using System.Windows.Forms;

    namespace HRApplicantSystem.Helpers
    {
        public static class UITheme
        {
            // Colors
            public static Color SeaGreen = ColorTranslator.FromHtml("#499167");
            public static Color DarkKhaki = ColorTranslator.FromHtml("#322E18");
            public static Color BrightLemon = ColorTranslator.FromHtml("#F7E733");
            public static Color BrightSnow = ColorTranslator.FromHtml("#F7F7F9");
            public static Color DarkWine = ColorTranslator.FromHtml("#721817");
            public static Color TextDark = ColorTranslator.FromHtml("#1A1A1A");
            public static Color TextLight = ColorTranslator.FromHtml("#F7F7F9");

            // Fonts (Segoe UI fits the professional HR system feel)
            public static Font FontHeader = new Font("Segoe UI", 16F, FontStyle.Bold);
            public static Font FontSubHeader = new Font("Segoe UI", 11F, FontStyle.Bold);
            public static Font FontBody = new Font("Segoe UI", 9F, FontStyle.Regular);
            public static Font FontButton = new Font("Segoe UI", 9F, FontStyle.Bold);
            public static Font FontSmall = new Font("Segoe UI", 8F, FontStyle.Regular);

            // Primary Button (Lemon Yellow)
            public static void StyleButtonPrimary(Button btn)
            {
                btn.BackColor = BrightLemon;
                btn.ForeColor = TextDark;
                btn.Font = FontButton;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
                btn.Size = new System.Drawing.Size(120, 35);
            }

            // Danger Button (Dark Wine)
            public static void StyleButtonDanger(Button btn)
            {
                btn.BackColor = DarkWine;
                btn.ForeColor = TextLight;
                btn.Font = FontButton;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
                btn.Size = new System.Drawing.Size(120, 35);
            }

            // Secondary Button (Sea Green)
            public static void StyleButtonSecondary(Button btn)
            {
                btn.BackColor = SeaGreen;
                btn.ForeColor = TextLight;
                btn.Font = FontButton;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
                btn.Size = new System.Drawing.Size(120, 35);
            }

            // TextBox
            public static void StyleTextBox(TextBox txt)
            {
                txt.Font = FontBody;
                txt.BackColor = Color.White;
                txt.ForeColor = TextDark;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.Height = 30;
            }

            // Label Header
            public static void StyleLabelHeader(Label lbl)
            {
                lbl.Font = FontHeader;
                lbl.ForeColor = DarkKhaki;
            }

            // Label Body
            public static void StyleLabelBody(Label lbl)
            {
                lbl.Font = FontBody;
                lbl.ForeColor = TextDark;
            }

            // Panel Sidebar
            public static void StyleSidebar(Panel pnl)
            {
                pnl.BackColor = SeaGreen;
            }

            // Panel Header Bar
            public static void StyleHeaderBar(Panel pnl)
            {
                pnl.BackColor = DarkKhaki;
            }

            // DataGridView
            public static void StyleDataGrid(DataGridView dgv)
            {
                dgv.BackgroundColor = BrightSnow;
                dgv.BorderStyle = BorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = DarkKhaki;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextLight;
                dgv.ColumnHeadersDefaultCellStyle.Font = FontButton;
                dgv.DefaultCellStyle.Font = FontBody;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = BrightSnow;
                dgv.GridColor = Color.LightGray;
                dgv.RowHeadersVisible = false;
                dgv.EnableHeadersVisualStyles = false;
            }
        }
    }
}