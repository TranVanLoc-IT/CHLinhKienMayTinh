﻿using BLL;
using DTO;
using PM_LKMT.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_LKMT.SubForm
{
	public partial class ViewProduct : Form
	{
		private SanPhamBLL _bll;
		public ViewProduct()
		{
			this._bll = new SanPhamBLL();
			InitializeComponent();
			LoadData();
		}
		private void LoadData()
		{
			IEnumerable<ResponseDTO.SanPham> hotSale = _bll.HotSale();
			IEnumerable<string> hotBrand = _bll.HotBrand();
			IEnumerable<ResponseDTO.SanPham> all = _bll.GetAll();

			// xem full màn hình
			int screenWidth = Screen.PrimaryScreen.Bounds.Width;
			this.panelBanChay.Width = screenWidth;
			this.panelThuongHieuHot.Width = screenWidth;
			this.panelAll.Width = screenWidth;
			foreach (ResponseDTO.SanPham sp in hotSale)
			{
				ProductViewCard card = new ProductViewCard(sp);
				this.panelBanChay.Controls.Add(card);
			}
			foreach (string br in hotBrand)
			{
				PictureBox card = LoadImage(br);

				this.panelThuongHieuHot.Controls.Add(card);
			}
			foreach (ResponseDTO.SanPham sp in all)
			{
				ProductViewCard card = new ProductViewCard(sp);
				this.panelAll.Controls.Add(card);
			}
		}
		private PictureBox LoadImage(string name)
		{
			PictureBox pic = new PictureBox();
			pic.Size = new Size(220, 189);
			pic.BackgroundImageLayout = ImageLayout.Stretch;
			string filePath = $"../../../images/Product/{name}.jpg";

			if (File.Exists(filePath))
			{
				using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
				{
					pic.Image = Image.FromStream(stream);
				}
			}
			else
			{
				MessageBox.Show("File not found: " + filePath);
			}
			return pic;
		}

		private void searchBox_TextChanged(object sender, EventArgs e)
		{
			foreach (Control control in panelAll.Controls)
			{
				if(control is ProductViewCard card)
				{
					if (card.productName.Text.ToLower().StartsWith(searchBox.Text.ToLower()) || card.productName.Text.ToLower().Contains(searchBox.Text.ToLower()))
					{
						DialogResult found = MessageBox.Show("Đã thấy kết quả phù hợp, xem ngay ?", "Thông báo", MessageBoxButtons.OKCancel);
						if (found == DialogResult.OK)
						{
							card.buttonView.Click += card.buttonView_Click;
						}
					}
				}
			}
		}
	}
}