﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_TianXueJingMaiShenQingShu {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLLPaiMaiXiTong.FRM_TianXueJingMaiShenQingShu.FRM_TianXueJingMaiShenQingShu")]
    public interface FRM_TianXueJingMaiShenQingShu {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/FRM_TianXueJingMaiShenQingShu_Lo" +
            "ad", ReplyAction="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/FRM_TianXueJingMaiShenQingShu_Lo" +
            "adResponse")]
        System.Data.DataSet FRM_TianXueJingMaiShenQingShu_Load(int GuaPaiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/FRM_TianXueJingMaiShenQingShu_Lo" +
            "ad", ReplyAction="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/FRM_TianXueJingMaiShenQingShu_Lo" +
            "adResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FRM_TianXueJingMaiShenQingShu_LoadAsync(int GuaPaiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/btnTongYi_Click_BaoCun1", ReplyAction="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/btnTongYi_Click_BaoCun1Response")]
        int btnTongYi_Click_BaoCun1(string KeHuMingCheng, string FaRenDaiBiao, string LianXiRen, string LianXiDiZhi, string YouZhengBianMa, string LianXiDianHua);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/btnTongYi_Click_BaoCun1", ReplyAction="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/btnTongYi_Click_BaoCun1Response")]
        System.Threading.Tasks.Task<int> btnTongYi_Click_BaoCun1Async(string KeHuMingCheng, string FaRenDaiBiao, string LianXiRen, string LianXiDiZhi, string YouZhengBianMa, string LianXiDianHua);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/btnTongYi_Click_BaoCun2", ReplyAction="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/btnTongYi_Click_BaoCun2Response")]
        int btnTongYi_Click_BaoCun2(System.DateTime ShenQingShiJian);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/btnTongYi_Click_BaoCun2", ReplyAction="http://tempuri.org/FRM_TianXueJingMaiShenQingShu/btnTongYi_Click_BaoCun2Response")]
        System.Threading.Tasks.Task<int> btnTongYi_Click_BaoCun2Async(System.DateTime ShenQingShiJian);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_TianXueJingMaiShenQingShuChannel : 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_TianXueJingMaiShenQingShu.FRM_TianXueJingMaiShenQingShu, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_TianXueJingMaiShenQingShuClient : System.ServiceModel.ClientBase<宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_TianXueJingMaiShenQingShu.FRM_TianXueJingMaiShenQingShu>, 宁夏土地和矿权拍卖系统_Client.BLLPaiMaiXiTong.FRM_TianXueJingMaiShenQingShu.FRM_TianXueJingMaiShenQingShu {
        
        public FRM_TianXueJingMaiShenQingShuClient() {
        }
        
        public FRM_TianXueJingMaiShenQingShuClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_TianXueJingMaiShenQingShuClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_TianXueJingMaiShenQingShuClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_TianXueJingMaiShenQingShuClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FRM_TianXueJingMaiShenQingShu_Load(int GuaPaiID) {
            return base.Channel.FRM_TianXueJingMaiShenQingShu_Load(GuaPaiID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FRM_TianXueJingMaiShenQingShu_LoadAsync(int GuaPaiID) {
            return base.Channel.FRM_TianXueJingMaiShenQingShu_LoadAsync(GuaPaiID);
        }
        
        public int btnTongYi_Click_BaoCun1(string KeHuMingCheng, string FaRenDaiBiao, string LianXiRen, string LianXiDiZhi, string YouZhengBianMa, string LianXiDianHua) {
            return base.Channel.btnTongYi_Click_BaoCun1(KeHuMingCheng, FaRenDaiBiao, LianXiRen, LianXiDiZhi, YouZhengBianMa, LianXiDianHua);
        }
        
        public System.Threading.Tasks.Task<int> btnTongYi_Click_BaoCun1Async(string KeHuMingCheng, string FaRenDaiBiao, string LianXiRen, string LianXiDiZhi, string YouZhengBianMa, string LianXiDianHua) {
            return base.Channel.btnTongYi_Click_BaoCun1Async(KeHuMingCheng, FaRenDaiBiao, LianXiRen, LianXiDiZhi, YouZhengBianMa, LianXiDianHua);
        }
        
        public int btnTongYi_Click_BaoCun2(System.DateTime ShenQingShiJian) {
            return base.Channel.btnTongYi_Click_BaoCun2(ShenQingShiJian);
        }
        
        public System.Threading.Tasks.Task<int> btnTongYi_Click_BaoCun2Async(System.DateTime ShenQingShiJian) {
            return base.Channel.btnTongYi_Click_BaoCun2Async(ShenQingShiJian);
        }
    }
}
