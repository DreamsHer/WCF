﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_XinZengShuJu {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLLPaiMaiXiTong.FRM_XinZengShuJu.FRM_XinZengShuJu")]
    public interface FRM_XinZengShuJu {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuJiaoYiZhuangTai", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuJiaoYiZhuangTaiResponse")]
        System.Data.DataSet XinZengShuJuJiaoYiZhuangTai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuJiaoYiZhuangTai", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuJiaoYiZhuangTaiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuJiaoYiZhuangTaiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuXingZhengQu", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuXingZhengQuResponse")]
        System.Data.DataSet XinZengShuJuXingZhengQu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuXingZhengQu", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuXingZhengQuResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuXingZhengQuAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuJiaoYiLeiBie", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuJiaoYiLeiBieResponse")]
        System.Data.DataSet XinZengShuJuJiaoYiLeiBie();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuJiaoYiLeiBie", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuJiaoYiLeiBieResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuJiaoYiLeiBieAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuShenQingTiSi", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuShenQingTiSiResponse")]
        System.Data.DataSet XinZengShuJuShenQingTiSi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuShenQingTiSi", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuShenQingTiSiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuShenQingTiSiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuGongGaoLeiXing", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuGongGaoLeiXingResponse")]
        System.Data.DataSet XinZengShuJuGongGaoLeiXing();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuGongGaoLeiXing", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuGongGaoLeiXingResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuGongGaoLeiXingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuKeHuMingCheng", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuKeHuMingChengResponse")]
        System.Data.DataSet XinZengShuJuKeHuMingCheng();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuKeHuMingCheng", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuKeHuMingChengResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuKeHuMingChengAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengGuaPaiShuJu", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengGuaPaiShuJuResponse")]
        int XinZengGuaPaiShuJu(
                    string GuaPaiBianHao, 
                    string JiaoYiFangShi, 
                    int JiaoYiLeiBieID, 
                    int JiaoYiZhuangTaiID, 
                    System.DateTime GuaPaiQiShiShiJian, 
                    System.DateTime GuaPaiJieZhiShiJian, 
                    System.DateTime BaoZhengJinDaoZhangJieZhiShiJian, 
                    string DiKuaiMingCheng, 
                    string TuDiWeiZhi, 
                    decimal QiShiJia, 
                    decimal ZengFu, 
                    string YuFuKuan, 
                    decimal BaoZhengJinJinE, 
                    string TuDiQuanShuDanWei, 
                    int XingZhengQuID, 
                    string ShiYongQuanMianJi, 
                    string JianZhuMianJi, 
                    string GuiHuaYongTu, 
                    string GuiHuaZhiBiao, 
                    string ChuRangNianXian, 
                    string DiKuaiBeiZhu, 
                    string RongJiLv, 
                    string JianZhuMiDu, 
                    string LvHuaLv, 
                    string JianZhuXianGao, 
                    string TouZiQiangDu, 
                    string XianZhuangTuDiTiaoJian, 
                    bool ShiFouYouBaoZhangXingZhuFang, 
                    decimal QiShiBaoZhangXingZhuFangBiLi, 
                    decimal ZuiGaoXianJia, 
                    decimal BiLiZengFu, 
                    bool ShiFouYouFuJiaZiGeShenHeTiaoJian, 
                    string GongGaoBeiZhu, 
                    int ShenQingTiShiID, 
                    int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengGuaPaiShuJu", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengGuaPaiShuJuResponse")]
        System.Threading.Tasks.Task<int> XinZengGuaPaiShuJuAsync(
                    string GuaPaiBianHao, 
                    string JiaoYiFangShi, 
                    int JiaoYiLeiBieID, 
                    int JiaoYiZhuangTaiID, 
                    System.DateTime GuaPaiQiShiShiJian, 
                    System.DateTime GuaPaiJieZhiShiJian, 
                    System.DateTime BaoZhengJinDaoZhangJieZhiShiJian, 
                    string DiKuaiMingCheng, 
                    string TuDiWeiZhi, 
                    decimal QiShiJia, 
                    decimal ZengFu, 
                    string YuFuKuan, 
                    decimal BaoZhengJinJinE, 
                    string TuDiQuanShuDanWei, 
                    int XingZhengQuID, 
                    string ShiYongQuanMianJi, 
                    string JianZhuMianJi, 
                    string GuiHuaYongTu, 
                    string GuiHuaZhiBiao, 
                    string ChuRangNianXian, 
                    string DiKuaiBeiZhu, 
                    string RongJiLv, 
                    string JianZhuMiDu, 
                    string LvHuaLv, 
                    string JianZhuXianGao, 
                    string TouZiQiangDu, 
                    string XianZhuangTuDiTiaoJian, 
                    bool ShiFouYouBaoZhangXingZhuFang, 
                    decimal QiShiBaoZhangXingZhuFangBiLi, 
                    decimal ZuiGaoXianJia, 
                    decimal BiLiZengFu, 
                    bool ShiFouYouFuJiaZiGeShenHeTiaoJian, 
                    string GongGaoBeiZhu, 
                    int ShenQingTiShiID, 
                    int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengGongGaoBiao", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengGongGaoBiaoResponse")]
        int XinZengGongGaoBiao(string GongGaoBianHao, string BiaoTi, System.DateTime FaBuShiJian, int GongGaoLeiXingID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengGongGaoBiao", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengGongGaoBiaoResponse")]
        System.Threading.Tasks.Task<int> XinZengGongGaoBiaoAsync(string GongGaoBianHao, string BiaoTi, System.DateTime FaBuShiJian, int GongGaoLeiXingID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengKeHuBiao", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengKeHuBiaoResponse")]
        int XinZengKeHuBiao(int KeHuLeiXingID, string KeHuMingCheng, string ZhengJianHao, string LianXiDiZhi, string LianXiRen, string FaRenDaiBiao, string YouXiang, string YouZhengBianMa, string LianXiDianHua, string ShuZiZhengShuMiMa, bool ZhengShuShiFouYouXiao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengKeHuBiao", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengKeHuBiaoResponse")]
        System.Threading.Tasks.Task<int> XinZengKeHuBiaoAsync(int KeHuLeiXingID, string KeHuMingCheng, string ZhengJianHao, string LianXiDiZhi, string LianXiRen, string FaRenDaiBiao, string YouXiang, string YouZhengBianMa, string LianXiDianHua, string ShuZiZhengShuMiMa, bool ZhengShuShiFouYouXiao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/ChaXunZuiDaGuaPaiDanShu", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/ChaXunZuiDaGuaPaiDanShuResponse")]
        System.Data.DataSet ChaXunZuiDaGuaPaiDanShu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/ChaXunZuiDaGuaPaiDanShu", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/ChaXunZuiDaGuaPaiDanShuResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ChaXunZuiDaGuaPaiDanShuAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/ChaXunZuiDaGongGaoDanShu", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/ChaXunZuiDaGongGaoDanShuResponse")]
        System.Data.DataSet ChaXunZuiDaGongGaoDanShu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/ChaXunZuiDaGongGaoDanShu", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/ChaXunZuiDaGongGaoDanShuResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ChaXunZuiDaGongGaoDanShuAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuKeHuLeiXing", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuKeHuLeiXingResponse")]
        System.Data.DataSet XinZengShuJuKeHuLeiXing();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuKeHuLeiXing", ReplyAction="http://tempuri.org/FRM_XinZengShuJu/XinZengShuJuKeHuLeiXingResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuKeHuLeiXingAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_XinZengShuJuChannel : 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_XinZengShuJu.FRM_XinZengShuJu, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_XinZengShuJuClient : System.ServiceModel.ClientBase<宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_XinZengShuJu.FRM_XinZengShuJu>, 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_XinZengShuJu.FRM_XinZengShuJu {
        
        public FRM_XinZengShuJuClient() {
        }
        
        public FRM_XinZengShuJuClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_XinZengShuJuClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_XinZengShuJuClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_XinZengShuJuClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet XinZengShuJuJiaoYiZhuangTai() {
            return base.Channel.XinZengShuJuJiaoYiZhuangTai();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuJiaoYiZhuangTaiAsync() {
            return base.Channel.XinZengShuJuJiaoYiZhuangTaiAsync();
        }
        
        public System.Data.DataSet XinZengShuJuXingZhengQu() {
            return base.Channel.XinZengShuJuXingZhengQu();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuXingZhengQuAsync() {
            return base.Channel.XinZengShuJuXingZhengQuAsync();
        }
        
        public System.Data.DataSet XinZengShuJuJiaoYiLeiBie() {
            return base.Channel.XinZengShuJuJiaoYiLeiBie();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuJiaoYiLeiBieAsync() {
            return base.Channel.XinZengShuJuJiaoYiLeiBieAsync();
        }
        
        public System.Data.DataSet XinZengShuJuShenQingTiSi() {
            return base.Channel.XinZengShuJuShenQingTiSi();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuShenQingTiSiAsync() {
            return base.Channel.XinZengShuJuShenQingTiSiAsync();
        }
        
        public System.Data.DataSet XinZengShuJuGongGaoLeiXing() {
            return base.Channel.XinZengShuJuGongGaoLeiXing();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuGongGaoLeiXingAsync() {
            return base.Channel.XinZengShuJuGongGaoLeiXingAsync();
        }
        
        public System.Data.DataSet XinZengShuJuKeHuMingCheng() {
            return base.Channel.XinZengShuJuKeHuMingCheng();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuKeHuMingChengAsync() {
            return base.Channel.XinZengShuJuKeHuMingChengAsync();
        }
        
        public int XinZengGuaPaiShuJu(
                    string GuaPaiBianHao, 
                    string JiaoYiFangShi, 
                    int JiaoYiLeiBieID, 
                    int JiaoYiZhuangTaiID, 
                    System.DateTime GuaPaiQiShiShiJian, 
                    System.DateTime GuaPaiJieZhiShiJian, 
                    System.DateTime BaoZhengJinDaoZhangJieZhiShiJian, 
                    string DiKuaiMingCheng, 
                    string TuDiWeiZhi, 
                    decimal QiShiJia, 
                    decimal ZengFu, 
                    string YuFuKuan, 
                    decimal BaoZhengJinJinE, 
                    string TuDiQuanShuDanWei, 
                    int XingZhengQuID, 
                    string ShiYongQuanMianJi, 
                    string JianZhuMianJi, 
                    string GuiHuaYongTu, 
                    string GuiHuaZhiBiao, 
                    string ChuRangNianXian, 
                    string DiKuaiBeiZhu, 
                    string RongJiLv, 
                    string JianZhuMiDu, 
                    string LvHuaLv, 
                    string JianZhuXianGao, 
                    string TouZiQiangDu, 
                    string XianZhuangTuDiTiaoJian, 
                    bool ShiFouYouBaoZhangXingZhuFang, 
                    decimal QiShiBaoZhangXingZhuFangBiLi, 
                    decimal ZuiGaoXianJia, 
                    decimal BiLiZengFu, 
                    bool ShiFouYouFuJiaZiGeShenHeTiaoJian, 
                    string GongGaoBeiZhu, 
                    int ShenQingTiShiID, 
                    int KeHuID) {
            return base.Channel.XinZengGuaPaiShuJu(GuaPaiBianHao, JiaoYiFangShi, JiaoYiLeiBieID, JiaoYiZhuangTaiID, GuaPaiQiShiShiJian, GuaPaiJieZhiShiJian, BaoZhengJinDaoZhangJieZhiShiJian, DiKuaiMingCheng, TuDiWeiZhi, QiShiJia, ZengFu, YuFuKuan, BaoZhengJinJinE, TuDiQuanShuDanWei, XingZhengQuID, ShiYongQuanMianJi, JianZhuMianJi, GuiHuaYongTu, GuiHuaZhiBiao, ChuRangNianXian, DiKuaiBeiZhu, RongJiLv, JianZhuMiDu, LvHuaLv, JianZhuXianGao, TouZiQiangDu, XianZhuangTuDiTiaoJian, ShiFouYouBaoZhangXingZhuFang, QiShiBaoZhangXingZhuFangBiLi, ZuiGaoXianJia, BiLiZengFu, ShiFouYouFuJiaZiGeShenHeTiaoJian, GongGaoBeiZhu, ShenQingTiShiID, KeHuID);
        }
        
        public System.Threading.Tasks.Task<int> XinZengGuaPaiShuJuAsync(
                    string GuaPaiBianHao, 
                    string JiaoYiFangShi, 
                    int JiaoYiLeiBieID, 
                    int JiaoYiZhuangTaiID, 
                    System.DateTime GuaPaiQiShiShiJian, 
                    System.DateTime GuaPaiJieZhiShiJian, 
                    System.DateTime BaoZhengJinDaoZhangJieZhiShiJian, 
                    string DiKuaiMingCheng, 
                    string TuDiWeiZhi, 
                    decimal QiShiJia, 
                    decimal ZengFu, 
                    string YuFuKuan, 
                    decimal BaoZhengJinJinE, 
                    string TuDiQuanShuDanWei, 
                    int XingZhengQuID, 
                    string ShiYongQuanMianJi, 
                    string JianZhuMianJi, 
                    string GuiHuaYongTu, 
                    string GuiHuaZhiBiao, 
                    string ChuRangNianXian, 
                    string DiKuaiBeiZhu, 
                    string RongJiLv, 
                    string JianZhuMiDu, 
                    string LvHuaLv, 
                    string JianZhuXianGao, 
                    string TouZiQiangDu, 
                    string XianZhuangTuDiTiaoJian, 
                    bool ShiFouYouBaoZhangXingZhuFang, 
                    decimal QiShiBaoZhangXingZhuFangBiLi, 
                    decimal ZuiGaoXianJia, 
                    decimal BiLiZengFu, 
                    bool ShiFouYouFuJiaZiGeShenHeTiaoJian, 
                    string GongGaoBeiZhu, 
                    int ShenQingTiShiID, 
                    int KeHuID) {
            return base.Channel.XinZengGuaPaiShuJuAsync(GuaPaiBianHao, JiaoYiFangShi, JiaoYiLeiBieID, JiaoYiZhuangTaiID, GuaPaiQiShiShiJian, GuaPaiJieZhiShiJian, BaoZhengJinDaoZhangJieZhiShiJian, DiKuaiMingCheng, TuDiWeiZhi, QiShiJia, ZengFu, YuFuKuan, BaoZhengJinJinE, TuDiQuanShuDanWei, XingZhengQuID, ShiYongQuanMianJi, JianZhuMianJi, GuiHuaYongTu, GuiHuaZhiBiao, ChuRangNianXian, DiKuaiBeiZhu, RongJiLv, JianZhuMiDu, LvHuaLv, JianZhuXianGao, TouZiQiangDu, XianZhuangTuDiTiaoJian, ShiFouYouBaoZhangXingZhuFang, QiShiBaoZhangXingZhuFangBiLi, ZuiGaoXianJia, BiLiZengFu, ShiFouYouFuJiaZiGeShenHeTiaoJian, GongGaoBeiZhu, ShenQingTiShiID, KeHuID);
        }
        
        public int XinZengGongGaoBiao(string GongGaoBianHao, string BiaoTi, System.DateTime FaBuShiJian, int GongGaoLeiXingID) {
            return base.Channel.XinZengGongGaoBiao(GongGaoBianHao, BiaoTi, FaBuShiJian, GongGaoLeiXingID);
        }
        
        public System.Threading.Tasks.Task<int> XinZengGongGaoBiaoAsync(string GongGaoBianHao, string BiaoTi, System.DateTime FaBuShiJian, int GongGaoLeiXingID) {
            return base.Channel.XinZengGongGaoBiaoAsync(GongGaoBianHao, BiaoTi, FaBuShiJian, GongGaoLeiXingID);
        }
        
        public int XinZengKeHuBiao(int KeHuLeiXingID, string KeHuMingCheng, string ZhengJianHao, string LianXiDiZhi, string LianXiRen, string FaRenDaiBiao, string YouXiang, string YouZhengBianMa, string LianXiDianHua, string ShuZiZhengShuMiMa, bool ZhengShuShiFouYouXiao) {
            return base.Channel.XinZengKeHuBiao(KeHuLeiXingID, KeHuMingCheng, ZhengJianHao, LianXiDiZhi, LianXiRen, FaRenDaiBiao, YouXiang, YouZhengBianMa, LianXiDianHua, ShuZiZhengShuMiMa, ZhengShuShiFouYouXiao);
        }
        
        public System.Threading.Tasks.Task<int> XinZengKeHuBiaoAsync(int KeHuLeiXingID, string KeHuMingCheng, string ZhengJianHao, string LianXiDiZhi, string LianXiRen, string FaRenDaiBiao, string YouXiang, string YouZhengBianMa, string LianXiDianHua, string ShuZiZhengShuMiMa, bool ZhengShuShiFouYouXiao) {
            return base.Channel.XinZengKeHuBiaoAsync(KeHuLeiXingID, KeHuMingCheng, ZhengJianHao, LianXiDiZhi, LianXiRen, FaRenDaiBiao, YouXiang, YouZhengBianMa, LianXiDianHua, ShuZiZhengShuMiMa, ZhengShuShiFouYouXiao);
        }
        
        public System.Data.DataSet ChaXunZuiDaGuaPaiDanShu() {
            return base.Channel.ChaXunZuiDaGuaPaiDanShu();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ChaXunZuiDaGuaPaiDanShuAsync() {
            return base.Channel.ChaXunZuiDaGuaPaiDanShuAsync();
        }
        
        public System.Data.DataSet ChaXunZuiDaGongGaoDanShu() {
            return base.Channel.ChaXunZuiDaGongGaoDanShu();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ChaXunZuiDaGongGaoDanShuAsync() {
            return base.Channel.ChaXunZuiDaGongGaoDanShuAsync();
        }
        
        public System.Data.DataSet XinZengShuJuKeHuLeiXing() {
            return base.Channel.XinZengShuJuKeHuLeiXing();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> XinZengShuJuKeHuLeiXingAsync() {
            return base.Channel.XinZengShuJuKeHuLeiXingAsync();
        }
    }
}
