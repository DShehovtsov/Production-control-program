

using PcpBl;
using PcpBl.Models;
using System.Collections.Generic;

namespace PcpUI
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMainPanel = new System.Windows.Forms.Panel();
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.HideMenu = new System.Windows.Forms.Label();
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.AgeListBox = new System.Windows.Forms.ListBox();
            this.CountListBox = new System.Windows.Forms.ListBox();
            this.BirdListBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShopListBox = new System.Windows.Forms.ListBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ShopsCheckBoxPanel = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ManagementPanel = new System.Windows.Forms.Panel();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.MonitoringButton = new System.Windows.Forms.Button();
            this.ManagementButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMainPanel.SuspendLayout();
            this.CentralPanel.SuspendLayout();
            this.TableMain.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.ShopsCheckBoxPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMainPanel
            // 
            this.MainMainPanel.Controls.Add(this.CentralPanel);
            this.MainMainPanel.Controls.Add(this.RightPanel);
            this.MainMainPanel.Controls.Add(this.LeftPanel);
            this.MainMainPanel.Controls.Add(this.TopPanel);
            this.MainMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMainPanel.Name = "MainMainPanel";
            this.MainMainPanel.Size = new System.Drawing.Size(1407, 652);
            this.MainMainPanel.TabIndex = 1;
            // 
            // CentralPanel
            // 
            this.CentralPanel.BackColor = System.Drawing.Color.LightCyan;
            this.CentralPanel.Controls.Add(this.HideMenu);
            this.CentralPanel.Controls.Add(this.TableMain);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(200, 80);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(1007, 572);
            this.CentralPanel.TabIndex = 0;
            // 
            // HideMenu
            // 
            this.HideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HideMenu.AutoSize = true;
            this.HideMenu.BackColor = System.Drawing.Color.Lime;
            this.HideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideMenu.Location = new System.Drawing.Point(1, 196);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.Size = new System.Drawing.Size(18, 100);
            this.HideMenu.TabIndex = 4;
            this.HideMenu.Text = ".\r\n.\r\n.\r\n.";
            this.HideMenu.Click += new System.EventHandler(this.HideMenu_Click);
            // 
            // TableMain
            // 
            this.TableMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TableMain.ColumnCount = 4;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.43568F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.56432F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.TableMain.Controls.Add(this.AgeListBox, 3, 1);
            this.TableMain.Controls.Add(this.CountListBox, 2, 1);
            this.TableMain.Controls.Add(this.BirdListBox1, 1, 1);
            this.TableMain.Controls.Add(this.label7, 0, 0);
            this.TableMain.Controls.Add(this.label6, 2, 0);
            this.TableMain.Controls.Add(this.label5, 1, 0);
            this.TableMain.Controls.Add(this.label4, 0, 0);
            this.TableMain.Controls.Add(this.ShopListBox, 0, 1);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 2;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TableMain.Size = new System.Drawing.Size(1007, 572);
            this.TableMain.TabIndex = 6;
            // 
            // AgeListBox
            // 
            this.AgeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeListBox.FormattingEnabled = true;
            this.AgeListBox.ItemHeight = 25;
            this.AgeListBox.Location = new System.Drawing.Point(765, 93);
            this.AgeListBox.Name = "AgeListBox";
            this.AgeListBox.Size = new System.Drawing.Size(236, 473);
            this.AgeListBox.TabIndex = 7;
            // 
            // CountListBox
            // 
            this.CountListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountListBox.FormattingEnabled = true;
            this.CountListBox.ItemHeight = 25;
            this.CountListBox.Location = new System.Drawing.Point(511, 93);
            this.CountListBox.Name = "CountListBox";
            this.CountListBox.Size = new System.Drawing.Size(245, 473);
            this.CountListBox.TabIndex = 6;
            // 
            // BirdListBox1
            // 
            this.BirdListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BirdListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdListBox1.FormattingEnabled = true;
            this.BirdListBox1.ItemHeight = 25;
            this.BirdListBox1.Location = new System.Drawing.Point(236, 93);
            this.BirdListBox1.Name = "BirdListBox1";
            this.BirdListBox1.Size = new System.Drawing.Size(266, 473);
            this.BirdListBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(236, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 37);
            this.label7.TabIndex = 3;
            this.label7.Text = "Птица";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(765, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 74);
            this.label6.TabIndex = 2;
            this.label6.Text = "Возраст\r\n(В днях)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(511, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Количество";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Цех";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShopListBox
            // 
            this.ShopListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShopListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopListBox.FormattingEnabled = true;
            this.ShopListBox.ItemHeight = 25;
            this.ShopListBox.Location = new System.Drawing.Point(6, 93);
            this.ShopListBox.Name = "ShopListBox";
            this.ShopListBox.Size = new System.Drawing.Size(221, 473);
            this.ShopListBox.TabIndex = 4;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.RightPanel.Controls.Add(this.ShopsCheckBoxPanel);
            this.RightPanel.Controls.Add(this.label3);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(1207, 80);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(200, 572);
            this.RightPanel.TabIndex = 1;
            // 
            // ShopsCheckBoxPanel
            // 
            this.ShopsCheckBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShopsCheckBoxPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.ShopsCheckBoxPanel.Controls.Add(this.checkedListBox1);
            this.ShopsCheckBoxPanel.Location = new System.Drawing.Point(6, 61);
            this.ShopsCheckBoxPanel.Name = "ShopsCheckBoxPanel";
            this.ShopsCheckBoxPanel.Size = new System.Drawing.Size(191, 508);
            this.ShopsCheckBoxPanel.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 7);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(185, 480);
            this.checkedListBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цех:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.ManagementPanel);
            this.LeftPanel.Controls.Add(this.HistoryButton);
            this.LeftPanel.Controls.Add(this.MonitoringButton);
            this.LeftPanel.Controls.Add(this.ManagementButton);
            this.LeftPanel.Controls.Add(this.MainButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 80);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 572);
            this.LeftPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(28, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Меню";
            // 
            // ManagementPanel
            // 
            this.ManagementPanel.Location = new System.Drawing.Point(200, 0);
            this.ManagementPanel.Name = "ManagementPanel";
            this.ManagementPanel.Size = new System.Drawing.Size(1147, 599);
            this.ManagementPanel.TabIndex = 2;
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(12, 211);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(165, 33);
            this.HistoryButton.TabIndex = 2;
            this.HistoryButton.Text = "Хронология";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // MonitoringButton
            // 
            this.MonitoringButton.Location = new System.Drawing.Point(12, 162);
            this.MonitoringButton.Name = "MonitoringButton";
            this.MonitoringButton.Size = new System.Drawing.Size(165, 33);
            this.MonitoringButton.TabIndex = 2;
            this.MonitoringButton.Text = "Мониторинг";
            this.MonitoringButton.UseVisualStyleBackColor = true;
            this.MonitoringButton.Click += new System.EventHandler(this.MonitoringButton_Click);
            // 
            // ManagementButton
            // 
            this.ManagementButton.Location = new System.Drawing.Point(12, 112);
            this.ManagementButton.Name = "ManagementButton";
            this.ManagementButton.Size = new System.Drawing.Size(165, 33);
            this.ManagementButton.TabIndex = 2;
            this.ManagementButton.Text = "Управление";
            this.ManagementButton.UseVisualStyleBackColor = true;
            this.ManagementButton.Click += new System.EventHandler(this.ManagementButton_Click);
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(12, 61);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(165, 33);
            this.MainButton.TabIndex = 2;
            this.MainButton.Text = "Главная";
            this.MainButton.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LawnGreen;
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1407, 80);
            this.TopPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главная";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 652);
            this.Controls.Add(this.MainMainPanel);
            this.Name = "Main";
            this.Text = "Программа контроля за производством";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMainPanel.ResumeLayout(false);
            this.CentralPanel.ResumeLayout(false);
            this.CentralPanel.PerformLayout();
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ShopsCheckBoxPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainMainPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button MonitoringButton;
        private System.Windows.Forms.Button ManagementButton;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Panel ManagementPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HideMenu;
        private System.Windows.Forms.Panel ShopsCheckBoxPanel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TableLayoutPanel TableMain;
        private System.Windows.Forms.ListBox AgeListBox;
        private System.Windows.Forms.ListBox CountListBox;
        private System.Windows.Forms.ListBox BirdListBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ShopListBox;
    }
}

