namespace PrintSystemBiztalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://PrintSystemBiztalk.Schemas.AuthResponse",@"AuthResponse")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::PrintSystemBiztalk.PropertySchema.RequestIdentification), XPath = @"/*[local-name()='AuthResponse' and namespace-uri()='http://PrintSystemBiztalk.Schemas.AuthResponse']/*[local-name()='RequestIdentification' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RequestIdentification", XPath = @"/*[local-name()='AuthResponse' and namespace-uri()='http://PrintSystemBiztalk.Schemas.AuthResponse']/*[local-name()='RequestIdentification' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "IsValid", XPath = @"/*[local-name()='AuthResponse' and namespace-uri()='http://PrintSystemBiztalk.Schemas.AuthResponse']/*[local-name()='IsValid' and namespace-uri()='']", XsdType = @"boolean")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AuthResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.PropertySchema.PropertySchema", typeof(global::PrintSystemBiztalk.PropertySchema.PropertySchema))]
    public sealed class AuthResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://PrintSystemBiztalk.Schemas.AuthResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://PrintSystemBiztalk.PropertySchema"" targetNamespace=""http://PrintSystemBiztalk.Schemas.AuthResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://PrintSystemBiztalk.PropertySchema"" location=""PrintSystemBiztalk.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AuthResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:RequestIdentification"" xpath=""/*[local-name()='AuthResponse' and namespace-uri()='http://PrintSystemBiztalk.Schemas.AuthResponse']/*[local-name()='RequestIdentification' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AuthResponse' and namespace-uri()='http://PrintSystemBiztalk.Schemas.AuthResponse']/*[local-name()='RequestIdentification' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AuthResponse' and namespace-uri()='http://PrintSystemBiztalk.Schemas.AuthResponse']/*[local-name()='IsValid' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RequestIdentification"" type=""xs:string"" />
        <xs:element name=""IsValid"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AuthResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AuthResponse";
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
