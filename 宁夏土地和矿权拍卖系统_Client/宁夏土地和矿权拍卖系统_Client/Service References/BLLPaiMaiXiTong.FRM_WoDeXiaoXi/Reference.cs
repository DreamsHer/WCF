﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_WoDeXiaoXi {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLLPaiMaiXiTong.FRM_WoDeXiaoXi.FRM_WoDeXiaoXi")]
    public interface FRM_WoDeXiaoXi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeXiaoXi_FenYe", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeXiaoXi_FenYeResponse")]
        System.Data.DataSet btnChaZao_Click_WoDeXiaoXi_FenYe(System.DateTime GuaPaiQiShiShiJian, System.DateTime GuaPaiJieZhiShiJian, int YeMa, int MeiYeShuLiang, int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeXiaoXi_FenYe", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeXiaoXi_FenYeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChaZao_Click_WoDeXiaoXi_FenYeAsync(System.DateTime GuaPaiQiShiShiJian, System.DateTime GuaPaiJieZhiShiJian, int YeMa, int MeiYeShuLiang, int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeXiaoXi_ZongShu", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeXiaoXi_ZongShuResponse")]
        System.Data.DataSet btnChaZao_Click_WoDeXiaoXi_ZongShu(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeXiaoXi_ZongShu", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeXiaoXi_ZongShuResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChaZao_Click_WoDeXiaoXi_ZongShuAsync(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu_Click_WoDeXiaoXi_FenYe", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu_Click_WoDeXiaoXi_FenYeResponse")]
        System.Data.DataSet btnChaKanQuanBu_Click_WoDeXiaoXi_FenYe(int YeMa, int MeiYeShuLiang, int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu_Click_WoDeXiaoXi_FenYe", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu_Click_WoDeXiaoXi_FenYeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChaKanQuanBu_Click_WoDeXiaoXi_FenYeAsync(int YeMa, int MeiYeShuLiang, int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShu", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShuRespons" +
            "e")]
        System.Data.DataSet btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShu(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShu", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShuRespons" +
            "e")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShuAsync(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJian", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJianR" +
            "esponse")]
        System.Data.DataSet btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJian(string DongTaiTiaoJian);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJian", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJianR" +
            "esponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJianAsync(string DongTaiTiaoJian);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu2_Click_WoDeChuJaiJiLu", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu2_Click_WoDeChuJaiJiLuResponse")]
        System.Data.DataSet btnChaKanQuanBu2_Click_WoDeChuJaiJiLu(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu2_Click_WoDeChuJaiJiLu", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaKanQuanBu2_Click_WoDeChuJaiJiLuResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChaKanQuanBu2_Click_WoDeChuJaiJiLuAsync(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZhaoQuanBu_Click_DengLuQingKuang", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZhaoQuanBu_Click_DengLuQingKuangResponse")]
        System.Data.DataSet btnChaZhaoQuanBu_Click_DengLuQingKuang(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZhaoQuanBu_Click_DengLuQingKuang", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChaZhaoQuanBu_Click_DengLuQingKuangResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChaZhaoQuanBu_Click_DengLuQingKuangAsync(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChazhao_Click_DengLuQingKuang", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChazhao_Click_DengLuQingKuangResponse")]
        System.Data.DataSet btnChazhao_Click_DengLuQingKuang(System.DateTime QiShiShiJian, System.DateTime JeiZhiShiJian, int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_WoDeXiaoXi/btnChazhao_Click_DengLuQingKuang", ReplyAction="http://tempuri.org/FRM_WoDeXiaoXi/btnChazhao_Click_DengLuQingKuangResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> btnChazhao_Click_DengLuQingKuangAsync(System.DateTime QiShiShiJian, System.DateTime JeiZhiShiJian, int KeHuID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_WoDeXiaoXiChannel : 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_WoDeXiaoXi.FRM_WoDeXiaoXi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_WoDeXiaoXiClient : System.ServiceModel.ClientBase<宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_WoDeXiaoXi.FRM_WoDeXiaoXi>, 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_WoDeXiaoXi.FRM_WoDeXiaoXi {
        
        public FRM_WoDeXiaoXiClient() {
        }
        
        public FRM_WoDeXiaoXiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_WoDeXiaoXiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_WoDeXiaoXiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_WoDeXiaoXiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet btnChaZao_Click_WoDeXiaoXi_FenYe(System.DateTime GuaPaiQiShiShiJian, System.DateTime GuaPaiJieZhiShiJian, int YeMa, int MeiYeShuLiang, int KeHuID) {
            return base.Channel.btnChaZao_Click_WoDeXiaoXi_FenYe(GuaPaiQiShiShiJian, GuaPaiJieZhiShiJian, YeMa, MeiYeShuLiang, KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChaZao_Click_WoDeXiaoXi_FenYeAsync(System.DateTime GuaPaiQiShiShiJian, System.DateTime GuaPaiJieZhiShiJian, int YeMa, int MeiYeShuLiang, int KeHuID) {
            return base.Channel.btnChaZao_Click_WoDeXiaoXi_FenYeAsync(GuaPaiQiShiShiJian, GuaPaiJieZhiShiJian, YeMa, MeiYeShuLiang, KeHuID);
        }
        
        public System.Data.DataSet btnChaZao_Click_WoDeXiaoXi_ZongShu(int KeHuID) {
            return base.Channel.btnChaZao_Click_WoDeXiaoXi_ZongShu(KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChaZao_Click_WoDeXiaoXi_ZongShuAsync(int KeHuID) {
            return base.Channel.btnChaZao_Click_WoDeXiaoXi_ZongShuAsync(KeHuID);
        }
        
        public System.Data.DataSet btnChaKanQuanBu_Click_WoDeXiaoXi_FenYe(int YeMa, int MeiYeShuLiang, int KeHuID) {
            return base.Channel.btnChaKanQuanBu_Click_WoDeXiaoXi_FenYe(YeMa, MeiYeShuLiang, KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChaKanQuanBu_Click_WoDeXiaoXi_FenYeAsync(int YeMa, int MeiYeShuLiang, int KeHuID) {
            return base.Channel.btnChaKanQuanBu_Click_WoDeXiaoXi_FenYeAsync(YeMa, MeiYeShuLiang, KeHuID);
        }
        
        public System.Data.DataSet btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShu(int KeHuID) {
            return base.Channel.btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShu(KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShuAsync(int KeHuID) {
            return base.Channel.btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShuAsync(KeHuID);
        }
        
        public System.Data.DataSet btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJian(string DongTaiTiaoJian) {
            return base.Channel.btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJian(DongTaiTiaoJian);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJianAsync(string DongTaiTiaoJian) {
            return base.Channel.btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJianAsync(DongTaiTiaoJian);
        }
        
        public System.Data.DataSet btnChaKanQuanBu2_Click_WoDeChuJaiJiLu(int KeHuID) {
            return base.Channel.btnChaKanQuanBu2_Click_WoDeChuJaiJiLu(KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChaKanQuanBu2_Click_WoDeChuJaiJiLuAsync(int KeHuID) {
            return base.Channel.btnChaKanQuanBu2_Click_WoDeChuJaiJiLuAsync(KeHuID);
        }
        
        public System.Data.DataSet btnChaZhaoQuanBu_Click_DengLuQingKuang(int KeHuID) {
            return base.Channel.btnChaZhaoQuanBu_Click_DengLuQingKuang(KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChaZhaoQuanBu_Click_DengLuQingKuangAsync(int KeHuID) {
            return base.Channel.btnChaZhaoQuanBu_Click_DengLuQingKuangAsync(KeHuID);
        }
        
        public System.Data.DataSet btnChazhao_Click_DengLuQingKuang(System.DateTime QiShiShiJian, System.DateTime JeiZhiShiJian, int KeHuID) {
            return base.Channel.btnChazhao_Click_DengLuQingKuang(QiShiShiJian, JeiZhiShiJian, KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> btnChazhao_Click_DengLuQingKuangAsync(System.DateTime QiShiShiJian, System.DateTime JeiZhiShiJian, int KeHuID) {
            return base.Channel.btnChazhao_Click_DengLuQingKuangAsync(QiShiShiJian, JeiZhiShiJian, KeHuID);
        }
    }
}
