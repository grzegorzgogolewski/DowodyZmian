namespace DowodyZmian
{
    partial class FormG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormG));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.PdfOknoPodlgadu = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.PasekStatusu = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxView.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxView
            // 
            this.groupBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxView.Controls.Add(this.PdfOknoPodlgadu);
            this.groupBoxView.Location = new System.Drawing.Point(13, 13);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(612, 643);
            this.groupBoxView.TabIndex = 0;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "groupBoxView";
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
            this.PdfOknoPodlgadu.MinimumZoomPercentage = 50;
            this.PdfOknoPodlgadu.Name = "PdfOknoPodlgadu";
            this.PdfOknoPodlgadu.PageBorderThickness = 1;
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
            this.PdfOknoPodlgadu.SpaceBetweenPages = 8;
            this.PdfOknoPodlgadu.TabIndex = 0;
            this.PdfOknoPodlgadu.Text = "PdfOknoPodlgadu";
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.PdfOknoPodlgadu.TextSearchSettings = textSearchSettings1;
            this.PdfOknoPodlgadu.ThemeName = "Default";
            this.PdfOknoPodlgadu.VerticalScrollOffset = 0;
            this.PdfOknoPodlgadu.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.PdfOknoPodlgadu.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage;
            // 
            // groupBoxList
            // 
            this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxList.Location = new System.Drawing.Point(632, 13);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(540, 643);
            this.groupBoxList.TabIndex = 1;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "groupBoxList";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasekStatusu});
            this.statusStripMain.Location = new System.Drawing.Point(0, 659);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1184, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // PasekStatusu
            // 
            this.PasekStatusu.Name = "PasekStatusu";
            this.PasekStatusu.Size = new System.Drawing.Size(76, 17);
            this.PasekStatusu.Text = "PasekStatusu";
            // 
            // FormG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FormG";
            this.Text = "FormGlowne";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormG_FormClosing);
            this.Load += new System.EventHandler(this.FormGlowne_Load);
            this.Shown += new System.EventHandler(this.FormGlowne_Shown);
            this.groupBoxView.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxView;
        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl PdfOknoPodlgadu;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel PasekStatusu;
    }
}

