﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_JiaoYiZiYuanLieBiao {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLLPaiMaiXiTong.FRM_JiaoYiZiYuanLieBiao.FRM_JiaoYiZiYuanLieBiao")]
    public interface FRM_JiaoYiZiYuanLieBiao {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuXingZhengQu", ReplyAction="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuXingZhengQuResponse")]
        System.Data.DataSet ChaXunShuJuXingZhengQu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuXingZhengQu", ReplyAction="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuXingZhengQuResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ChaXunShuJuXingZhengQuAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuJiaoYiZiYuanLieBiao", ReplyAction="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuJiaoYiZiYuanLieBiaoResponse" +
            "")]
        System.Data.DataSet ChaXunShuJuJiaoYiZiYuanLieBiao(string DongTaiTiaoJian);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuJiaoYiZiYuanLieBiao", ReplyAction="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuJiaoYiZiYuanLieBiaoResponse" +
            "")]
        System.Threading.Tasks.Task<System.Data.DataSet> ChaXunShuJuJiaoYiZiYuanLieBiaoAsync(string DongTaiTiaoJian);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongS" +
            "hu", ReplyAction="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongS" +
            "huResponse")]
        System.Data.DataSet ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongShu(string DongTaiTiaoJian);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongS" +
            "hu", ReplyAction="http://tempuri.org/FRM_JiaoYiZiYuanLieBiao/ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongS" +
            "huResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongShuAsync(string DongTaiTiaoJian);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_JiaoYiZiYuanLieBiaoChannel : 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_JiaoYiZiYuanLieBiao.FRM_JiaoYiZiYuanLieBiao, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_JiaoYiZiYuanLieBiaoClient : System.ServiceModel.ClientBase<宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_JiaoYiZiYuanLieBiao.FRM_JiaoYiZiYuanLieBiao>, 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_JiaoYiZiYuanLieBiao.FRM_JiaoYiZiYuanLieBiao {
        
        public FRM_JiaoYiZiYuanLieBiaoClient() {
        }
        
        public FRM_JiaoYiZiYuanLieBiaoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_JiaoYiZiYuanLieBiaoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_JiaoYiZiYuanLieBiaoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_JiaoYiZiYuanLieBiaoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ChaXunShuJuXingZhengQu() {
            return base.Channel.ChaXunShuJuXingZhengQu();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ChaXunShuJuXingZhengQuAsync() {
            return base.Channel.ChaXunShuJuXingZhengQuAsync();
        }
        
        public System.Data.DataSet ChaXunShuJuJiaoYiZiYuanLieBiao(string DongTaiTiaoJian) {
            return base.Channel.ChaXunShuJuJiaoYiZiYuanLieBiao(DongTaiTiaoJian);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ChaXunShuJuJiaoYiZiYuanLieBiaoAsync(string DongTaiTiaoJian) {
            return base.Channel.ChaXunShuJuJiaoYiZiYuanLieBiaoAsync(DongTaiTiaoJian);
        }
        
        public System.Data.DataSet ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongShu(string DongTaiTiaoJian) {
            return base.Channel.ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongShu(DongTaiTiaoJian);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongShuAsync(string DongTaiTiaoJian) {
            return base.Channel.ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongShuAsync(DongTaiTiaoJian);
        }
    }
}
