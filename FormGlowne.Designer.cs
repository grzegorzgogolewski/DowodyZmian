namespace DowodyZmian
{
    partial class FormGlowne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlowne));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.GroupBoxView = new System.Windows.Forms.GroupBox();
            this.PdfOknoPodlgadu = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.GroupBoxList = new System.Windows.Forms.GroupBox();
            this.ListBoxPliki = new System.Windows.Forms.ListBox();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.PasekStatusu = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBoxPrzyciski = new System.Windows.Forms.GroupBox();
            this.ButtonKonwersja = new System.Windows.Forms.Button();
            this.LabelNumerZmiany = new System.Windows.Forms.Label();
            this.TextBoxZmiana = new System.Windows.Forms.TextBox();
            this.ButtonWskazPliki = new System.Windows.Forms.Button();
            this.ButtonWybierzFolder = new System.Windows.Forms.Button();
            this.GroupBoxView.SuspendLayout();
            this.GroupBoxList.SuspendLayout();
            this.StatusStripMain.SuspendLayout();
            this.GroupBoxPrzyciski.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxView
            // 
            this.GroupBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxView.Controls.Add(this.PdfOknoPodlgadu);
            this.GroupBoxView.Location = new System.Drawing.Point(13, 13);
            this.GroupBoxView.Name = "GroupBoxView";
            this.GroupBoxView.Size = new System.Drawing.Size(612, 643);
            this.GroupBoxView.TabIndex = 0;
            this.GroupBoxView.TabStop = false;
            this.GroupBoxView.Text = "GroupBoxView";
            // 
            // PdfOknoPodlgadu
            // 
            this.PdfOknoPodlgadu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PdfOknoPodlgadu.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.HandTool;
            this.PdfOknoPodlgadu.EnableContextMenu = false;
            this.PdfOknoPodlgadu.EnableNotificationBar = false;
            this.PdfOknoPodlgadu.HorizontalScrollOffset = 0;
            this.PdfOknoPodlgadu.IsBookmarkEnabled = false;
            this.PdfOknoPodlgadu.IsTextSearchEnabled = false;
            this.PdfOknoPodlgadu.IsTextSelectionEnabled = false;
            this.PdfOknoPodlgadu.Location = new System.Drawing.Point(7, 20);
            messageBoxSettings1.EnableNotification = true;
            this.PdfOknoPodlgadu.MessageBoxSettings = messageBoxSettings1;
            this.PdfOknoPodlgadu.MinimumZoomPercentage = 10;
            this.PdfOknoPodlgadu.Name = "PdfOknoPodlgadu";
            this.PdfOknoPodlgadu.PageBorderThickness = 0;
            pdfViewerPrinterSettings1.Copies = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            this.PdfOknoPodlgadu.PrinterSettings = pdfViewerPrinterSettings1;
            this.PdfOknoPodlgadu.ReferencePath = null;
            this.PdfOknoPodlgadu.ScrollDisplacementValue = 0;
            this.PdfOknoPodlgadu.ShowHorizontalScrollBar = true;
            this.PdfOknoPodlgadu.ShowToolBar = true;
            this.PdfOknoPodlgadu.ShowVerticalScrollBar = true;
            this.PdfOknoPodlgadu.Size = new System.Drawing.Size(599, 617);
            this.PdfOknoPodlgadu.SpaceBetweenPages = 0;
            this.PdfOknoPodlgadu.TabIndex = 0;
            this.PdfOknoPodlgadu.TabStop = false;
            this.PdfOknoPodlgadu.Text = "PdfOknoPodlgadu";
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.PdfOknoPodlgadu.TextSearchSettings = textSearchSettings1;
            this.PdfOknoPodlgadu.ThemeName = "Office2016Colorful";
            this.PdfOknoPodlgadu.VerticalScrollOffset = 0;
            this.PdfOknoPodlgadu.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Colorful;
            this.PdfOknoPodlgadu.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage;
            this.PdfOknoPodlgadu.DocumentLoaded += new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl.DocumentLoadedEventHandler(this.PdfOknoPodlgadu_DocumentLoaded);
            // 
            // GroupBoxList
            // 
            this.GroupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxList.Controls.Add(this.ListBoxPliki);
            this.GroupBoxList.Location = new System.Drawing.Point(632, 13);
            this.GroupBoxList.Name = "GroupBoxList";
            this.GroupBoxList.Size = new System.Drawing.Size(540, 477);
            this.GroupBoxList.TabIndex = 0;
            this.GroupBoxList.TabStop = false;
            this.GroupBoxList.Text = "GroupBoxList";
            // 
            // ListBoxPliki
            // 
            this.ListBoxPliki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxPliki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxPliki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxPliki.FormattingEnabled = true;
            this.ListBoxPliki.ItemHeight = 16;
            this.ListBoxPliki.Location = new System.Drawing.Point(7, 20);
            this.ListBoxPliki.Name = "ListBoxPliki";
            this.ListBoxPliki.Size = new System.Drawing.Size(527, 432);
            this.ListBoxPliki.TabIndex = 4;
            this.ListBoxPliki.SelectedIndexChanged += new System.EventHandler(this.ListBoxPliki_SelectedIndexChanged);
            this.ListBoxPliki.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxPliki_KeyDown);
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasekStatusu});
            this.StatusStripMain.Location = new System.Drawing.Point(0, 667);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Size = new System.Drawing.Size(1192, 22);
            this.StatusStripMain.TabIndex = 2;
            this.StatusStripMain.Text = "StatusStripMain";
            // 
            // PasekStatusu
            // 
            this.PasekStatusu.Name = "PasekStatusu";
            this.PasekStatusu.Size = new System.Drawing.Size(76, 17);
            this.PasekStatusu.Text = "PasekStatusu";
            // 
            // GroupBoxPrzyciski
            // 
            this.GroupBoxPrzyciski.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxPrzyciski.Controls.Add(this.ButtonKonwersja);
            this.GroupBoxPrzyciski.Controls.Add(this.LabelNumerZmiany);
            this.GroupBoxPrzyciski.Controls.Add(this.TextBoxZmiana);
            this.GroupBoxPrzyciski.Controls.Add(this.ButtonWskazPliki);
            this.GroupBoxPrzyciski.Controls.Add(this.ButtonWybierzFolder);
            this.GroupBoxPrzyciski.Location = new System.Drawing.Point(632, 496);
            this.GroupBoxPrzyciski.Name = "GroupBoxPrzyciski";
            this.GroupBoxPrzyciski.Size = new System.Drawing.Size(540, 119);
            this.GroupBoxPrzyciski.TabIndex = 3;
            this.GroupBoxPrzyciski.TabStop = false;
            this.GroupBoxPrzyciski.Text = "GroupBoxPrzyciski";
            // 
            // ButtonKonwersja
            // 
            this.ButtonKonwersja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKonwersja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonKonwersja.ForeColor = System.Drawing.Color.Red;
            this.ButtonKonwersja.Location = new System.Drawing.Point(7, 69);
            this.ButtonKonwersja.Name = "ButtonKonwersja";
            this.ButtonKonwersja.Size = new System.Drawing.Size(120, 30);
            this.ButtonKonwersja.TabIndex = 4;
            this.ButtonKonwersja.Text = "Konwersja";
            this.ButtonKonwersja.UseVisualStyleBackColor = true;
            this.ButtonKonwersja.Click += new System.EventHandler(this.ButtonKonwersja_Click);
            // 
            // LabelNumerZmiany
            // 
            this.LabelNumerZmiany.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNumerZmiany.Location = new System.Drawing.Point(292, 19);
            this.LabelNumerZmiany.Name = "LabelNumerZmiany";
            this.LabelNumerZmiany.Size = new System.Drawing.Size(97, 27);
            this.LabelNumerZmiany.TabIndex = 3;
            this.LabelNumerZmiany.Text = "Nr zmiany:";
            this.LabelNumerZmiany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxZmiana
            // 
            this.TextBoxZmiana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxZmiana.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxZmiana.Location = new System.Drawing.Point(395, 17);
            this.TextBoxZmiana.Name = "TextBoxZmiana";
            this.TextBoxZmiana.Size = new System.Drawing.Size(139, 29);
            this.TextBoxZmiana.TabIndex = 2;
            this.TextBoxZmiana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxZmiana.TextChanged += new System.EventHandler(this.TextBoxZmiana_TextChanged);
            this.TextBoxZmiana.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxZmiana_KeyDown);
            this.TextBoxZmiana.Leave += new System.EventHandler(this.TextBoxZmiana_TextChanged);
            // 
            // ButtonWskazPliki
            // 
            this.ButtonWskazPliki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWskazPliki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonWskazPliki.Location = new System.Drawing.Point(132, 17);
            this.ButtonWskazPliki.Name = "ButtonWskazPliki";
            this.ButtonWskazPliki.Size = new System.Drawing.Size(120, 30);
            this.ButtonWskazPliki.TabIndex = 1;
            this.ButtonWskazPliki.Text = "Wskaż pliki";
            this.ButtonWskazPliki.UseVisualStyleBackColor = true;
            this.ButtonWskazPliki.Click += new System.EventHandler(this.ButtonPliki_Click);
            // 
            // ButtonWybierzFolder
            // 
            this.ButtonWybierzFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWybierzFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonWybierzFolder.Location = new System.Drawing.Point(6, 17);
            this.ButtonWybierzFolder.Name = "ButtonWybierzFolder";
            this.ButtonWybierzFolder.Size = new System.Drawing.Size(120, 30);
            this.ButtonWybierzFolder.TabIndex = 0;
            this.ButtonWybierzFolder.Text = "Wskaż folder";
            this.ButtonWybierzFolder.UseVisualStyleBackColor = true;
            this.ButtonWybierzFolder.Click += new System.EventHandler(this.ButtonPliki_Click);
            // 
            // FormGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 689);
            this.Controls.Add(this.GroupBoxPrzyciski);
            this.Controls.Add(this.StatusStripMain);
            this.Controls.Add(this.GroupBoxList);
            this.Controls.Add(this.GroupBoxView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FormGlowne";
            this.Text = "FormGlowne";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormG_FormClosing);
            this.Load += new System.EventHandler(this.FormGlowne_Load);
            this.Shown += new System.EventHandler(this.FormGlowne_Shown);
            this.GroupBoxView.ResumeLayout(false);
            this.GroupBoxList.ResumeLayout(false);
            this.StatusStripMain.ResumeLayout(false);
            this.StatusStripMain.PerformLayout();
            this.GroupBoxPrzyciski.ResumeLayout(false);
            this.GroupBoxPrzyciski.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxView;
        private System.Windows.Forms.GroupBox GroupBoxList;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel PasekStatusu;
        private System.Windows.Forms.GroupBox GroupBoxPrzyciski;
        private System.Windows.Forms.Button ButtonWskazPliki;
        private System.Windows.Forms.Button ButtonWybierzFolder;
        private System.Windows.Forms.TextBox TextBoxZmiana;
        private System.Windows.Forms.Label LabelNumerZmiany;
        private System.Windows.Forms.ListBox ListBoxPliki;
        private System.Windows.Forms.Button ButtonKonwersja;
        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl PdfOknoPodlgadu;
    }
}

