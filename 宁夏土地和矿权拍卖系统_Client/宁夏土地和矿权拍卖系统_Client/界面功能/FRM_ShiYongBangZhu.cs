using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 宁夏土地和矿权拍卖系统_Client
{
    public partial class FRM_ShiYongBangZhu : Form
    {
        FRM_ZhuChuangTi myFRM_ZhuChuangTi;
        public FRM_ShiYongBangZhu(FRM_ZhuChuangTi FRM_ZhuChuangTi)
        {
            InitializeComponent();
            myFRM_ZhuChuangTi = FRM_ZhuChuangTi;
        }                
    }
}
