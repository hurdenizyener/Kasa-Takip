﻿namespace KASA_EVSHOP
{
    partial class FRM_DETAY_MERKEZ_ODEME_GUNCELLE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DETAY_MERKEZ_ODEME_GUNCELLE));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.memo_aciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date_tarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(52, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 25);
            this.labelControl6.TabIndex = 128;
            this.labelControl6.Text = "TUTAR :";
            // 
            // txt_tutar
            // 
            this.txt_tutar.EditValue = "";
            this.txt_tutar.Location = new System.Drawing.Point(143, 50);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txt_tutar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tutar.Properties.Mask.EditMask = "n";
            this.txt_tutar.Size = new System.Drawing.Size(255, 32);
            this.txt_tutar.TabIndex = 1;
            this.txt_tutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tutar_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(11, 91);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(126, 25);
            this.labelControl5.TabIndex = 127;
            this.labelControl5.Text = "AÇIKLAMA :";
            // 
            // memo_aciklama
            // 
            this.memo_aciklama.EditValue = "";
            this.memo_aciklama.Location = new System.Drawing.Point(143, 88);
            this.memo_aciklama.Name = "memo_aciklama";
            this.memo_aciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memo_aciklama.Properties.Appearance.Options.UseFont = true;
            this.memo_aciklama.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memo_aciklama.Size = new System.Drawing.Size(255, 109);
            this.memo_aciklama.TabIndex = 2;
            this.memo_aciklama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memo_aciklama_KeyDown);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(196, 206);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(159, 52);
            this.btn_kaydet.TabIndex = 126;
            this.btn_kaydet.TabStop = false;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "icons8_save_125px_19.png");
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(55, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 25);
            this.labelControl2.TabIndex = 130;
            this.labelControl2.Text = "TARİH :";
            // 
            // date_tarih
            // 
            this.date_tarih.EditValue = null;
            this.date_tarih.Location = new System.Drawing.Point(143, 12);
            this.date_tarih.Name = "date_tarih";
            this.date_tarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_tarih.Properties.Appearance.Options.UseFont = true;
            this.date_tarih.Properties.Appearance.Options.UseTextOptions = true;
            this.date_tarih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.date_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_tarih.Properties.Mask.EditMask = "99.99.0000";
            this.date_tarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.date_tarih.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_tarih.Size = new System.Drawing.Size(255, 32);
            this.date_tarih.TabIndex = 129;
            this.date_tarih.TabStop = false;
            this.date_tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_tarih_KeyDown);
            // 
            // FRM_DETAY_MERKEZ_ODEME_GUNCELLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 269);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.date_tarih);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.memo_aciklama);
            this.Controls.Add(this.btn_kaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_DETAY_MERKEZ_ODEME_GUNCELLE";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MERKEZ ÖDEME GÜNCELLE";
            this.Load += new System.EventHandler(this.FRM_DETAY_MERKEZ_ODEME_GUNCELLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit memo_aciklama;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit date_tarih;
    }
}