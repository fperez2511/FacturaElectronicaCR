﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/mensajeReceptor")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/mensajeReceptor", IsNullable=false)]
public partial class MensajeReceptor {
    
    private string claveField;
    
    private string numeroCedulaEmisorField;
    
    private System.DateTime fechaEmisionDocField;
    
    private MensajeReceptorMensaje mensajeField;
    
    private string detalleMensajeField;
    
    private decimal montoTotalImpuestoField;
    
    private bool montoTotalImpuestoFieldSpecified;
    
    private decimal totalFacturaField;
    
    private string numeroCedulaReceptorField;
    
    private string numeroConsecutivoReceptorField;
    
    private SignatureType signatureField;
    
    /// <remarks/>
    public string Clave {
        get {
            return this.claveField;
        }
        set {
            this.claveField = value;
        }
    }
    
    /// <remarks/>
    public string NumeroCedulaEmisor {
        get {
            return this.numeroCedulaEmisorField;
        }
        set {
            this.numeroCedulaEmisorField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime FechaEmisionDoc {
        get {
            return this.fechaEmisionDocField;
        }
        set {
            this.fechaEmisionDocField = value;
        }
    }
    
    /// <remarks/>
    public MensajeReceptorMensaje Mensaje {
        get {
            return this.mensajeField;
        }
        set {
            this.mensajeField = value;
        }
    }
    
    /// <remarks/>
    public string DetalleMensaje {
        get {
            return this.detalleMensajeField;
        }
        set {
            this.detalleMensajeField = value;
        }
    }
    
    /// <remarks/>
    public decimal MontoTotalImpuesto {
        get {
            return this.montoTotalImpuestoField;
        }
        set {
            this.montoTotalImpuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MontoTotalImpuestoSpecified {
        get {
            return this.montoTotalImpuestoFieldSpecified;
        }
        set {
            this.montoTotalImpuestoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalFactura {
        get {
            return this.totalFacturaField;
        }
        set {
            this.totalFacturaField = value;
        }
    }
    
    /// <remarks/>
    public string NumeroCedulaReceptor {
        get {
            return this.numeroCedulaReceptorField;
        }
        set {
            this.numeroCedulaReceptorField = value;
        }
    }
    
    /// <remarks/>
    public string NumeroConsecutivoReceptor {
        get {
            return this.numeroConsecutivoReceptorField;
        }
        set {
            this.numeroConsecutivoReceptorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public SignatureType Signature {
        get {
            return this.signatureField;
        }
        set {
            this.signatureField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/mensajeReceptor")]
public enum MensajeReceptorMensaje {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Aceptado,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    AceptadoParcialmente,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Rechazado,
}
