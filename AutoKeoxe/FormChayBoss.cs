using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000067 RID: 103
	public partial class FormChayBoss : Form
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x0013074B File Offset: 0x0012E94B
		public FormChayBoss()
		{
			FormChayBoss.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0013077C File Offset: 0x0012E97C
		static FormChayBoss()
		{
			string[,] array = new string[111, 5];
			array[0, 0] = "...";
			array[0, 1] = "0.0";
			array[0, 2] = "0";
			array[0, 3] = "0|0|0|0";
			array[0, 4] = "";
			array[1, 0] = "PDĐ.1 213.182";
			array[1, 1] = "213.182";
			array[1, 2] = "11";
			array[1, 3] = "11|20|202";
			array[1, 4] = "Phù Dung động";
			array[2, 0] = "PDĐ.2 192.188";
			array[2, 1] = "192.188";
			array[2, 2] = "11";
			array[2, 3] = "11|20|202";
			array[2, 4] = "Phù Dung động";
			array[3, 0] = "PDĐ.3 200.195";
			array[3, 1] = "200.195";
			array[3, 2] = "11";
			array[3, 3] = "11|20|202";
			array[3, 4] = "Phù Dung động";
			array[4, 0] = "PDĐ.4 193.177";
			array[4, 1] = "193.177";
			array[4, 2] = "11";
			array[4, 3] = "11|20|202";
			array[4, 4] = "Phù Dung động";
			array[5, 0] = "PDĐ.5 185.176";
			array[5, 1] = "185.176";
			array[5, 2] = "11";
			array[5, 3] = "11|20|202";
			array[5, 4] = "Phù Dung động";
			array[6, 0] = "PDĐ.6 191.166";
			array[6, 1] = "191.166";
			array[6, 2] = "11";
			array[6, 3] = "11|20|202";
			array[6, 4] = "Phù Dung động";
			array[7, 0] = "...";
			array[7, 1] = "0.0";
			array[7, 2] = "0";
			array[7, 3] = "0|0|0|0";
			array[7, 4] = "";
			array[8, 0] = "PTĐ.1 205.202";
			array[8, 1] = "205.202";
			array[8, 2] = "37";
			array[8, 3] = "37|100|204";
			array[8, 4] = "Phi Thiên động";
			array[9, 0] = "PTĐ.2 219.220";
			array[9, 1] = "219.220";
			array[9, 2] = "37";
			array[9, 3] = "37|100|204";
			array[9, 4] = "Phi Thiên động";
			array[10, 0] = "PTĐ.3 182.225";
			array[10, 1] = "182.225";
			array[10, 2] = "37";
			array[10, 3] = "37|100|204";
			array[10, 4] = "Phi Thiên động";
			array[11, 0] = "PTĐ.4 175.212";
			array[11, 1] = "175.212";
			array[11, 2] = "37";
			array[11, 3] = "37|100|204";
			array[11, 4] = "Phi Thiên động";
			array[12, 0] = "...";
			array[12, 1] = "0.0";
			array[12, 2] = "0";
			array[12, 3] = "0|0|0|0";
			array[12, 4] = "";
			array[13, 0] = "TKĐ.1 211.188";
			array[13, 1] = "211.188";
			array[13, 2] = "162";
			array[13, 3] = "176|174|198";
			array[13, 4] = "Thanh Khê động";
			array[14, 0] = "TKĐ.2 192.176";
			array[14, 1] = "192.176";
			array[14, 2] = "162";
			array[14, 3] = "176|174|198";
			array[14, 4] = "Thanh Khê động";
			array[15, 0] = "TKĐ.3 202.199";
			array[15, 1] = "202.199";
			array[15, 2] = "162";
			array[15, 3] = "176|174|198";
			array[15, 4] = "Thanh Khê động";
			array[16, 0] = "...";
			array[16, 1] = "0.0";
			array[16, 2] = "0";
			array[16, 3] = "0|0|0|0";
			array[16, 4] = "";
			array[17, 0] = "VLĐ.1 225.187";
			array[17, 1] = "225.187";
			array[17, 2] = "78";
			array[17, 3] = "78|53|199";
			array[17, 4] = "Vũ Lăng động";
			array[18, 0] = "VLĐ.2 209.200";
			array[18, 1] = "209.200";
			array[18, 2] = "78";
			array[18, 3] = "78|53|199";
			array[18, 4] = "Vũ Lăng động";
			array[19, 0] = "VLĐ.3 181.185";
			array[19, 1] = "181.185";
			array[19, 2] = "78";
			array[19, 3] = "78|53|199";
			array[19, 4] = "Vũ Lăng động";
			array[20, 0] = "...";
			array[20, 1] = "0.0";
			array[20, 2] = "0";
			array[20, 3] = "0|0|0|0";
			array[20, 4] = "";
			array[21, 0] = "LTĐ.1 0.0";
			array[21, 1] = "0.0";
			array[21, 2] = "162";
			array[21, 3] = "176|174|179|181";
			array[21, 4] = "Lưỡng Thủy động";
			array[22, 0] = "...";
			array[22, 1] = "0.0";
			array[22, 2] = "0";
			array[22, 3] = "0|0|0|0";
			array[22, 4] = "";
			array[23, 0] = "DTĐ.1 201.210";
			array[23, 1] = "201.210";
			array[23, 2] = "80";
			array[23, 3] = "80|101|205";
			array[23, 4] = "Dương Trung động";
			array[24, 0] = "DTĐ.2 198.202";
			array[24, 1] = "198.202";
			array[24, 2] = "80";
			array[24, 3] = "80|101|205";
			array[24, 4] = "Dương Trung động";
			array[25, 0] = "DTĐ.3 187.194";
			array[25, 1] = "187.194";
			array[25, 2] = "80";
			array[25, 3] = "80|101|205";
			array[25, 4] = "Dương Trung động";
			array[26, 0] = "DTĐ.4 160.192";
			array[26, 1] = "160.192";
			array[26, 2] = "80";
			array[26, 3] = "80|101|205";
			array[26, 4] = "Dương Trung động";
			array[27, 0] = "...";
			array[27, 1] = "0.0";
			array[27, 2] = "0";
			array[27, 3] = "0|0|0|0";
			array[27, 4] = "";
			array[28, 0] = "NTĐ.1 0.0";
			array[28, 1] = "0.0";
			array[28, 2] = "11";
			array[28, 3] = "11|9|10";
			array[28, 4] = "Nhạn Thạch động";
			array[29, 0] = "...";
			array[29, 1] = "0.0";
			array[29, 2] = "0";
			array[29, 3] = "0|0|0|0";
			array[29, 4] = "";
			array[30, 0] = "SBĐ.1 0.0";
			array[30, 1] = "0.0";
			array[30, 2] = "1";
			array[30, 3] = "78|53|74|76";
			array[30, 4] = "Sơn Bảo động";
			array[31, 0] = "...";
			array[31, 1] = "0.0";
			array[31, 2] = "0";
			array[31, 3] = "0|0|0|0";
			array[31, 4] = "";
			array[32, 0] = "KLĐ.1 0.0";
			array[32, 1] = "0.0";
			array[32, 2] = "1";
			array[32, 3] = "78|53|74|76|75";
			array[32, 4] = "Khỏa Lang động";
			array[33, 0] = "...";
			array[33, 1] = "0.0";
			array[33, 2] = "0";
			array[33, 3] = "0|0|0|0";
			array[33, 4] = "";
			array[34, 0] = "VDĐ.1 0.0";
			array[34, 1] = "0.0";
			array[34, 2] = "162";
			array[34, 3] = "162|153|203";
			array[34, 4] = "Vô Danh động";
			array[35, 0] = "...";
			array[35, 1] = "0.0";
			array[35, 2] = "0";
			array[35, 3] = "0|0|0|0";
			array[35, 4] = "";
			array[36, 0] = "TBN.1 164.149";
			array[36, 1] = "164.149";
			array[36, 2] = "1";
			array[36, 3] = "37|319|320|321";
			array[36, 4] = "Trường Bạch Sơn Nam";
			array[37, 0] = "TBN.2 183.148";
			array[37, 1] = "183.148";
			array[37, 2] = "1";
			array[37, 3] = "37|319|320|321";
			array[37, 4] = "Trường Bạch Sơn Nam";
			array[38, 0] = "TBN.3 148.175";
			array[38, 1] = "148.175";
			array[38, 2] = "1";
			array[38, 3] = "37|319|320|321";
			array[38, 4] = "Trường Bạch Sơn Nam";
			array[39, 0] = "TBN.4 124.180";
			array[39, 1] = "124.180";
			array[39, 2] = "1";
			array[39, 3] = "37|319|320|321";
			array[39, 4] = "Trường Bạch Sơn Nam";
			array[40, 0] = "TBN.5 127.186";
			array[40, 1] = "127.186";
			array[40, 2] = "1";
			array[40, 3] = "37|319|320|321";
			array[40, 4] = "Trường Bạch Sơn Nam";
			array[41, 0] = "TBN.6 172.193";
			array[41, 1] = "172.193";
			array[41, 2] = "1";
			array[41, 3] = "37|319|320|321";
			array[41, 4] = "Trường Bạch Sơn Nam";
			array[42, 0] = "...";
			array[42, 1] = "0.0";
			array[42, 2] = "0";
			array[42, 3] = "0|0|0|0";
			array[42, 4] = "";
			array[43, 0] = "TBB.1 222.202";
			array[43, 1] = "222.202";
			array[43, 2] = "37";
			array[43, 3] = "37|319|320|322";
			array[43, 4] = "Trường Bạch Sơn Bắc";
			array[44, 0] = "TBB.2 248.202";
			array[44, 1] = "248.202";
			array[44, 2] = "37";
			array[44, 3] = "37|319|320|322";
			array[44, 4] = "Trường Bạch Sơn Bắc";
			array[45, 0] = "TBB.3 237.202";
			array[45, 1] = "237.202";
			array[45, 2] = "37";
			array[45, 3] = "37|319|320|322";
			array[45, 4] = "Trường Bạch Sơn Bắc";
			array[46, 0] = "TBB.4 211.218";
			array[46, 1] = "211.218";
			array[46, 2] = "37";
			array[46, 3] = "37|319|320|322";
			array[46, 4] = "Trường Bạch Sơn Bắc";
			array[47, 0] = "TBB.5 203.221";
			array[47, 1] = "203.221";
			array[47, 2] = "37";
			array[47, 3] = "37|319|320|322";
			array[47, 4] = "Trường Bạch Sơn Bắc";
			array[48, 0] = "TBB.6 226.230";
			array[48, 1] = "226.230";
			array[48, 2] = "37";
			array[48, 3] = "37|319|320|322";
			array[48, 4] = "Trường Bạch Sơn Bắc";
			array[49, 0] = "...";
			array[49, 1] = "0.0";
			array[49, 2] = "0";
			array[49, 3] = "0|0|0|0";
			array[49, 4] = "";
			array[50, 0] = "MCQ.1 167.183";
			array[50, 1] = "167.183";
			array[50, 2] = "11";
			array[50, 3] = "1|121|340";
			array[50, 4] = "Mạc Cao Quật";
			array[51, 0] = "MCQ.2 175.201";
			array[51, 1] = "175.201";
			array[51, 2] = "11";
			array[51, 3] = "1|121|340";
			array[51, 4] = "Mạc Cao Quật";
			array[52, 0] = "MCQ.3 206.205";
			array[52, 1] = "206.205";
			array[52, 2] = "11";
			array[52, 3] = "1|121|340";
			array[52, 4] = "Mạc Cao Quật";
			array[53, 0] = "MCQ.4 231.177";
			array[53, 1] = "231.177";
			array[53, 2] = "11";
			array[53, 3] = "1|121|340";
			array[53, 4] = "Mạc Cao Quật";
			array[54, 0] = "MCQ.5 219.205";
			array[54, 1] = "219.205";
			array[54, 2] = "11";
			array[54, 3] = "1|121|340";
			array[54, 4] = "Mạc Cao Quật";
			array[55, 0] = "MCQ.6 225.194";
			array[55, 1] = "225.194";
			array[55, 2] = "11";
			array[55, 3] = "1|121|340";
			array[55, 4] = "Mạc Cao Quật";
			array[56, 0] = "MCQ.7 185.205";
			array[56, 1] = "185.205";
			array[56, 2] = "11";
			array[56, 3] = "1|121|340";
			array[56, 4] = "Mạc Cao Quật";
			array[57, 0] = "...";
			array[57, 1] = "0.0";
			array[57, 2] = "0";
			array[57, 3] = "0|0|0|0";
			array[57, 4] = "";
			array[58, 0] = "SMĐB.1 215.178";
			array[58, 1] = "215.178";
			array[58, 2] = "176";
			array[58, 3] = "1|121|131|136|224";
			array[58, 4] = "Sa Mạc địa biểu";
			array[59, 0] = "SMĐB.2 230.185";
			array[59, 1] = "230.185";
			array[59, 2] = "176";
			array[59, 3] = "1|121|131|136|224";
			array[59, 4] = "Sa Mạc địa biểu";
			array[60, 0] = "SMĐB.3 188.190";
			array[60, 1] = "188.190";
			array[60, 2] = "176";
			array[60, 3] = "1|121|131|136|224";
			array[60, 4] = "Sa Mạc địa biểu";
			array[61, 0] = "SMĐB.4 210.192";
			array[61, 1] = "210.192";
			array[61, 2] = "176";
			array[61, 3] = "1|121|131|136|224";
			array[61, 4] = "Sa Mạc địa biểu";
			array[62, 0] = "SMĐB.5 211.200";
			array[62, 1] = "211.200";
			array[62, 2] = "176";
			array[62, 3] = "1|121|131|136|224";
			array[62, 4] = "Sa Mạc địa biểu";
			array[63, 0] = "...";
			array[63, 1] = "0.0";
			array[63, 2] = "0";
			array[63, 3] = "0|0|0|0";
			array[63, 4] = "";
			array[64, 0] = "SM1.1 194.205";
			array[64, 1] = "194.205";
			array[64, 2] = "176";
			array[64, 3] = "1|121|131|136|224|225";
			array[64, 4] = "Sa Mạc 1";
			array[65, 0] = "SM1.2 180.210";
			array[65, 1] = "180.210";
			array[65, 2] = "176";
			array[65, 3] = "1|121|131|136|224|225";
			array[65, 4] = "Sa Mạc 1";
			array[66, 0] = "SM1.3 176.216";
			array[66, 1] = "176.216";
			array[66, 2] = "176";
			array[66, 3] = "1|121|131|136|224|225";
			array[66, 4] = "Sa Mạc 1";
			array[67, 0] = "SM1.4 160.203";
			array[67, 1] = "160.203";
			array[67, 2] = "176";
			array[67, 3] = "1|121|131|136|224|225";
			array[67, 4] = "Sa Mạc 1";
			array[68, 0] = "SM1.5 176.194";
			array[68, 1] = "176.194";
			array[68, 2] = "176";
			array[68, 3] = "1|121|131|136|224|225";
			array[68, 4] = "Sa Mạc 1";
			array[69, 0] = "...";
			array[69, 1] = "0.0";
			array[69, 2] = "0";
			array[69, 3] = "0|0|0|0";
			array[69, 4] = "";
			array[70, 0] = "SM2.1 215.201";
			array[70, 1] = "215.201";
			array[70, 2] = "176";
			array[70, 3] = "1|121|131|136|224|226";
			array[70, 4] = "Sa Mạc 2";
			array[71, 0] = "SM2.2 0.0";
			array[71, 1] = "0.0";
			array[71, 2] = "176";
			array[71, 3] = "1|121|131|136|224|226";
			array[71, 4] = "Sa Mạc 2";
			array[72, 0] = "...";
			array[72, 1] = "0.0";
			array[72, 2] = "0";
			array[72, 3] = "0|0|0|0";
			array[72, 4] = "";
			array[73, 0] = "SM3.1 170.197";
			array[73, 1] = "170.197";
			array[73, 2] = "176";
			array[73, 3] = "1|121|131|136|224|227";
			array[73, 4] = "Sa Mạc 3";
			array[74, 0] = "SM3.2 0.0";
			array[74, 1] = "0.0";
			array[74, 2] = "176";
			array[74, 3] = "1|121|131|136|224|227";
			array[74, 4] = "Sa Mạc 3";
			array[75, 0] = "...";
			array[75, 1] = "0.0";
			array[75, 2] = "0";
			array[75, 3] = "0|0|0|0";
			array[75, 4] = "";
			array[76, 0] = "PLĐ.1 0.0";
			array[76, 1] = "0.0";
			array[76, 2] = "78";
			array[76, 3] = "1|121|336";
			array[76, 4] = "Phong Lăng độ";
			array[77, 0] = "...";
			array[77, 1] = "0.0";
			array[77, 2] = "0";
			array[77, 3] = "0|0|0|0";
			array[77, 4] = "";
			array[78, 0] = "LA.1 154.209";
			array[78, 1] = "154.209";
			array[78, 2] = "176";
			array[78, 3] = "176";
			array[78, 4] = "Lâm An";
			array[79, 0] = "LA.2 150.192";
			array[79, 1] = "150.192";
			array[79, 2] = "176";
			array[79, 3] = "176";
			array[79, 4] = "Lâm An";
			array[80, 0] = "LA.3 140.168";
			array[80, 1] = "140.168";
			array[80, 2] = "176";
			array[80, 3] = "176";
			array[80, 4] = "Lâm An";
			array[81, 0] = "LA.4 0.0";
			array[81, 1] = "0.0";
			array[81, 2] = "176";
			array[81, 3] = "176";
			array[81, 4] = "Lâm An";
			array[82, 0] = "...";
			array[82, 1] = "0.0";
			array[82, 2] = "0";
			array[82, 3] = "0|0|0|0";
			array[82, 4] = "";
			array[83, 0] = "BK.1 200.176";
			array[83, 1] = "200.176";
			array[83, 2] = "37";
			array[83, 3] = "37";
			array[83, 4] = "Biện Kinh";
			array[84, 0] = "BK.2 252.175";
			array[84, 1] = "252.175";
			array[84, 2] = "37";
			array[84, 3] = "37";
			array[84, 4] = "Biện Kinh";
			array[85, 0] = "BK.3 222.212";
			array[85, 1] = "222.212";
			array[85, 2] = "37";
			array[85, 3] = "37";
			array[85, 4] = "Biện Kinh";
			array[86, 0] = "BK.4 0.0";
			array[86, 1] = "0.0";
			array[86, 2] = "37";
			array[86, 3] = "37";
			array[86, 4] = "Biện Kinh";
			array[87, 0] = "...";
			array[87, 1] = "0.0";
			array[87, 2] = "0";
			array[87, 3] = "0|0|0|0";
			array[87, 4] = "";
			array[88, 0] = "PhTuong.1 177.204";
			array[88, 1] = "177.204";
			array[88, 2] = "1";
			array[88, 3] = "1";
			array[88, 4] = "Phượng Tường";
			array[89, 0] = "PhTuong.2 225.191";
			array[89, 1] = "225.191";
			array[89, 2] = "1";
			array[89, 3] = "1";
			array[89, 4] = "Phượng Tường";
			array[90, 0] = "PhTuong.3 229.213";
			array[90, 1] = "229.213";
			array[90, 2] = "1";
			array[90, 3] = "1";
			array[90, 4] = "Phượng Tường";
			array[91, 0] = "PhTuong.4 0.0";
			array[91, 1] = "0.0";
			array[91, 2] = "1";
			array[91, 3] = "1";
			array[91, 4] = "Phượng Tường";
			array[92, 0] = "...";
			array[92, 1] = "0.0";
			array[92, 2] = "0";
			array[92, 3] = "0|0|0|0";
			array[92, 4] = "";
			array[93, 0] = "DC.1 202.180";
			array[93, 1] = "202.180";
			array[93, 2] = "80";
			array[93, 3] = "80";
			array[93, 4] = "Dương Châu";
			array[94, 0] = "DC.2 193.210";
			array[94, 1] = "193.210";
			array[94, 2] = "80";
			array[94, 3] = "80";
			array[94, 4] = "Dương Châu";
			array[95, 0] = "DC.3 0.0";
			array[95, 1] = "0.0";
			array[95, 2] = "80";
			array[95, 3] = "80";
			array[95, 4] = "Dương Châu";
			array[96, 0] = "...";
			array[96, 1] = "0.0";
			array[96, 2] = "0";
			array[96, 3] = "0|0|0|0";
			array[96, 4] = "";
			array[97, 0] = "ĐL.1 225.207";
			array[97, 1] = "225.207";
			array[97, 2] = "162";
			array[97, 3] = "162";
			array[97, 4] = "Đại Lý";
			array[98, 0] = "ĐL.2 223.186";
			array[98, 1] = "223.186";
			array[98, 2] = "162";
			array[98, 3] = "162";
			array[98, 4] = "Đại Lý";
			array[99, 0] = "ĐL.3 165.196";
			array[99, 1] = "165.196";
			array[99, 2] = "162";
			array[99, 3] = "162";
			array[99, 4] = "Đại Lý";
			array[100, 0] = "ĐL.4 0.0";
			array[100, 1] = "0.0";
			array[100, 2] = "162";
			array[100, 3] = "162";
			array[100, 4] = "Đại Lý";
			array[101, 0] = "...";
			array[101, 1] = "0.0";
			array[101, 2] = "0";
			array[101, 3] = "0|0|0|0";
			array[101, 4] = "";
			array[102, 0] = "TD.1 174.190";
			array[102, 1] = "174.190";
			array[102, 2] = "78";
			array[102, 3] = "78";
			array[102, 4] = "Tương Dương";
			array[103, 0] = "TD.2 212.209";
			array[103, 1] = "212.209";
			array[103, 2] = "78";
			array[103, 3] = "78";
			array[103, 4] = "Tương Dương";
			array[104, 0] = "TD.3 210.221";
			array[104, 1] = "210.221";
			array[104, 2] = "78";
			array[104, 3] = "78";
			array[104, 4] = "Tương Dương";
			array[105, 0] = "TD.4 0.0";
			array[105, 1] = "0.0";
			array[105, 2] = "78";
			array[105, 3] = "78";
			array[105, 4] = "Tương Dương";
			array[106, 0] = "...";
			array[106, 1] = "0.0";
			array[106, 2] = "0";
			array[106, 3] = "0|0|0|0";
			array[106, 4] = "";
			array[107, 0] = "TĐô.1 374.302";
			array[107, 1] = "374.302";
			array[107, 2] = "11";
			array[107, 3] = "11";
			array[107, 4] = "Thành Đô";
			array[108, 0] = "TĐô.2 419.320";
			array[108, 1] = "419.320";
			array[108, 2] = "11";
			array[108, 3] = "11";
			array[108, 4] = "Thành Đô";
			array[109, 0] = "TĐô.3 375.328";
			array[109, 1] = "375.328";
			array[109, 2] = "11";
			array[109, 3] = "11";
			array[109, 4] = "Thành Đô";
			array[110, 0] = "TĐô.4 0.0";
			array[110, 1] = "0.0";
			array[110, 2] = "11";
			array[110, 3] = "11";
			array[110, 4] = "Thành Đô";
			FormChayBoss.string_1 = array;
			uint[,] array_ = new uint[16, 2];
			Class11.smethod_4(array_, 383844);
			FormChayBoss.uint_0 = array_;
			FormChayBoss.string_2 = FormChayBoss.smethod_0();
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00132634 File Offset: 0x00130834
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00133A00 File Offset: 0x00131C00
		private static string[,] smethod_0()
		{
			string text = Class12.smethod_33(Class53.string_9 + "\\ToadoBoss.txt", 0, 0, 1);
			bool flag = text == null || text == string.Empty;
			string[,] result;
			if (flag)
			{
				result = FormChayBoss.string_1;
			}
			else
			{
				string[] array = text.Split(new char[]
				{
					'\r',
					'\n'
				});
				int num = 0;
				bool flag2 = false;
				bool flag3 = false;
				string[,] array2 = new string[array.Length, 5];
				for (int i = 0; i < array.Length; i++)
				{
					bool flag4 = array[i] == null || array[i] == string.Empty;
					if (!flag4)
					{
						string[] array3 = array[i].Split(new char[]
						{
							'ÿ'
						});
						bool flag5 = array3.Length == 5 && FormChayBoss.smethod_1(array3[0]);
						if (flag5)
						{
							bool flag6 = Class12.smethod_2(array3[0], "PhTuong", false);
							if (flag6)
							{
								flag2 = true;
							}
							bool flag7 = Class12.smethod_2(array3[0], "SBĐ", false);
							if (flag7)
							{
								flag3 = true;
							}
							for (int j = 0; j < 5; j++)
							{
								array2[num, j] = array3[j];
							}
							num++;
						}
					}
				}
				bool flag8 = !flag2 || !flag3;
				if (flag8)
				{
					FormChayBoss.bool_3 = true;
				}
				bool flag9 = num != array2.GetLength(0);
				if (flag9)
				{
					string[,] array4 = new string[num, 5];
					for (int k = 0; k < num; k++)
					{
						for (int l = 0; l < 5; l++)
						{
							array4[k, l] = array2[k, l];
						}
					}
					result = array4;
				}
				else
				{
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00133BCC File Offset: 0x00131DCC
		private static bool smethod_1(string string_3)
		{
			bool flag = string_3 == null || string_3 == string.Empty;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				int num = Class12.smethod_1(string_3, ".");
				bool flag2 = num > 0;
				if (flag2)
				{
					string_3 = string_3.Substring(0, num);
				}
				int num2 = 0;
				for (;;)
				{
					bool flag3 = num2 < FormChayBoss.string_1.GetLength(0);
					if (!flag3)
					{
						goto IL_77;
					}
					bool flag4 = Class12.smethod_1(FormChayBoss.string_1[num2, 0], string_3) == 0;
					if (flag4)
					{
						break;
					}
					num2++;
				}
				return true;
				IL_77:
				result = false;
			}
			return result;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00133C60 File Offset: 0x00131E60
		public static int smethod_2(GStruct49 gstruct49_0)
		{
			int int_ = gstruct49_0.int_136;
			int num = 0;
			int num2 = gstruct49_0.int_0;
			long long_ = 0L;
			uint[] array = null;
			bool flag = num2 >= 0 && FormChayBoss.string_2.GetLength(0) > num2;
			int num3;
			if (flag)
			{
				string text = FormChayBoss.string_2[num2, 0];
				bool flag2 = text == null || text == string.Empty || text == "..." || text[0] == '.';
				if (flag2)
				{
					num3 = 1;
				}
				else
				{
					string[] array2 = FormChayBoss.string_2[num2, 1].Split(new char[]
					{
						'/',
						'.',
						','
					});
					bool flag3 = array2.Length >= 2;
					if (flag3)
					{
						int num4 = Class12.smethod_11(FormChayBoss.string_2[num2, 2]);
						bool flag4 = num4 > 0;
						if (flag4)
						{
							uint[] array3 = new uint[]
							{
								Class12.smethod_12(array2[0]) * 256U,
								Class12.smethod_12(array2[1]) * 512U
							};
							string[] array4 = FormChayBoss.string_2[num2, 3].Split(new char[]
							{
								'|'
							});
							int[] array5 = new int[array4.Length];
							for (int i = 0; i < array5.Length; i++)
							{
								array5[i] = Class12.smethod_11(array4[i]);
							}
							int num5 = array5[array5.Length - 1];
							bool flag5 = num5 > 0;
							if (flag5)
							{
								bool flag6 = FormChayBoss.int_4 <= 0;
								bool flag7 = false;
								int num6 = 0;
								int num7 = 0;
								int num8 = 0;
								int num9 = 0;
								int num10 = 0;
								int num11 = 0;
								int num12 = -1;
								int num13 = 0;
								uint[,] array6 = new uint[5, 2];
								Class11.smethod_4(array6, 376502);
								uint[,] array7 = array6;
								GStruct26 gstruct = default(GStruct26);
								int num14 = 0;
								int num15 = -1;
								int num16 = 0;
								int num17 = -1;
								int num18 = 0;
								byte[] byte_ = new byte[4];
								for (;;)
								{
									Thread.Sleep(180);
									int num19 = Class81.smethod_3(Form1.gstruct49_0, int_);
									bool flag8 = !Class12.bool_0 && num19 >= 0 && Form1.gstruct49_0[num19].bool_25;
									if (!flag8)
									{
										goto IL_975;
									}
									gstruct49_0 = Form1.gstruct49_0[num19];
									bool flag9 = num14 == 0;
									if (flag9)
									{
										bool flag10 = Class44.gstruct33_0.int_0 == gstruct49_0.int_136;
										if (flag10)
										{
											Class44.gstruct33_0.bool_1 = true;
										}
										Class70.smethod_52(gstruct49_0, Class10.smethod_2("<color=yellow>Bắt đầu chạy điểm boss..."), 1);
										num14 = 1;
									}
									bool flag11 = num2 == gstruct49_0.int_0 && gstruct49_0.bool_1;
									if (!flag11)
									{
										goto IL_966;
									}
									int num20 = Class83.smethod_12(gstruct49_0);
									bool flag12 = num20 == 1;
									if (flag12)
									{
										Thread.Sleep(100);
									}
									else
									{
										uint num21 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
										uint num22 = Class22.smethod_30(num21 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
										uint num23 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
										uint num24 = num23 + num22 * Class53.gstruct51_15.uint_0;
										int num25 = (int)Class22.smethod_30(num24 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
										int num26 = (int)Class22.smethod_30(num24 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
										int num27 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
										int num28 = (int)Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
										int num29 = Class83.smethod_39(gstruct49_0);
										bool flag13 = num26 > 0 && num27 > 0 && num25 != 10 && num25 != 21 && num29 > 1;
										if (!flag13)
										{
											goto IL_95E;
										}
										bool flag14 = num17 != num27;
										if (flag14)
										{
											num16 = 0;
											num17 = num27;
										}
										bool flag15 = num15 >= 0 && num15 == num28;
										if (flag15)
										{
											uint[] array8 = new uint[]
											{
												Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
												Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
											};
											bool flag16 = array3 == null || array3[0] == 0U || array3[1] == 0U;
											bool flag17 = num27 != num5 || (!flag6 && FormChayBoss.int_4 > 0 && num28 <= 0);
											if (flag17)
											{
												bool flag18 = Form1.int_11 > 0 && num28 > 0;
												if (flag18)
												{
													gstruct = Class43.smethod_4(num27, num5);
													bool flag19 = gstruct.int_0 == num27 && gstruct.int_1 == num5 && gstruct.uint_0 != null;
													if (flag19)
													{
														goto IL_1066;
													}
												}
												uint[] array9 = null;
												int num30 = array5.Length;
												bool flag20 = false;
												bool flag21 = !flag7;
												int j;
												if (flag21)
												{
													bool flag22 = num13 <= 0;
													if (flag22)
													{
														num13 = ((num27 == num4) ? 1 : 0);
													}
													bool flag23 = num30 > 1;
													if (flag23)
													{
														j = 0;
														while (j < array5.Length)
														{
															bool flag24 = array5[j] != num27;
															if (flag24)
															{
																j++;
															}
															else
															{
																flag20 = true;
																bool flag25 = j <= 0;
																if (flag25)
																{
																	num10++;
																	goto IL_A64;
																}
																goto IL_97C;
															}
														}
													}
												}
												bool flag26 = !flag6 && FormChayBoss.int_4 > 0;
												if (!flag26)
												{
													num10++;
													flag7 = false;
													goto IL_A64;
												}
												bool flag27 = num30 == 1 && !flag16;
												if (flag27)
												{
													array9 = Class43.smethod_10(array3, num4, "R­¬ng chøa ®å", true);
												}
												bool flag28 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) <= 0 || num9 >= 2;
												if (!flag28)
												{
													flag6 = Class35.smethod_140(gstruct49_0, num4, null, array9, true);
													num9++;
													goto IL_1055;
												}
												num28 = (int)Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
												bool flag29 = num28 <= 0;
												if (flag29)
												{
													num27 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
													bool flag30 = num27 != num4;
													if (flag30)
													{
														num13 = 2;
														bool flag31;
														flag7 = (flag31 = (Class50.smethod_5(gstruct49_0, num4) > 0));
														if (flag31)
														{
															Thread.Sleep(300);
															Class60.smethod_11(gstruct49_0, 15000);
														}
													}
													else
													{
														flag6 = (FormChayBoss.int_4 <= 0 || Class91.smethod_0(gstruct49_0, true, array9) > 0);
													}
													goto IL_1055;
												}
												int[] array10 = new int[]
												{
													224,
													225,
													226,
													227
												};
												bool flag32 = false;
												bool flag33 = false;
												for (j = 0; j < array10.Length; j++)
												{
													bool flag34 = num5 == array10[j];
													if (flag34)
													{
														flag32 = true;
													}
													bool flag35 = num27 == array10[j];
													if (flag35)
													{
														flag33 = true;
													}
												}
												bool flag36 = flag32 && flag33;
												if (flag36)
												{
													gstruct = Class43.smethod_4(num27, num5);
													goto IL_1066;
												}
												break;
												IL_97C:
												num27 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
												int num31 = -1;
												for (j = 0; j < array5.Length; j++)
												{
													bool flag37 = num27 == array5[j];
													if (flag37)
													{
														num31 = j;
														break;
													}
												}
												bool flag38 = num31 < 0 || array5.Length - 1 <= num31;
												if (flag38)
												{
													num27 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
													bool flag39 = num27 == num5 && num11 <= 3;
													if (flag39)
													{
														num11++;
														bool flag40 = !flag6;
														if (flag40)
														{
															flag6 = (num11 > 2);
														}
														goto IL_1055;
													}
													goto IL_A30;
												}
												else
												{
													gstruct = Class43.smethod_4(num27, array5[num31 + 1]);
													bool flag41 = gstruct.uint_0 == null;
													if (flag41)
													{
														goto Block_79;
													}
													goto IL_1066;
												}
												IL_A64:
												bool flag42 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && num6 < 2;
												if (flag42)
												{
													bool flag44;
													bool flag43 = !(flag44 = Class35.smethod_140(gstruct49_0, num5, null, null, false)) && array5[num30 - 1] == 76;
													if (flag43)
													{
														flag44 = Class35.smethod_140(gstruct49_0, 75, null, null, false);
													}
													bool flag45 = flag44;
													if (flag45)
													{
														Thread.Sleep(300);
														Class60.smethod_11(gstruct49_0, 15000);
														num6++;
														goto IL_1055;
													}
												}
												num6 = 2;
												bool flag46 = num10 == 1;
												if (flag46)
												{
													int num32 = (int)Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
													bool flag47 = num32 > 0;
													if (flag47)
													{
														bool flag48 = flag20;
														if (flag48)
														{
															goto IL_DAD;
														}
														bool flag49 = num13 < 2;
														if (flag49)
														{
															num13 = 2;
															bool flag50 = Class60.smethod_14(gstruct49_0, true);
															if (flag50)
															{
																Thread.Sleep(300);
																Class60.smethod_11(gstruct49_0, 15000);
																goto IL_1055;
															}
														}
													}
													bool flag51 = FormChayBoss.int_5 > 0 && num13 == 1 && Class50.smethod_2(gstruct49_0, "®iÓm c", null, null, 0) > 0;
													if (flag51)
													{
														num10 = 0;
														num13 = 2;
														Thread.Sleep(300);
														Class60.smethod_11(gstruct49_0, 15000);
														Thread.Sleep(300);
														int num33 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
														bool flag52 = num33 == num5;
														if (flag52)
														{
															goto IL_1055;
														}
														bool flag53 = num33 != num27;
														if (flag53)
														{
															bool flag54 = num30 > 1;
															if (flag54)
															{
																for (j = 0; j < array5.Length; j++)
																{
																	bool flag55 = array5[j] != num27;
																	if (!flag55)
																	{
																		goto IL_1055;
																	}
																}
															}
															bool flag56 = Class60.smethod_14(gstruct49_0, true);
															if (flag56)
															{
																Thread.Sleep(300);
																Class60.smethod_11(gstruct49_0, 15000);
																goto IL_1055;
															}
															goto IL_C60;
														}
													}
													num13 = 2;
													num10 = 2;
													bool flag57 = Class50.smethod_4(gstruct49_0, array5[num30 - 1]) > 0;
													if (flag57)
													{
														Thread.Sleep(300);
														Class60.smethod_11(gstruct49_0, 15000);
														goto IL_1055;
													}
													num27 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
													bool flag58 = num27 != array5[0];
													if (flag58)
													{
														bool flag59 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && num7 < 2;
														if (flag59)
														{
															uint[] uint_ = null;
															bool flag60 = num30 == 1 && !flag16;
															if (flag60)
															{
																uint_ = Class43.smethod_10(array3, array5[0], "NGOAITHANH", true);
															}
															num7++;
															bool flag61 = Class35.smethod_140(gstruct49_0, array5[0], null, uint_, false);
															if (flag61)
															{
																Thread.Sleep(300);
																Class60.smethod_11(gstruct49_0, 15000);
																goto IL_1055;
															}
														}
														bool flag62 = Class50.smethod_5(gstruct49_0, array5[0]) > 0;
														if (flag62)
														{
															Thread.Sleep(300);
															Class60.smethod_11(gstruct49_0, 15000);
														}
														goto IL_1055;
													}
												}
												IL_DAD:
												int num34 = -1;
												bool flag63 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && num8 < 2;
												if (flag63)
												{
													for (j = 0; j < num30; j++)
													{
														int num35 = array5[num30 - j - 1];
														bool flag64 = 0 <= Class35.smethod_137(num35);
														if (flag64)
														{
															num34 = num35;
															break;
														}
													}
													bool flag65 = num34 > 0 && Class35.smethod_140(gstruct49_0, num34, null, null, false);
													if (flag65)
													{
														Thread.Sleep(300);
														Class60.smethod_11(gstruct49_0, 15000);
														num8++;
														goto IL_1055;
													}
													num8 = 2;
												}
												num34 = -1;
												j = 0;
												while (j < num30 && Class60.smethod_9(array5[j]) != null)
												{
													num34 = array5[j];
													j++;
												}
												num27 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
												bool flag66 = num27 == num34;
												if (flag66)
												{
													goto IL_97C;
												}
												bool flag67 = num34 > 0 && Class50.smethod_5(gstruct49_0, num34) > 0;
												if (flag67)
												{
													Thread.Sleep(300);
													Class60.smethod_11(gstruct49_0, 15000);
												}
												num16++;
												bool flag68 = num16 <= 3;
												if (flag68)
												{
													goto IL_1055;
												}
												gstruct = Class43.smethod_4(num27, num5);
												bool flag69 = gstruct.int_0 != num27 || gstruct.int_1 != num5 || gstruct.uint_0 == null;
												if (flag69)
												{
													num16 = 0;
													goto IL_1055;
												}
												goto IL_1066;
												goto IL_DAD;
												IL_1066:
												Class22.WriteProcessMemory(gstruct49_0.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
												array8 = new uint[]
												{
													Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
													Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
												};
												int num36 = 0;
												bool flag70 = gstruct.uint_0.GetLength(0) > 1;
												if (flag70)
												{
													num36 = Class60.smethod_20(gstruct.uint_0, array8);
												}
												uint[] uint_2 = null;
												uint[] uint_3 = null;
												int num37 = 0;
												Class60.smethod_8(gstruct.uint_0, num36, ref uint_2, ref uint_3, ref num37);
												long num38 = Class60.smethod_18(array8, uint_2);
												bool flag71 = num38 <= 240000L;
												if (flag71)
												{
													int num39 = 0;
													int num40 = 0;
													Thread.Sleep(600);
													while (num39 < 100 && num40 < 30)
													{
														int num41 = (int)Class22.smethod_30(num24 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
														num40 = ((num41 != 3) ? (num40 + 1) : 0);
														num39++;
														Thread.Sleep(10);
													}
													Class60.smethod_23(gstruct49_0, uint_2, num37, uint_3, gstruct.int_1);
												}
												else
												{
													bool flag72 = array == null;
													if (flag72)
													{
														array = new uint[]
														{
															array8[0],
															array8[1]
														};
														num = 0;
													}
													bool flag73 = num > 12;
													if (flag73)
													{
														long num42 = Class60.smethod_18(array, array8);
														bool flag74 = num42 < 180000L;
														if (flag74)
														{
															Class22.WriteProcessMemory(gstruct49_0.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
															Class60.smethod_2(gstruct49_0, array8, uint_2, 600);
														}
														array = null;
													}
													bool flag75 = num27 != 53 || num5 != 199;
													if (flag75)
													{
														int num43 = (int)Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
														bool flag76 = num43 <= 0;
														if (flag76)
														{
															int[] array11 = Class60.smethod_9(num27);
															bool flag77 = array11 == null || array11[1] != 0;
															if (!flag77)
															{
																uint[] array12 = Class43.smethod_10(uint_2, num27, "NGOAITHANH", true);
																bool flag78 = array12 != null;
																if (flag78)
																{
																	long num44 = Class60.smethod_18(uint_2, array12);
																	bool flag79 = num44 <= 400000000L;
																	if (flag79)
																	{
																		uint[,] array13 = Class42.smethod_1(num27, array8, array12, null, false);
																		bool flag80 = array13 != null;
																		if (flag80)
																		{
																			int num45 = Class60.smethod_20(array13, array12);
																			bool flag81 = num45 >= 0;
																			if (flag81)
																			{
																				uint[] uint_4 = new uint[]
																				{
																					array13[num45, 0],
																					array13[num45, 1]
																				};
																				long num46 = Class60.smethod_18(array8, uint_4);
																				bool flag82 = num46 > 90000L;
																				if (flag82)
																				{
																					Class14.smethod_2(gstruct49_0, false);
																					Class60.smethod_22(gstruct49_0, array13, array8, array12, num27, true, 6000, false);
																					goto IL_1055;
																				}
																				goto IL_F97;
																			}
																		}
																	}
																}
																goto IL_1393;
															}
															IL_F97:
															bool flag83 = num27 == 224;
															if (flag83)
															{
																long num47 = Class60.smethod_21(array7, array8);
																bool flag84 = num47 < 200000L;
																if (flag84)
																{
																	int length = array7.GetLength(0);
																	uint[] uint_5 = new uint[]
																	{
																		array7[0, 0],
																		array7[0, 1]
																	};
																	uint[] array14 = new uint[]
																	{
																		array7[length - 1, 0],
																		array7[length - 1, 1]
																	};
																	long num48 = Class60.smethod_18(array8, uint_5);
																	long num49 = Class60.smethod_18(array8, array14);
																	bool flag85 = num48 < num49;
																	if (flag85)
																	{
																		Class60.smethod_22(gstruct49_0, array7, array8, array14, num27, true, 0, false);
																	}
																}
															}
														}
														IL_F48:
														bool flag86 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_) > 5000L;
														if (flag86)
														{
															num += 3;
															Class14.smethod_1(gstruct49_0, uint_2);
															long_ = Class12.smethod_27();
															Thread.Sleep(300);
														}
														Class60.smethod_29(gstruct49_0, false);
														goto IL_1055;
														IL_1393:
														goto IL_F48;
													}
													Class60.smethod_22(gstruct49_0, FormChayBoss.uint_0, array8, null, num27, false, 8000, false);
												}
											}
											else
											{
												flag6 = true;
												num16 = 0;
												bool flag87 = !flag16;
												if (!flag87)
												{
													goto IL_8F3;
												}
												bool flag88 = 0 > num12 || num12 == num28;
												if (!flag88)
												{
													goto IL_8EC;
												}
												long num50 = Class60.smethod_18(array8, array3);
												bool flag89 = num50 >= 100000L;
												if (!flag89)
												{
													goto IL_8E5;
												}
												bool flag90 = array == null;
												if (flag90)
												{
													array = new uint[]
													{
														array8[0],
														array8[1]
													};
													num = 0;
												}
												bool flag91 = num > 2;
												if (flag91)
												{
													bool flag92 = array != null && Class60.smethod_18(array, array8) < 180000L;
													array = null;
													bool flag93 = flag92;
													if (flag93)
													{
														Class22.WriteProcessMemory(gstruct49_0.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
														Class60.smethod_2(gstruct49_0, array8, array3, 600);
														goto IL_1055;
													}
												}
												Class60.smethod_29(gstruct49_0, false);
												bool flag94 = num27 == 224;
												if (flag94)
												{
													num50 = Class60.smethod_21(array7, array8);
													bool flag95 = num50 < 200000L;
													if (flag95)
													{
														int length2 = array7.GetLength(0);
														uint[] uint_6 = new uint[]
														{
															array7[0, 0],
															array7[0, 1]
														};
														uint[] array15 = new uint[]
														{
															array7[length2 - 1, 0],
															array7[length2 - 1, 1]
														};
														long num51 = Class60.smethod_18(array8, uint_6);
														long num52 = Class60.smethod_18(array8, array15);
														bool flag96 = num51 < num52;
														if (flag96)
														{
															Class60.smethod_22(gstruct49_0, array7, array8, array15, num27, false, 0, false);
														}
													}
												}
												bool flag97 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_) > 5000L;
												if (flag97)
												{
													num++;
													num12 = num28;
													Class14.smethod_1(gstruct49_0, array3);
													long_ = Class12.smethod_27();
												}
											}
										}
										else
										{
											for (int k = 0; k < 8; k++)
											{
												bool flag98 = num28 == num15;
												if (flag98)
												{
													break;
												}
												bool flag99 = num15 <= 0;
												if (flag99)
												{
													break;
												}
												num28 = (int)Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
												Thread.Sleep(100);
											}
											num15 = num28;
											num16 = 0;
										}
									}
									IL_1055:
									Thread.Sleep(150);
								}
								bool flag100 = !Class60.smethod_14(gstruct49_0, true);
								if (flag100)
								{
									Thread.Sleep(100);
									num3 = 1;
								}
								else
								{
									Thread.Sleep(300);
									Class60.smethod_11(gstruct49_0, 15000);
									num3 = -1;
								}
								goto IL_13BD;
								IL_8E5:
								num3 = 1;
								goto IL_13BD;
								IL_8EC:
								num3 = -1;
								goto IL_13BD;
								IL_8F3:
								num3 = 1;
								goto IL_13BD;
								IL_95E:
								num3 = -2;
								goto IL_13BD;
								IL_966:
								num3 = -1;
								Class14.smethod_2(gstruct49_0, false);
								goto IL_13BD;
								IL_975:
								num3 = -1;
								goto IL_13BD;
								IL_A30:
								num3 = 1;
								goto IL_13BD;
								Block_79:
								num3 = 1;
								goto IL_13BD;
								IL_C60:
								num3 = -1;
								IL_13BD:;
							}
							else
							{
								num3 = 1;
							}
						}
						else
						{
							num3 = 1;
						}
					}
					else
					{
						num3 = 1;
					}
				}
			}
			else
			{
				num3 = 1;
			}
			bool flag101 = num3 > 0 && Class44.gstruct33_0.int_0 == gstruct49_0.int_136;
			if (flag101)
			{
				Class44.gstruct33_0.bool_1 = false;
			}
			Class14.smethod_2(gstruct49_0, false);
			Class70.smethod_52(gstruct49_0, Class10.smethod_2("<color=yellow>Kết thúc chạy điểm boss !"), 1);
			return num3;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0013508C File Offset: 0x0013328C
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			string text = string.Empty;
			bool flag = FormChayBoss.string_2 != null;
			if (flag)
			{
				for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
				{
					string text2 = string.Empty;
					for (int j = 0; j < FormChayBoss.string_2.GetLength(1); j++)
					{
						bool flag2 = text2 != string.Empty;
						if (flag2)
						{
							text2 += "ÿ";
						}
						text2 += FormChayBoss.string_2[i, j];
					}
					bool flag3 = text != string.Empty;
					if (flag3)
					{
						text += "\r";
					}
					text += text2;
				}
			}
			Class12.smethod_34(Class53.string_9 + "\\ToadoBoss.txt", text, 1);
			FormChayBoss.bool_0 = false;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00135170 File Offset: 0x00133370
		private void FormChayBoss_Load(object sender, EventArgs e)
		{
			this.timer_0.Enabled = false;
			bool flag = 0 <= this.int_0 && 0 <= this.int_1;
			if (flag)
			{
				int num = this.int_0 - base.Width;
				int num2 = this.int_1 + this.int_3 - base.Height;
				bool flag2 = num < 0;
				if (flag2)
				{
					num = 0;
				}
				bool flag3 = num2 < 0;
				if (flag3)
				{
					num2 = 0;
				}
				base.SetBounds(num, num2, base.Width, base.Height);
			}
			this.checkBoxTuLuuRuong.Checked = (FormChayBoss.int_4 > 0);
			this.checkBoxTrolaiDiemcu.Checked = (FormChayBoss.int_5 > 0);
			bool flag4 = FormChayBoss.string_2 != null;
			if (flag4)
			{
				for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
				{
					this.method_0(this.listView1, FormChayBoss.string_2[i, 0], FormChayBoss.string_2[i, 1], FormChayBoss.string_2[i, 4]);
				}
			}
			string text = string.Empty;
			for (int j = 0; j < FormChayBoss.string_1.GetLength(0); j++)
			{
				string text2 = FormChayBoss.string_1[j, 0];
				int num3 = Class12.smethod_1(text2, ".");
				bool flag5 = num3 > 0;
				if (flag5)
				{
					text2 = text2.Substring(0, num3);
				}
				bool flag6 = text == string.Empty;
				if (flag6)
				{
					text = text2;
				}
				else
				{
					bool flag7 = !FormChayBoss.smethod_3(text, text2);
					if (flag7)
					{
						text = text + "|" + text2;
					}
				}
				bool flag8 = j == 70;
				if (flag8)
				{
					Thread.Sleep(10);
				}
			}
			string[] array = text.Split(new char[]
			{
				'|'
			});
			for (int k = 0; k < array.Length; k++)
			{
				this.comboBoxTenTat.Items.Add(array[k]);
			}
			this.comboBoxTenTat.Text = array[0];
			Thread.Sleep(150);
			bool flag9 = FormChayBoss.bool_3;
			if (flag9)
			{
				string string_ = "Chưa được cập nhật Phượng Tường và Sơn Bảo động, bấm nút sau để cập nhật lại phần này:||1. Bấm nút <Lưu vào tệp> để đề phòng cần xem lại tọa độ.||2. Bấm nút <Xóa tọa độ về mặc định> để hiển thị phần Phượng Tường.||";
				FormTip.smethod_0("DIEM BOSS", string_, 600000, 300, 180, false, base.Left, base.Top, false, false, false);
			}
			this.timer_0.Interval = 100;
			this.timer_0.Enabled = true;
			FormChayBoss.bool_2 = true;
			base.TopMost = true;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x001353FC File Offset: 0x001335FC
		private static bool smethod_3(string string_3, string string_4)
		{
			return Class12.smethod_1(string_3, string_4) >= 0;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0013541C File Offset: 0x0013361C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormChayBoss.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00135440 File Offset: 0x00133640
		private void method_0(ListView listView_0, string string_3, string string_4, string string_5)
		{
			try
			{
				string[] array = new string[]
				{
					string_3,
					string_4,
					string_5
				};
				ListViewItem listViewItem = new ListViewItem(array[0]);
				bool flag = array.Length > 1;
				if (flag)
				{
					for (int i = 1; i < array.Length; i++)
					{
						ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
						listViewItem.SubItems.Add(item);
					}
				}
				listView_0.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x001354CC File Offset: 0x001336CC
		private int method_1(ListView listView_0)
		{
			bool flag = listView_0.Items != null;
			if (flag)
			{
				for (int i = 0; i < listView_0.Items.Count; i++)
				{
					bool selected = listView_0.Items[i].Selected;
					if (selected)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00135528 File Offset: 0x00133728
		private void checkBoxTuLuuRuong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormChayBoss.bool_2;
			if (flag)
			{
				FormChayBoss.int_4 = (int)Convert.ToByte(this.checkBoxTuLuuRuong.Checked);
				Class62.smethod_10(Class53.string_3, "flagLuuRuongChayBoss", FormChayBoss.int_4, "", 0);
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00135586 File Offset: 0x00133786
		private void buttonApdungAll_Click(object sender, EventArgs e)
		{
			FormChayBoss.bool_0 = false;
			base.Close();
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00135598 File Offset: 0x00133798
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormChayBoss.bool_2;
			if (!flag)
			{
				int num = this.method_1(this.listView1);
				bool flag2 = num >= 0;
				if (flag2)
				{
					string text = FormChayBoss.string_0 = this.listView1.Items[num].SubItems[0].Text;
					int num2 = Class12.smethod_1(text, ".");
					bool flag3 = num2 > 0;
					if (flag3)
					{
						text = text.Substring(0, num2);
					}
					this.comboBoxTenTat.Text = text;
					this.textBoxToado.Text = this.listView1.Items[num].SubItems[1].Text;
				}
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00135668 File Offset: 0x00133868
		private void buttonSua_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormChayBoss.bool_2;
			if (!flag)
			{
				string text = this.textBoxToado.Text.Trim().Replace(" ", "").Replace("/", ".").Replace(",", ".");
				bool flag2 = Class12.smethod_1(text, ".") <= 0;
				if (!flag2)
				{
					int num = this.method_1(this.listView1);
					bool flag3 = num >= 0 && FormChayBoss.string_2.GetLength(0) > num;
					if (flag3)
					{
						string text2 = this.listView1.Items[num].SubItems[0].Text;
						string text3 = this.listView1.Items[num].SubItems[1].Text;
						this.listView1.Items[num].SubItems[0].Text = text2.Replace(text3, text);
						this.listView1.Items[num].SubItems[1].Text = text;
						int num2 = Class12.smethod_1(FormChayBoss.string_2[num, 0], " ");
						bool flag4 = num2 > 0;
						if (flag4)
						{
							FormChayBoss.string_2[num, 0] = FormChayBoss.string_2[num, 0].Substring(0, num2) + " " + text;
						}
						FormChayBoss.string_2[num, 1] = text;
						FormChayBoss.bool_1 = true;
					}
				}
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00135814 File Offset: 0x00133A14
		private void buttonMacdinh_Click(object sender, EventArgs e)
		{
			string text = "Huong dan: Bấm <Lưu vào tệp> đề phòng muốn xem lại tọa độ cũ." + Class53.string_7 + Class53.string_7 + "Bạn chắc chắn muốn xóa dữ liệu tọa độ boss hiện tại để đưa về mặc định của auto ?";
			bool flag = MessageBox.Show(text, Form1.string_1, MessageBoxButtons.YesNo) != DialogResult.No;
			if (flag)
			{
				FormChayBoss.string_2 = FormChayBoss.string_1;
				this.listView1.Items.Clear();
				for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
				{
					this.method_0(this.listView1, FormChayBoss.string_2[i, 0], FormChayBoss.string_2[i, 1], FormChayBoss.string_2[i, 4]);
				}
				FormChayBoss.bool_1 = true;
				FormChayBoss.bool_3 = false;
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x001358C8 File Offset: 0x00133AC8
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			int num = this.method_1(this.listView1);
			bool flag = num < 0 || FormChayBoss.string_2.GetLength(0) <= num;
			if (!flag)
			{
				this.listView1.Items.RemoveAt(num);
				int num2 = num;
				int count = this.listView1.Items.Count;
				bool flag2 = count > 0;
				if (flag2)
				{
					bool flag3 = count <= num;
					if (flag3)
					{
						num = count - 1;
					}
					this.listView1.TopItem = this.listView1.Items[num];
					this.listView1.Items[num].Focused = true;
					this.listView1.Items[num].Selected = true;
				}
				bool flag4 = FormChayBoss.string_2 == null;
				if (!flag4)
				{
					string[,] array = new string[FormChayBoss.string_2.GetLength(0) - 1, FormChayBoss.string_2.GetLength(1)];
					int num3 = 0;
					for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
					{
						bool flag5 = i != num2;
						if (flag5)
						{
							for (int j = 0; j < FormChayBoss.string_2.GetLength(1); j++)
							{
								array[num3, j] = FormChayBoss.string_2[i, j];
							}
							num3++;
						}
					}
					FormChayBoss.string_2 = array;
					FormChayBoss.bool_1 = true;
				}
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00135A48 File Offset: 0x00133C48
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = FormChayBoss.string_2 == null;
			if (flag)
			{
				FormChayBoss.string_2 = FormChayBoss.string_1;
				this.listView1.Items.Clear();
				for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
				{
					this.method_0(this.listView1, FormChayBoss.string_2[i, 0], FormChayBoss.string_2[i, 1], FormChayBoss.string_2[i, 4]);
				}
				FormChayBoss.bool_1 = true;
			}
			else
			{
				int num = -1;
				int num2 = 1;
				string text = "...";
				string text2 = "0.0";
				string text3 = this.comboBoxTenTat.Text;
				bool flag2 = !(text3 == "...");
				if (flag2)
				{
					text2 = this.textBoxToado.Text.Replace(",", ".").Replace("/", ".");
					bool flag3 = Class12.smethod_1(text2, ".") <= 0;
					if (flag3)
					{
						string string_ = "Tọa độ sai qui cách, phải là dạng XXX.YYY (ví dụ: 123.456)";
						FormTip.smethod_0(Form1.string_1, string_, 600000, 250, 80, false, -1, -1, false, false, false);
						return;
					}
					for (int j = 0; j < FormChayBoss.string_2.GetLength(0); j++)
					{
						bool flag4 = Class12.smethod_1(FormChayBoss.string_2[j, 0], text3) == 0;
						if (flag4)
						{
							num2++;
						}
					}
					for (int k = 0; k < FormChayBoss.string_1.GetLength(0); k++)
					{
						bool flag5 = Class12.smethod_1(FormChayBoss.string_1[k, 0], text3) == 0;
						if (flag5)
						{
							num = k;
							break;
						}
					}
					bool flag6 = num < 0;
					if (flag6)
					{
						string string_2 = "Tên tắt Không có trong danh sách, bạn bấm nút Xóa đưa về tọa độ mặc định để lấy tên tắt.|";
						FormTip.smethod_0(Form1.string_1, string_2, 600000, 280, 100, false, -1, -1, false, false, false);
						return;
					}
					text = string.Concat(new string[]
					{
						text3,
						".",
						num2.ToString(),
						" ",
						text2
					});
				}
				string[,] array = new string[FormChayBoss.string_2.GetLength(0) + 1, FormChayBoss.string_2.GetLength(1)];
				for (int l = 0; l < FormChayBoss.string_2.GetLength(0); l++)
				{
					for (int m = 0; m < FormChayBoss.string_2.GetLength(1); m++)
					{
						array[l, m] = FormChayBoss.string_2[l, m];
					}
				}
				int num3 = FormChayBoss.string_2.GetLength(0);
				string text4 = string.Empty;
				array[num3, 0] = text;
				array[num3, 1] = text2;
				array[num3, 2] = "0";
				array[num3, 3] = "0|0|0|0";
				array[num3, 4] = text4;
				bool flag7 = text != "...";
				if (flag7)
				{
					for (int n = 2; n < FormChayBoss.string_2.GetLength(1); n++)
					{
						array[num3, n] = FormChayBoss.string_1[num, n];
					}
					text4 = FormChayBoss.string_1[num, 4];
				}
				FormChayBoss.string_2 = array;
				this.method_0(this.listView1, text, text2, text4);
				num3 = this.listView1.Items.Count;
				this.listView1.TopItem = this.listView1.Items[num3 - 1];
				this.listView1.Items[num3 - 1].Focused = true;
				this.listView1.Items[num3 - 1].Selected = true;
				FormChayBoss.bool_1 = true;
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00135E24 File Offset: 0x00134024
		private void buttonLen_Click(object sender, EventArgs e)
		{
			int num = this.method_1(this.listView1);
			bool flag = num <= 0 || FormChayBoss.string_2 == null;
			if (!flag)
			{
				int count = this.listView1.Items[num].SubItems.Count;
				for (int i = 0; i < count; i++)
				{
					string text = this.listView1.Items[num].SubItems[i].Text;
					this.listView1.Items[num].SubItems[i].Text = this.listView1.Items[num - 1].SubItems[i].Text;
					this.listView1.Items[num - 1].SubItems[i].Text = text;
				}
				bool flag2 = num == this.listView1.TopItem.Index;
				if (flag2)
				{
					this.listView1.TopItem = this.listView1.Items[num - 1];
				}
				this.listView1.Items[num - 1].Focused = true;
				this.listView1.Items[num - 1].Selected = true;
				bool flag3 = FormChayBoss.string_2.GetLength(0) > 1;
				if (flag3)
				{
					for (int j = 0; j < FormChayBoss.string_2.GetLength(1); j++)
					{
						string text2 = FormChayBoss.string_2[num, j];
						FormChayBoss.string_2[num, j] = FormChayBoss.string_2[num - 1, j];
						FormChayBoss.string_2[num - 1, j] = text2;
					}
				}
				FormChayBoss.bool_1 = true;
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00136004 File Offset: 0x00134204
		private void buttonXuong_Click(object sender, EventArgs e)
		{
			int num = this.method_1(this.listView1);
			bool flag = num <= 0 || FormChayBoss.string_2.GetLength(0) - 1 <= num || FormChayBoss.string_2 == null;
			if (!flag)
			{
				int count = this.listView1.Items[num].SubItems.Count;
				for (int i = 0; i < count; i++)
				{
					string text = this.listView1.Items[num].SubItems[i].Text;
					this.listView1.Items[num].SubItems[i].Text = this.listView1.Items[num + 1].SubItems[i].Text;
					this.listView1.Items[num + 1].SubItems[i].Text = text;
				}
				bool flag2 = num - this.listView1.TopItem.Index > 12;
				if (flag2)
				{
					this.listView1.TopItem = this.listView1.Items[num + 1];
				}
				this.listView1.Items[num + 1].Focused = true;
				this.listView1.Items[num + 1].Selected = true;
				bool flag3 = FormChayBoss.string_2.GetLength(0) > 1;
				if (flag3)
				{
					for (int j = 0; j < FormChayBoss.string_2.GetLength(1); j++)
					{
						string text2 = FormChayBoss.string_2[num, j];
						FormChayBoss.string_2[num, j] = FormChayBoss.string_2[num + 1, j];
						FormChayBoss.string_2[num + 1, j] = text2;
					}
				}
				FormChayBoss.bool_1 = true;
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x001361F4 File Offset: 0x001343F4
		private void checkBoxTrolaiDiemcu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormChayBoss.bool_2;
			if (flag)
			{
				FormChayBoss.int_5 = (int)Convert.ToByte(this.checkBoxTrolaiDiemcu.Checked);
				Class62.smethod_10(Class53.string_3, "flagDiemcuChayBoss", FormChayBoss.int_5, "", 0);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00136254 File Offset: 0x00134454
		private void buttonLuu_Click(object sender, EventArgs e)
		{
			string text = Class53.string_9 + "\\ToadoBossLuu.txt";
			bool flag = Class12.smethod_17(text);
			if (flag)
			{
				string text2 = "Lệnh lưu vào tệp sẽ ghi đè tọa độ boss hiện có vào tệp ToadoBossLuu.txt cũ, nên những tọa độ cũ trong tệp sẽ mất hết và thay thế vào đó là tọa độ boss hiện tại." + Class53.string_7 + Class53.string_7 + "Bạn có chắc chắn muốn lưu vào tệp không ?";
				bool flag2 = MessageBox.Show(text2, "TOA_DO_BOSS", MessageBoxButtons.YesNo) == DialogResult.No;
				if (flag2)
				{
					return;
				}
			}
			string text3 = string.Empty;
			bool flag3 = FormChayBoss.string_2 != null;
			if (flag3)
			{
				for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
				{
					bool flag4 = FormChayBoss.string_2.GetLength(1) >= 2;
					if (flag4)
					{
						object obj = text3;
						text3 = string.Concat(new object[]
						{
							obj,
							i,
							". ",
							FormChayBoss.string_2[i, 0]
						});
						bool flag5 = FormChayBoss.string_2[i, 1] != null && FormChayBoss.string_2[i, 1] != string.Empty && FormChayBoss.string_2[i, 1] != "0.0";
						if (flag5)
						{
							text3 = text3 + "\t : " + FormChayBoss.string_2[i, 1];
						}
						bool flag6 = FormChayBoss.string_2[i, 4] != null && FormChayBoss.string_2[i, 4] != string.Empty;
						if (flag6)
						{
							text3 = text3 + "\t : " + FormChayBoss.string_2[i, 4];
						}
						text3 += Class53.string_7;
					}
				}
			}
			Class12.smethod_34(text, text3, 1);
			MessageBox.Show("Đã lưu tọa độ boss vào tệp: " + Class53.string_7 + text, "TOA DO BOSS", MessageBoxButtons.OK);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00136420 File Offset: 0x00134620
		private void buttonXem_Click(object sender, EventArgs e)
		{
			string string_ = Class12.smethod_33(Class53.string_9 + "\\ToadoBossLuu.txt", 0, 0, 1);
			FormTip.smethod_0("TOA DO BOSS (LUU)", string_, 900000, 430, 600, true, -1, -1, false, false, false);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00136468 File Offset: 0x00134668
		private void buttonThumucAuto_Click(object sender, EventArgs e)
		{
			string environmentVariable = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0));
			string string_ = Class53.string_9;
			Class22.smethod_40(environmentVariable + "\\explorer.exe", string_, string_, 0, false, false);
		}

		// Token: 0x040007C7 RID: 1991
		private IContainer icontainer_0 = null;

		// Token: 0x040007E4 RID: 2020
		public static bool bool_0 = false;

		// Token: 0x040007E5 RID: 2021
		public static bool bool_1 = false;

		// Token: 0x040007E6 RID: 2022
		public static string string_0 = null;

		// Token: 0x040007E7 RID: 2023
		public int int_0;

		// Token: 0x040007E8 RID: 2024
		public int int_1;

		// Token: 0x040007E9 RID: 2025
		public int int_2;

		// Token: 0x040007EA RID: 2026
		public int int_3;

		// Token: 0x040007EB RID: 2027
		private static bool bool_2 = false;

		// Token: 0x040007EC RID: 2028
		private static bool bool_3 = false;

		// Token: 0x040007ED RID: 2029
		public static int int_4 = Class62.smethod_3("flagLuuRuongChayBoss", 0, "1");

		// Token: 0x040007EE RID: 2030
		public static int int_5 = Class62.smethod_3("flagDiemcuChayBoss", 0, "1");

		// Token: 0x040007EF RID: 2031
		public static string[,] string_1;

		// Token: 0x040007F0 RID: 2032
		private static uint[,] uint_0;

		// Token: 0x040007F2 RID: 2034
		public static string[,] string_2;
	}
}
