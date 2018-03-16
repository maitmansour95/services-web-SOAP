//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by Web Services Description Language Utility
//Mono Framework v4.0.30319.42000
//


/// CodeRemarks
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "0.0.0.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="GeoIPServiceSoap", Namespace="http://www.webservicex.net/")]
public partial class GeoIPService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback GetGeoIPOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetGeoIPContextOperationCompleted;
    
    /// CodeRemarks
    public GeoIPService() {
        this.Url = "http://www.webservicex.net/geoipservice.asmx";
    }
    
    /// CodeRemarks
    public event GetGeoIPCompletedEventHandler GetGeoIPCompleted;
    
    /// CodeRemarks
    public event GetGeoIPContextCompletedEventHandler GetGeoIPContextCompleted;
    
    /// CodeRemarks
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webservicex.net/GetGeoIP", RequestNamespace="http://www.webservicex.net/", ResponseNamespace="http://www.webservicex.net/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public GeoIP GetGeoIP(string IPAddress) {
        object[] results = this.Invoke("GetGeoIP", new object[] {
                    IPAddress});
        return ((GeoIP)(results[0]));
    }
    
    /// CodeRemarks
    public void GetGeoIPAsync(string IPAddress) {
        this.GetGeoIPAsync(IPAddress, null);
    }
    
    /// CodeRemarks
    public void GetGeoIPAsync(string IPAddress, object userState) {
        if ((this.GetGeoIPOperationCompleted == null)) {
            this.GetGeoIPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGeoIPOperationCompleted);
        }
        this.InvokeAsync("GetGeoIP", new object[] {
                    IPAddress}, this.GetGeoIPOperationCompleted, userState);
    }
    
    private void OnGetGeoIPOperationCompleted(object arg) {
        if ((this.GetGeoIPCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetGeoIPCompleted(this, new GetGeoIPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// CodeRemarks
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webservicex.net/GetGeoIPContext", RequestNamespace="http://www.webservicex.net/", ResponseNamespace="http://www.webservicex.net/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public GeoIP GetGeoIPContext() {
        object[] results = this.Invoke("GetGeoIPContext", new object[0]);
        return ((GeoIP)(results[0]));
    }
    
    /// CodeRemarks
    public void GetGeoIPContextAsync() {
        this.GetGeoIPContextAsync(null);
    }
    
    /// CodeRemarks
    public void GetGeoIPContextAsync(object userState) {
        if ((this.GetGeoIPContextOperationCompleted == null)) {
            this.GetGeoIPContextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGeoIPContextOperationCompleted);
        }
        this.InvokeAsync("GetGeoIPContext", new object[0], this.GetGeoIPContextOperationCompleted, userState);
    }
    
    private void OnGetGeoIPContextOperationCompleted(object arg) {
        if ((this.GetGeoIPContextCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetGeoIPContextCompleted(this, new GetGeoIPContextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// CodeRemarks
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "0.0.0.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.webservicex.net/")]
public partial class GeoIP {
    
    private int returnCodeField;
    
    private string ipField;
    
    private string returnCodeDetailsField;
    
    private string countryNameField;
    
    private string countryCodeField;
    
    /// <remarks/>
    public int ReturnCode {
        get {
            return this.returnCodeField;
        }
        set {
            this.returnCodeField = value;
        }
    }
    
    /// <remarks/>
    public string IP {
        get {
            return this.ipField;
        }
        set {
            this.ipField = value;
        }
    }
    
    /// <remarks/>
    public string ReturnCodeDetails {
        get {
            return this.returnCodeDetailsField;
        }
        set {
            this.returnCodeDetailsField = value;
        }
    }
    
    /// <remarks/>
    public string CountryName {
        get {
            return this.countryNameField;
        }
        set {
            this.countryNameField = value;
        }
    }
    
    /// <remarks/>
    public string CountryCode {
        get {
            return this.countryCodeField;
        }
        set {
            this.countryCodeField = value;
        }
    }
}

/// CodeRemarks
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "0.0.0.0")]
public delegate void GetGeoIPCompletedEventHandler(object sender, GetGeoIPCompletedEventArgs e);

/// CodeRemarks
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "0.0.0.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetGeoIPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetGeoIPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// CodeRemarks
    public GeoIP Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((GeoIP)(this.results[0]));
        }
    }
}

/// CodeRemarks
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "0.0.0.0")]
public delegate void GetGeoIPContextCompletedEventHandler(object sender, GetGeoIPContextCompletedEventArgs e);

/// CodeRemarks
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "0.0.0.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetGeoIPContextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetGeoIPContextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// CodeRemarks
    public GeoIP Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((GeoIP)(this.results[0]));
        }
    }
}
