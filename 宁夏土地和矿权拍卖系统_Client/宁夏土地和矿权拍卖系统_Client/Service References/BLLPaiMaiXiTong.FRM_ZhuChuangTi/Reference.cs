﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_ZhuChuangTi {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLLPaiMaiXiTong.FRM_ZhuChuangTi.FRM_ZhuChuangTi")]
    public interface FRM_ZhuChuangTi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ZhuChuangTi/ChaXunKeHuXinXi_KuHuID", ReplyAction="http://tempuri.org/FRM_ZhuChuangTi/ChaXunKeHuXinXi_KuHuIDResponse")]
        System.Data.DataSet ChaXunKeHuXinXi_KuHuID(int KeHuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ZhuChuangTi/ChaXunKeHuXinXi_KuHuID", ReplyAction="http://tempuri.org/FRM_ZhuChuangTi/ChaXunKeHuXinXi_KuHuIDResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ChaXunKeHuXinXi_KuHuIDAsync(int KeHuID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_ZhuChuangTiChannel : 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_ZhuChuangTi.FRM_ZhuChuangTi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_ZhuChuangTiClient : System.ServiceModel.ClientBase<宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_ZhuChuangTi.FRM_ZhuChuangTi>, 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_ZhuChuangTi.FRM_ZhuChuangTi {
        
        public FRM_ZhuChuangTiClient() {
        }
        
        public FRM_ZhuChuangTiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_ZhuChuangTiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_ZhuChuangTiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_ZhuChuangTiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ChaXunKeHuXinXi_KuHuID(int KeHuID) {
            return base.Channel.ChaXunKeHuXinXi_KuHuID(KeHuID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ChaXunKeHuXinXi_KuHuIDAsync(int KeHuID) {
            return base.Channel.ChaXunKeHuXinXi_KuHuIDAsync(KeHuID);
        }
    }
}
