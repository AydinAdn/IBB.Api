﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBB.Wsdl.Seferler
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IBB.Wsdl.Seferler.SeferGerceklesmeSoap")]
    internal interface ISeferGerceklesmeSoapClient
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBozukSatih_XML", ReplyAction="*")]
        System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetBozukSatih_XMLResponse> GetBozukSatih_XMLAsync(IBB.Wsdl.Seferler.GetBozukSatih_XMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBozukSatih_json", ReplyAction="*")]
        System.Threading.Tasks.Task GetBozukSatih_jsonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFiloAracKonum_json", ReplyAction="*")]
        System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetFiloAracKonum_jsonResponse> GetFiloAracKonum_jsonAsync(IBB.Wsdl.Seferler.GetFiloAracKonum_jsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetKazaLokasyon_XML", ReplyAction="*")]
        System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetKazaLokasyon_XMLResponse> GetKazaLokasyon_XMLAsync(IBB.Wsdl.Seferler.GetKazaLokasyon_XMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetKazaLokasyon_json", ReplyAction="*")]
        System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetKazaLokasyon_jsonResponse> GetKazaLokasyon_jsonAsync(IBB.Wsdl.Seferler.GetKazaLokasyon_jsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class GetBozukSatih_XMLRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBozukSatih_XML", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.Seferler.GetBozukSatih_XMLRequestBody Body;
        
        public GetBozukSatih_XMLRequest()
        {
        }
        
        public GetBozukSatih_XMLRequest(IBB.Wsdl.Seferler.GetBozukSatih_XMLRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    internal partial class GetBozukSatih_XMLRequestBody
    {
        
        public GetBozukSatih_XMLRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class GetBozukSatih_XMLResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBozukSatih_XMLResponse", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.Seferler.GetBozukSatih_XMLResponseBody Body;
        
        public GetBozukSatih_XMLResponse()
        {
        }
        
        public GetBozukSatih_XMLResponse(IBB.Wsdl.Seferler.GetBozukSatih_XMLResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class GetBozukSatih_XMLResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetBozukSatih_XMLResult;
        
        public GetBozukSatih_XMLResponseBody()
        {
        }
        
        public GetBozukSatih_XMLResponseBody(System.Xml.Linq.XElement GetBozukSatih_XMLResult)
        {
            this.GetBozukSatih_XMLResult = GetBozukSatih_XMLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class GetFiloAracKonum_jsonRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFiloAracKonum_json", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.Seferler.GetFiloAracKonum_jsonRequestBody Body;
        
        public GetFiloAracKonum_jsonRequest()
        {
        }
        
        public GetFiloAracKonum_jsonRequest(IBB.Wsdl.Seferler.GetFiloAracKonum_jsonRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    internal partial class GetFiloAracKonum_jsonRequestBody
    {
        
        public GetFiloAracKonum_jsonRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class GetFiloAracKonum_jsonResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFiloAracKonum_jsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.Seferler.GetFiloAracKonum_jsonResponseBody Body;
        
        public GetFiloAracKonum_jsonResponse()
        {
        }
        
        public GetFiloAracKonum_jsonResponse(IBB.Wsdl.Seferler.GetFiloAracKonum_jsonResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class GetFiloAracKonum_jsonResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetFiloAracKonum_jsonResult;
        
        public GetFiloAracKonum_jsonResponseBody()
        {
        }
        
        public GetFiloAracKonum_jsonResponseBody(string GetFiloAracKonum_jsonResult)
        {
            this.GetFiloAracKonum_jsonResult = GetFiloAracKonum_jsonResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class GetKazaLokasyon_XMLRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetKazaLokasyon_XML", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.Seferler.GetKazaLokasyon_XMLRequestBody Body;
        
        public GetKazaLokasyon_XMLRequest()
        {
        }
        
        public GetKazaLokasyon_XMLRequest(IBB.Wsdl.Seferler.GetKazaLokasyon_XMLRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class GetKazaLokasyon_XMLRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Tarih;
        
        public GetKazaLokasyon_XMLRequestBody()
        {
        }
        
        public GetKazaLokasyon_XMLRequestBody(string Tarih)
        {
            this.Tarih = Tarih;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class GetKazaLokasyon_XMLResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetKazaLokasyon_XMLResponse", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.Seferler.GetKazaLokasyon_XMLResponseBody Body;
        
        public GetKazaLokasyon_XMLResponse()
        {
        }
        
        public GetKazaLokasyon_XMLResponse(IBB.Wsdl.Seferler.GetKazaLokasyon_XMLResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class GetKazaLokasyon_XMLResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetKazaLokasyon_XMLResult;
        
        public GetKazaLokasyon_XMLResponseBody()
        {
        }
        
        public GetKazaLokasyon_XMLResponseBody(System.Xml.Linq.XElement GetKazaLokasyon_XMLResult)
        {
            this.GetKazaLokasyon_XMLResult = GetKazaLokasyon_XMLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class GetKazaLokasyon_jsonRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetKazaLokasyon_json", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.Seferler.GetKazaLokasyon_jsonRequestBody Body;
        
        public GetKazaLokasyon_jsonRequest()
        {
        }
        
        public GetKazaLokasyon_jsonRequest(IBB.Wsdl.Seferler.GetKazaLokasyon_jsonRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class GetKazaLokasyon_jsonRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Tarih;
        
        public GetKazaLokasyon_jsonRequestBody()
        {
        }
        
        public GetKazaLokasyon_jsonRequestBody(string Tarih)
        {
            this.Tarih = Tarih;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    internal partial class GetKazaLokasyon_jsonResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetKazaLokasyon_jsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public IBB.Wsdl.Seferler.GetKazaLokasyon_jsonResponseBody Body;
        
        public GetKazaLokasyon_jsonResponse()
        {
        }
        
        public GetKazaLokasyon_jsonResponse(IBB.Wsdl.Seferler.GetKazaLokasyon_jsonResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    internal partial class GetKazaLokasyon_jsonResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetKazaLokasyon_jsonResult;
        
        public GetKazaLokasyon_jsonResponseBody()
        {
        }
        
        public GetKazaLokasyon_jsonResponseBody(string GetKazaLokasyon_jsonResult)
        {
            this.GetKazaLokasyon_jsonResult = GetKazaLokasyon_jsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    internal interface ISeferGerceklesmeSoapClientChannel : IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    internal partial class SeferGerceklesmeSoapClient : System.ServiceModel.ClientBase<IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient>, IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SeferGerceklesmeSoapClient() : 
                base(SeferGerceklesmeSoapClient.GetDefaultBinding(), SeferGerceklesmeSoapClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SeferGerceklesmeSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SeferGerceklesmeSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(SeferGerceklesmeSoapClient.GetBindingForEndpoint(endpointConfiguration), SeferGerceklesmeSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SeferGerceklesmeSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SeferGerceklesmeSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SeferGerceklesmeSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SeferGerceklesmeSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SeferGerceklesmeSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetBozukSatih_XMLResponse> IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient.GetBozukSatih_XMLAsync(IBB.Wsdl.Seferler.GetBozukSatih_XMLRequest request)
        {
            return base.Channel.GetBozukSatih_XMLAsync(request);
        }
        
        public System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetBozukSatih_XMLResponse> GetBozukSatih_XMLAsync()
        {
            IBB.Wsdl.Seferler.GetBozukSatih_XMLRequest inValue = new IBB.Wsdl.Seferler.GetBozukSatih_XMLRequest();
            inValue.Body = new IBB.Wsdl.Seferler.GetBozukSatih_XMLRequestBody();
            return ((IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient)(this)).GetBozukSatih_XMLAsync(inValue);
        }
        
        public System.Threading.Tasks.Task GetBozukSatih_jsonAsync()
        {
            return base.Channel.GetBozukSatih_jsonAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetFiloAracKonum_jsonResponse> IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient.GetFiloAracKonum_jsonAsync(IBB.Wsdl.Seferler.GetFiloAracKonum_jsonRequest request)
        {
            return base.Channel.GetFiloAracKonum_jsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetFiloAracKonum_jsonResponse> GetFiloAracKonum_jsonAsync()
        {
            IBB.Wsdl.Seferler.GetFiloAracKonum_jsonRequest inValue = new IBB.Wsdl.Seferler.GetFiloAracKonum_jsonRequest();
            inValue.Body = new IBB.Wsdl.Seferler.GetFiloAracKonum_jsonRequestBody();
            return ((IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient)(this)).GetFiloAracKonum_jsonAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetKazaLokasyon_XMLResponse> IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient.GetKazaLokasyon_XMLAsync(IBB.Wsdl.Seferler.GetKazaLokasyon_XMLRequest request)
        {
            return base.Channel.GetKazaLokasyon_XMLAsync(request);
        }
        
        public System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetKazaLokasyon_XMLResponse> GetKazaLokasyon_XMLAsync(string Tarih)
        {
            IBB.Wsdl.Seferler.GetKazaLokasyon_XMLRequest inValue = new IBB.Wsdl.Seferler.GetKazaLokasyon_XMLRequest();
            inValue.Body = new IBB.Wsdl.Seferler.GetKazaLokasyon_XMLRequestBody();
            inValue.Body.Tarih = Tarih;
            return ((IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient)(this)).GetKazaLokasyon_XMLAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetKazaLokasyon_jsonResponse> IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient.GetKazaLokasyon_jsonAsync(IBB.Wsdl.Seferler.GetKazaLokasyon_jsonRequest request)
        {
            return base.Channel.GetKazaLokasyon_jsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<IBB.Wsdl.Seferler.GetKazaLokasyon_jsonResponse> GetKazaLokasyon_jsonAsync(string Tarih)
        {
            IBB.Wsdl.Seferler.GetKazaLokasyon_jsonRequest inValue = new IBB.Wsdl.Seferler.GetKazaLokasyon_jsonRequest();
            inValue.Body = new IBB.Wsdl.Seferler.GetKazaLokasyon_jsonRequestBody();
            inValue.Body.Tarih = Tarih;
            return ((IBB.Wsdl.Seferler.ISeferGerceklesmeSoapClient)(this)).GetKazaLokasyon_jsonAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.SeferGerceklesmeSoap))
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
            if ((endpointConfiguration == EndpointConfiguration.SeferGerceklesmeSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://api.ibb.gov.tr/iett/FiloDurum/SeferGerceklesme.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SeferGerceklesmeSoapClient.GetBindingForEndpoint(EndpointConfiguration.SeferGerceklesmeSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SeferGerceklesmeSoapClient.GetEndpointAddress(EndpointConfiguration.SeferGerceklesmeSoap);
        }
        
        public enum EndpointConfiguration
        {
            
            SeferGerceklesmeSoap,
        }
    }
}
