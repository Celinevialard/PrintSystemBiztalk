namespace PrintSystemBiztalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.Schemas.SAPUsers", typeof(global::PrintSystemBiztalk.Schemas.SAPUsers))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.PrintPaymentService_tempuri_org+CreateUser", typeof(global::PrintSystemBiztalk.PrintPaymentService_tempuri_org.CreateUser))]
    public sealed class SAP : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:s0=""http://PrintSystemBiztalk.Schemas.SAPUsers"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:User"" />
  </xsl:template>
  <xsl:template match=""/s0:User"">
    <ns0:CreateUser>
      <ns0:username>
        <xsl:value-of select=""Username/text()"" />
      </ns0:username>
      <ns0:cardId>
        <xsl:value-of select=""CardId/text()"" />
      </ns0:cardId>
    </ns0:CreateUser>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"PrintSystemBiztalk.Schemas.SAPUsers";
        
        private const global::PrintSystemBiztalk.Schemas.SAPUsers _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PrintSystemBiztalk.PrintPaymentService_tempuri_org+CreateUser";
        
        private const global::PrintSystemBiztalk.PrintPaymentService_tempuri_org.CreateUser _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"PrintSystemBiztalk.Schemas.SAPUsers";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PrintSystemBiztalk.PrintPaymentService_tempuri_org+CreateUser";
                return _TrgSchemas;
            }
        }
    }
}
