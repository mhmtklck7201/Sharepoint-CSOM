using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using System.Text.RegularExpressions;

namespace SharepointCSOM
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (!(string.IsNullOrEmpty(txtSigortali.Text) || string.IsNullOrEmpty(txtSigortaEttiren.Text) || string.IsNullOrEmpty(txtTaban.Text) || string.IsNullOrEmpty(txtKarlilik.Text) || string.IsNullOrEmpty(txtGenelMaliyetler.Text)))
				{
					using (ClientContext ctx = new ClientContext("http://odeabankwebsite/"))
					{
						Web web = ctx.Web;
						List oList = ctx.Web.Lists.GetByTitle("SigortaBilgileri");

						//string sigortaEttiren = "<Field Type='Text' Name='SigortaEttiren'   DisplayName='SigortaEttiren' />";
						//string sigortali = "<Field Type='Text' Name='Sigortali' DisplayName='Sigortali'   />";
						//string dt = "<Field Type='Text' Name='DogumTarihi'  DisplayName='DogumTarihi' />";
						//string sigortaKonusu = "<Field Type='Text' Name='SigortaKonusu'  DisplayName='SigortaKonusu' />";
						//string sigortaBasslangic = "<Field Type='Text' Name='SigortaBaslangic'   DisplayName='SigortaBaslangic' />";
						//string sigortaBitis = "<Field Type='Text' Name='SigortaBitis'   DisplayName='SigortaBitis' />";
						//string tanzim = "<Field Type='Text' Name='Tanzim' DisplayName='Tanzim' />";
						////FieldCollection collField = oList.Fields;
						//CreateList(oList, sigortaEttiren, ctx);
						//CreateList(oList, sigortali, ctx);
						//CreateList(oList, dt, ctx);

						//CreateList(oList, sigortaKonusu, ctx);
						//CreateList(oList, sigortaBasslangic, ctx);

						//CreateList(oList, sigortaBitis, ctx);
						//CreateList(oList, tanzim, ctx);

						ListItemCreationInformation listItemColl = new ListItemCreationInformation();
						ListItem item = oList.AddItem(listItemColl);
						item["SigortaEttiren"] = txtSigortaEttiren.Text;
						item["Sigortali"] = txtSigortali.Text;
						item["DogumTarihi"] = dtDogumT.Value.ToString("yyyy-MM-dd");
						item["SigortaKonusu"] = comboBox1.Text;
						item["SigortaBaslangic"] = dtSigortaBaslangic.Value.ToString();
						item["SigortaBitis"] = dtSigortaBitis.Value.ToString();

						item["Tanzim"] = dtTanzim.Value.ToString();
						item.Update();
						ctx.ExecuteQuery();
					}
					double karlilik = Convert.ToDouble(txtKarlilik.Text) * 0.01;
					groupBox1.Visible = true;
					lblMin.Text = string.Format("{0:0.00}", (Convert.ToDouble(txtTaban.Text) + (Convert.ToDouble(txtGenelMaliyetler.Text) * Convert.ToDouble((1 + 0.15)))));
					lblMax.Text = string.Format("{0:0.00}", (Convert.ToDouble(txtTaban.Text) + (Convert.ToDouble(txtGenelMaliyetler.Text) * Convert.ToDouble((1 + 0.4)))));
					lblIOnerilen.Text = string.Format("{0:0.00}", (Convert.ToDouble(txtTaban.Text) + (Convert.ToDouble(txtGenelMaliyetler.Text) * Convert.ToDouble((1 + karlilik)))));
					ClearFields();
				}
				else
				{
					MessageBox.Show("Lütfen boş alan bırakmayınız");
				}
			
			}
			catch (Exception)
			{

				MessageBox.Show("Hata");
			}


		}
		public void ClearFields()
		{
			foreach (Control ctrl in panel1.Controls)

			{
				TextBox tb = ctrl as TextBox;
				if (tb != null)
				{
					tb.Text = string.Empty;
				}

			}
		}
 
		public void CreateList(List list, string fieldSchema, ClientContext ctx)
		{
			using (ctx)
			{
				FieldCollection collField = list.Fields;
				collField.AddFieldAsXml(fieldSchema, true, AddFieldOptions.AddToDefaultContentType);
				//list.Fields.Add(field);
				ctx.Load(collField);
				ctx.ExecuteQuery();
			}

		}

	 
	 

		public bool eHandled(object sender, KeyPressEventArgs e)
		{
			bool handled = false;
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
			{
				handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
			{
				handled = true;
			}
			string senderText = (sender as TextBox).Text;
			if (senderText.Contains(','))
			{

				string[] splitByDecimal = senderText.Split(',');
				if (splitByDecimal[1].Length > 1 && e.KeyChar != 46 && e.KeyChar != '\b')
				{
					handled = true;
				}
			}
			return handled;

		}


		private void Form1_Load(object sender, EventArgs e)
		{

			comboBox1.SelectedIndex = 0;
			groupBox1.Visible = false;
		}

		private void txtTaban_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = eHandled(sender, e);
		}

		private void txtGenelMaliyetler_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = eHandled(sender, e);
		}
		private void txtKarlilik_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = eHandled(sender, e);
		}
		private void txtTaban_TextChanged(object sender, EventArgs e)
		{
			if (txtTaban.Text.Length >= 2)//Taban fiyat için burası >=0 olacak gene
			{

				double acceptednumber = Convert.ToDouble(txtTaban.Text);

				if (acceptednumber < 0)
				{
					txtTaban.Text = "";
					MessageBox.Show("-ve values are not allowed");
				}
				else
				{
					txtTaban.Text = txtTaban.Text;
				}
			}
		}
		private void txtKarlilik_TextChanged(object sender, EventArgs e)
		{
			if (txtKarlilik.Text.Length >= 2)//Taban fiyat için burası >=0 olacak gene
			{

				double acceptednumber = Convert.ToDouble(txtKarlilik.Text);

				if (acceptednumber >= 41 || acceptednumber < 14)
				{
					txtKarlilik.Text = "";
					MessageBox.Show("Lütfen %15 ile %40 arası değer giriniz");
				}
				else
				{
					txtKarlilik.Text = txtKarlilik.Text;
				}
			}
		}
		private void txtGenelMaliyetler_TextChanged(object sender, EventArgs e)
		{
			if (txtGenelMaliyetler.Text.Length >= 2)//Taban fiyat için burası >=0 olacak gene
			{

				double acceptednumber = Convert.ToDouble(txtGenelMaliyetler.Text);

				if (acceptednumber < 0)
				{
					txtGenelMaliyetler.Text = "";
					MessageBox.Show("-ve values are not allowed");
				}
				else
				{
					txtGenelMaliyetler.Text = txtGenelMaliyetler.Text;
				}
			}
		}

	 
	}
}
