namespace PrintSystemBiztalk.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.Schemas.Auth", typeof(global::PrintSystemBiztalk.Schemas.Auth))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystemBiztalk.Schemas.AuthResponse", typeof(global::PrintSystemBiztalk.Schemas.AuthResponse))]
    public sealed class Auth_to_AuthResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://PrintSystemBiztalk.Schemas.Auth"" xmlns:ns0=""http://PrintSystemBiztalk.Schemas.AuthResponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Auth"" />
  </xsl:template>
  <xsl:template match=""/s0:Auth"">
    <ns0:AuthResponse>
      <xsl:variable name=""var:v1"" select=""userCSharp:RandomBoolean()"" />
      <IsValid>
        <xsl:value-of select=""$var:v1"" />
      </IsValid>
    </ns0:AuthResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public bool RandomBoolean()
{
    return new System.Random().NextDouble() > 0.75;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"PrintSystemBiztalk.Schemas.Auth";
        
        private const global::PrintSystemBiztalk.Schemas.Auth _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PrintSystemBiztalk.Schemas.AuthResponse";
        
        private const global::PrintSystemBiztalk.Schemas.AuthResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"PrintSystemBiztalk.Schemas.Auth";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PrintSystemBiztalk.Schemas.AuthResponse";
                return _TrgSchemas;
            }
        }
    }
}
