﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_HuoQuBaoZhangJinZhangHao {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLLPaiMaiXiTong.FRM_HuoQuBaoZhangJinZhangHao.FRM_HuoQuBaoZhangJinZhangHao")]
    public interface FRM_HuoQuBaoZhangJinZhangHao {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/FRM_HuoQuBaoZhangJinZhangHao_Load" +
            "", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/FRM_HuoQuBaoZhangJinZhangHao_Load" +
            "Response")]
        System.Data.DataSet FRM_HuoQuBaoZhangJinZhangHao_Load(int GuaPaiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/FRM_HuoQuBaoZhangJinZhangHao_Load" +
            "", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/FRM_HuoQuBaoZhangJinZhangHao_Load" +
            "Response")]
        System.Threading.Tasks.Task<System.Data.DataSet> FRM_HuoQuBaoZhangJinZhangHao_LoadAsync(int GuaPaiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/btnDaYin_Click_InsertShenQingBiao" +
            "", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/btnDaYin_Click_InsertShenQingBiao" +
            "Response")]
        int btnDaYin_Click_InsertShenQingBiao(string ShenQingBianHao, string ShenQingShiJian);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/btnDaYin_Click_InsertShenQingBiao" +
            "", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/btnDaYin_Click_InsertShenQingBiao" +
            "Response")]
        System.Threading.Tasks.Task<int> btnDaYin_Click_InsertShenQingBiaoAsync(string ShenQingBianHao, string ShenQingShiJian);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/btnDaYin_Click_InsertBaoZhengJinB" +
            "iao", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/btnDaYin_Click_InsertBaoZhengJinB" +
            "iaoResponse")]
        int btnDaYin_Click_InsertBaoZhengJinBiao(string YinXingZhangHao, string YinXingMingCheng, string ZhangHuMing);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/btnDaYin_Click_InsertBaoZhengJinB" +
            "iao", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/btnDaYin_Click_InsertBaoZhengJinB" +
            "iaoResponse")]
        System.Threading.Tasks.Task<int> btnDaYin_Click_InsertBaoZhengJinBiaoAsync(string YinXingZhangHao, string YinXingMingCheng, string ZhangHuMing);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/Select_ShengChengBaoZhengJinZhang" +
            "Hao", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/Select_ShengChengBaoZhengJinZhang" +
            "HaoResponse")]
        System.Data.DataSet Select_ShengChengBaoZhengJinZhangHao();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/Select_ShengChengBaoZhengJinZhang" +
            "Hao", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/Select_ShengChengBaoZhengJinZhang" +
            "HaoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> Select_ShengChengBaoZhengJinZhangHaoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/Select_ShengChengBaoZhengJinZhang" +
            "Hao_XinZeng", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/Select_ShengChengBaoZhengJinZhang" +
            "Hao_XinZengResponse")]
        int Select_ShengChengBaoZhengJinZhangHao_XinZeng(string BaoZhengJinZhangHao, string KaiHuYinXing);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/Select_ShengChengBaoZhengJinZhang" +
            "Hao_XinZeng", ReplyAction="http://tempuri.org/FRM_HuoQuBaoZhangJinZhangHao/Select_ShengChengBaoZhengJinZhang" +
            "Hao_XinZengResponse")]
        System.Threading.Tasks.Task<int> Select_ShengChengBaoZhengJinZhangHao_XinZengAsync(string BaoZhengJinZhangHao, string KaiHuYinXing);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_HuoQuBaoZhangJinZhangHaoChannel : 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_HuoQuBaoZhangJinZhangHao.FRM_HuoQuBaoZhangJinZhangHao, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_HuoQuBaoZhangJinZhangHaoClient : System.ServiceModel.ClientBase<宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_HuoQuBaoZhangJinZhangHao.FRM_HuoQuBaoZhangJinZhangHao>, 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_HuoQuBaoZhangJinZhangHao.FRM_HuoQuBaoZhangJinZhangHao {
        
        public FRM_HuoQuBaoZhangJinZhangHaoClient() {
        }
        
        public FRM_HuoQuBaoZhangJinZhangHaoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_HuoQuBaoZhangJinZhangHaoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_HuoQuBaoZhangJinZhangHaoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_HuoQuBaoZhangJinZhangHaoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FRM_HuoQuBaoZhangJinZhangHao_Load(int GuaPaiID) {
            return base.Channel.FRM_HuoQuBaoZhangJinZhangHao_Load(GuaPaiID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FRM_HuoQuBaoZhangJinZhangHao_LoadAsync(int GuaPaiID) {
            return base.Channel.FRM_HuoQuBaoZhangJinZhangHao_LoadAsync(GuaPaiID);
        }
        
        public int btnDaYin_Click_InsertShenQingBiao(string ShenQingBianHao, string ShenQingShiJian) {
            return base.Channel.btnDaYin_Click_InsertShenQingBiao(ShenQingBianHao, ShenQingShiJian);
        }
        
        public System.Threading.Tasks.Task<int> btnDaYin_Click_InsertShenQingBiaoAsync(string ShenQingBianHao, string ShenQingShiJian) {
            return base.Channel.btnDaYin_Click_InsertShenQingBiaoAsync(ShenQingBianHao, ShenQingShiJian);
        }
        
        public int btnDaYin_Click_InsertBaoZhengJinBiao(string YinXingZhangHao, string YinXingMingCheng, string ZhangHuMing) {
            return base.Channel.btnDaYin_Click_InsertBaoZhengJinBiao(YinXingZhangHao, YinXingMingCheng, ZhangHuMing);
        }
        
        public System.Threading.Tasks.Task<int> btnDaYin_Click_InsertBaoZhengJinBiaoAsync(string YinXingZhangHao, string YinXingMingCheng, string ZhangHuMing) {
            return base.Channel.btnDaYin_Click_InsertBaoZhengJinBiaoAsync(YinXingZhangHao, YinXingMingCheng, ZhangHuMing);
        }
        
        public System.Data.DataSet Select_ShengChengBaoZhengJinZhangHao() {
            return base.Channel.Select_ShengChengBaoZhengJinZhangHao();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Select_ShengChengBaoZhengJinZhangHaoAsync() {
            return base.Channel.Select_ShengChengBaoZhengJinZhangHaoAsync();
        }
        
        public int Select_ShengChengBaoZhengJinZhangHao_XinZeng(string BaoZhengJinZhangHao, string KaiHuYinXing) {
            return base.Channel.Select_ShengChengBaoZhengJinZhangHao_XinZeng(BaoZhengJinZhangHao, KaiHuYinXing);
        }
        
        public System.Threading.Tasks.Task<int> Select_ShengChengBaoZhengJinZhangHao_XinZengAsync(string BaoZhengJinZhangHao, string KaiHuYinXing) {
            return base.Channel.Select_ShengChengBaoZhengJinZhangHao_XinZengAsync(BaoZhengJinZhangHao, KaiHuYinXing);
        }
    }
}
