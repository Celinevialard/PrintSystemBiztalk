namespace PrintSystemBiztalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.Schemas.PrintSystemPrint", typeof(global::PrintSystemBiztalk.Schemas.PrintSystemPrint))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.Schemas.Auth", typeof(global::PrintSystemBiztalk.Schemas.Auth))]
    public sealed class Print_to_Auth : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://PrintSystemBiztalk.Schemas.Auth"" xmlns:s0=""http://PrintSystemBiztalk.Schemas.PrintSystemPrint"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Print"" />
  </xsl:template>
  <xsl:template match=""/s0:Print"">
    <ns0:Auth>
      <Username>
        <xsl:value-of select=""Username/text()"" />
      </Username>
      <Password>
        <xsl:value-of select=""Password/text()"" />
      </Password>
    </ns0:Auth>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"PrintSystemBiztalk.Schemas.PrintSystemPrint";
        
        private const global::PrintSystemBiztalk.Schemas.PrintSystemPrint _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PrintSystemBiztalk.Schemas.Auth";
        
        private const global::PrintSystemBiztalk.Schemas.Auth _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"PrintSystemBiztalk.Schemas.PrintSystemPrint";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PrintSystemBiztalk.Schemas.Auth";
                return _TrgSchemas;
            }
        }
    }
}
