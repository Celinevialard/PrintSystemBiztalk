namespace PrintSystemBiztalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.Schemas.PaymentDBAddMoney", typeof(global::PrintSystemBiztalk.Schemas.PaymentDBAddMoney))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.PrintPaymentService_tempuri_org+AddChfByCardId", typeof(global::PrintSystemBiztalk.PrintPaymentService_tempuri_org.AddChfByCardId))]
    public sealed class AddMoneyWithCardId : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:s0=""http://PrintSystemBiztalk.Schemas.PaymentDBAddMoney"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddMoney"" />
  </xsl:template>
  <xsl:template match=""/s0:AddMoney"">
    <ns0:AddChfByCardId>
      <ns0:cardId>
        <xsl:value-of select=""CardID/text()"" />
      </ns0:cardId>
      <ns0:chf>
        <xsl:value-of select=""Amount/text()"" />
      </ns0:chf>
      <xsl:variable name=""var:v1"" select=""userCSharp:GenerateGUID()"" />
      <ns0:requestId>
        <xsl:value-of select=""$var:v1"" />
      </ns0:requestId>
    </ns0:AddChfByCardId>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string GenerateGUID()
{
    System.Guid temp = System.Guid.NewGuid();
    return temp.ToString();
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"PrintSystemBiztalk.Schemas.PaymentDBAddMoney";
        
        private const global::PrintSystemBiztalk.Schemas.PaymentDBAddMoney _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PrintSystemBiztalk.PrintPaymentService_tempuri_org+AddChfByCardId";
        
        private const global::PrintSystemBiztalk.PrintPaymentService_tempuri_org.AddChfByCardId _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"PrintSystemBiztalk.Schemas.PaymentDBAddMoney";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PrintSystemBiztalk.PrintPaymentService_tempuri_org+AddChfByCardId";
                return _TrgSchemas;
            }
        }
    }
}
