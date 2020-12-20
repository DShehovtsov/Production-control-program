using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using PcpBl;
using PcpBl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcpUI
{
    public partial class Main : Form
    {
        PcpContext db = new PcpContext();
        
        public Main()
        {
            InitializeComponent();

        }




        #region MAIN FORM
        public void HideMenu_Click(object sender, EventArgs e)
        {
            if (LeftPanel.Visible == true)
            {
                LeftPanel.Visible = false;
            }
            else
            {
                LeftPanel.Visible = true;
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {
            #region MANAGEMENT FORM CREATED

            this.ManagementMainPanel = new System.Windows.Forms.Panel();
            this.ManagementCentralPanel = new System.Windows.Forms.Panel();
            this.AddEggPanel = new System.Windows.Forms.Panel();
            this.EggCountLabel = new System.Windows.Forms.Label();
            this.EggCountText = new System.Windows.Forms.TextBox();
            this.EggBirdText = new System.Windows.Forms.ComboBox();
            this.EggBirdLabel = new System.Windows.Forms.Label();
            this.EggShopText = new System.Windows.Forms.ComboBox();
            this.EggPsLabel = new System.Windows.Forms.Label();
            this.EggShopLabel = new System.Windows.Forms.Label();
            this.EggPsText = new System.Windows.Forms.TextBox();
            this.EggAddButton = new System.Windows.Forms.Button();
            this.EggCancelButton = new System.Windows.Forms.Button();
            this.ChangeShopPanel = new System.Windows.Forms.Panel();
            this.ChangeShopLabelShop = new System.Windows.Forms.Label();
            this.ChangeShopTextShop = new System.Windows.Forms.TextBox();
            this.ChangeShopButtonC = new System.Windows.Forms.Button();
            this.ChangeShopBoxShop = new System.Windows.Forms.ComboBox();
            this.ChangeShopLabelPs = new System.Windows.Forms.Label();
            this.ChangeShopLabelShop2 = new System.Windows.Forms.Label();
            this.ChangeShopTextPs = new System.Windows.Forms.TextBox();
            this.ChangeShopButtonD = new System.Windows.Forms.Button();
            this.ChangeShopButtonE = new System.Windows.Forms.Button();
            this.ShopAddPanel = new System.Windows.Forms.Panel();
            this.ShopPsLabel = new System.Windows.Forms.Label();
            this.ShopNameLabel = new System.Windows.Forms.Label();
            this.ShopNameText = new System.Windows.Forms.TextBox();
            this.ShopPsText = new System.Windows.Forms.TextBox();
            this.ShopAddButton = new System.Windows.Forms.Button();
            this.ShopCancelButton = new System.Windows.Forms.Button();
            this.ManagementAddPanel = new System.Windows.Forms.Panel();
            this.BirdDateText = new System.Windows.Forms.DateTimePicker();
            this.BirdPsLabel = new System.Windows.Forms.Label();
            this.BirdCountLabel = new System.Windows.Forms.Label();
            this.BirdAgeLabel = new System.Windows.Forms.Label();
            this.BirdShopLabel = new System.Windows.Forms.Label();
            this.BirdNameLabel = new System.Windows.Forms.Label();
            this.BirdShopText = new System.Windows.Forms.ComboBox();
            this.BirdCountAge = new System.Windows.Forms.TextBox();
            this.BirdNameText = new System.Windows.Forms.TextBox();
            this.BirdPsText = new System.Windows.Forms.TextBox();
            this.SaveAddButton = new System.Windows.Forms.Button();
            this.ButtonAddCancel = new System.Windows.Forms.Button();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.CloseCreateButton = new System.Windows.Forms.Label();
            this.AddEgg = new System.Windows.Forms.Button();
            this.AddShop = new System.Windows.Forms.Button();
            this.AddBird = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.ManagementHideMenu = new System.Windows.Forms.Label();
            this.ManagementLeftPanel = new System.Windows.Forms.Panel();
            this.Managementlabel2 = new System.Windows.Forms.Label();
            this.ManagementManagementPanel = new System.Windows.Forms.Panel();
            this.ManagementHistoryButton = new System.Windows.Forms.Button();
            this.ManagementMonitoringButton = new System.Windows.Forms.Button();
            this.ManagementManagementButton = new System.Windows.Forms.Button();
            this.ManagementMainButton = new System.Windows.Forms.Button();
            this.ManagementRightPanel = new System.Windows.Forms.Panel();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ManagementTopPanel = new System.Windows.Forms.Panel();
            this.Manage = new System.Windows.Forms.Label();
            this.QuestionPanelDelete = new System.Windows.Forms.Panel();
            this.QuestionExitDelete = new System.Windows.Forms.Label();
            this.ChangeShopButton = new System.Windows.Forms.Button();
            this.ChangeBirdButton = new System.Windows.Forms.Button();
            this.Qpanelgreen = new System.Windows.Forms.Panel();
            this.QuestionLabelDelete = new System.Windows.Forms.Label();
            this.ChangeBirdPanel = new System.Windows.Forms.Panel();
            this.ChangeBirdLabelCount = new System.Windows.Forms.Label();
            this.ChangeBirdTextCount = new System.Windows.Forms.TextBox();
            this.ChangeBirdBoxBird = new System.Windows.Forms.ComboBox();
            this.ChangeBirdLabelBird = new System.Windows.Forms.Label();
            this.ChangeBirdTextShop = new System.Windows.Forms.ComboBox();
            this.ChangeBirdLabelPs = new System.Windows.Forms.Label();
            this.ChangeBirdLabelShop = new System.Windows.Forms.Label();
            this.ChangeBirdTextPs = new System.Windows.Forms.TextBox();
            this.ChangeBirdButtonD = new System.Windows.Forms.Button();
            this.ChangeBirdButtonE = new System.Windows.Forms.Button();
            this.ChangeBirdButtonC = new System.Windows.Forms.Button();
            this.ChangeBirdLabelBird2 = new System.Windows.Forms.Label();
            this.ChangeBirdTextBird = new System.Windows.Forms.TextBox();
            this.ChangeBirdTextDate = new System.Windows.Forms.DateTimePicker();
            this.ChangeBirdLabelDate = new System.Windows.Forms.Label();
            this.ManagementMainPanel.SuspendLayout();
            this.ManagementCentralPanel.SuspendLayout();
            this.ShopAddPanel.SuspendLayout();
            this.ManagementAddPanel.SuspendLayout();
            this.ChangeShopPanel.SuspendLayout();
            this.ManagementLeftPanel.SuspendLayout();
            this.ManagementRightPanel.SuspendLayout();
            this.ManagementTopPanel.SuspendLayout();
            this.QuestionPanel.SuspendLayout();
            this.AddEggPanel.SuspendLayout();
            this.QuestionPanelDelete.SuspendLayout();
            this.ChangeBirdPanel.SuspendLayout();
            this.SuspendLayout();
            //
            //ManagementMainPanel
            //
            this.ManagementMainPanel.Location = new System.Drawing.Point(200, 0);
            
            this.ManagementMainPanel.Controls.Add(this.ManagementCentralPanel);
            this.ManagementMainPanel.Controls.Add(this.ManagementTopPanel);
            this.ManagementMainPanel.Controls.Add(this.ManagementManagementPanel);
            this.ManagementMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagementMainPanel.Name = "ManagementMainPanel";
            this.ManagementMainPanel.Size = new System.Drawing.Size(1347, 574);
            this.ManagementMainPanel.TabIndex = 1;
            this.ManagementMainPanel.Visible = false;
            // 
            // ManagementCentralPanel
            // 
            this.ManagementCentralPanel.BackColor = System.Drawing.Color.LightCyan;
            this.ManagementCentralPanel.Controls.Add(this.ManagementHideMenu);
            this.ManagementCentralPanel.Controls.Add(this.AddEggPanel);
            this.ManagementCentralPanel.Controls.Add(this.ShopAddPanel);
            this.ManagementCentralPanel.Controls.Add(this.ManagementAddPanel);
            this.ManagementCentralPanel.Controls.Add(this.QuestionPanel);
            this.ManagementCentralPanel.Controls.Add(this.QuestionPanelDelete);
            this.ManagementCentralPanel.Controls.Add(this.ChangeBirdPanel);
            this.ManagementCentralPanel.Controls.Add(this.ChangeShopPanel);
            this.ManagementCentralPanel.Controls.Add(this.ManagementLeftPanel);
            this.ManagementCentralPanel.Controls.Add(this.ManagementRightPanel);
            this.ManagementCentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagementCentralPanel.Location = new System.Drawing.Point(0, 80);
            this.ManagementCentralPanel.Name = "ManagementCentralPanel";
            this.ManagementCentralPanel.Size = new System.Drawing.Size(1167, 532);
            this.ManagementCentralPanel.TabIndex = 3;
            // 
            // AddEggPanel
            // 
            this.AddEggPanel.BackColor = System.Drawing.Color.Teal;
            this.AddEggPanel.Controls.Add(this.EggCountLabel);
            this.AddEggPanel.Controls.Add(this.EggCountText);
            this.AddEggPanel.Controls.Add(this.EggBirdText);
            this.AddEggPanel.Controls.Add(this.EggBirdLabel);
            this.AddEggPanel.Controls.Add(this.EggShopText);
            this.AddEggPanel.Controls.Add(this.EggPsLabel);
            this.AddEggPanel.Controls.Add(this.EggShopLabel);
            this.AddEggPanel.Controls.Add(this.EggPsText);
            this.AddEggPanel.Controls.Add(this.EggAddButton);
            this.AddEggPanel.Controls.Add(this.EggCancelButton);
            this.AddEggPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddEggPanel.Location = new System.Drawing.Point(221, 25);
            this.AddEggPanel.Name = "AddEggPanel";
            this.AddEggPanel.Size = new System.Drawing.Size(947, 495);
            this.AddEggPanel.TabIndex = 21;
            this.AddEggPanel.Visible = false;
            // 
            // ChangeShopPanel
            // 
            this.ChangeShopPanel.BackColor = System.Drawing.Color.Teal;
            this.ChangeShopPanel.Controls.Add(this.ChangeShopLabelShop);
            this.ChangeShopPanel.Controls.Add(this.ChangeShopTextShop);
            this.ChangeShopPanel.Controls.Add(this.ChangeShopButtonC);
            this.ChangeShopPanel.Controls.Add(this.ChangeShopBoxShop);
            this.ChangeShopPanel.Controls.Add(this.ChangeShopLabelPs);
            this.ChangeShopPanel.Controls.Add(this.ChangeShopLabelShop2);
            this.ChangeShopPanel.Controls.Add(this.ChangeShopTextPs);
            this.ChangeShopPanel.Controls.Add(this.ChangeShopButtonD);
            this.ChangeShopPanel.Controls.Add(this.ChangeShopButtonE);
            this.ChangeShopPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangeShopPanel.Location = new System.Drawing.Point(-5, 0);
            this.ChangeShopPanel.Name = "ChangeShopPanel";
            this.ChangeShopPanel.Size = new System.Drawing.Size(947, 532);
            this.ChangeShopPanel.TabIndex = 29;
            this.ChangeShopPanel.Visible = false;
            // 
            // ChangeShopLabelShop
            // 
            this.ChangeShopLabelShop.AutoSize = true;
            this.ChangeShopLabelShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopLabelShop.Location = new System.Drawing.Point(59, 198);
            this.ChangeShopLabelShop.Name = "ChangeShopLabelShop";
            this.ChangeShopLabelShop.Size = new System.Drawing.Size(50, 25);
            this.ChangeShopLabelShop.TabIndex = 26;
            this.ChangeShopLabelShop.Text = "Цех";
            // 
            // ChangeShopTextShop
            // 
            this.ChangeShopTextShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopTextShop.Location = new System.Drawing.Point(371, 192);
            this.ChangeShopTextShop.Name = "ChangeShopTextShop";
            this.ChangeShopTextShop.Size = new System.Drawing.Size(477, 34);
            this.ChangeShopTextShop.TabIndex = 25;
            // 
            // ChangeShopButtonC
            // 
            this.ChangeShopButtonC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeShopButtonC.BackColor = System.Drawing.Color.LawnGreen;
            this.ChangeShopButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopButtonC.ForeColor = System.Drawing.Color.DarkBlue;
            this.ChangeShopButtonC.Location = new System.Drawing.Point(322, 485);
            this.ChangeShopButtonC.Name = "ChangeShopButtonC";
            this.ChangeShopButtonC.Size = new System.Drawing.Size(202, 36);
            this.ChangeShopButtonC.TabIndex = 24;
            this.ChangeShopButtonC.Text = "Изменить";
            this.ChangeShopButtonC.UseVisualStyleBackColor = false;
            this.ChangeShopButtonC.Click += new System.EventHandler(this.ChangeShopButtonC_Click);
            // 
            // ChangeShopBoxShop
            // 
            this.ChangeShopBoxShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeShopBoxShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopBoxShop.FormattingEnabled = true;
            this.ChangeShopBoxShop.Location = new System.Drawing.Point(258, 66);
            this.ChangeShopBoxShop.Name = "ChangeShopBoxShop";
            this.ChangeShopBoxShop.Size = new System.Drawing.Size(402, 37);
            this.ChangeShopBoxShop.TabIndex = 19;
            this.ChangeShopBoxShop.SelectedValueChanged += new System.EventHandler(this.ChangeShopBoxShop_SelectedValueChanged);
            // 
            // ChangeShopLabelPs
            // 
            this.ChangeShopLabelPs.AutoSize = true;
            this.ChangeShopLabelPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopLabelPs.Location = new System.Drawing.Point(60, 311);
            this.ChangeShopLabelPs.Name = "ChangeShopLabelPs";
            this.ChangeShopLabelPs.Size = new System.Drawing.Size(140, 25);
            this.ChangeShopLabelPs.TabIndex = 18;
            this.ChangeShopLabelPs.Text = "Примечание";
            // 
            // ChangeShopLabelShop2
            // 
            this.ChangeShopLabelShop2.AutoSize = true;
            this.ChangeShopLabelShop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopLabelShop2.Location = new System.Drawing.Point(437, 27);
            this.ChangeShopLabelShop2.Name = "ChangeShopLabelShop2";
            this.ChangeShopLabelShop2.Size = new System.Drawing.Size(50, 25);
            this.ChangeShopLabelShop2.TabIndex = 14;
            this.ChangeShopLabelShop2.Text = "Цех";
            // 
            // ChangeShopTextPs
            // 
            this.ChangeShopTextPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopTextPs.Location = new System.Drawing.Point(371, 305);
            this.ChangeShopTextPs.Name = "ChangeShopTextPs";
            this.ChangeShopTextPs.Size = new System.Drawing.Size(477, 34);
            this.ChangeShopTextPs.TabIndex = 9;
            // 
            // ChangeShopButtonD
            // 
            this.ChangeShopButtonD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeShopButtonD.BackColor = System.Drawing.Color.LawnGreen;
            this.ChangeShopButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopButtonD.ForeColor = System.Drawing.Color.DarkBlue;
            this.ChangeShopButtonD.Location = new System.Drawing.Point(534, 485);
            this.ChangeShopButtonD.Name = "ChangeShopButtonD";
            this.ChangeShopButtonD.Size = new System.Drawing.Size(202, 36);
            this.ChangeShopButtonD.TabIndex = 7;
            this.ChangeShopButtonD.Text = "Удалить";
            this.ChangeShopButtonD.UseVisualStyleBackColor = false;
            this.ChangeShopButtonD.Click += new System.EventHandler(this.ChangeShopButtonD_Click);
            // 
            // ChangeShopButtonE
            // 
            this.ChangeShopButtonE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeShopButtonE.BackColor = System.Drawing.Color.LawnGreen;
            this.ChangeShopButtonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopButtonE.ForeColor = System.Drawing.Color.DarkBlue;
            this.ChangeShopButtonE.Location = new System.Drawing.Point(742, 485);
            this.ChangeShopButtonE.Name = "ChangeShopButtonE";
            this.ChangeShopButtonE.Size = new System.Drawing.Size(202, 36);
            this.ChangeShopButtonE.TabIndex = 8;
            this.ChangeShopButtonE.Text = "Отмена";
            this.ChangeShopButtonE.UseVisualStyleBackColor = false;
            this.ChangeShopButtonE.Click += new System.EventHandler(this.ChangeShopButtonE_Click);
            // 
            // EggCountLabel
            // 
            this.EggCountLabel.AutoSize = true;
            this.EggCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggCountLabel.Location = new System.Drawing.Point(47, 274);
            this.EggCountLabel.Name = "EggCountLabel";
            this.EggCountLabel.Size = new System.Drawing.Size(146, 25);
            this.EggCountLabel.TabIndex = 23;
            this.EggCountLabel.Text = "Колличество";
            // 
            // EggCountText
            // 
            this.EggCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggCountText.Location = new System.Drawing.Point(371, 268);
            this.EggCountText.Name = "EggCountText";
            this.EggCountText.Size = new System.Drawing.Size(477, 34);
            this.EggCountText.TabIndex = 22;
            // 
            // EggBirdText
            // 
            this.EggBirdText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EggBirdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggBirdText.FormattingEnabled = true;
            this.EggBirdText.Location = new System.Drawing.Point(373, 170);
            this.EggBirdText.Name = "EggBirdText";
            this.EggBirdText.Size = new System.Drawing.Size(477, 37);
            this.EggBirdText.TabIndex = 21;
            // 
            // EggBirdLabel
            // 
            this.EggBirdLabel.AutoSize = true;
            this.EggBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggBirdLabel.Location = new System.Drawing.Point(49, 172);
            this.EggBirdLabel.Name = "EggBirdLabel";
            this.EggBirdLabel.Size = new System.Drawing.Size(76, 25);
            this.EggBirdLabel.TabIndex = 20;
            this.EggBirdLabel.Text = "Птица";
            // 
            // EggShopText
            // 
            this.EggShopText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EggShopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggShopText.FormattingEnabled = true;
            this.EggShopText.Location = new System.Drawing.Point(371, 82);
            this.EggShopText.Name = "EggShopText";
            this.EggShopText.Size = new System.Drawing.Size(477, 37);
            this.EggShopText.TabIndex = 19;
            this.EggShopText.SelectedValueChanged += new System.EventHandler(this.EggShopText_SelectedIndexChanged);
            // 
            // EggPsLabel
            // 
            this.EggPsLabel.AutoSize = true;
            this.EggPsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggPsLabel.Location = new System.Drawing.Point(49, 361);
            this.EggPsLabel.Name = "EggPsLabel";
            this.EggPsLabel.Size = new System.Drawing.Size(140, 25);
            this.EggPsLabel.TabIndex = 18;
            this.EggPsLabel.Text = "Примечание";
            // 
            // EggShopLabel
            // 
            this.EggShopLabel.AutoSize = true;
            this.EggShopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggShopLabel.Location = new System.Drawing.Point(47, 84);
            this.EggShopLabel.Name = "EggShopLabel";
            this.EggShopLabel.Size = new System.Drawing.Size(50, 25);
            this.EggShopLabel.TabIndex = 14;
            this.EggShopLabel.Text = "Цех";
            // 
            // EggPsText
            // 
            this.EggPsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggPsText.Location = new System.Drawing.Point(373, 355);
            this.EggPsText.Name = "EggPsText";
            this.EggPsText.Size = new System.Drawing.Size(477, 34);
            this.EggPsText.TabIndex = 9;
            // 
            // EggAddButton
            // 
            this.EggAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EggAddButton.BackColor = System.Drawing.Color.LawnGreen;
            this.EggAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggAddButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.EggAddButton.Location = new System.Drawing.Point(529, 448);
            this.EggAddButton.Name = "EggAddButton";
            this.EggAddButton.Size = new System.Drawing.Size(202, 36);
            this.EggAddButton.TabIndex = 7;
            this.EggAddButton.Text = "Добавить";
            this.EggAddButton.UseVisualStyleBackColor = false;
            this.EggAddButton.Click += new System.EventHandler(this.EggAddButton_Click);
            // 
            // EggCancelButton
            // 
            this.EggCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EggCancelButton.BackColor = System.Drawing.Color.LawnGreen;
            this.EggCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EggCancelButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.EggCancelButton.Location = new System.Drawing.Point(737, 448);
            this.EggCancelButton.Name = "EggCancelButton";
            this.EggCancelButton.Size = new System.Drawing.Size(202, 36);
            this.EggCancelButton.TabIndex = 8;
            this.EggCancelButton.Text = "Отмена";
            this.EggCancelButton.UseVisualStyleBackColor = false;
            this.EggCancelButton.Click += new System.EventHandler(this.EggCancelButton_Click);
            // 
            // ShopAddPanel
            // 
            this.ShopAddPanel.BackColor = System.Drawing.Color.Teal;
            this.ShopAddPanel.Controls.Add(this.ShopPsLabel);
            this.ShopAddPanel.Controls.Add(this.ShopNameLabel);
            this.ShopAddPanel.Controls.Add(this.ShopNameText);
            this.ShopAddPanel.Controls.Add(this.ShopPsText);
            this.ShopAddPanel.Controls.Add(this.ShopAddButton);
            this.ShopAddPanel.Controls.Add(this.ShopCancelButton);
            this.ShopAddPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShopAddPanel.Location = new System.Drawing.Point(-5,0);
            this.ShopAddPanel.Name = "ShopAddPanel";
            this.ShopAddPanel.Size = new System.Drawing.Size(942, 532);
            this.ShopAddPanel.TabIndex = 20;
            this.ShopAddPanel.Visible = false;
            // 
            // ShopPsLabel
            // 
            this.ShopPsLabel.AutoSize = true;
            this.ShopPsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopPsLabel.Location = new System.Drawing.Point(44, 229);
            this.ShopPsLabel.Name = "ShopPsLabel";
            this.ShopPsLabel.Size = new System.Drawing.Size(140, 25);
            this.ShopPsLabel.TabIndex = 18;
            this.ShopPsLabel.Text = "Примечание";
            // 
            // ShopNameLabel
            // 
            this.ShopNameLabel.AutoSize = true;
            this.ShopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopNameLabel.Location = new System.Drawing.Point(44, 102);
            this.ShopNameLabel.Name = "ShopNameLabel";
            this.ShopNameLabel.Size = new System.Drawing.Size(160, 25);
            this.ShopNameLabel.TabIndex = 14;
            this.ShopNameLabel.Text = "Название цеха";
            // 
            // ShopNameText
            // 
            this.ShopNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopNameText.Location = new System.Drawing.Point(370, 99);
            this.ShopNameText.Name = "ShopNameText";
            this.ShopNameText.Size = new System.Drawing.Size(477, 34);
            this.ShopNameText.TabIndex = 10;
            // 
            // ShopPsText
            // 
            this.ShopPsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopPsText.Location = new System.Drawing.Point(370, 223);
            this.ShopPsText.Name = "ShopPsText";
            this.ShopPsText.Size = new System.Drawing.Size(477, 34);
            this.ShopPsText.TabIndex = 9;
            // 
            // ShopAddButton
            // 
            this.ShopAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShopAddButton.BackColor = System.Drawing.Color.LawnGreen;
            this.ShopAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopAddButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.ShopAddButton.Location = new System.Drawing.Point(529, 448);
            this.ShopAddButton.Name = "ShopAddButton";
            this.ShopAddButton.Size = new System.Drawing.Size(202, 36);
            this.ShopAddButton.TabIndex = 7;
            this.ShopAddButton.Text = "Добавить";
            this.ShopAddButton.UseVisualStyleBackColor = false;
            this.ShopAddButton.Click += new System.EventHandler(this.ShopAddButton_Click);
            // 
            // ShopCancelButton
            // 
            this.ShopCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShopCancelButton.BackColor = System.Drawing.Color.LawnGreen;
            this.ShopCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopCancelButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.ShopCancelButton.Location = new System.Drawing.Point(737, 448);
            this.ShopCancelButton.Name = "ShopCancelButton";
            this.ShopCancelButton.Size = new System.Drawing.Size(202, 36);
            this.ShopCancelButton.TabIndex = 8;
            this.ShopCancelButton.Text = "Отмена";
            this.ShopCancelButton.UseVisualStyleBackColor = false;
            this.ShopCancelButton.Click += new System.EventHandler(this.ShopCancelButton_Click);
            // 
            // ManagementAddPanel
            // 
            this.ManagementAddPanel.BackColor = System.Drawing.Color.Teal;
            this.ManagementAddPanel.Controls.Add(this.BirdDateText);
            this.ManagementAddPanel.Controls.Add(this.BirdPsLabel);
            this.ManagementAddPanel.Controls.Add(this.BirdCountLabel);
            this.ManagementAddPanel.Controls.Add(this.BirdAgeLabel);
            this.ManagementAddPanel.Controls.Add(this.BirdShopLabel);
            this.ManagementAddPanel.Controls.Add(this.BirdNameLabel);
            this.ManagementAddPanel.Controls.Add(this.BirdShopText);
            this.ManagementAddPanel.Controls.Add(this.BirdCountAge);
            this.ManagementAddPanel.Controls.Add(this.BirdNameText);
            this.ManagementAddPanel.Controls.Add(this.BirdPsText);
            this.ManagementAddPanel.Controls.Add(this.SaveAddButton);
            this.ManagementAddPanel.Controls.Add(this.ButtonAddCancel);
            this.ManagementAddPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ManagementAddPanel.Location = new System.Drawing.Point(222, 25);
            this.ManagementAddPanel.Name = "ManagementAddPanel";
            this.ManagementAddPanel.Size = new System.Drawing.Size(942, 495);
            this.ManagementAddPanel.TabIndex = 9;
            this.ManagementAddPanel.Visible = false;
            // 
            // BirdDateText
            // 
            this.BirdDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdDateText.Location = new System.Drawing.Point(370, 174);
            this.BirdDateText.Name = "BirdDateText";
            this.BirdDateText.Size = new System.Drawing.Size(477, 34);
            this.BirdDateText.TabIndex = 19;
            // 
            // BirdPsLabel
            // 
            this.BirdPsLabel.AutoSize = true;
            this.BirdPsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdPsLabel.Location = new System.Drawing.Point(44, 364);
            this.BirdPsLabel.Name = "BirdPsLabel";
            this.BirdPsLabel.Size = new System.Drawing.Size(314, 25);
            this.BirdPsLabel.TabIndex = 18;
            this.BirdPsLabel.Text = "Примечание";
            // 
            // BirdCountLabel
            // 
            this.BirdCountLabel.AutoSize = true;
            this.BirdCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdCountLabel.Location = new System.Drawing.Point(44, 268);
            this.BirdCountLabel.Name = "BirdCountLabel";
            this.BirdCountLabel.Size = new System.Drawing.Size(202, 25);
            this.BirdCountLabel.TabIndex = 17;
            this.BirdCountLabel.Text = "Колличество птиц";
            // 
            // BirdAgeLabel
            // 
            this.BirdAgeLabel.AutoSize = true;
            this.BirdAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdAgeLabel.Location = new System.Drawing.Point(44, 181);
            this.BirdAgeLabel.Name = "BirdAgeLabel";
            this.BirdAgeLabel.Size = new System.Drawing.Size(193, 25);
            this.BirdAgeLabel.TabIndex = 16;
            this.BirdAgeLabel.Text = "Дата вылупления";
            // 
            // BirdShopLabel
            // 
            this.BirdShopLabel.AutoSize = true;
            this.BirdShopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdShopLabel.Location = new System.Drawing.Point(44, 102);
            this.BirdShopLabel.Name = "BirdShopLabel";
            this.BirdShopLabel.Size = new System.Drawing.Size(155, 25);
            this.BirdShopLabel.TabIndex = 15;
            this.BirdShopLabel.Text = "Выберите цех";
            // 
            // BirdNameLabel
            // 
            this.BirdNameLabel.AutoSize = true;
            this.BirdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdNameLabel.Location = new System.Drawing.Point(44, 21);
            this.BirdNameLabel.Name = "BirdNameLabel";
            this.BirdNameLabel.Size = new System.Drawing.Size(289, 25);
            this.BirdNameLabel.TabIndex = 14;
            this.BirdNameLabel.Text = "Введите вид/породу птицы";
            // 
            // BirdShopText
            // 
            this.BirdShopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdShopText.FormattingEnabled = true;
            this.BirdShopText.Location = new System.Drawing.Point(370, 96);
            this.BirdShopText.Name = "BirdShopText";
            this.BirdShopText.Size = new System.Drawing.Size(477, 37);
            this.BirdShopText.TabIndex = 13;
            // 
            // BirdCountAge
            // 
            this.BirdCountAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdCountAge.Location = new System.Drawing.Point(370, 262);
            this.BirdCountAge.Name = "BirdCountAge";
            this.BirdCountAge.Size = new System.Drawing.Size(477, 34);
            this.BirdCountAge.TabIndex = 12;
            // 
            // BirdNameText
            // 
            this.BirdNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdNameText.Location = new System.Drawing.Point(370, 17);
            this.BirdNameText.Name = "BirdNameText";
            this.BirdNameText.Size = new System.Drawing.Size(477, 34);
            this.BirdNameText.TabIndex = 10;
            // 
            // BirdPsText
            // 
            this.BirdPsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirdPsText.Location = new System.Drawing.Point(370, 358);
            this.BirdPsText.Name = "BirdPsText";
            this.BirdPsText.Size = new System.Drawing.Size(477, 34);
            this.BirdPsText.TabIndex = 9;
            // 
            // SaveAddButton
            // 
            this.SaveAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAddButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SaveAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAddButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.SaveAddButton.Location = new System.Drawing.Point(529, 448);
            this.SaveAddButton.Name = "SaveAddButton";
            this.SaveAddButton.Size = new System.Drawing.Size(202, 36);
            this.SaveAddButton.TabIndex = 7;
            this.SaveAddButton.Text = "Добавить";
            this.SaveAddButton.UseVisualStyleBackColor = false;
            this.SaveAddButton.Visible = true;
            this.SaveAddButton.Click += new System.EventHandler(this.SaveAddButton_Click);
            // 
            // ButtonAddCancel
            // 
            this.ButtonAddCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddCancel.BackColor = System.Drawing.Color.LawnGreen;
            this.ButtonAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.ButtonAddCancel.Location = new System.Drawing.Point(737, 448);
            this.ButtonAddCancel.Name = "ButtonAddCancel";
            this.ButtonAddCancel.Size = new System.Drawing.Size(202, 36);
            this.ButtonAddCancel.TabIndex = 8;
            this.ButtonAddCancel.Text = "Отмена";
            this.ButtonAddCancel.UseVisualStyleBackColor = false;
            this.ButtonAddCancel.Visible = true;
            this.ButtonAddCancel.Click += new System.EventHandler(this.ButtonAddCancel_Click);
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.QuestionPanel.Controls.Add(this.CloseCreateButton);
            this.QuestionPanel.Controls.Add(this.AddEgg);
            this.QuestionPanel.Controls.Add(this.AddShop);
            this.QuestionPanel.Controls.Add(this.AddBird);
            this.QuestionPanel.Controls.Add(this.panel1);
            this.QuestionPanel.Controls.Add(this.QuestionLabel);
            this.QuestionPanel.Location = new System.Drawing.Point(425, 112);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(511, 265);
            this.QuestionPanel.TabIndex = 6;
            this.QuestionPanel.Visible = false;
            // 
            // CloseCreateButton
            // 
            this.CloseCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseCreateButton.AutoSize = true;
            this.CloseCreateButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.CloseCreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseCreateButton.Location = new System.Drawing.Point(475, 6);
            this.CloseCreateButton.Name = "CloseCreateButton";
            this.CloseCreateButton.Size = new System.Drawing.Size(31, 29);
            this.CloseCreateButton.TabIndex = 5;
            this.CloseCreateButton.Text = "X";
            this.CloseCreateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseCreateButton_Click);
            // 
            // AddEgg
            // 
            this.AddEgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEgg.Location = new System.Drawing.Point(95, 184);
            this.AddEgg.Name = "AddEgg";
            this.AddEgg.Size = new System.Drawing.Size(329, 33);
            this.AddEgg.TabIndex = 4;
            this.AddEgg.Text = "Собранное яйцо";
            this.AddEgg.UseVisualStyleBackColor = true;
            this.AddEgg.Click += new System.EventHandler(this.AddEgg_Click);
            // 
            // AddShop
            // 
            this.AddShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddShop.Location = new System.Drawing.Point(95, 136);
            this.AddShop.Name = "AddShop";
            this.AddShop.Size = new System.Drawing.Size(329, 33);
            this.AddShop.TabIndex = 3;
            this.AddShop.Text = "Добавить цех";
            this.AddShop.UseVisualStyleBackColor = true;
            this.AddShop.Click += new System.EventHandler(this.AddShop_Click);
            // 
            // AddBird
            // 
            this.AddBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBird.Location = new System.Drawing.Point(95, 87);
            this.AddBird.Name = "AddBird";
            this.AddBird.Size = new System.Drawing.Size(329, 33);
            this.AddBird.TabIndex = 2;
            this.AddBird.Text = "Добавить птиц";
            this.AddBird.UseVisualStyleBackColor = true;
            this.AddBird.Click += new System.EventHandler(this.AddBird_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 10);
            this.panel1.TabIndex = 1;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(128, 10);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(260, 32);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "С чем работаем?";
            // 
            // ManagementHideMenu
            // 
            this.ManagementHideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ManagementHideMenu.AutoSize = true;
            this.ManagementHideMenu.BackColor = System.Drawing.Color.Lime;
            this.ManagementHideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagementHideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagementHideMenu.Location = new System.Drawing.Point(201, 176);
            this.ManagementHideMenu.Name = "ManagementHideMenu";
            this.ManagementHideMenu.Size = new System.Drawing.Size(18, 100);
            this.ManagementHideMenu.TabIndex = 5;
            this.ManagementHideMenu.Text = ".\r\n.\r\n.\r\n.";
            this.ManagementHideMenu.Click += new System.EventHandler(this.ManagementHideMenu_Click);
            // 
            // ManagementRightPanel
            // 
            this.ManagementRightPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.ManagementRightPanel.Controls.Add(this.ButtonDelete);
            this.ManagementRightPanel.Controls.Add(this.ButtonCreate);
            this.ManagementRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ManagementRightPanel.Location = new System.Drawing.Point(1147, 80);
            this.ManagementRightPanel.Name = "ManagementRightPanel";
            this.ManagementRightPanel.Size = new System.Drawing.Size(200, 532);
            this.ManagementRightPanel.TabIndex = 5;
            // 
            // ManagementLeftPanel
            // 
            this.ManagementLeftPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.ManagementLeftPanel.Controls.Add(this.Managementlabel2);
            this.ManagementLeftPanel.Controls.Add(this.ManagementManagementPanel);
            this.ManagementLeftPanel.Controls.Add(this.ManagementHistoryButton);
            this.ManagementLeftPanel.Controls.Add(this.ManagementMonitoringButton);
            this.ManagementLeftPanel.Controls.Add(this.ManagementManagementButton);
            this.ManagementLeftPanel.Controls.Add(this.ManagementMainButton);
            this.ManagementLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ManagementLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagementLeftPanel.Name = "ManagementLeftPanel";
            this.ManagementLeftPanel.Size = new System.Drawing.Size(200, 532);
            this.ManagementLeftPanel.TabIndex = 3;
            // 
            // Managementlabel2
            // 
            this.Managementlabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Managementlabel2.AutoSize = true;
            this.Managementlabel2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Managementlabel2.Location = new System.Drawing.Point(28, 3);
            this.Managementlabel2.Name = "Managementlabel2";
            this.Managementlabel2.Size = new System.Drawing.Size(124, 46);
            this.Managementlabel2.TabIndex = 3;
            this.Managementlabel2.Text = "Меню";
            // 
            // ManagementManagementPanel
            // 
            this.ManagementManagementPanel.Location = new System.Drawing.Point(200, 0);
            this.ManagementManagementPanel.Name = "ManagementManagementPanel";

            this.ManagementManagementPanel.Size = new System.Drawing.Size(1147, 599);
            this.ManagementManagementPanel.TabIndex = 2;
            // 
            // ManagementHistoryButton
            // 
            this.ManagementHistoryButton.Location = new System.Drawing.Point(12, 211);
            this.ManagementHistoryButton.Name = "ManagementHistoryButton";
            this.ManagementHistoryButton.Size = new System.Drawing.Size(165, 33);
            this.ManagementHistoryButton.TabIndex = 2;
            this.ManagementHistoryButton.Text = "Хронология";
            this.ManagementHistoryButton.UseVisualStyleBackColor = true;
            this.ManagementHistoryButton.Click += new EventHandler(this.ManagementHistoryButton_Click);
            // 
            // ManagementMonitoringButton
            // 
            this.ManagementMonitoringButton.Location = new System.Drawing.Point(12, 162);
            this.ManagementMonitoringButton.Name = "ManagementMonitoringButton";
            this.ManagementMonitoringButton.Size = new System.Drawing.Size(165, 33);
            this.ManagementMonitoringButton.TabIndex = 2;
            this.ManagementMonitoringButton.Text = "Мониторинг";
            this.ManagementMonitoringButton.UseVisualStyleBackColor = true;
            this.ManagementMonitoringButton.Click += new EventHandler(this.ManagementMonitoringButton_Click);
            // 
            // ManagementManagementButton
            // 
            this.ManagementManagementButton.Location = new System.Drawing.Point(12, 112);
            this.ManagementManagementButton.Name = "ManagementManagementButton";
            this.ManagementManagementButton.Size = new System.Drawing.Size(165, 33);
            this.ManagementManagementButton.TabIndex = 2;
            this.ManagementManagementButton.Text = "Управление";
            this.ManagementManagementButton.UseVisualStyleBackColor = true;
            // 
            // ManagementMainButton
            // 
            this.ManagementMainButton.Location = new System.Drawing.Point(12, 61);
            this.ManagementMainButton.Name = "ManagementMainButton";
            this.ManagementMainButton.Size = new System.Drawing.Size(165, 33);
            this.ManagementMainButton.TabIndex = 2;
            this.ManagementMainButton.Text = "Главная";
            this.ManagementMainButton.UseVisualStyleBackColor = true;
            this.ManagementMainButton.Click += new System.EventHandler(this.ManagementMainButton_Click);
            
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(5, 78);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(190, 33);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "Изменить запись";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(5, 25);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(190, 33);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Добавить запись";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ManagementTopPanel
            // 
            this.ManagementTopPanel.BackColor = System.Drawing.Color.LawnGreen;
            this.ManagementTopPanel.Controls.Add(this.Manage);
            this.ManagementTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagementTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagementTopPanel.Name = "ManagementTopPanel";
            this.ManagementTopPanel.Size = new System.Drawing.Size(1367, 80);
            this.ManagementTopPanel.TabIndex = 4;
            // 
            // Manage
            // 
            this.Manage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Manage.AutoSize = true;
            this.Manage.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage.Location = new System.Drawing.Point(621, 9);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(228, 46);
            this.Manage.TabIndex = 1;
            this.Manage.Text = "Управление";
            this.Manage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionPanelDelete
            // 
            this.QuestionPanelDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionPanelDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.QuestionPanelDelete.Controls.Add(this.QuestionExitDelete);
            this.QuestionPanelDelete.Controls.Add(this.ChangeShopButton);
            this.QuestionPanelDelete.Controls.Add(this.ChangeBirdButton);
            this.QuestionPanelDelete.Controls.Add(this.Qpanelgreen);
            this.QuestionPanelDelete.Controls.Add(this.QuestionLabelDelete);
            this.QuestionPanelDelete.Location = new System.Drawing.Point(425, 112);
            this.QuestionPanelDelete.Name = "QuestionPanelDelete";
            this.QuestionPanelDelete.Size = new System.Drawing.Size(511, 265);
            this.QuestionPanelDelete.TabIndex = 24;
            this.QuestionPanelDelete.Visible = false;
            // 
            // QuestionExitDelete
            // 
            this.QuestionExitDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionExitDelete.AutoSize = true;
            this.QuestionExitDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.QuestionExitDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestionExitDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionExitDelete.Location = new System.Drawing.Point(475, 6);
            this.QuestionExitDelete.Name = "QuestionExitDelete";
            this.QuestionExitDelete.Size = new System.Drawing.Size(31, 29);
            this.QuestionExitDelete.TabIndex = 5;
            this.QuestionExitDelete.Text = "X";
            this.QuestionExitDelete.Click += new System.EventHandler(this.QuestionExitDelete_Click);
            // 
            // ChangeShopButton
            // 
            this.ChangeShopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeShopButton.Location = new System.Drawing.Point(95, 136);
            this.ChangeShopButton.Name = "ChangeShopButton";
            this.ChangeShopButton.Size = new System.Drawing.Size(329, 33);
            this.ChangeShopButton.TabIndex = 3;
            this.ChangeShopButton.Text = "Цеха";
            this.ChangeShopButton.UseVisualStyleBackColor = true;
            this.ChangeShopButton.Click += new System.EventHandler(this.ChangeShopButton_Click);
            // 
            // ChangeBirdButton
            // 
            this.ChangeBirdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdButton.Location = new System.Drawing.Point(95, 87);
            this.ChangeBirdButton.Name = "ChangeBirdButton";
            this.ChangeBirdButton.Size = new System.Drawing.Size(329, 33);
            this.ChangeBirdButton.TabIndex = 2;
            this.ChangeBirdButton.Text = "Список птиц";
            this.ChangeBirdButton.UseVisualStyleBackColor = true;
            this.ChangeBirdButton.Click += new System.EventHandler(this.ChangeBird_Click);
            // 
            // Qpanelgreen
            // 
            this.Qpanelgreen.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Qpanelgreen.Location = new System.Drawing.Point(3, 50);
            this.Qpanelgreen.Name = "Qpanelgreen";
            this.Qpanelgreen.Size = new System.Drawing.Size(505, 10);
            this.Qpanelgreen.TabIndex = 1;
            // 
            // QuestionLabelDelete
            // 
            this.QuestionLabelDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabelDelete.AutoSize = true;
            this.QuestionLabelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabelDelete.Location = new System.Drawing.Point(128, 10);
            this.QuestionLabelDelete.Name = "QuestionLabelDelete";
            this.QuestionLabelDelete.Size = new System.Drawing.Size(260, 32);
            this.QuestionLabelDelete.TabIndex = 0;
            this.QuestionLabelDelete.Text = "С чем работаем?";
            // 
            // ChangeBirdPanel
            // 
            this.ChangeBirdPanel.BackColor = System.Drawing.Color.Teal;
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdLabelDate);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdTextDate);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdLabelBird2);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdTextBird);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdButtonC);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdLabelCount);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdTextCount);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdBoxBird);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdLabelBird);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdTextShop);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdLabelPs);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdLabelShop);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdTextPs);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdButtonD);
            this.ChangeBirdPanel.Controls.Add(this.ChangeBirdButtonE);
            this.ChangeBirdPanel.Location = new System.Drawing.Point(3, 0);
            this.ChangeBirdPanel.Name = "ChangeBirdPanel";
            this.ChangeBirdPanel.Size = new System.Drawing.Size(942, 532);
            this.ChangeBirdPanel.TabIndex = 25;
            this.ChangeBirdPanel.Visible = false;
            // 
            // ChangeBirdLabelCount
            // 
            this.ChangeBirdLabelCount.AutoSize = true;
            this.ChangeBirdLabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdLabelCount.Location = new System.Drawing.Point(59, 314);
            this.ChangeBirdLabelCount.Name = "ChangeBirdLabelCount";
            this.ChangeBirdLabelCount.Size = new System.Drawing.Size(146, 25);
            this.ChangeBirdLabelCount.TabIndex = 23;
            this.ChangeBirdLabelCount.Text = "Колличество";
            // 
            // ChangeBirdTextCount
            // 
            this.ChangeBirdTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdTextCount.Location = new System.Drawing.Point(371, 308);
            this.ChangeBirdTextCount.Name = "ChangeBirdTextCount";
            this.ChangeBirdTextCount.Size = new System.Drawing.Size(477, 34);
            this.ChangeBirdTextCount.TabIndex = 22;
            // 
            // ChangeBirdBoxBird
            // 
            this.ChangeBirdBoxBird.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeBirdBoxBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdBoxBird.FormattingEnabled = true;
            this.ChangeBirdBoxBird.Location = new System.Drawing.Point(441, 66);
            this.ChangeBirdBoxBird.Name = "ChangeBirdBoxBird";
            this.ChangeBirdBoxBird.Size = new System.Drawing.Size(477, 37);
            this.ChangeBirdBoxBird.TabIndex = 21;
            ;
            // 
            // ChangeBirdLabelBird
            // 
            this.ChangeBirdLabelBird.AutoSize = true;
            this.ChangeBirdLabelBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdLabelBird.Location = new System.Drawing.Point(647, 27);
            this.ChangeBirdLabelBird.Name = "ChangeBirdLabelBird";
            this.ChangeBirdLabelBird.Size = new System.Drawing.Size(76, 25);
            this.ChangeBirdLabelBird.TabIndex = 20;
            this.ChangeBirdLabelBird.Text = "Птица";
            // 
            // ChangeBirdTextShop
            // 
            this.ChangeBirdTextShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeBirdTextShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdTextShop.FormattingEnabled = true;
            this.ChangeBirdTextShop.Location = new System.Drawing.Point(13, 66);
            this.ChangeBirdTextShop.Name = "ChangeBirdTextShop";
            this.ChangeBirdTextShop.Size = new System.Drawing.Size(402, 37);
            this.ChangeBirdTextShop.TabIndex = 19;
            this.ChangeBirdTextShop.SelectedIndexChanged += new EventHandler(ChangeBird_SelectedIndexChanged);
            // 
            // ChangeBirdLabelPs
            // 
            this.ChangeBirdLabelPs.AutoSize = true;
            this.ChangeBirdLabelPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdLabelPs.Location = new System.Drawing.Point(60, 386);
            this.ChangeBirdLabelPs.Name = "ChangeBirdLabelPs";
            this.ChangeBirdLabelPs.Size = new System.Drawing.Size(140, 25);
            this.ChangeBirdLabelPs.TabIndex = 18;
            this.ChangeBirdLabelPs.Text = "Примечание";
            // 
            // ChangeBirdLabelShop
            // 
            this.ChangeBirdLabelShop.AutoSize = true;
            this.ChangeBirdLabelShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdLabelShop.Location = new System.Drawing.Point(190, 25);
            this.ChangeBirdLabelShop.Name = "ChangeBirdLabelShop";
            this.ChangeBirdLabelShop.Size = new System.Drawing.Size(50, 25);
            this.ChangeBirdLabelShop.TabIndex = 14;
            this.ChangeBirdLabelShop.Text = "Цех";
            // 
            // ChangeBirdTextPs
            // 
            this.ChangeBirdTextPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdTextPs.Location = new System.Drawing.Point(371, 380);
            this.ChangeBirdTextPs.Name = "ChangeBirdTextPs";
            this.ChangeBirdTextPs.Size = new System.Drawing.Size(477, 34);
            this.ChangeBirdTextPs.TabIndex = 9;
            // 
            // ChangeBirdButtonD
            // 
            this.ChangeBirdButtonD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeBirdButtonD.BackColor = System.Drawing.Color.LawnGreen;
            this.ChangeBirdButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdButtonD.ForeColor = System.Drawing.Color.DarkBlue;
            this.ChangeBirdButtonD.Location = new System.Drawing.Point(529, 485);
            this.ChangeBirdButtonD.Name = "ChangeBirdButtonD";
            this.ChangeBirdButtonD.Size = new System.Drawing.Size(202, 36);
            this.ChangeBirdButtonD.TabIndex = 7;
            this.ChangeBirdButtonD.Text = "Удалить";
            this.ChangeBirdButtonD.UseVisualStyleBackColor = false;
            this.ChangeBirdButtonD.Click += new System.EventHandler(this.ChangeBirdButtonD_Click);
            // 
            // ChangeBirdButtonE
            // 
            this.ChangeBirdButtonE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeBirdButtonE.BackColor = System.Drawing.Color.LawnGreen;
            this.ChangeBirdButtonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdButtonE.ForeColor = System.Drawing.Color.DarkBlue;
            this.ChangeBirdButtonE.Location = new System.Drawing.Point(737, 485);
            this.ChangeBirdButtonE.Name = "ChangeBirdButtonE";
            this.ChangeBirdButtonE.Size = new System.Drawing.Size(202, 36);
            this.ChangeBirdButtonE.TabIndex = 8;
            this.ChangeBirdButtonE.Text = "Отмена";
            this.ChangeBirdButtonE.UseVisualStyleBackColor = false;
            this.ChangeBirdButtonE.Click += new System.EventHandler(this.ChangeBirdButtonE_Click);
            // 
            // ChangeBirdButtonC
            // 
            this.ChangeBirdButtonC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeBirdButtonC.BackColor = System.Drawing.Color.LawnGreen;
            this.ChangeBirdButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdButtonC.ForeColor = System.Drawing.Color.DarkBlue;
            this.ChangeBirdButtonC.Location = new System.Drawing.Point(317, 485);
            this.ChangeBirdButtonC.Name = "ChangeBirdButtonC";
            this.ChangeBirdButtonC.Size = new System.Drawing.Size(202, 36);
            this.ChangeBirdButtonC.TabIndex = 24;
            this.ChangeBirdButtonC.Text = "Изменить";
            this.ChangeBirdButtonC.UseVisualStyleBackColor = false;
            this.ChangeBirdButtonC.Click += new System.EventHandler(this.ChangeBirdButtonC_Click);
            // 
            // ChangeBirdLabelBird2
            // 
            this.ChangeBirdLabelBird2.AutoSize = true;
            this.ChangeBirdLabelBird2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdLabelBird2.Location = new System.Drawing.Point(59, 163);
            this.ChangeBirdLabelBird2.Name = "ChangeBirdLabelBird2";
            this.ChangeBirdLabelBird2.Size = new System.Drawing.Size(76, 25);
            this.ChangeBirdLabelBird2.TabIndex = 26;
            this.ChangeBirdLabelBird2.Text = "Птица";
            // 
            // ChangeBirdTextBird
            // 
            this.ChangeBirdTextBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdTextBird.Location = new System.Drawing.Point(371, 157);
            this.ChangeBirdTextBird.Name = "ChangeBirdTextBird";
            this.ChangeBirdTextBird.Size = new System.Drawing.Size(477, 34);
            this.ChangeBirdTextBird.TabIndex = 25;
            // 
            // ChangeBirdTextDate
            // 
            this.ChangeBirdTextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdTextDate.Location = new System.Drawing.Point(371, 235);
            this.ChangeBirdTextDate.Name = "ChangeBirdTextDate";
            this.ChangeBirdTextDate.Size = new System.Drawing.Size(477, 34);
            this.ChangeBirdTextDate.TabIndex = 27;
            this.ChangeBirdTextDate.Format = DateTimePickerFormat.Custom;
            this.ChangeBirdTextDate.CustomFormat = "yyyy/MM/dd";
            // 
            // ChangeBirdLabelDate
            // 
            this.ChangeBirdLabelDate.AutoSize = true;
            this.ChangeBirdLabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBirdLabelDate.Location = new System.Drawing.Point(59, 243);
            this.ChangeBirdLabelDate.Name = "ChangeBirdLabelDate";
            this.ChangeBirdLabelDate.Size = new System.Drawing.Size(193, 25);
            this.ChangeBirdLabelDate.TabIndex = 28;
            this.ChangeBirdLabelDate.Text = "Дата вылупления";
            
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 652);
            this.Controls.Add(this.ManagementMainPanel);
            this.Name = "Management";
            this.Text = "Программа контроля за производством";
            this.ManagementMainPanel.ResumeLayout(false);
            this.ManagementMainPanel.PerformLayout();
            this.ManagementCentralPanel.ResumeLayout(false);
            this.ManagementCentralPanel.PerformLayout();
            this.AddEggPanel.ResumeLayout(false);
            this.AddEggPanel.PerformLayout();
            this.ShopAddPanel.ResumeLayout(false);
            this.ShopAddPanel.PerformLayout();
            this.ManagementAddPanel.ResumeLayout(false);
            this.ManagementAddPanel.PerformLayout();
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            this.ChangeShopPanel.ResumeLayout(false);
            this.ChangeShopPanel.PerformLayout();
            this.ManagementLeftPanel.ResumeLayout(false);
            this.ManagementLeftPanel.PerformLayout();
            this.ManagementRightPanel.ResumeLayout(false);
            this.ManagementTopPanel.ResumeLayout(false);
            this.ManagementTopPanel.PerformLayout();
            this.QuestionPanelDelete.ResumeLayout(false);
            this.QuestionPanelDelete.PerformLayout();
            this.ChangeBirdPanel.ResumeLayout(false);
            this.ChangeBirdPanel.PerformLayout();
            this.ResumeLayout(false);



            #endregion

            #region MONITORING FORM CREATED
            this.MonitoringMainPanel = new System.Windows.Forms.Panel();
            this.MonitoringLeftPanel = new System.Windows.Forms.Panel();
            this.MonitoringMenuLabel = new System.Windows.Forms.Label();
            this.MonitoringHistoryButton = new System.Windows.Forms.Button();
            this.MonitoringMonitoringButton = new System.Windows.Forms.Button();
            this.MonitoringManagementButton = new System.Windows.Forms.Button();
            this.MonitoringMainButton = new System.Windows.Forms.Button();
            this.MonitoringRightPanel = new System.Windows.Forms.Panel();
            this.MonitoringShopBox = new System.Windows.Forms.ComboBox();
            this.MonitoringShopsCheckBoxPanel = new System.Windows.Forms.Panel();
            this.MonitoringCheckBoxBird = new System.Windows.Forms.CheckedListBox();
            this.MonitoringShopLabel = new System.Windows.Forms.Label();
            this.MonitoringCentralPanel = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.MonitoringHideMenu = new System.Windows.Forms.Label();
            this.MonitoringTopPanel = new System.Windows.Forms.Panel();
            this.MonitoringMonitorinLabel = new System.Windows.Forms.Label();
            this.MonitoringMainPanel.SuspendLayout();
            this.MonitoringLeftPanel.SuspendLayout();
            this.MonitoringRightPanel.SuspendLayout();
            this.MonitoringShopsCheckBoxPanel.SuspendLayout();
            this.MonitoringCentralPanel.SuspendLayout();
            this.MonitoringTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonitoringMainPanel
            // 
            
            this.MonitoringMainPanel.Controls.Add(this.MonitoringCentralPanel);
            this.MonitoringMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonitoringMainPanel.Location = new System.Drawing.Point(0, 0);
            this.MonitoringMainPanel.Name = "MonitoringMainPanel";
            this.MonitoringMainPanel.Size = new System.Drawing.Size(1360, 599);
            this.MonitoringMainPanel.TabIndex = 0;
            // 
            // MonitoringLeftPanel
            // 
            this.MonitoringLeftPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.MonitoringLeftPanel.Controls.Add(this.MonitoringMenuLabel);
            this.MonitoringLeftPanel.Controls.Add(this.MonitoringHistoryButton);
            this.MonitoringLeftPanel.Controls.Add(this.MonitoringMonitoringButton);
            this.MonitoringLeftPanel.Controls.Add(this.MonitoringManagementButton);
            this.MonitoringLeftPanel.Controls.Add(this.MonitoringMainButton);
            this.MonitoringLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MonitoringLeftPanel.Location = new System.Drawing.Point(0, 80);
            this.MonitoringLeftPanel.Name = "MonitoringLeftPanel";
            this.MonitoringLeftPanel.Size = new System.Drawing.Size(200, 519);
            this.MonitoringLeftPanel.TabIndex = 6;
            // 
            // MonitoringMenuLabel
            // 
            this.MonitoringMenuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MonitoringMenuLabel.AutoSize = true;
            this.MonitoringMenuLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MonitoringMenuLabel.Location = new System.Drawing.Point(28, 3);
            this.MonitoringMenuLabel.Name = "MonitoringMenuLabel";
            this.MonitoringMenuLabel.Size = new System.Drawing.Size(124, 46);
            this.MonitoringMenuLabel.TabIndex = 3;
            this.MonitoringMenuLabel.Text = "Меню";
            // 
            // MonitoringHistoryButton
            // 
            this.MonitoringHistoryButton.Location = new System.Drawing.Point(12, 211);
            this.MonitoringHistoryButton.Name = "MonitoringHistoryButton";
            this.MonitoringHistoryButton.Size = new System.Drawing.Size(165, 33);
            this.MonitoringHistoryButton.TabIndex = 2;
            this.MonitoringHistoryButton.Text = "Хронология";
            this.MonitoringHistoryButton.UseVisualStyleBackColor = true;
            this.MonitoringHistoryButton.Click += new System.EventHandler(this.MonitoringHistoryButton_Click);
            // 
            // MonitoringMonitoringButton
            // 
            this.MonitoringMonitoringButton.Location = new System.Drawing.Point(12, 162);
            this.MonitoringMonitoringButton.Name = "MonitoringMonitoringButton";
            this.MonitoringMonitoringButton.Size = new System.Drawing.Size(165, 33);
            this.MonitoringMonitoringButton.TabIndex = 2;
            this.MonitoringMonitoringButton.Text = "Мониторинг";
            this.MonitoringMonitoringButton.UseVisualStyleBackColor = true;
            // 
            // MonitoringManagementButton
            // 
            this.MonitoringManagementButton.Location = new System.Drawing.Point(12, 112);
            this.MonitoringManagementButton.Name = "MonitoringManagementButton";
            this.MonitoringManagementButton.Size = new System.Drawing.Size(165, 33);
            this.MonitoringManagementButton.TabIndex = 2;
            this.MonitoringManagementButton.Text = "Управление";
            this.MonitoringManagementButton.UseVisualStyleBackColor = true;
            this.MonitoringManagementButton.Click += new System.EventHandler(this.MonitoringManagementButton_Click);
            // 
            // MonitoringMainButton
            // 
            this.MonitoringMainButton.Location = new System.Drawing.Point(12, 61);
            this.MonitoringMainButton.Name = "MonitoringMainButton";
            this.MonitoringMainButton.Size = new System.Drawing.Size(165, 33);
            this.MonitoringMainButton.TabIndex = 2;
            this.MonitoringMainButton.Text = "Главная";
            this.MonitoringMainButton.UseVisualStyleBackColor = true;
            this.MonitoringMainButton.Click += new System.EventHandler(this.MonitoringMainButton_Click);
            // 
            // MonitoringRightPanel
            // 
            this.MonitoringRightPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.MonitoringRightPanel.Controls.Add(this.MonitoringShopBox);
            this.MonitoringRightPanel.Controls.Add(this.MonitoringShopsCheckBoxPanel);
            this.MonitoringRightPanel.Controls.Add(this.MonitoringShopLabel);
            this.MonitoringRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MonitoringRightPanel.Location = new System.Drawing.Point(1160, 80);
            this.MonitoringRightPanel.Name = "MonitoringRightPanel";
            this.MonitoringRightPanel.Size = new System.Drawing.Size(200, 519);
            this.MonitoringRightPanel.TabIndex = 4;
            // 
            // MonitoringShopBox
            // 
            this.MonitoringShopBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonitoringShopBox.FormattingEnabled = true;
            this.MonitoringShopBox.Location = new System.Drawing.Point(6, 16);
            this.MonitoringShopBox.Name = "MonitoringShopBox";
            this.MonitoringShopBox.Size = new System.Drawing.Size(188, 33);
            this.MonitoringShopBox.TabIndex = 4;
            this.MonitoringShopBox.SelectedValueChanged += MonitoringShopBox_SelectedValueChanged;
            // 
            // MonitoringShopsCheckBoxPanel
            // 
            this.MonitoringShopsCheckBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoringShopsCheckBoxPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.MonitoringShopsCheckBoxPanel.Controls.Add(this.MonitoringCheckBoxBird);
            this.MonitoringShopsCheckBoxPanel.Location = new System.Drawing.Point(6, 110);
            this.MonitoringShopsCheckBoxPanel.Name = "MonitoringShopsCheckBoxPanel";
            this.MonitoringShopsCheckBoxPanel.Size = new System.Drawing.Size(191, 406);
            this.MonitoringShopsCheckBoxPanel.TabIndex = 3;
            // 
            // MonitoringCheckBoxBird
            // 
            this.MonitoringCheckBoxBird.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MonitoringCheckBoxBird.CheckOnClick = true;
            this.MonitoringCheckBoxBird.FormattingEnabled = true;
            this.MonitoringCheckBoxBird.Location = new System.Drawing.Point(3, 3);
            this.MonitoringCheckBoxBird.MultiColumn = true;
            this.MonitoringCheckBoxBird.Name = "MonitoringCheckBoxBird";
            this.MonitoringCheckBoxBird.Size = new System.Drawing.Size(185, 395);
            this.MonitoringCheckBoxBird.TabIndex = 0;
            this.MonitoringCheckBoxBird.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MonitoringCheckBoxBird_ItemCheck);
            // 
            // MonitoringShopLabel
            // 
            this.MonitoringShopLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MonitoringShopLabel.AutoSize = true;
            this.MonitoringShopLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitoringShopLabel.Location = new System.Drawing.Point(18, 61);
            this.MonitoringShopLabel.Name = "MonitoringShopLabel";
            this.MonitoringShopLabel.Size = new System.Drawing.Size(161, 46);
            this.MonitoringShopLabel.TabIndex = 2;
            this.MonitoringShopLabel.Text = "Птица:";
            this.MonitoringShopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonitoringCentralPanel
            // 
            this.MonitoringCentralPanel.BackColor = System.Drawing.Color.LightCyan;
            this.MonitoringMainPanel.Controls.Add(this.MonitoringLeftPanel);
            this.MonitoringMainPanel.Controls.Add(this.MonitoringRightPanel);
            this.MonitoringMainPanel.Controls.Add(this.MonitoringTopPanel);
            this.MonitoringCentralPanel.Controls.Add(this.cartesianChart1);
            this.MonitoringCentralPanel.Controls.Add(this.MonitoringHideMenu);
            this.MonitoringCentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonitoringCentralPanel.Location = new System.Drawing.Point(0, 80);
            this.MonitoringCentralPanel.Name = "MonitoringCentralPanel";
            this.MonitoringCentralPanel.Size = new System.Drawing.Size(1360, 519);
            this.MonitoringCentralPanel.TabIndex = 3;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = DockStyle.Fill;
            this.cartesianChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartesianChart1.Location = new System.Drawing.Point(206, 6);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(948, 501);
            this.cartesianChart1.TabIndex = 5;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // MonitoringHideMenu
            // 
            this.MonitoringHideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MonitoringHideMenu.AutoSize = true;
            this.MonitoringHideMenu.BackColor = System.Drawing.Color.Lime;
            this.MonitoringHideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonitoringHideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonitoringHideMenu.Location = new System.Drawing.Point(1, 196);
            this.MonitoringHideMenu.Name = "MonitoringHideMenu";
            this.MonitoringHideMenu.Size = new System.Drawing.Size(18, 100);
            this.MonitoringHideMenu.TabIndex = 4;
            this.MonitoringHideMenu.Text = ".\r\n.\r\n.\r\n.";
            // 
            // MonitoringTopPanel
            // 
            this.MonitoringTopPanel.BackColor = System.Drawing.Color.LawnGreen;
            this.MonitoringTopPanel.Controls.Add(this.MonitoringMonitorinLabel);
            this.MonitoringTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonitoringTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MonitoringTopPanel.Name = "MonitoringTopPanel";
            this.MonitoringTopPanel.Size = new System.Drawing.Size(1360, 80);
            this.MonitoringTopPanel.TabIndex = 5;
            // 
            // MonitoringMonitorinLabel
            // 
            this.MonitoringMonitorinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoringMonitorinLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitoringMonitorinLabel.Location = new System.Drawing.Point(572, 9);
            this.MonitoringMonitorinLabel.Name = "MonitoringMonitorinLabel";
            this.MonitoringMonitorinLabel.Size = new System.Drawing.Size(281, 46);
            this.MonitoringMonitorinLabel.TabIndex = 1;
            this.MonitoringMonitorinLabel.Text = "Мониторинг";
            this.MonitoringMonitorinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 652);
            this.Controls.Add(this.MonitoringMainPanel);
            this.Name = "Monitoring";
            this.Text = "Программа контроля за производством";
            this.MonitoringMainPanel.ResumeLayout(false);
            this.MonitoringLeftPanel.ResumeLayout(false);
            this.MonitoringLeftPanel.PerformLayout();
            this.MonitoringRightPanel.ResumeLayout(false);
            this.MonitoringRightPanel.PerformLayout();
            this.MonitoringShopsCheckBoxPanel.ResumeLayout(false);
            this.MonitoringCentralPanel.ResumeLayout(false);
            this.MonitoringCentralPanel.PerformLayout();
            this.MonitoringTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);


            #endregion

            #region HISTORY FORM CREATED
            this.HistoryMainPanel = new System.Windows.Forms.Panel();
            this.HistoryCentralPanel = new System.Windows.Forms.Panel();
            this.HistoryRightPanel = new System.Windows.Forms.Panel();
            this.HistoryLeftPanel = new System.Windows.Forms.Panel();
            this.HistoryMenuLabel = new System.Windows.Forms.Label();
            this.HistoryManagementPanel = new System.Windows.Forms.Panel();
            this.HistoryHistoryButton = new System.Windows.Forms.Button();
            this.HistoryMonitoringButton = new System.Windows.Forms.Button();
            this.HistoryManagementButton = new System.Windows.Forms.Button();
            this.HistoryMainButton = new System.Windows.Forms.Button();
            this.HistoryTopPanel = new System.Windows.Forms.Panel();
            this.HistoryHistoryLabel = new System.Windows.Forms.Label();
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.HistorySearchBox = new System.Windows.Forms.TextBox();
            this.HistorySearchButton = new System.Windows.Forms.Button();
            this.HistorySearchLabel = new System.Windows.Forms.Label();
            this.HistoryMainPanel.SuspendLayout();
            this.HistoryCentralPanel.SuspendLayout();
            this.HistoryRightPanel.SuspendLayout();
            this.HistoryLeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryMainPanel
            // 
            this.HistoryMainPanel.Controls.Add(this.HistoryCentralPanel);
            this.HistoryMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryMainPanel.Location = new System.Drawing.Point(0, 0);
            this.HistoryMainPanel.Name = "HistoryMainPanel";
            this.HistoryMainPanel.Size = new System.Drawing.Size(1389, 605);
            this.HistoryMainPanel.TabIndex = 0;
            this.HistoryMainPanel.Visible = false;
            // 
            // HistoryCentralPanel
            // 
            this.HistoryCentralPanel.Controls.Add(this.HistoryListBox);
            this.HistoryCentralPanel.Controls.Add(this.HistoryRightPanel);
            this.HistoryCentralPanel.Controls.Add(this.HistoryLeftPanel);
            this.HistoryCentralPanel.Controls.Add(this.HistoryTopPanel);
            this.HistoryCentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryCentralPanel.Location = new System.Drawing.Point(0, 0);
            this.HistoryCentralPanel.Name = "HistoryCentralPanel";
            this.HistoryCentralPanel.Size = new System.Drawing.Size(1389, 605);
            this.HistoryCentralPanel.TabIndex = 0;
            // 
            // HistoryRightPanel
            // 
            this.HistoryRightPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.HistoryRightPanel.Controls.Add(this.HistorySearchLabel);
            this.HistoryRightPanel.Controls.Add(this.HistorySearchButton);
            this.HistoryRightPanel.Controls.Add(this.HistorySearchBox);
            this.HistoryRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HistoryRightPanel.Location = new System.Drawing.Point(1177, 80);
            this.HistoryRightPanel.Name = "HistoryRightPanel";
            this.HistoryRightPanel.Size = new System.Drawing.Size(212, 525);
            this.HistoryRightPanel.TabIndex = 10;
            // 
            // HistoryLeftPanel
            // 
            this.HistoryLeftPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.HistoryLeftPanel.Controls.Add(this.HistoryMenuLabel);
            this.HistoryLeftPanel.Controls.Add(this.HistoryManagementPanel);
            this.HistoryLeftPanel.Controls.Add(this.HistoryHistoryButton);
            this.HistoryLeftPanel.Controls.Add(this.HistoryMonitoringButton);
            this.HistoryLeftPanel.Controls.Add(this.HistoryManagementButton);
            this.HistoryLeftPanel.Controls.Add(this.HistoryMainButton);
            this.HistoryLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HistoryLeftPanel.Location = new System.Drawing.Point(0, 80);
            this.HistoryLeftPanel.Name = "HistoryLeftPanel";
            this.HistoryLeftPanel.Size = new System.Drawing.Size(200, 525);
            this.HistoryLeftPanel.TabIndex = 12;
            // 
            // HistoryMenuLabel
            // 
            this.HistoryMenuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HistoryMenuLabel.AutoSize = true;
            this.HistoryMenuLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HistoryMenuLabel.Location = new System.Drawing.Point(28, 3);
            this.HistoryMenuLabel.Name = "HistoryMenuLabel";
            this.HistoryMenuLabel.Size = new System.Drawing.Size(124, 46);
            this.HistoryMenuLabel.TabIndex = 3;
            this.HistoryMenuLabel.Text = "Меню";
            // 
            // HistoryManagementPanel
            // 
            this.HistoryManagementPanel.Location = new System.Drawing.Point(200, 0);
            this.HistoryManagementPanel.Name = "HistoryManagementPanel";
            this.HistoryManagementPanel.Size = new System.Drawing.Size(1147, 599);
            this.HistoryManagementPanel.TabIndex = 2;
            // 
            // HistoryHistoryButton
            // 
            this.HistoryHistoryButton.Location = new System.Drawing.Point(12, 211);
            this.HistoryHistoryButton.Name = "HistoryHistoryButton";
            this.HistoryHistoryButton.Size = new System.Drawing.Size(165, 33);
            this.HistoryHistoryButton.TabIndex = 2;
            this.HistoryHistoryButton.Text = "Хронология";
            this.HistoryHistoryButton.UseVisualStyleBackColor = true;
            // 
            // HistoryMonitoringButton
            // 
            this.HistoryMonitoringButton.Location = new System.Drawing.Point(12, 162);
            this.HistoryMonitoringButton.Name = "HistoryMonitoringButton";
            this.HistoryMonitoringButton.Size = new System.Drawing.Size(165, 33);
            this.HistoryMonitoringButton.TabIndex = 2;
            this.HistoryMonitoringButton.Text = "Мониторинг";
            this.HistoryMonitoringButton.UseVisualStyleBackColor = true;
            this.HistoryMonitoringButton.Click += new System.EventHandler(this.HistoryMonitoringButton_Click);
            // 
            // HistoryManagementButton
            // 
            this.HistoryManagementButton.Location = new System.Drawing.Point(12, 112);
            this.HistoryManagementButton.Name = "HistoryManagementButton";
            this.HistoryManagementButton.Size = new System.Drawing.Size(165, 33);
            this.HistoryManagementButton.TabIndex = 2;
            this.HistoryManagementButton.Text = "Управление";
            this.HistoryManagementButton.UseVisualStyleBackColor = true;
            this.HistoryManagementButton.Click += new System.EventHandler(this.HistoryManagementButton_Click);
            // 
            // HistoryMainButton
            // 
            this.HistoryMainButton.Location = new System.Drawing.Point(12, 61);
            this.HistoryMainButton.Name = "HistoryMainButton";
            this.HistoryMainButton.Size = new System.Drawing.Size(165, 33);
            this.HistoryMainButton.TabIndex = 2;
            this.HistoryMainButton.Text = "Главная";
            this.HistoryMainButton.UseVisualStyleBackColor = true;
            this.HistoryMainButton.Click += new System.EventHandler(this.HistoryMainButton_Click);
            // 
            // HistoryTopPanel
            // 
            this.HistoryTopPanel.BackColor = System.Drawing.Color.LawnGreen;
            this.HistoryTopPanel.Controls.Add(this.HistoryHistoryLabel);
            this.HistoryTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryTopPanel.Location = new System.Drawing.Point(0, 0);
            this.HistoryTopPanel.Name = "HistoryTopPanel";
            this.HistoryTopPanel.Size = new System.Drawing.Size(1389, 80);
            this.HistoryTopPanel.TabIndex = 11;
            // 
            // HistoryHistoryLabel
            // 
            this.HistoryHistoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HistoryHistoryLabel.AutoSize = true;
            this.HistoryHistoryLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryHistoryLabel.Location = new System.Drawing.Point(632, 9);
            this.HistoryHistoryLabel.Name = "HistoryHistoryLabel";
            this.HistoryHistoryLabel.Size = new System.Drawing.Size(227, 46);
            this.HistoryHistoryLabel.TabIndex = 1;
            this.HistoryHistoryLabel.Text = "Хронология";
            this.HistoryHistoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 31;
            this.HistoryListBox.Location = new System.Drawing.Point(200, 80);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(977, 525);
            this.HistoryListBox.TabIndex = 13;
            // 
            // HistorySearchBox
            // 
            this.HistorySearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistorySearchBox.Location = new System.Drawing.Point(4, 78);
            this.HistorySearchBox.Name = "HistorySearchBox";
            this.HistorySearchBox.Size = new System.Drawing.Size(203, 38);
            this.HistorySearchBox.TabIndex = 0;
            // 
            // HistorySearchButton
            // 
            this.HistorySearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistorySearchButton.Location = new System.Drawing.Point(16, 122);
            this.HistorySearchButton.Name = "HistorySearchButton";
            this.HistorySearchButton.Size = new System.Drawing.Size(184, 38);
            this.HistorySearchButton.TabIndex = 1;
            this.HistorySearchButton.Text = "Поиск";
            this.HistorySearchButton.UseVisualStyleBackColor = true;
            this.HistorySearchButton.Click += new System.EventHandler(this.HistorySearchButton_Click);
            // 
            // HistorySearchLabel
            // 
            this.HistorySearchLabel.AutoSize = true;
            this.HistorySearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistorySearchLabel.Location = new System.Drawing.Point(33, 17);
            this.HistorySearchLabel.Name = "HistorySearchLabel";
            this.HistorySearchLabel.Size = new System.Drawing.Size(148, 58);
            this.HistorySearchLabel.TabIndex = 2;
            this.HistorySearchLabel.Text = "Поиск \r\nпо записям";
            this.HistorySearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 605);
            this.Controls.Add(this.HistoryMainPanel);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.HistoryMainPanel.ResumeLayout(false);
            this.HistoryCentralPanel.ResumeLayout(false);
            this.HistoryRightPanel.ResumeLayout(false);
            this.HistoryRightPanel.PerformLayout();
            this.HistoryLeftPanel.ResumeLayout(false);
            this.HistoryLeftPanel.PerformLayout();
            this.HistoryTopPanel.ResumeLayout(false);
            this.HistoryTopPanel.PerformLayout();
            this.ResumeLayout(false);
            #endregion

            db.WorkShops.Load();
            db.Birds.Load();
            var shops = db.WorkShops.ToList();
            var birds = db.Birds.ToList();
            
            ((ListBox)checkedListBox1).DataSource = shops;
            ((ListBox)checkedListBox1).ValueMember = "WorkShopId";
            ((ListBox)checkedListBox1).DisplayMember = "Name";
            checkedListBox1.ItemCheck += checkedListBox1_SelectedIndecesChanged;
        }
        private void checkedListBox1_SelectedIndecesChanged(object sender, ItemCheckEventArgs e)
        {
            db.Birds.Load();
            var birds = (from Bird in db.Birds where Bird.WorkShop.WorkShopId == (int)checkedListBox1.SelectedValue select Bird).ToList();
            var bird = birds.Where(p => p.Count > 0).ToList();
            var birdbird = db.Birds.Where(p => p.WorkShop.WorkShopId == (int)checkedListBox1.SelectedValue).ToList();
            var Shopitems = ShopListBox.Items;
            if(e.NewValue == CheckState.Checked)
            {
                foreach (var b in birdbird)
                {
                    ShopListBox.Items.Add(b.WorkShop);
                    BirdListBox1.Items.Add(b.Name);
                    CountListBox.Items.Add(b.Count);
                    AgeListBox.Items.Add(AgeCount(b.Age));
                }
            }
            else
            {
                foreach (var b in birdbird)
                {
                    ShopListBox.Items.Remove(b.WorkShop);
                    BirdListBox1.Items.Remove(b.Name);
                    CountListBox.Items.Remove(b.Count);
                    AgeListBox.Items.Remove(AgeCount(b.Age));
                }
            }
        }

        public int AgeCount(DateTime date)
        {

            DateTime dateTime = DateTime.Today;
            int secInAMin = 60;
            int secInAnHour = 60 * secInAMin;
            int secInADay = 24 * secInAnHour;
            double secInAYear = (int)365.25 * secInADay;

            double ageSeconds = (double)(date.Year * secInAYear) +
                           (date.DayOfYear * secInADay) +
                           (date.Hour * secInAnHour) +
                           (date.Minute * secInAMin) +
                           date.Second;
            double totalSeconds = (double)(dateTime.Year * secInAYear) +
                           (dateTime.DayOfYear * secInADay) +
                           (dateTime.Hour * secInAnHour) +
                           (dateTime.Minute * secInAMin) +
                           dateTime.Second;
            double ageTime = totalSeconds - ageSeconds;
            return Convert.ToInt32(ageTime / secInADay);
        }
        public void ManagementButton_Click(object sender, EventArgs e)
        {
            MainMainPanel.Visible = false;
            ManagementMainPanel.Visible = true;
            MonitoringMainPanel.Visible = false;
        }

        private void MonitoringButton_Click(object sender, EventArgs e)
        {
            db.WorkShops.Load();
            var shops = db.WorkShops.ToList();
            MonitoringShopBox.ValueMember = "WorkShopId";
            MonitoringShopBox.DisplayMember = "Name";
            MonitoringShopBox.DataSource = shops;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            MainMainPanel.Visible = false;
            ManagementMainPanel.Visible = false;
            MonitoringMainPanel.Visible = true;
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            db.ManagementHistories.Load();
            var history = db.ManagementHistories;
            foreach (var h in history)
            {
                HistoryListBox.Items.Add("\n" + h.Date + "  ");
                HistoryListBox.Items.Add(h.HistoryEvent + "  ");
                if (!string.IsNullOrEmpty(h.PsEvent))
                    HistoryListBox.Items.Add(h.PsEvent + "\n");
                else
                    HistoryListBox.Items.Add("\n");
                MainMainPanel.Visible = false;
                ManagementMainPanel.Visible = false;
                MonitoringMainPanel.Visible = false;
                HistoryMainPanel.Visible = true;
            }
        }
        #endregion

        #region MANAGEMENT FORM

        private void ManagementMainButton_Click(object sender, EventArgs e)
        {
            var shops = db.WorkShops.ToList();
            var birds = db.Birds.ToList();
            ((ListBox)checkedListBox1).DataSource = shops;
            ((ListBox)checkedListBox1).ValueMember = "WorkShopId";
            ((ListBox)checkedListBox1).DisplayMember = "Name";
            MainMainPanel.Visible = true;
            ManagementMainPanel.Visible = false;
            MonitoringMainPanel.Visible = false;
            HistoryMainPanel.Visible = false;
        }

        private void ManagementMonitoringButton_Click(object sender, EventArgs e)
        {
            db.WorkShops.Load();
            var shops = db.WorkShops.ToList();
            MonitoringShopBox.ValueMember = "WorkShopId";
            MonitoringShopBox.DisplayMember = "Name";
            MonitoringShopBox.DataSource = shops;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            MainMainPanel.Visible = false;
            ManagementMainPanel.Visible = false;
            MonitoringMainPanel.Visible = true;
            HistoryMainPanel.Visible = false;
        }

        private void ManagementHistoryButton_Click(object sender, EventArgs e)
        {
            db.ManagementHistories.Load();
            var history = db.ManagementHistories;
            foreach (var h in history)
            {
                HistoryListBox.Items.Add("\n" + h.Date + "  ");
                HistoryListBox.Items.Add(h.HistoryEvent + "  ");
                if (!string.IsNullOrEmpty(h.PsEvent))
                    HistoryListBox.Items.Add(h.PsEvent + "\n");
                else
                    HistoryListBox.Items.Add("\n");
            }
            MainMainPanel.Visible = false;
            ManagementMainPanel.Visible = false;
            MonitoringMainPanel.Visible = false;
            HistoryMainPanel.Visible = true;
        }

        public void ManagementHideMenu_Click(object sender, EventArgs e)
        {
            if (ManagementLeftPanel.Visible == true)
            {
                ManagementLeftPanel.Visible = false;
                ManagementHideMenu.Location = new System.Drawing.Point(1, 176);
            }
            else
            {
                ManagementLeftPanel.Visible = true;
                ManagementHideMenu.Location = new System.Drawing.Point(151, 176);
            }

        }

        /*
         Добавление элементов в базу данных
         */
        #region
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = true;
            AddEggPanel.Visible = false;
            ShopAddPanel.Visible = false;
            ManagementAddPanel.Visible = false;
            QuestionPanelDelete.Visible = false;
            ChangeShopPanel.Visible = false;
            ChangeBirdPanel.Visible = false;
        }
        private void CloseCreateButton_Click(object sender, MouseEventArgs e)
        {
            if (QuestionPanel.Visible == true)
            {
                QuestionPanel.Visible = false;
            }
        }
        private void AddBird_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = false;
            AddEggPanel.Visible = false;
            ShopAddPanel.Visible = false;
            ManagementAddPanel.Visible = true;
            QuestionPanelDelete.Visible = false;
            ChangeShopPanel.Visible = false;
            ChangeBirdPanel.Visible = false;

            db.WorkShops.Load();
            var WorkShops = db.WorkShops.ToList();
            BirdShopText.DisplayMember = "Name";
            BirdShopText.ValueMember = "WorkShopId";
            BirdShopText.DataSource = WorkShops;
                
            

        }
        private void AddShop_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = false;
            AddEggPanel.Visible = false;
            ShopAddPanel.Visible = true;
            ManagementAddPanel.Visible = false;
            QuestionPanelDelete.Visible = false;
            ChangeShopPanel.Visible = false;
            ChangeBirdPanel.Visible = false;
        }
        private void AddEgg_Click(object sender, EventArgs e)
        {
            db.WorkShops.Load();
            var workshop = db.WorkShops.ToList();
            EggShopText.ValueMember = "WorkShopId";
            EggShopText.DataSource = workshop;
            EggShopText.DisplayMember = "Name";
            EggBirdText.DisplayMember = "Name";




            QuestionPanel.Visible = false;
            AddEggPanel.Visible = true;
            ShopAddPanel.Visible = false;
            ManagementAddPanel.Visible = false;
            QuestionPanelDelete.Visible = false;
            ChangeShopPanel.Visible = false;
            ChangeBirdPanel.Visible = false;

        }
        void EggShopText_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Birds.Load();
            EggShopText.SelectedValueChanged += EggShopText_SelectedValueChanged;
        }

        private void EggShopText_SelectedValueChanged(object sender, EventArgs e)
        {
            db.Birds.Load();
            var birds = (from Bird in db.Birds where Bird.WorkShop.WorkShopId == (int)EggShopText.SelectedValue select Bird).ToList();
            EggBirdText.DataSource = birds;
        }

        private void SaveAddButton_Click(object sender, EventArgs e)
        {
            db.Birds.Load();
            db.WorkShops.Load();
            db.ManagementHistories.Load();
            Bird bird = new Bird();
            ManagementHistory ps = new ManagementHistory();
            if (!string.IsNullOrEmpty(BirdNameText.Text.ToString()))
                bird.Name = BirdNameText.Text;
            else
            {
                MessageBox.Show("Введите вид/породу птицы!");
                return;
            }
            
            bird.WorkShop = (WorkShop)BirdShopText.SelectedItem;
            bird.Age = (DateTime)BirdDateText.Value;
            if (!string.IsNullOrEmpty(BirdCountAge.Text.ToString()))
            {
                int a;
                if (int.TryParse(BirdCountAge.Text, out a))
                {
                    bird.Count = Convert.ToInt32(BirdCountAge.Text);
                }
                else
                {
                    MessageBox.Show("Неверный формат!", "Количество!");
                    return;
                }
            }

            else
            {
                MessageBox.Show("Введите количество!");
                return;
            }
            ps.Date = DateTime.Now;
            ps.HistoryEvent = $"В цех {(WorkShop)BirdShopText.SelectedItem} добавлены {BirdNameText.Text} вылупившиеся {(DateTime)BirdDateText.Value} в колличестве {Convert.ToInt32(BirdCountAge.Text)}.";
            if (!string.IsNullOrEmpty(BirdPsText.Text.ToString()))
            {
                ps.PsEvent = BirdPsText.Text.ToString();
            }
            db.Birds.Add(bird);
            db.ManagementHistories.Add(ps);
            db.SaveChanges();
            MessageBox.Show("Элемент добавлен!");
            BirdNameText.Text = "";
            BirdCountAge.Text = "";
            BirdPsText.Text = "";
            
            if (ManagementAddPanel.Visible == true)
            {
                ManagementAddPanel.Visible = false;
            }
        }

        private void ButtonAddCancel_Click(object sender, EventArgs e)
        {
            if (ManagementAddPanel.Visible == true)
            {
                ManagementAddPanel.Visible = false;
                BirdNameText.Text = "";
                BirdCountAge.Text = "";
                BirdPsText.Text = "";
            }
        }
        private void ShopAddButton_Click(object sender, EventArgs e)
        {
            db.WorkShops.Load();
            db.ManagementHistories.Load();
            ManagementHistory history = new ManagementHistory();
            WorkShop work = new WorkShop();
            if (!string.IsNullOrEmpty(ShopNameText.Text.ToString()))
                work.Name = ShopNameText.Text.ToString();
            else
            {
                MessageBox.Show("Введите название!");
                return;
            }
            history.Date = DateTime.Now;
            history.HistoryEvent = $"Добавлен цех {work.Name}.";
            if (!string.IsNullOrEmpty(ShopPsText.Text.ToString()))
                history.PsEvent = ShopPsText.Text.ToString();
            db.ManagementHistories.Add(history);
            db.WorkShops.Add(work);
            db.SaveChanges();
            MessageBox.Show("Элемент добавлен!");
            ShopNameText.Text = "";
            ShopAddPanel.Visible = false;
        }

        private void ShopCancelButton_Click(object sender, EventArgs e)
        {
            if (ShopAddPanel.Visible == true)
                ShopAddPanel.Visible = false;
        }

        private void EggAddButton_Click(object sender, EventArgs e)
        {
            db.Birds.Load();
            db.EggLayingQualities.Load();
            db.ManagementHistories.Load();
            EggLayingQualities egg = new EggLayingQualities();
            ManagementHistory history = new ManagementHistory();
            egg.Bird = (Bird)EggBirdText.SelectedItem;
            if (!string.IsNullOrEmpty(EggCountText.Text.ToString()))
            {
                int a;
                if (int.TryParse(EggCountText.Text, out a))
                {
                    egg.Count = Convert.ToInt32(EggCountText.Text);
                }
                else
                {
                    MessageBox.Show("Неверный формат!", "Количество!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введите количество!");
                return;
            }
            history.Date = DateTime.Now;
            history.HistoryEvent = $"В цехе {(WorkShop)EggShopText.SelectedItem} от {(Bird)EggBirdText.SelectedItem} было собрано {Convert.ToInt32(EggCountText.Text)} яиц.";
            if (!string.IsNullOrEmpty(EggPsText.Text))
                history.PsEvent = EggPsText.Text;
            egg.DateEgg = DateTime.Now;
            db.EggLayingQualities.Add(egg);
            db.ManagementHistories.Add(history);
            db.SaveChanges();
            MessageBox.Show("Запись добавлена!");
            EggCountText.Text = "";
            EggPsText.Text = "";
        }

        private void EggCancelButton_Click(object sender, EventArgs e)
        {
            if (AddEggPanel.Visible == true)
                AddEggPanel.Visible = false;
        }
        #endregion


        /*
         Изменение элементов в базе данных:
            Птицы
         */
        #region ChangeBird
        //Add ChangeShopPanel
        private void ChangeBird_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = false;
            AddEggPanel.Visible = false;
            ShopAddPanel.Visible = false;
            ManagementAddPanel.Visible = false;
            QuestionPanelDelete.Visible = false;
            ChangeShopPanel.Visible = false;
            ChangeBirdPanel.Visible = true;
            ChangeBirdPanel.Dock = DockStyle.Right;

            db.WorkShops.Load();
            var shops = db.WorkShops.ToList();
            ChangeBirdTextShop.ValueMember = "WorkShopId";
            ChangeBirdTextShop.DisplayMember = "Name";
            ChangeBirdTextShop.DataSource = shops;
            
        }
        void ChangeBird_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Birds.Load();
            var birds = (from Bird in db.Birds where Bird.WorkShop.WorkShopId == (int)ChangeBirdTextShop.SelectedValue select Bird).ToList();
            ChangeBirdBoxBird.ValueMember = "BirdId";
            ChangeBirdBoxBird.DisplayMember = "Name";
            ChangeBirdBoxBird.DataSource = birds;
            ChangeBirdTextShop.SelectedIndexChanged += ChangeBirdBoxBird_SelectedIndexChanged;
        }
        void ChangeBirdBoxBird_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBirdTextBird.Text = "";
            ChangeBirdTextDate.Value = DateTime.Now;
            ChangeBirdTextCount.Text = "";
            ChangeBirdBoxBird.SelectedIndexChanged += ChangeBirdBoxBird_TextUpdate;
        }

        void ChangeBirdBoxBird_TextUpdate(object sender, EventArgs e)
        {
            db.Birds.Load();
            int id = (int)ChangeBirdBoxBird.SelectedValue;
            var bird = (from Bird in db.Birds where Bird.BirdId == id select Bird).ToList();
            foreach (var b in bird)
            {
                ChangeBirdTextBird.Text = b.Name;
                ChangeBirdTextDate.Value = (DateTime)b.Age;
                ChangeBirdTextCount.Text = b.Count.ToString();
            }
        }
        void ChangeBirdButtonC_Click(object sender, EventArgs e)
        {
            db.Birds.Load();
            db.ManagementHistories.Load();
            ManagementHistory history = new ManagementHistory();
            var bird = db.Birds.Where(p => p.BirdId == (int)ChangeBirdBoxBird.SelectedValue).FirstOrDefault();
            int a;
            if (!int.TryParse(ChangeBirdTextCount.Text, out a))
            {
                MessageBox.Show("Введите колличество", "Неверный формат!");
                return;
            }
            if(bird.Name != ChangeBirdTextBird.Text || bird.Age != ChangeBirdTextDate.Value || bird.Count != Convert.ToInt32(ChangeBirdTextCount.Text))
            {
                if (!string.IsNullOrEmpty(ChangeBirdTextBird.Text))
                {
                    if(bird.Name != ChangeBirdTextBird.Text)
                    {
                        history.HistoryEvent += $"Птица {bird.Name} изменено на {ChangeBirdTextBird.Text} ";
                        bird.Name = ChangeBirdTextBird.Text;
                        db.Entry(bird).State = EntityState.Modified;
                    }
                    else
                        bird.Name = ChangeBirdTextBird.Text;
                }
                else
                {
                    MessageBox.Show("Введите вид/породу птицы!","Пустое значение!");
                    return;
                }
                if ((DateTime)bird.Age != (DateTime)ChangeBirdTextDate.Value)
                {
                    history.HistoryEvent += $"Дата вылупления {bird.Name} изменено на {ChangeBirdTextDate.Value} ";
                    bird.Age = ChangeBirdTextDate.Value;
                    db.Entry(bird).State = EntityState.Modified;
                }
                else
                    bird.Age = ChangeBirdTextDate.Value;
                if (!string.IsNullOrEmpty(ChangeBirdTextCount.Text))
                {
                    if (int.TryParse(ChangeBirdTextCount.Text, out a))
                    {
                        if (Convert.ToInt32(ChangeBirdTextCount.Text) != bird.Count)
                        {
                            history.HistoryEvent += $"Колличество {bird.Name} изменено с {bird.Count} на {ChangeBirdTextCount.Text}";
                            bird.Count = Convert.ToInt32(ChangeBirdTextCount.Text);
                            db.Entry(bird).State = EntityState.Modified;
                        }
                        else
                            bird.Count = Convert.ToInt32(ChangeBirdTextCount.Text);
                    }
                    else
                    {
                        MessageBox.Show("Введите колличество", "Неверный формат!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Введите колличество", "Пустое значение!");
                    return;
                }
                history.PsEvent = ChangeBirdTextPs.Text;
                history.Date = DateTime.Now;
                db.ManagementHistories.Add(history);
                MessageBox.Show("Изменения сохранены!");
                db.SaveChanges();
                ChangeBirdPanel.Visible = false;
            }
            

            
        }
        void ChangeBirdButtonD_Click(object sender, EventArgs e)
        {
            db.Birds.Load();
            var bird = db.Birds.Where(p => p.BirdId == (int)ChangeBirdBoxBird.SelectedValue).FirstOrDefault();
            db.Birds.Remove(bird);
            MessageBox.Show($"Запись {bird} удалена!", "Успех!");
            db.SaveChanges();
            ChangeBirdPanel.Visible = false;
        }
        void ChangeBirdButtonE_Click(object sender, EventArgs e)
        {
            ChangeBirdPanel.Visible = false;
        }
        private void QuestionExitDelete_Click(object sender, EventArgs e)
        {
            QuestionPanelDelete.Visible = false;
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            QuestionPanelDelete.Visible = true;
            QuestionPanel.Visible = false;
            AddEggPanel.Visible = false;
            ShopAddPanel.Visible = false;
            ManagementAddPanel.Visible = false;
            ChangeShopPanel.Visible = false;
            ChangeBirdPanel.Visible = false;
        }
        #endregion


        /*
         Изменение элементов в базе данных:
            Цеха
         */

        #region ChangeShop
        private void ChangeShopButton_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = false;
            AddEggPanel.Visible = false;
            ShopAddPanel.Visible = false;
            ManagementAddPanel.Visible = false;
            QuestionPanelDelete.Visible = false;
            ChangeShopPanel.Visible = true;
            ChangeBirdPanel.Visible = false;

            db.WorkShops.Load();
            var shops = db.WorkShops.ToList();
            ChangeShopBoxShop.ValueMember = "WorkShopId";
            ChangeShopBoxShop.DisplayMember = "Name";
            ChangeShopBoxShop.DataSource = shops;

        }

        private void ChangeShopBoxShop_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeShopTextShop.Text = "";
            ChangeShopBoxShop.SelectedValueChanged += ChangeShopBoxShop_SelectedValueChanged1;
        }

        private void ChangeShopBoxShop_SelectedValueChanged1(object sender, EventArgs e)
        {
            db.WorkShops.Load();
            var shop = (from WorkShop in db.WorkShops where WorkShop.WorkShopId == (int)ChangeShopBoxShop.SelectedValue select WorkShop).ToList();
            foreach(var s in shop)
            {
                ChangeShopTextShop.Text = s.Name;
            }
        }

        private void ChangeShopButtonC_Click(object sender, EventArgs e)
        {
            db.WorkShops.Load();
            db.ManagementHistories.Load();
            ManagementHistory history = new ManagementHistory();
            var shop = db.WorkShops.Where(p => p.WorkShopId == (int)ChangeShopBoxShop.SelectedValue).FirstOrDefault();
            if (!string.IsNullOrEmpty(ChangeShopTextShop.Text))
            {
                if(shop.Name != ChangeShopTextShop.Text)
                {
                    history.HistoryEvent = $"Цех {shop.Name} изменен на {ChangeShopTextShop.Text}";
                    shop.Name = ChangeShopTextShop.Text;
                    MessageBox.Show("Изменения сохранены!");
                }
            }
            else
            {
                MessageBox.Show("Введите название!");
                return;
            }
        }

        private void ChangeShopButtonD_Click(object sender, EventArgs e)
        {
            db.WorkShops.Load();
            db.EggLayingQualities.Load();
            db.ManagementHistories.Load();
            ManagementHistory history = new ManagementHistory();
            var shop = db.WorkShops.Where(p => p.WorkShopId == (int)ChangeShopBoxShop.SelectedValue).FirstOrDefault();
            history.Date = DateTime.Now;
            history.HistoryEvent = $"Цех {shop.Name} удален!";
            if (!string.IsNullOrEmpty(ChangeShopTextPs.Text))
            {
                history.PsEvent = ChangeShopTextPs.Text;
            }
            db.WorkShops.Remove(shop);
            db.SaveChanges();
            MessageBox.Show($"Цех {shop.Name} удален!");
            ChangeShopPanel.Visible = false;
        }

        private void ChangeShopButtonE_Click(object sender, EventArgs e)
        {
            ChangeShopPanel.Visible = false;
        }
        #endregion



        
        #region MANAGEMEN ELEMENTS
        private System.Windows.Forms.Panel ManagementMainPanel;
        private System.Windows.Forms.Panel ManagementRightPanel;
        private System.Windows.Forms.Panel ManagementTopPanel;
        private System.Windows.Forms.Panel ManagementCentralPanel;
        private System.Windows.Forms.Label Manage;
        private System.Windows.Forms.Panel ManagementLeftPanel;
        private System.Windows.Forms.Label Managementlabel2;
        private System.Windows.Forms.Panel ManagementManagementPanel;
        private System.Windows.Forms.Button ManagementHistoryButton;
        private System.Windows.Forms.Button ManagementMonitoringButton;
        private System.Windows.Forms.Button ManagementManagementButton;
        private System.Windows.Forms.Button ManagementMainButton;
        private System.Windows.Forms.Label ManagementHideMenu;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button SaveAddButton;
        private System.Windows.Forms.Button ButtonAddCancel;
        private System.Windows.Forms.Panel ManagementAddPanel;
        private System.Windows.Forms.TextBox BirdCountAge;
        private System.Windows.Forms.TextBox BirdNameText;
        private System.Windows.Forms.TextBox BirdPsText;
        private System.Windows.Forms.ComboBox BirdShopText;
        private System.Windows.Forms.Label BirdPsLabel;
        private System.Windows.Forms.Label BirdCountLabel;
        private System.Windows.Forms.Label BirdAgeLabel;
        private System.Windows.Forms.Label BirdShopLabel;
        private System.Windows.Forms.Label BirdNameLabel;
        private System.Windows.Forms.DateTimePicker BirdDateText;
        private System.Windows.Forms.Panel ShopAddPanel;
        private System.Windows.Forms.Label ShopPsLabel;
        private System.Windows.Forms.Label ShopNameLabel;
        private System.Windows.Forms.TextBox ShopNameText;
        private System.Windows.Forms.TextBox ShopPsText;
        private System.Windows.Forms.Button ShopAddButton;
        private System.Windows.Forms.Button ShopCancelButton;
        private System.Windows.Forms.Panel ChangeShopPanel;
        private System.Windows.Forms.Label ChangeShopLabelShop;
        private System.Windows.Forms.TextBox ChangeShopTextShop;
        private System.Windows.Forms.Button ChangeShopButtonC;
        private System.Windows.Forms.ComboBox ChangeShopBoxShop;
        private System.Windows.Forms.Label ChangeShopLabelPs;
        private System.Windows.Forms.Label ChangeShopLabelShop2;
        private System.Windows.Forms.TextBox ChangeShopTextPs;
        private System.Windows.Forms.Button ChangeShopButtonD;
        private System.Windows.Forms.Button ChangeShopButtonE;
        private System.Windows.Forms.Panel AddEggPanel;
        private System.Windows.Forms.Panel QuestionPanelDelete;
        private System.Windows.Forms.Label QuestionExitDelete;
        private System.Windows.Forms.Button ChangeShopButton;
        private System.Windows.Forms.Button ChangeBirdButton;
        private System.Windows.Forms.Panel Qpanelgreen;
        private System.Windows.Forms.Label QuestionLabelDelete;
        private System.Windows.Forms.Label EggCountLabel;
        private System.Windows.Forms.TextBox EggCountText;
        private System.Windows.Forms.ComboBox EggBirdText;
        private System.Windows.Forms.Label EggBirdLabel;
        private System.Windows.Forms.ComboBox EggShopText;
        private System.Windows.Forms.Label EggPsLabel;
        private System.Windows.Forms.Label EggShopLabel;
        private System.Windows.Forms.TextBox EggPsText;
        private System.Windows.Forms.Button EggAddButton;
        private System.Windows.Forms.Button EggCancelButton;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Label CloseCreateButton;
        private System.Windows.Forms.Button AddEgg;
        private System.Windows.Forms.Button AddShop;
        private System.Windows.Forms.Button AddBird;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Panel ChangeBirdPanel;
        private System.Windows.Forms.Label ChangeBirdLabelDate;
        private System.Windows.Forms.DateTimePicker ChangeBirdTextDate;
        private System.Windows.Forms.Label ChangeBirdLabelBird2;
        private System.Windows.Forms.TextBox ChangeBirdTextBird;
        private System.Windows.Forms.Button ChangeBirdButtonC;
        private System.Windows.Forms.Label ChangeBirdLabelCount;
        private System.Windows.Forms.TextBox ChangeBirdTextCount;
        private System.Windows.Forms.ComboBox ChangeBirdBoxBird;
        private System.Windows.Forms.Label ChangeBirdLabelBird;
        private System.Windows.Forms.ComboBox ChangeBirdTextShop;
        private System.Windows.Forms.Label ChangeBirdLabelPs;
        private System.Windows.Forms.Label ChangeBirdLabelShop;
        private System.Windows.Forms.TextBox ChangeBirdTextPs;
        private System.Windows.Forms.Button ChangeBirdButtonD;
        private System.Windows.Forms.Button ChangeBirdButtonE;


        #endregion

        #endregion

        #region MONITORING FORM
        #region MONITORING ELEMENTS
        private System.Windows.Forms.Panel MonitoringMainPanel;
        private System.Windows.Forms.Panel MonitoringLeftPanel;
        private System.Windows.Forms.Label MonitoringMenuLabel;
        private System.Windows.Forms.Button MonitoringHistoryButton;
        private System.Windows.Forms.Button MonitoringMonitoringButton;
        private System.Windows.Forms.Button MonitoringManagementButton;
        private System.Windows.Forms.Button MonitoringMainButton;
        private System.Windows.Forms.Panel MonitoringRightPanel;
        private System.Windows.Forms.Panel MonitoringShopsCheckBoxPanel;
        private System.Windows.Forms.CheckedListBox MonitoringCheckBoxBird;
        private System.Windows.Forms.Label MonitoringShopLabel;
        private System.Windows.Forms.Panel MonitoringCentralPanel;
        private System.Windows.Forms.Label MonitoringHideMenu;
        private System.Windows.Forms.Panel MonitoringTopPanel;
        private System.Windows.Forms.Label MonitoringMonitorinLabel;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ComboBox MonitoringShopBox;
        #endregion

        private void MonitoringMainButton_Click(object sender, EventArgs e)
        {
            var shops = db.WorkShops.ToList();
            var birds = db.Birds.ToList();
            ((ListBox)checkedListBox1).DataSource = shops;
            ((ListBox)checkedListBox1).ValueMember = "WorkShopId";
            ((ListBox)checkedListBox1).DisplayMember = "Name";
            MainMainPanel.Visible = true;
            ManagementMainPanel.Visible = false;
            MonitoringMainPanel.Visible = false;
        }

        private void MonitoringManagementButton_Click(object sender, EventArgs e)
        {
            MainMainPanel.Visible = false;
            ManagementMainPanel.Visible = true;
            MonitoringMainPanel.Visible = false;
            HistoryMainPanel.Visible = false;
        }


        private void MonitoringHistoryButton_Click(object sender, EventArgs e)
        {
            db.ManagementHistories.Load();
            var history = db.ManagementHistories;
            foreach (var h in history)
            {
                HistoryListBox.Items.Add("\n" + h.Date + "  ");
                HistoryListBox.Items.Add(h.HistoryEvent + "  ");
                if (!string.IsNullOrEmpty(h.PsEvent))
                    HistoryListBox.Items.Add(h.PsEvent + "\n");
                else
                    HistoryListBox.Items.Add("\n");
            }
            MainMainPanel.Visible = false;
            ManagementMainPanel.Visible = false;
            MonitoringMainPanel.Visible = false;
            HistoryMainPanel.Visible = true;
        }
        private void MonitoringShopBox_SelectedValueChanged(object sender, System.EventArgs e)
        {
            MonitoringShopBox.SelectedValueChanged += MonitoringShopBox_SelectedValueChanged1;
        }

        private void MonitoringShopBox_SelectedValueChanged1(object sender, EventArgs e)
        {
            db.Birds.Load();
            db.WorkShops.Load();
            var birds = (from Bird in db.Birds where Bird.WorkShop.WorkShopId == (int)MonitoringShopBox.SelectedValue select Bird).ToList();
            ((ListBox)MonitoringCheckBoxBird).DataSource = birds;
            ((ListBox)MonitoringCheckBoxBird).ValueMember = "BirdId";
            ((ListBox)MonitoringCheckBoxBird).DisplayMember = "Name";

        }



        private void MonitoringCheckBoxBird_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            db.Birds.Load();
            db.EggLayingQualities.Load();
            db.WorkShops.Load();

            SeriesCollection series = new SeriesCollection();
            ChartValues<int> eggCount = new ChartValues<int>();
            List<string> date = new List<string>();
            if (e.NewValue == CheckState.Checked)
            {
                var eggs = (from EggLayingQualities in db.EggLayingQualities where EggLayingQualities.Bird.BirdId == (int)MonitoringCheckBoxBird.SelectedValue select EggLayingQualities).ToList();
                foreach (var egg in eggs)
                {
                    eggCount.Add(egg.Count);
                    date.Add(egg.DateEgg.ToShortDateString());
                }
                cartesianChart1.AxisX.Clear();
                cartesianChart1.AxisX.Add(new Axis()
                {
                    Title = "Date",
                    Labels = date
                });

                LineSeries line = new LineSeries();
                line.Title = MonitoringCheckBoxBird.SelectedItem.ToString();
                line.Values = eggCount;

                series.Add(line);
                cartesianChart1.Series.AddRange(series);
            }
            else
            {
                cartesianChart1.Series.Clear();
            }
        }

        #endregion

        #region HISTORY FORM

        private void HistoryMainButton_Click(object sender, EventArgs e)
        {
            var shops = db.WorkShops.ToList();
            var birds = db.Birds.ToList();
            ((ListBox)checkedListBox1).DataSource = shops;
            ((ListBox)checkedListBox1).ValueMember = "WorkShopId";
            ((ListBox)checkedListBox1).DisplayMember = "Name";
            MainMainPanel.Visible = true;
            ManagementMainPanel.Visible = false;
            MonitoringMainPanel.Visible = false;
            HistoryMainPanel.Visible = false;
        }

        private void HistoryManagementButton_Click(object sender, EventArgs e)
        {
            MainMainPanel.Visible = false;
            ManagementMainPanel.Visible = true;
            MonitoringMainPanel.Visible = false;
            HistoryMainPanel.Visible = false;
        }

        private void HistoryMonitoringButton_Click(object sender, EventArgs e)
        {
            db.WorkShops.Load();
            var shops = db.WorkShops.ToList();
            MonitoringShopBox.ValueMember = "WorkShopId";
            MonitoringShopBox.DisplayMember = "Name";
            MonitoringShopBox.DataSource = shops;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            MainMainPanel.Visible = false;
            ManagementMainPanel.Visible = false;
            MonitoringMainPanel.Visible = true;
            HistoryMainPanel.Visible = false;
        }

        private int lastindex = -1;
        private void HistorySearchButton_Click(object sender, EventArgs e)
        {
            int i;
            for (i = lastindex + 1; i < HistoryListBox.Items.Count; i++)
            {
                var currVal = HistoryListBox.Items[i].ToString();
                if (currVal.IndexOf(HistorySearchBox.Text, StringComparison.OrdinalIgnoreCase) > -1)
                {
                    HistoryListBox.SetSelected(i, true);
                    lastindex = i;
                    break;
                }
            }
            if (lastindex > -1 && i == HistoryListBox.Items.Count)
            {
                for (i = 0; i <= lastindex; i++)
                {
                    var currVal = HistoryListBox.Items[i].ToString();
                    if (currVal.IndexOf(HistorySearchBox.Text, StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        HistoryListBox.SetSelected(i, true);
                        lastindex = i;
                        break;
                    }
                }
            }
        }

        #region HISTORY FORM ELEMENTS
        private System.Windows.Forms.Panel HistoryMainPanel;
        private System.Windows.Forms.Panel HistoryCentralPanel;
        private System.Windows.Forms.Panel HistoryRightPanel;
        private System.Windows.Forms.Panel HistoryLeftPanel;
        private System.Windows.Forms.Label HistoryMenuLabel;
        private System.Windows.Forms.Panel HistoryManagementPanel;
        private System.Windows.Forms.Button HistoryHistoryButton;
        private System.Windows.Forms.Button HistoryMonitoringButton;
        private System.Windows.Forms.Button HistoryManagementButton;
        private System.Windows.Forms.Button HistoryMainButton;
        private System.Windows.Forms.Panel HistoryTopPanel;
        private System.Windows.Forms.Label HistoryHistoryLabel;
        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.Label HistorySearchLabel;
        private System.Windows.Forms.Button HistorySearchButton;
        private System.Windows.Forms.TextBox HistorySearchBox;
        #endregion

        #endregion
    }

}
