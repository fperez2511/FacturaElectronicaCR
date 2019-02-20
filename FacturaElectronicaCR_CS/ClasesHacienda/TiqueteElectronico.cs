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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico", IsNullable=false)]
public partial class TiqueteElectronico {
    
    private string claveField;
    
    private string numeroConsecutivoField;
    
    private System.DateTime fechaEmisionField;
    
    private EmisorType emisorField;
    
    private ReceptorType receptorField;
    
    private TiqueteElectronicoCondicionVenta condicionVentaField;
    
    private string plazoCreditoField;
    
    private TiqueteElectronicoMedioPago[] medioPagoField;
    
    private TiqueteElectronicoLineaDetalle[] detalleServicioField;
    
    private TiqueteElectronicoResumenFactura resumenFacturaField;
    
    private TiqueteElectronicoInformacionReferencia[] informacionReferenciaField;
    
    private TiqueteElectronicoNormativa normativaField;
    
    private TiqueteElectronicoOtros otrosField;
    
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
    public string NumeroConsecutivo {
        get {
            return this.numeroConsecutivoField;
        }
        set {
            this.numeroConsecutivoField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime FechaEmision {
        get {
            return this.fechaEmisionField;
        }
        set {
            this.fechaEmisionField = value;
        }
    }
    
    /// <remarks/>
    public EmisorType Emisor {
        get {
            return this.emisorField;
        }
        set {
            this.emisorField = value;
        }
    }
    
    /// <remarks/>
    public ReceptorType Receptor {
        get {
            return this.receptorField;
        }
        set {
            this.receptorField = value;
        }
    }
    
    /// <remarks/>
    public TiqueteElectronicoCondicionVenta CondicionVenta {
        get {
            return this.condicionVentaField;
        }
        set {
            this.condicionVentaField = value;
        }
    }
    
    /// <remarks/>
    public string PlazoCredito {
        get {
            return this.plazoCreditoField;
        }
        set {
            this.plazoCreditoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MedioPago")]
    public TiqueteElectronicoMedioPago[] MedioPago {
        get {
            return this.medioPagoField;
        }
        set {
            this.medioPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("LineaDetalle", IsNullable=false)]
    public TiqueteElectronicoLineaDetalle[] DetalleServicio {
        get {
            return this.detalleServicioField;
        }
        set {
            this.detalleServicioField = value;
        }
    }
    
    /// <remarks/>
    public TiqueteElectronicoResumenFactura ResumenFactura {
        get {
            return this.resumenFacturaField;
        }
        set {
            this.resumenFacturaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InformacionReferencia")]
    public TiqueteElectronicoInformacionReferencia[] InformacionReferencia {
        get {
            return this.informacionReferenciaField;
        }
        set {
            this.informacionReferenciaField = value;
        }
    }
    
    /// <remarks/>
    public TiqueteElectronicoNormativa Normativa {
        get {
            return this.normativaField;
        }
        set {
            this.normativaField = value;
        }
    }
    
    /// <remarks/>
    public TiqueteElectronicoOtros Otros {
        get {
            return this.otrosField;
        }
        set {
            this.otrosField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public enum TiqueteElectronicoCondicionVenta {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Contado,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Credito,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Consignacion,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Apartado,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    ArrendamientoOpcionCompra,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("06")]
    ArrendamientoFuncionFinanciera,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("99")]
    Otros,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public enum TiqueteElectronicoMedioPago {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("99")]
    Item99,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public partial class TiqueteElectronicoLineaDetalle {
    
    private string numeroLineaField;
    
    private CodigoType[] codigoField;
    
    private decimal cantidadField;
    
    private UnidadMedidaType unidadMedidaField;
    
    private string unidadMedidaComercialField;
    
    private string detalleField;
    
    private decimal precioUnitarioField;
    
    private decimal montoTotalField;
    
    private decimal montoDescuentoField;
    
    private bool montoDescuentoFieldSpecified;
    
    private string naturalezaDescuentoField;
    
    private decimal subTotalField;
    
    private ImpuestoType[] impuestoField;
    
    private decimal montoTotalLineaField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumeroLinea {
        get {
            return this.numeroLineaField;
        }
        set {
            this.numeroLineaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Codigo")]
    public CodigoType[] Codigo {
        get {
            return this.codigoField;
        }
        set {
            this.codigoField = value;
        }
    }
    
    /// <remarks/>
    public decimal Cantidad {
        get {
            return this.cantidadField;
        }
        set {
            this.cantidadField = value;
        }
    }
    
    /// <remarks/>
    public UnidadMedidaType UnidadMedida {
        get {
            return this.unidadMedidaField;
        }
        set {
            this.unidadMedidaField = value;
        }
    }
    
    /// <remarks/>
    public string UnidadMedidaComercial {
        get {
            return this.unidadMedidaComercialField;
        }
        set {
            this.unidadMedidaComercialField = value;
        }
    }
    
    /// <remarks/>
    public string Detalle {
        get {
            return this.detalleField;
        }
        set {
            this.detalleField = value;
        }
    }
    
    /// <remarks/>
    public decimal PrecioUnitario {
        get {
            return this.precioUnitarioField;
        }
        set {
            this.precioUnitarioField = value;
        }
    }
    
    /// <remarks/>
    public decimal MontoTotal {
        get {
            return this.montoTotalField;
        }
        set {
            this.montoTotalField = value;
        }
    }
    
    /// <remarks/>
    public decimal MontoDescuento {
        get {
            return this.montoDescuentoField;
        }
        set {
            this.montoDescuentoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MontoDescuentoSpecified {
        get {
            return this.montoDescuentoFieldSpecified;
        }
        set {
            this.montoDescuentoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string NaturalezaDescuento {
        get {
            return this.naturalezaDescuentoField;
        }
        set {
            this.naturalezaDescuentoField = value;
        }
    }
    
    /// <remarks/>
    public decimal SubTotal {
        get {
            return this.subTotalField;
        }
        set {
            this.subTotalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Impuesto")]
    public ImpuestoType[] Impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    public decimal MontoTotalLinea {
        get {
            return this.montoTotalLineaField;
        }
        set {
            this.montoTotalLineaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public partial class TiqueteElectronicoResumenFactura {
    
    private TiqueteElectronicoResumenFacturaCodigoMoneda codigoMonedaField;
    
    private bool codigoMonedaFieldSpecified;
    
    private decimal tipoCambioField;
    
    private bool tipoCambioFieldSpecified;
    
    private decimal totalServGravadosField;
    
    private bool totalServGravadosFieldSpecified;
    
    private decimal totalServExentosField;
    
    private bool totalServExentosFieldSpecified;
    
    private decimal totalMercanciasGravadasField;
    
    private bool totalMercanciasGravadasFieldSpecified;
    
    private decimal totalMercanciasExentasField;
    
    private bool totalMercanciasExentasFieldSpecified;
    
    private decimal totalGravadoField;
    
    private bool totalGravadoFieldSpecified;
    
    private decimal totalExentoField;
    
    private bool totalExentoFieldSpecified;
    
    private decimal totalVentaField;
    
    private decimal totalDescuentosField;
    
    private bool totalDescuentosFieldSpecified;
    
    private decimal totalVentaNetaField;
    
    private decimal totalImpuestoField;
    
    private bool totalImpuestoFieldSpecified;
    
    private decimal totalComprobanteField;
    
    /// <remarks/>
    public TiqueteElectronicoResumenFacturaCodigoMoneda CodigoMoneda {
        get {
            return this.codigoMonedaField;
        }
        set {
            this.codigoMonedaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CodigoMonedaSpecified {
        get {
            return this.codigoMonedaFieldSpecified;
        }
        set {
            this.codigoMonedaFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TipoCambio {
        get {
            return this.tipoCambioField;
        }
        set {
            this.tipoCambioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoCambioSpecified {
        get {
            return this.tipoCambioFieldSpecified;
        }
        set {
            this.tipoCambioFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalServGravados {
        get {
            return this.totalServGravadosField;
        }
        set {
            this.totalServGravadosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalServGravadosSpecified {
        get {
            return this.totalServGravadosFieldSpecified;
        }
        set {
            this.totalServGravadosFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalServExentos {
        get {
            return this.totalServExentosField;
        }
        set {
            this.totalServExentosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalServExentosSpecified {
        get {
            return this.totalServExentosFieldSpecified;
        }
        set {
            this.totalServExentosFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalMercanciasGravadas {
        get {
            return this.totalMercanciasGravadasField;
        }
        set {
            this.totalMercanciasGravadasField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalMercanciasGravadasSpecified {
        get {
            return this.totalMercanciasGravadasFieldSpecified;
        }
        set {
            this.totalMercanciasGravadasFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalMercanciasExentas {
        get {
            return this.totalMercanciasExentasField;
        }
        set {
            this.totalMercanciasExentasField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalMercanciasExentasSpecified {
        get {
            return this.totalMercanciasExentasFieldSpecified;
        }
        set {
            this.totalMercanciasExentasFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalGravado {
        get {
            return this.totalGravadoField;
        }
        set {
            this.totalGravadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalGravadoSpecified {
        get {
            return this.totalGravadoFieldSpecified;
        }
        set {
            this.totalGravadoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalExento {
        get {
            return this.totalExentoField;
        }
        set {
            this.totalExentoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalExentoSpecified {
        get {
            return this.totalExentoFieldSpecified;
        }
        set {
            this.totalExentoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalVenta {
        get {
            return this.totalVentaField;
        }
        set {
            this.totalVentaField = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalDescuentos {
        get {
            return this.totalDescuentosField;
        }
        set {
            this.totalDescuentosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalDescuentosSpecified {
        get {
            return this.totalDescuentosFieldSpecified;
        }
        set {
            this.totalDescuentosFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalVentaNeta {
        get {
            return this.totalVentaNetaField;
        }
        set {
            this.totalVentaNetaField = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalImpuesto {
        get {
            return this.totalImpuestoField;
        }
        set {
            this.totalImpuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalImpuestoSpecified {
        get {
            return this.totalImpuestoFieldSpecified;
        }
        set {
            this.totalImpuestoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal TotalComprobante {
        get {
            return this.totalComprobanteField;
        }
        set {
            this.totalComprobanteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public enum TiqueteElectronicoResumenFacturaCodigoMoneda {
    
    /// <remarks/>
    AED,
    
    /// <remarks/>
    AFN,
    
    /// <remarks/>
    ALL,
    
    /// <remarks/>
    AMD,
    
    /// <remarks/>
    ANG,
    
    /// <remarks/>
    AOA,
    
    /// <remarks/>
    ARS,
    
    /// <remarks/>
    AUD,
    
    /// <remarks/>
    AWG,
    
    /// <remarks/>
    AZN,
    
    /// <remarks/>
    BAM,
    
    /// <remarks/>
    BBD,
    
    /// <remarks/>
    BDT,
    
    /// <remarks/>
    BGN,
    
    /// <remarks/>
    BHD,
    
    /// <remarks/>
    BIF,
    
    /// <remarks/>
    BMD,
    
    /// <remarks/>
    BND,
    
    /// <remarks/>
    BOB,
    
    /// <remarks/>
    BOV,
    
    /// <remarks/>
    BRL,
    
    /// <remarks/>
    BSD,
    
    /// <remarks/>
    BTN,
    
    /// <remarks/>
    BWP,
    
    /// <remarks/>
    BYR,
    
    /// <remarks/>
    BZD,
    
    /// <remarks/>
    CAD,
    
    /// <remarks/>
    CDF,
    
    /// <remarks/>
    CHE,
    
    /// <remarks/>
    CHF,
    
    /// <remarks/>
    CHW,
    
    /// <remarks/>
    CLF,
    
    /// <remarks/>
    CLP,
    
    /// <remarks/>
    CNY,
    
    /// <remarks/>
    COP,
    
    /// <remarks/>
    COU,
    
    /// <remarks/>
    CRC,
    
    /// <remarks/>
    CUC,
    
    /// <remarks/>
    CUP,
    
    /// <remarks/>
    CVE,
    
    /// <remarks/>
    CZK,
    
    /// <remarks/>
    DJF,
    
    /// <remarks/>
    DKK,
    
    /// <remarks/>
    DOP,
    
    /// <remarks/>
    DZD,
    
    /// <remarks/>
    EGP,
    
    /// <remarks/>
    ERN,
    
    /// <remarks/>
    ETB,
    
    /// <remarks/>
    EUR,
    
    /// <remarks/>
    FJD,
    
    /// <remarks/>
    FKP,
    
    /// <remarks/>
    GBP,
    
    /// <remarks/>
    GEL,
    
    /// <remarks/>
    GHS,
    
    /// <remarks/>
    GIP,
    
    /// <remarks/>
    GMD,
    
    /// <remarks/>
    GNF,
    
    /// <remarks/>
    GTQ,
    
    /// <remarks/>
    GYD,
    
    /// <remarks/>
    HKD,
    
    /// <remarks/>
    HNL,
    
    /// <remarks/>
    HRK,
    
    /// <remarks/>
    HTG,
    
    /// <remarks/>
    HUF,
    
    /// <remarks/>
    IDR,
    
    /// <remarks/>
    ILS,
    
    /// <remarks/>
    INR,
    
    /// <remarks/>
    IQD,
    
    /// <remarks/>
    IRR,
    
    /// <remarks/>
    ISK,
    
    /// <remarks/>
    JMD,
    
    /// <remarks/>
    JOD,
    
    /// <remarks/>
    JPY,
    
    /// <remarks/>
    KES,
    
    /// <remarks/>
    KGS,
    
    /// <remarks/>
    KHR,
    
    /// <remarks/>
    KMF,
    
    /// <remarks/>
    KPW,
    
    /// <remarks/>
    KRW,
    
    /// <remarks/>
    KWD,
    
    /// <remarks/>
    KYD,
    
    /// <remarks/>
    KZT,
    
    /// <remarks/>
    LAK,
    
    /// <remarks/>
    LBP,
    
    /// <remarks/>
    LKR,
    
    /// <remarks/>
    LRD,
    
    /// <remarks/>
    LSL,
    
    /// <remarks/>
    LYD,
    
    /// <remarks/>
    MAD,
    
    /// <remarks/>
    MDL,
    
    /// <remarks/>
    MGA,
    
    /// <remarks/>
    MKD,
    
    /// <remarks/>
    MMK,
    
    /// <remarks/>
    MNT,
    
    /// <remarks/>
    MOP,
    
    /// <remarks/>
    MRO,
    
    /// <remarks/>
    MUR,
    
    /// <remarks/>
    MVR,
    
    /// <remarks/>
    MWK,
    
    /// <remarks/>
    MXN,
    
    /// <remarks/>
    MXV,
    
    /// <remarks/>
    MYR,
    
    /// <remarks/>
    MZN,
    
    /// <remarks/>
    NAD,
    
    /// <remarks/>
    NGN,
    
    /// <remarks/>
    NIO,
    
    /// <remarks/>
    NOK,
    
    /// <remarks/>
    NPR,
    
    /// <remarks/>
    NZD,
    
    /// <remarks/>
    OMR,
    
    /// <remarks/>
    PAB,
    
    /// <remarks/>
    PEN,
    
    /// <remarks/>
    PGK,
    
    /// <remarks/>
    PHP,
    
    /// <remarks/>
    PKR,
    
    /// <remarks/>
    PLN,
    
    /// <remarks/>
    PYG,
    
    /// <remarks/>
    QAR,
    
    /// <remarks/>
    RON,
    
    /// <remarks/>
    RSD,
    
    /// <remarks/>
    RUB,
    
    /// <remarks/>
    RWF,
    
    /// <remarks/>
    SAR,
    
    /// <remarks/>
    SBD,
    
    /// <remarks/>
    SCR,
    
    /// <remarks/>
    SDG,
    
    /// <remarks/>
    SEK,
    
    /// <remarks/>
    SGD,
    
    /// <remarks/>
    SHP,
    
    /// <remarks/>
    SLL,
    
    /// <remarks/>
    SOS,
    
    /// <remarks/>
    SRD,
    
    /// <remarks/>
    SSP,
    
    /// <remarks/>
    STD,
    
    /// <remarks/>
    SVC,
    
    /// <remarks/>
    SYP,
    
    /// <remarks/>
    SZL,
    
    /// <remarks/>
    THB,
    
    /// <remarks/>
    TJS,
    
    /// <remarks/>
    TMT,
    
    /// <remarks/>
    TND,
    
    /// <remarks/>
    TOP,
    
    /// <remarks/>
    TRY,
    
    /// <remarks/>
    TTD,
    
    /// <remarks/>
    TWD,
    
    /// <remarks/>
    TZS,
    
    /// <remarks/>
    UAH,
    
    /// <remarks/>
    UGX,
    
    /// <remarks/>
    USD,
    
    /// <remarks/>
    USN,
    
    /// <remarks/>
    UYI,
    
    /// <remarks/>
    UYU,
    
    /// <remarks/>
    UZS,
    
    /// <remarks/>
    VEF,
    
    /// <remarks/>
    VND,
    
    /// <remarks/>
    VUV,
    
    /// <remarks/>
    WST,
    
    /// <remarks/>
    XAF,
    
    /// <remarks/>
    XAG,
    
    /// <remarks/>
    XAU,
    
    /// <remarks/>
    XBA,
    
    /// <remarks/>
    XBB,
    
    /// <remarks/>
    XBC,
    
    /// <remarks/>
    XBD,
    
    /// <remarks/>
    XCD,
    
    /// <remarks/>
    XDR,
    
    /// <remarks/>
    XOF,
    
    /// <remarks/>
    XPD,
    
    /// <remarks/>
    XPF,
    
    /// <remarks/>
    XPT,
    
    /// <remarks/>
    XSU,
    
    /// <remarks/>
    XTS,
    
    /// <remarks/>
    XUA,
    
    /// <remarks/>
    XXX,
    
    /// <remarks/>
    YER,
    
    /// <remarks/>
    ZAR,
    
    /// <remarks/>
    ZMW,
    
    /// <remarks/>
    ZWL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public partial class TiqueteElectronicoInformacionReferencia {
    
    private TiqueteElectronicoInformacionReferenciaTipoDoc tipoDocField;
    
    private string numeroField;
    
    private System.DateTime fechaEmisionField;
    
    private TiqueteElectronicoInformacionReferenciaCodigo codigoField;
    
    private string razonField;
    
    /// <remarks/>
    public TiqueteElectronicoInformacionReferenciaTipoDoc TipoDoc {
        get {
            return this.tipoDocField;
        }
        set {
            this.tipoDocField = value;
        }
    }
    
    /// <remarks/>
    public string Numero {
        get {
            return this.numeroField;
        }
        set {
            this.numeroField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime FechaEmision {
        get {
            return this.fechaEmisionField;
        }
        set {
            this.fechaEmisionField = value;
        }
    }
    
    /// <remarks/>
    public TiqueteElectronicoInformacionReferenciaCodigo Codigo {
        get {
            return this.codigoField;
        }
        set {
            this.codigoField = value;
        }
    }
    
    /// <remarks/>
    public string Razon {
        get {
            return this.razonField;
        }
        set {
            this.razonField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public enum TiqueteElectronicoInformacionReferenciaTipoDoc {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("06")]
    Item06,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("07")]
    Item07,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("08")]
    Item08,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("99")]
    Item99,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public enum TiqueteElectronicoInformacionReferenciaCodigo {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    AnulaDocumentoReferencia,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    CorrigeTextoDocumentoReferencia,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    CorrigeMonto,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    ReferenciaOtroDocumento,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    SustituyeComprobanteProvisionalPorContingencia,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("99")]
    Otros,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public partial class TiqueteElectronicoNormativa {
    
    private string numeroResolucionField;
    
    private string fechaResolucionField;
    
    /// <remarks/>
    public string NumeroResolucion {
        get {
            return this.numeroResolucionField;
        }
        set {
            this.numeroResolucionField = value;
        }
    }
    
    /// <remarks/>
    public string FechaResolucion {
        get {
            return this.fechaResolucionField;
        }
        set {
            this.fechaResolucionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public partial class TiqueteElectronicoOtros {
    
    private TiqueteElectronicoOtrosOtroTexto[] otroTextoField;
    
    private TiqueteElectronicoOtrosOtroContenido[] otroContenidoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OtroTexto")]
    public TiqueteElectronicoOtrosOtroTexto[] OtroTexto {
        get {
            return this.otroTextoField;
        }
        set {
            this.otroTextoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OtroContenido")]
    public TiqueteElectronicoOtrosOtroContenido[] OtroContenido {
        get {
            return this.otroContenidoField;
        }
        set {
            this.otroContenidoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public partial class TiqueteElectronicoOtrosOtroTexto {
    
    private string codigoField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codigo {
        get {
            return this.codigoField;
        }
        set {
            this.codigoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/tiqueteElectronico")]
public partial class TiqueteElectronicoOtrosOtroContenido {
    
    private System.Xml.XmlElement anyField;
    
    private string codigoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codigo {
        get {
            return this.codigoField;
        }
        set {
            this.codigoField = value;
        }
    }
}
