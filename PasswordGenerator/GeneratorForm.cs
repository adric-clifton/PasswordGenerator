using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PasswordGenerator
{
	public partial class GeneratorForm : Form
	{
		//private CustomRegEx regex;
		private bool bAllowKey;

		private bool bFirstRun = true;

		public GeneratorForm()
		{
			InitializeComponent();
		}

		private void trkLength_Scroll(object sender, EventArgs e)
		{
			LengthChanged(trkLength.Value);
		}

		private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
				LengthUpdate();
		}

		private void txtLength_Leave(object sender, EventArgs e)
		{
			LengthUpdate();
		}

		/// <summary>
		/// Called when the user changes how long the password wants to be.
		/// Limits input to the range of the slider.
		/// </summary>
		private void LengthUpdate()
		{
			try
			{
				int toVal = Convert.ToInt32(txtLength.Text);
				if (toVal > trkLength.Maximum)
					toVal = trkLength.Maximum;
				if (toVal < trkLength.Minimum)
					toVal = trkLength.Minimum;

				LengthChanged(toVal);
			}
			catch (Exception)
			{
				LengthChanged(trkLength.Value);
			}
		}

		/// <summary>
		/// Updates slider value and text field.
		/// </summary>
		private void LengthChanged(int toValue)
		{
			trkLength.Value = toValue;
			txtLength.Text = toValue.ToString();
		}

		/// <summary>
		/// Only allows 0-9 and Shift
		/// </summary>
		private void txtLength_KeyDown(object sender, KeyEventArgs e)
		{
			bAllowKey = false;

			if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
				bAllowKey = true;

			if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
				bAllowKey = true;

			if (Control.ModifierKeys == Keys.Shift)
				bAllowKey = false;

			AllowModKeys(e);

			e.SuppressKeyPress = !bAllowKey;
		}

		/// <summary>
		/// Permits Select-all, Cut, Copy, Paste, Backspace, Escape and Enter
		/// </summary>
		private void AllowModKeys(KeyEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control)
				if (e.KeyCode == Keys.A || e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X)
					bAllowKey = true;

			if (e.KeyCode == Keys.Back)
				bAllowKey = true;

			if (e.KeyCode == Keys.Escape)
				bAllowKey = true;

			if (e.KeyCode == Keys.Enter)
				bAllowKey = true;
		}

		/// <summary>
		/// Generates a new password.
		/// </summary>
		private void cmdGenerate_Click(object sender, EventArgs e)
		{
			//string result = regex.CalculateOutput(currentRun, txtPattern.Text, trkLength.Value);
			string result = Parser.Instance.Parse(txtPattern.Text, trkLength.Value);

			txtOutput.Text = result;

			if (bFirstRun)
				lstHistory.Items.Clear();

			lstHistory.Items.Insert(0, result);

			bFirstRun = false;
		}

		/// <summary>
		/// Changes the output text box to have the selected password in it.
		/// </summary>
		private void lstHistory_SelectedValueChanged(object sender, EventArgs e)
		{
			txtOutput.Text = (string)lstHistory.SelectedItem;
		}
	}
}
