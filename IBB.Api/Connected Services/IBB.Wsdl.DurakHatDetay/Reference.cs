﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBB.Wsdl.DurakHatDetay
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IBB.Wsdl.DurakHatDetay.ibbSoap")]
    internal interface IIbbSoapClient
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DurakDetay_GYY", ReplyAction="*")]
        System.Threading.Tasks.Task<IBB.Wsdl.DurakHatDetay.DurakDetay_GYYResponse> DurakDetay_GYYAsync(IBB.Wsdl.DurakHatDetay.DurakDetay_GYYRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HatServisi_GYY", ReplyAction="*")]
        System.Threading.Tasks.Task<IBB.Wsdl.DurakHatDetay.HatServisi_GYYResponse> HatServisi_GYYAsync(IBB.Wsdl.DurakHatDetay.HatServisi_GYYRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class DurakDetay_GYYRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DurakDetay_GYY", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.DurakHatDetay.DurakDetay_GYYRequestBody Body;
        
        public DurakDetay_GYYRequest()
        {
        }
        
        public DurakDetay_GYYRequest(IBB.Wsdl.DurakHatDetay.DurakDetay_GYYRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class DurakDetay_GYYRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string hat_kodu;
        
        public DurakDetay_GYYRequestBody()
        {
        }
        
        public DurakDetay_GYYRequestBody(string hat_kodu)
        {
            this.hat_kodu = hat_kodu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class DurakDetay_GYYResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DurakDetay_GYYResponse", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.DurakHatDetay.DurakDetay_GYYResponseBody Body;
        
        public DurakDetay_GYYResponse()
        {
        }
        
        public DurakDetay_GYYResponse(IBB.Wsdl.DurakHatDetay.DurakDetay_GYYResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class DurakDetay_GYYResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement DurakDetay_GYYResult;
        
        public DurakDetay_GYYResponseBody()
        {
        }
        
        public DurakDetay_GYYResponseBody(System.Xml.Linq.XElement DurakDetay_GYYResult)
        {
            this.DurakDetay_GYYResult = DurakDetay_GYYResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class HatServisi_GYYRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HatServisi_GYY", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.DurakHatDetay.HatServisi_GYYRequestBody Body;
        
        public HatServisi_GYYRequest()
        {
        }
        
        public HatServisi_GYYRequest(IBB.Wsdl.DurakHatDetay.HatServisi_GYYRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class HatServisi_GYYRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string hat_kodu;
        
        public HatServisi_GYYRequestBody()
        {
        }
        
        public HatServisi_GYYRequestBody(string hat_kodu)
        {
            this.hat_kodu = hat_kodu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class HatServisi_GYYResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HatServisi_GYYResponse", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.DurakHatDetay.HatServisi_GYYResponseBody Body;
        
        public HatServisi_GYYResponse()
        {
        }
        
        public HatServisi_GYYResponse(IBB.Wsdl.DurakHatDetay.HatServisi_GYYResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class HatServisi_GYYResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement HatServisi_GYYResult;
        
        public HatServisi_GYYResponseBody()
        {
        }
        
        public HatServisi_GYYResponseBody(System.Xml.Linq.XElement HatServisi_GYYResult)
        {
            this.HatServisi_GYYResult = HatServisi_GYYResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    internal interface IIbbSoapClientChannel : IBB.Wsdl.DurakHatDetay.IIbbSoapClient, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    internal partial class IbbSoapClient : System.ServiceModel.ClientBase<IBB.Wsdl.DurakHatDetay.IIbbSoapClient>, IBB.Wsdl.DurakHatDetay.IIbbSoapClient
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public IbbSoapClient() : 
                base(IbbSoapClient.GetDefaultBinding(), IbbSoapClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ibbSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public IbbSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(IbbSoapClient.GetBindingForEndpoint(endpointConfiguration), IbbSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public IbbSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(IbbSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public IbbSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(IbbSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public IbbSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IBB.Wsdl.DurakHatDetay.DurakDetay_GYYResponse> IBB.Wsdl.DurakHatDetay.IIbbSoapClient.DurakDetay_GYYAsync(IBB.Wsdl.DurakHatDetay.DurakDetay_GYYRequest request)
        {
            return base.Channel.DurakDetay_GYYAsync(request);
        }
        
        public System.Threading.Tasks.Task<IBB.Wsdl.DurakHatDetay.DurakDetay_GYYResponse> DurakDetay_GYYAsync(string hat_kodu)
        {
            IBB.Wsdl.DurakHatDetay.DurakDetay_GYYRequest inValue = new IBB.Wsdl.DurakHatDetay.DurakDetay_GYYRequest();
            inValue.Body = new IBB.Wsdl.DurakHatDetay.DurakDetay_GYYRequestBody();
            inValue.Body.hat_kodu = hat_kodu;
            return ((IBB.Wsdl.DurakHatDetay.IIbbSoapClient)(this)).DurakDetay_GYYAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IBB.Wsdl.DurakHatDetay.HatServisi_GYYResponse> IBB.Wsdl.DurakHatDetay.IIbbSoapClient.HatServisi_GYYAsync(IBB.Wsdl.DurakHatDetay.HatServisi_GYYRequest request)
        {
            return base.Channel.HatServisi_GYYAsync(request);
        }
        
        public System.Threading.Tasks.Task<IBB.Wsdl.DurakHatDetay.HatServisi_GYYResponse> HatServisi_GYYAsync(string hat_kodu)
        {
            IBB.Wsdl.DurakHatDetay.HatServisi_GYYRequest inValue = new IBB.Wsdl.DurakHatDetay.HatServisi_GYYRequest();
            inValue.Body = new IBB.Wsdl.DurakHatDetay.HatServisi_GYYRequestBody();
            inValue.Body.hat_kodu = hat_kodu;
            return ((IBB.Wsdl.DurakHatDetay.IIbbSoapClient)(this)).HatServisi_GYYAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ibbSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ibbSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://api.ibb.gov.tr/iett/ibb/ibb.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return IbbSoapClient.GetBindingForEndpoint(EndpointConfiguration.ibbSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return IbbSoapClient.GetEndpointAddress(EndpointConfiguration.ibbSoap);
        }
        
        public enum EndpointConfiguration
        {
            
            ibbSoap,
        }
    }
}
