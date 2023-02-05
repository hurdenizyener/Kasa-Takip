﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace KASA_EVSHOP
{
    public partial class FRM_TAKSIT : DevExpress.XtraEditors.XtraForm
    {
        public FRM_TAKSIT()
        {
            InitializeComponent();
        }
        OLEDB_BAGLANTI bgl = new OLEDB_BAGLANTI();

        public int kod;
        //TİMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToShortDateString();
            lbl_saat.Text = DateTime.Now.ToShortTimeString();
        }
        // FORM LOAD
        private void FRM_TAKSIT_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // BUTON HESAPLA
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // PARA ÜSTÜ HESAP
        double a, b, sonuc;
        public void para_ustu()
        {
            try
            {
                a = Convert.ToDouble(txt_odenen_tutar.Text);
                b = Convert.ToDouble(txt_tahsilat_tutar.Text);
                sonuc = a - b;

                txt_para_ustu.Text = sonuc.ToString() + "  ₺";


                txt_musteri_kodu.Text = "0";
                txt_odenen_tutar.Text = "0";
                txt_tahsilat_tutar.Text = "0";

                txt_odenen_tutar.Focus();
            }
            catch (Exception)
            {


            }
        }
        // VERİLERİ KAYDETME      
        public void kaydet()
        {
           

            OleDbTransaction islem = null;
            islem = bgl.baglanti().BeginTransaction();


            OleDbCommand kmt = new OleDbCommand("insert into kasa_taksit (musteri_kodu,odenen_tutar,tahsilat_tutari,tarih,saat,kullanici_kodu) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txt_musteri_kodu.Text);
            kmt.Parameters.AddWithValue("@p2", txt_odenen_tutar.Text);
            kmt.Parameters.AddWithValue("@p3", txt_tahsilat_tutar.Text);
            kmt.Parameters.AddWithValue("@p4", lbl_tarih.Text);
            kmt.Parameters.AddWithValue("@p5", Convert.ToString(lbl_saat.Text));
            kmt.Parameters.AddWithValue("@p6", Convert.ToInt32(kod.ToString()));


            try
            {
                kmt.ExecuteNonQuery();
                islem.Commit();
                
            }
            catch
            {
                islem.Rollback();

                XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();

            }
            para_ustu();
           



        }
        // ENTER TUSU
        private void txt_musteri_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
                
            }
        }
        // ENTER TUSU
        private void txt_odenen_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
               
            }
        }
        // ENTER TUSU
        private void txt_tahsilat_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
                
            }
        }
        //KÜÇÜLT
        private void btn_kucult_Click(object sender, EventArgs e)
        {
            FRM_KASA_TAKSIT_KUCUK frm_kucuk = new FRM_KASA_TAKSIT_KUCUK();
            frm_kucuk.kullanici_kod =int.Parse( kod.ToString());
            frm_kucuk.Show();
        }
    }
}