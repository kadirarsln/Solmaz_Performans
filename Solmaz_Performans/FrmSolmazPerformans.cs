using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Solmaz_Performans
{
    public partial class FrmSolmazPerformans : Form
    {
        public FrmSolmazPerformans()
        {
            InitializeComponent();
        }
        private void FrmSolmazPerformans_Load(object sender, EventArgs e)
        {

        }

        FrmListele frmListele;
        private void btnListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmListele == null)
            {
                frmListele = new FrmListele();
                frmListele.MdiParent = this;
                frmListele.Show();
            }
        }
        //İthalatDosyasiListele
        FrmİthalatDosyasi frmIthalatDosyasi;
        private void btnİthalatDosyasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmIthalatDosyasi == null)
            {
                frmIthalatDosyasi = new FrmİthalatDosyasi();
                frmIthalatDosyasi.MdiParent = this;
                frmIthalatDosyasi.Show();
            }
        }
        //İhracatDosyasiListele
        private FrmİhracatDosyasi frmIhracatDosyasi;
        private void btnİhracatDosyasi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmIhracatDosyasi == null)
            {
                frmIhracatDosyasi = new FrmİhracatDosyasi();
                frmIhracatDosyasi.MdiParent = this;
                frmIhracatDosyasi.Show();
            }
        }

        private FrmNCTSDosyasi frmNctsDosyasi;
        private void btnNCTSDosyasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNctsDosyasi == null)
            {
                frmNctsDosyasi = new FrmNCTSDosyasi();
                frmNctsDosyasi.MdiParent = this;
                frmNctsDosyasi.Show();
            }
        }

        private FrmAntrepoDosyasi frmAntrepoDosyasi;
        private void btnAntrepoDosyasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAntrepoDosyasi == null)
            {
                frmAntrepoDosyasi = new FrmAntrepoDosyasi();
                frmAntrepoDosyasi.MdiParent = this;
                frmAntrepoDosyasi.Show();
            }
        }

        FrmSBIFDosyasi frmSbifDosyasi;
        private void btnSBIFDosyasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSbifDosyasi == null)
            {
                frmSbifDosyasi = new FrmSBIFDosyasi();
                frmSbifDosyasi.MdiParent = this;
                frmSbifDosyasi.Show();
            }
        }

        FrmATADosyasi frmAtaDosyasi;
        private void btnATADosyasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAtaDosyasi == null)
            {
                frmAtaDosyasi = new FrmATADosyasi();
                frmAtaDosyasi.MdiParent = this;
                frmAtaDosyasi.Show();
            }
        }
        FrmKalemSayisi frmKalemSayisi;
        private void btnKalemSayisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKalemSayisi == null)
            {
                frmKalemSayisi = new FrmKalemSayisi();
                frmKalemSayisi.MdiParent = this;
                frmKalemSayisi.Show();
            }
        }

        FrmDigerDosyasi frmDigerDosyasi;
        private void btnDigerDosyasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDigerDosyasi == null)
            {
                frmDigerDosyasi = new FrmDigerDosyasi();
                frmDigerDosyasi.MdiParent = this;
                frmDigerDosyasi.Show();
            }
        }

        FrmOzetBeyanDosyasi frmOzetBeyanDosyasi;
        private void btnOzetBeyanDosyasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmOzetBeyanDosyasi == null)
            {
                frmOzetBeyanDosyasi = new FrmOzetBeyanDosyasi();
                frmOzetBeyanDosyasi.MdiParent = this;
                frmOzetBeyanDosyasi.Show();
            }
        }

        FrmDilekceDosyasi frmDilekceDosyasi;
        private void btnDilekceDosya_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDilekceDosyasi == null)
            {
                frmDilekceDosyasi = new FrmDilekceDosyasi();
                frmDilekceDosyasi.MdiParent = this;
                frmDilekceDosyasi.Show();
            }
        }

        private FrmSozluBeyanDosyasi frmSozluBeyanDosyasi;
        private void btnSozluBeyanDosyasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSozluBeyanDosyasi ==null)
            {
                frmSozluBeyanDosyasi = new FrmSozluBeyanDosyasi();
                frmSozluBeyanDosyasi.MdiParent = this;
                frmSozluBeyanDosyasi.Show();
            }
        }

        private FrmRehber frmRehber;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmRehber == null)
            {
                frmRehber = new FrmRehber();
                frmRehber.MdiParent = this;
                frmRehber.Show();
            }
        }
    }
}
