﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TcKimlikNoSorgulama_Soap.TcKimlikDogrulama {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS", ConfigurationName="TcKimlikDogrulama.KPSPublicSoap")]
    public interface KPSPublicSoap {
        
        // CODEGEN: Generating message contract since element name Ad from namespace http://tckimlik.nvi.gov.tr/WS is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula", ReplyAction="*")]
        TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaResponse TCKimlikNoDogrula(TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula", ReplyAction="*")]
        System.Threading.Tasks.Task<TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaResponse> TCKimlikNoDogrulaAsync(TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrula", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequestBody Body;
        
        public TCKimlikNoDogrulaRequest() {
        }
        
        public TCKimlikNoDogrulaRequest(TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long TCKimlikNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyad;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int DogumYili;
        
        public TCKimlikNoDogrulaRequestBody() {
        }
        
        public TCKimlikNoDogrulaRequestBody(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            this.TCKimlikNo = TCKimlikNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.DogumYili = DogumYili;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrulaResponse", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaResponseBody Body;
        
        public TCKimlikNoDogrulaResponse() {
        }
        
        public TCKimlikNoDogrulaResponse(TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool TCKimlikNoDogrulaResult;
        
        public TCKimlikNoDogrulaResponseBody() {
        }
        
        public TCKimlikNoDogrulaResponseBody(bool TCKimlikNoDogrulaResult) {
            this.TCKimlikNoDogrulaResult = TCKimlikNoDogrulaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface KPSPublicSoapChannel : TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.KPSPublicSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KPSPublicSoapClient : System.ServiceModel.ClientBase<TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.KPSPublicSoap>, TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.KPSPublicSoap {
        
        public KPSPublicSoapClient() {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPSPublicSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaResponse TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.KPSPublicSoap.TCKimlikNoDogrula(TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequest request) {
            return base.Channel.TCKimlikNoDogrula(request);
        }
        
        public bool TCKimlikNoDogrula(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequest inValue = new TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequest();
            inValue.Body = new TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequestBody();
            inValue.Body.TCKimlikNo = TCKimlikNo;
            inValue.Body.Ad = Ad;
            inValue.Body.Soyad = Soyad;
            inValue.Body.DogumYili = DogumYili;
            TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaResponse retVal = ((TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.KPSPublicSoap)(this)).TCKimlikNoDogrula(inValue);
            return retVal.Body.TCKimlikNoDogrulaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaResponse> TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.KPSPublicSoap.TCKimlikNoDogrulaAsync(TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequest request) {
            return base.Channel.TCKimlikNoDogrulaAsync(request);
        }
        
        public System.Threading.Tasks.Task<TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaResponse> TCKimlikNoDogrulaAsync(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequest inValue = new TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequest();
            inValue.Body = new TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.TCKimlikNoDogrulaRequestBody();
            inValue.Body.TCKimlikNo = TCKimlikNo;
            inValue.Body.Ad = Ad;
            inValue.Body.Soyad = Soyad;
            inValue.Body.DogumYili = DogumYili;
            return ((TcKimlikNoSorgulama_Soap.TcKimlikDogrulama.KPSPublicSoap)(this)).TCKimlikNoDogrulaAsync(inValue);
        }
    }
}