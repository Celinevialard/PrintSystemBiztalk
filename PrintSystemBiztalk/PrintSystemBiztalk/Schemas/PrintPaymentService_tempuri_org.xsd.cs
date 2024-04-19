namespace PrintSystemBiztalk {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddChfByCardId", @"AddChfByCardIdResponse", @"AddChfByUsername", @"AddChfByUsernameResponse", @"CreateUser", @"CreateUserResponse", @"RemoveQuota", @"RemoveQuotaResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.PrintPaymentService_schemas_datacontract_org_2004_07_DTO", typeof(global::PrintSystemBiztalk.PrintPaymentService_schemas_datacontract_org_2004_07_DTO))]
    public sealed class PrintPaymentService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""PrintSystemBiztalk.PrintPaymentService_schemas_datacontract_org_2004_07_DTO"" namespace=""http://schemas.datacontract.org/2004/07/DTO"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/DTO"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AddChfByCardId"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""cardId"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""chf"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddChfByCardIdResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/DTO"" minOccurs=""0"" name=""AddChfByCardIdResult"" nillable=""true"" type=""q1:QuotaReturn"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddChfByUsername"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""username"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""chf"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddChfByUsernameResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/DTO"" minOccurs=""0"" name=""AddChfByUsernameResult"" nillable=""true"" type=""q2:QuotaReturn"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CreateUser"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""username"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""cardId"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CreateUserResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""CreateUserResult"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RemoveQuota"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""username"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""quota"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RemoveQuotaResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""RemoveQuotaResult"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PrintPaymentService_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [8];
                _RootElements[0] = "AddChfByCardId";
                _RootElements[1] = "AddChfByCardIdResponse";
                _RootElements[2] = "AddChfByUsername";
                _RootElements[3] = "AddChfByUsernameResponse";
                _RootElements[4] = "CreateUser";
                _RootElements[5] = "CreateUserResponse";
                _RootElements[6] = "RemoveQuota";
                _RootElements[7] = "RemoveQuotaResponse";
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
        
        [Schema(@"http://tempuri.org/",@"AddChfByCardId")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddChfByCardId"})]
        public sealed class AddChfByCardId : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddChfByCardId() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddChfByCardId";
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
        
        [Schema(@"http://tempuri.org/",@"AddChfByCardIdResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddChfByCardIdResponse"})]
        public sealed class AddChfByCardIdResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddChfByCardIdResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddChfByCardIdResponse";
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
        
        [Schema(@"http://tempuri.org/",@"AddChfByUsername")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddChfByUsername"})]
        public sealed class AddChfByUsername : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddChfByUsername() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddChfByUsername";
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
        
        [Schema(@"http://tempuri.org/",@"AddChfByUsernameResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddChfByUsernameResponse"})]
        public sealed class AddChfByUsernameResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddChfByUsernameResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddChfByUsernameResponse";
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
        
        [Schema(@"http://tempuri.org/",@"CreateUser")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateUser"})]
        public sealed class CreateUser : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateUser() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateUser";
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
        
        [Schema(@"http://tempuri.org/",@"CreateUserResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateUserResponse"})]
        public sealed class CreateUserResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateUserResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateUserResponse";
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
        
        [Schema(@"http://tempuri.org/",@"RemoveQuota")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RemoveQuota"})]
        public sealed class RemoveQuota : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RemoveQuota() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RemoveQuota";
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
        
        [Schema(@"http://tempuri.org/",@"RemoveQuotaResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RemoveQuotaResponse"})]
        public sealed class RemoveQuotaResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RemoveQuotaResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RemoveQuotaResponse";
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
}
