namespace PrintSystemBiztalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.PrintPaymentService_tempuri_org+AddChfByUsernameResponse", typeof(global::PrintSystemBiztalk.PrintPaymentService_tempuri_org.AddChfByUsernameResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.Schemas.PrintSystemAddQuota", typeof(global::PrintSystemBiztalk.Schemas.PrintSystemAddQuota))]
    public sealed class WSUsernameResponse_to_Print : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s1=""http://tempuri.org/"" xmlns:s0=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:ns0=""http://PrintSystemBiztalk.Schemas.PrintSystemAddQuota"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:AddChfByUsernameResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:AddChfByUsernameResponse"">
    <ns0:AddQuota>
      <xsl:for-each select=""s1:AddChfByUsernameResult"">
        <xsl:if test=""s0:quota"">
          <Quota>
            <xsl:value-of select=""s0:quota/text()"" />
          </Quota>
        </xsl:if>
      </xsl:for-each>
      <xsl:for-each select=""s1:AddChfByUsernameResult"">
        <xsl:if test=""s0:username"">
          <Username>
            <xsl:value-of select=""s0:username/text()"" />
          </Username>
        </xsl:if>
      </xsl:for-each>
    </ns0:AddQuota>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"PrintSystemBiztalk.PrintPaymentService_tempuri_org+AddChfByUsernameResponse";
        
        private const global::PrintSystemBiztalk.PrintPaymentService_tempuri_org.AddChfByUsernameResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PrintSystemBiztalk.Schemas.PrintSystemAddQuota";
        
        private const global::PrintSystemBiztalk.Schemas.PrintSystemAddQuota _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"PrintSystemBiztalk.PrintPaymentService_tempuri_org+AddChfByUsernameResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PrintSystemBiztalk.Schemas.PrintSystemAddQuota";
                return _TrgSchemas;
            }
        }
    }
}
