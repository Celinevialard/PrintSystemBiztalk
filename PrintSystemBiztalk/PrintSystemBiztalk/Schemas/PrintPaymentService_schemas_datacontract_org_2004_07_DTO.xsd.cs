namespace PrintSystemBiztalk {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.datacontract.org/2004/07/DTO",@"QuotaReturn")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::PrintSystemBiztalk.PropertySchema.requestId), XPath = @"/*[local-name()='QuotaReturn' and namespace-uri()='http://schemas.datacontract.org/2004/07/DTO']/*[local-name()='requestId' and namespace-uri()='http://schemas.datacontract.org/2004/07/DTO']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "requestId", XPath = @"/*[local-name()='QuotaReturn' and namespace-uri()='http://schemas.datacontract.org/2004/07/DTO']/*[local-name()='requestId' and namespace-uri()='http://schemas.datacontract.org/2004/07/DTO']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"QuotaReturn"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.PropertySchema.PropertySchema", typeof(global::PrintSystemBiztalk.PropertySchema.PropertySchema))]
    public sealed class PrintPaymentService_schemas_datacontract_org_2004_07_DTO : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:ns0=""https://PrintSystemBiztalk.PropertySchema"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://PrintSystemBiztalk.PropertySchema"" location=""PrintSystemBiztalk.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""QuotaReturn"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""quota"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""username"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""requestId"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""QuotaReturn"" nillable=""true"" type=""tns:QuotaReturn"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:requestId"" xpath=""/*[local-name()='QuotaReturn' and namespace-uri()='http://schemas.datacontract.org/2004/07/DTO']/*[local-name()='requestId' and namespace-uri()='http://schemas.datacontract.org/2004/07/DTO']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='QuotaReturn' and namespace-uri()='http://schemas.datacontract.org/2004/07/DTO']/*[local-name()='requestId' and namespace-uri()='http://schemas.datacontract.org/2004/07/DTO']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public PrintPaymentService_schemas_datacontract_org_2004_07_DTO() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "QuotaReturn";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
