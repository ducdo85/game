using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000085 RID: 133
	public partial class FormTest : Form
	{
		// Token: 0x06000ADF RID: 2783 RVA: 0x001809E0 File Offset: 0x0017EBE0
		public FormTest()
		{
			FormTest.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00180A0F File Offset: 0x0017EC0F
		private void FormTest_Load(object sender, EventArgs e)
		{
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00180A30 File Offset: 0x0017EC30
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormTest.bool_0 = false;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00088771 File Offset: 0x00086971
		private void timer_0_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00088771 File Offset: 0x00086971
		private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00088771 File Offset: 0x00086971
		private void method_0(string string_0, bool bool_2 = true, bool bool_3 = true)
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonLayToado_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonClear_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonCopyDefine_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonTdSingle_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonGetIndexInfo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonLamMap_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonCopyNPCObjGannhat_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonGetAllNPCObject_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonTenNPCgannhat_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonXemMaloi_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonDialogGetText_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonTitleMenu_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonGetChanelAllTop_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonFileMahoa_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonMoThumuc_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonMaHoa_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonSum1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonSum2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonPaste_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonDelete_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonBrowss_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonBatdau_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonStopFind_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00088771 File Offset: 0x00086971
		private void method_1()
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonXoaNhatky_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00088771 File Offset: 0x00086971
		private void comboBoxFind_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonCreateTK_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonBatdautaoPHLT_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonOpenFile_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00088771 File Offset: 0x00086971
		private void textBoxFile_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonPaste2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonTenTabKTC_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonSortcutSkill_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00088771 File Offset: 0x00086971
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonBrowse_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00088771 File Offset: 0x00086971
		private void button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00088771 File Offset: 0x00086971
		private void button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00088771 File Offset: 0x00086971
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00088771 File Offset: 0x00086971
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00088771 File Offset: 0x00086971
		private void button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00088771 File Offset: 0x00086971
		private void button9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00088771 File Offset: 0x00086971
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00088771 File Offset: 0x00086971
		private void button6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonAllSkill_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00088771 File Offset: 0x00086971
		private void checkBoxFont_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonLine_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00088771 File Offset: 0x00086971
		private void textBoxNPCObjectInfo_MouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00088771 File Offset: 0x00086971
		private void button11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00180A3C File Offset: 0x0017EC3C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000C0B RID: 3083
		public static bool bool_0;

		// Token: 0x04000C0C RID: 3084
		public static bool bool_1;

		// Token: 0x04000C0D RID: 3085
		public static GStruct49 gstruct49_0;

		// Token: 0x04000C0E RID: 3086
		public static int int_0;

		// Token: 0x04000C0F RID: 3087
		public int int_1;

		// Token: 0x04000C10 RID: 3088
		public int int_2;

		// Token: 0x04000C11 RID: 3089
		public int int_3;

		// Token: 0x04000C12 RID: 3090
		public int int_4;

		// Token: 0x04000C13 RID: 3091
		private IContainer icontainer_0 = null;
	}
}
