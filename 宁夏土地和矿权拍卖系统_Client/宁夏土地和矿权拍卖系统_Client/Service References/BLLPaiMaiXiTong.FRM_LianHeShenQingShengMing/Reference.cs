﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_LianHeShenQingShengMing {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLLPaiMaiXiTong.FRM_LianHeShenQingShengMing.FRM_LianHeShenQingShengMing")]
    public interface FRM_LianHeShenQingShengMing {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_Load", ReplyAction="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_LoadRe" +
            "sponse")]
        System.Data.DataSet FRM_LianHeShenQingShengMing_Load(int GuaPaiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_Load", ReplyAction="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_LoadRe" +
            "sponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FRM_LianHeShenQingShengMing_LoadAsync(int GuaPaiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_KeHuXi" +
            "nXi", ReplyAction="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_KeHuXi" +
            "nXiResponse")]
        System.Data.DataSet FRM_LianHeShenQingShengMing_KeHuXinXi(string KeHuMingCheng);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_KeHuXi" +
            "nXi", ReplyAction="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_KeHuXi" +
            "nXiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FRM_LianHeShenQingShengMing_KeHuXinXiAsync(string KeHuMingCheng);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_TianJa" +
            "iKeHu", ReplyAction="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_TianJa" +
            "iKeHuResponse")]
        System.Data.DataSet FRM_LianHeShenQingShengMing_TianJaiKeHu(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_TianJa" +
            "iKeHu", ReplyAction="http://tempuri.org/FRM_LianHeShenQingShengMing/FRM_LianHeShenQingShengMing_TianJa" +
            "iKeHuResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FRM_LianHeShenQingShengMing_TianJaiKeHuAsync(int KeHuID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_LianHeShenQingShengMingChannel : 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_LianHeShenQingShengMing.FRM_LianHeShenQingShengMing, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_LianHeShenQingShengMingClient : System.ServiceModel.ClientBase<宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_LianHeShenQingShengMing.FRM_LianHeShenQingShengMing>, 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_LianHeShenQingShengMing.FRM_LianHeShenQingShengMing {
        
        public FRM_LianHeShenQingShengMingClient() {
        }
        
        public FRM_LianHeShenQingShengMingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_LianHeShenQingShengMingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_LianHeShenQingShengMingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_LianHeShenQingShengMingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FRM_LianHeShenQingShengMing_Load(int GuaPaiID) {
            return base.Channel.FRM_LianHeShenQingShengMing_Load(GuaPaiID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FRM_LianHeShenQingShengMing_LoadAsync(int GuaPaiID) {
            return base.Channel.FRM_LianHeShenQingShengMing_LoadAsync(GuaPaiID);
        }
        
        public System.Data.DataSet FRM_LianHeShenQingShengMing_KeHuXinXi(string KeHuMingCheng) {
            return base.Channel.FRM_LianHeShenQingShengMing_KeHuXinXi(KeHuMingCheng);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FRM_LianHeShenQingShengMing_KeHuXinXiAsync(string KeHuMingCheng) {
            return base.Channel.FRM_LianHeShenQingShengMing_KeHuXinXiAsync(KeHuMingCheng);
        }
        
        public System.Data.DataSet FRM_LianHeShenQingShengMing_TianJaiKeHu(int KeHuID) {
            return base.Channel.FRM_LianHeShenQingShengMing_TianJaiKeHu(KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FRM_LianHeShenQingShengMing_TianJaiKeHuAsync(int KeHuID) {
            return base.Channel.FRM_LianHeShenQingShengMing_TianJaiKeHuAsync(KeHuID);
        }
    }
}
