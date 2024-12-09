﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_LKMT.SubForm
{
    public partial class ImportReceiptForm : Form
    {
        PhieuNhapBLL phieuNhapBLL = new PhieuNhapBLL();
        ChiTietPhieuNhapBLL chiTietPhieuNhapBLL = new ChiTietPhieuNhapBLL();
        List<ResponseDTO.ChiTietPhieuNhap> listCTPN = new List<ResponseDTO.ChiTietPhieuNhap>();
        public ImportReceiptForm()
        {
            InitializeComponent();
            this.Load += ImportReceiptForm_Load;
            this.dgvPN.CellFormatting += DgvPN_CellFormatting;
            this.dgvPN.SelectionChanged += DgvPN_SelectionChanged;
            this.dgvCTPN.CellFormatting += DgvCTPN_CellFormatting;
            this.dgvSP.SelectionChanged += DgvSP_SelectionChanged;
            this.dgvSP.CellFormatting += DgvSP_CellFormatting;
            this.txtSearchSP.KeyUp += TxtSearchSP_KeyUp;
            this.btnAddCTPN.Click += BtnAddCTPN_Click;
            this.btnDeleteCTPN.Click += BtnDeleteCTPN_Click;
            this.btnUpdateCTPN.Click += BtnUpdateCTPN_Click;
            this.btnAddPN.Click += BtnAddPN_Click;
        }

        private void BtnAddPN_Click(object? sender, EventArgs e)
        {
            EditDTO.PhieuNhap pn = new EditDTO.PhieuNhap();
            pn.MaPN = phieuNhapBLL.GeneratorMaPN();
            pn.TongTien = listCTPN.Sum(p => p.ThanhTien);
            pn.NgayNhap = DateTime.Now;
            pn.DaXoa = false;
            List<EditDTO.ChiTietPhieuNhap> list = new List<EditDTO.ChiTietPhieuNhap>();
            foreach(var item in listCTPN)
            {
                EditDTO.ChiTietPhieuNhap ctpn = new EditDTO.ChiTietPhieuNhap();
                ctpn.MaPN = pn.MaPN;
                ctpn.MaSanPham = item.MaSP;
                ctpn.MaThuongHieu = item.MaThuongHieu;
                ctpn.GiaNhap = item.GiaNhap;
                ctpn.SoLuong = item.SoLuong;
                ctpn.ThanhTien = item.ThanhTien;
                list.Add(ctpn);
            }
            phieuNhapBLL.Create(pn, list);
            loadPN();
        }

        private void BtnUpdateCTPN_Click(object? sender, EventArgs e)
        {
            if (listCTPN.Count > 0)
            {
                listCTPN[dgvCTPN.CurrentRow.Index].SoLuong = int.Parse(txtSL.Text);
                loadCTPN(listCTPN);
                txtTotalPrice.Text = listCTPN.Sum(p => p.ThanhTien).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            }
            
        }

        private void BtnDeleteCTPN_Click(object? sender, EventArgs e)
        {
            if(listCTPN.Count > 0)
            {
                listCTPN.RemoveAt(dgvCTPN.CurrentRow.Index);
                loadCTPN(listCTPN);
                txtTotalPrice.Text = listCTPN.Sum(p => p.ThanhTien).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));

            }
        }

        private void BtnAddCTPN_Click(object? sender, EventArgs e)
        {
            if(txtSL.Text == "" || txtMaSP.Text == "" || txtMaTH.Text == "" || txtGiaNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            ResponseDTO.ChiTietPhieuNhap item = listCTPN.Where(p => p.MaSP == txtMaSP.Text).FirstOrDefault();
            if(item == null)
            {
                ResponseDTO.ChiTietPhieuNhap ctpn = new ResponseDTO.ChiTietPhieuNhap();
                ctpn.MaSP = txtMaSP.Text;
                ctpn.MaThuongHieu = txtMaTH.Text;
                ctpn.GiaNhap = decimal.Parse(txtGiaNhap.Text);
                ctpn.SoLuong = int.Parse(txtSL.Text);
                ctpn.ThanhTien = ctpn.GiaNhap * ctpn.SoLuong;
                listCTPN.Add(ctpn);
            }    
            else
            {
                item.SoLuong += int.Parse(txtSL.Text);
            }    
            loadCTPN(listCTPN);
            txtTotalPrice.Text = listCTPN.Sum(p => p.ThanhTien).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));

        }

        private void TxtSearchSP_KeyUp(object? sender, KeyEventArgs e)
        {
            dgvSP.DataSource = phieuNhapBLL.searchSP(txtSearchSP.Text);
        }

        private void DgvSP_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSP.Columns[e.ColumnIndex].Name == "DonGia" && e.Value != null)
            {
                e.Value = string.Format(new System.Globalization.CultureInfo("vi-VN"), "{0:C0}", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void DgvSP_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvSP.SelectedRows.Count > 0)
            {
                txtMaSP.Text = dgvSP.CurrentRow.Cells[0].Value.ToString();
                txtMaTH.Text = dgvSP.CurrentRow.Cells[2].Value.ToString();
                txtGiaNhap.Text = dgvSP.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void DgvCTPN_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnsToFormat = new List<string> { "GiaNhap", "ThanhTien" };

            if (columnsToFormat.Contains(dgvCTPN.Columns[e.ColumnIndex].Name) && e.Value != null)
            {
                e.Value = string.Format(new System.Globalization.CultureInfo("vi-VN"), "{0:C0}", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void DgvPN_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvPN.SelectedRows.Count > 0)
            {
                string idPN = dgvPN.CurrentRow.Cells[0].Value.ToString();
                loadCTPN(chiTietPhieuNhapBLL.GetAll(idPN));
                txtTotalPrice.Text = chiTietPhieuNhapBLL.GetTotal(idPN).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));

            }
        }

        private void DgvPN_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPN.Columns[e.ColumnIndex].Name == "TongTien" && e.Value != null)
            {
                e.Value = string.Format(new System.Globalization.CultureInfo("vi-VN"), "{0:C0}", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void ImportReceiptForm_Load(object? sender, EventArgs e)
        {
            loadPN();
            loadSP();
        }

        public void loadPN()
        {
            dgvPN.DataSource = null;
            dgvPN.DataSource = phieuNhapBLL.GetAll();
            dgvPN.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPN.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPN.Columns["MaPN"].HeaderText = "Mã phiếu nhập";
            dgvPN.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvPN.Columns["NgayNhap"].HeaderText = "Ngày nhập";
        }

        public void loadCTPN(List<ResponseDTO.ChiTietPhieuNhap> list)
        {
            dgvCTPN.DataSource = null;
            dgvCTPN.DataSource = list;
            dgvCTPN.Columns["MaSP"].HeaderText = "Tên sản phẩm";
            dgvCTPN.Columns["MaThuongHieu"].HeaderText = "Mã thương hiệu";
            dgvCTPN.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dgvCTPN.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvCTPN.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvCTPN.Columns["GiaNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCTPN.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCTPN.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void loadSP()
        {
            dgvSP.DataSource = phieuNhapBLL.GetAllSP();
            dgvSP.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvSP.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvSP.Columns["MaThuongHieu"].HeaderText = "Mã thương hiệu";
            dgvSP.Columns["DonGia"].HeaderText = "Giá bán";
            dgvSP.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            dgvSP.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSP.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
