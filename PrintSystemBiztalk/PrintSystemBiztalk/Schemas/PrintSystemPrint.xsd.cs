namespace PrintSystemBiztalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://PrintSystemBiztalk.Schemas.PrintSystemPrint",@"Print")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Print"})]
    public sealed class PrintSystemPrint : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://PrintSystemBiztalk.Schemas.PrintSystemPrint"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://PrintSystemBiztalk.Schemas.PrintSystemPrint"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Print"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Username"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:string"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Password"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:string"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Quota"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:int"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PrintSystemPrint() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Print";
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
