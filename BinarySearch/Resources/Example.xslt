<xsl:stylesheet
      version="1.0"
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
      xmlns="http://www.w3.org/TR/xhtml1/strict">
 
<xsl:template match="/">
<html>
  <head>
    <title>Binary Search</title>
  </head>
  <body>
    <h3>Array of numbers: 
    <xsl:value-of select="/XMLImpl/Array"/></h3>
    <h3>Searched value:
    <xsl:value-of select="/XMLImpl/SearchValue"/></h3>
    <h2>Index of found element:
    <xsl:value-of select="/XMLImpl/FoundIndex"/></h2>
  </body>
</html>
</xsl:template></xsl:stylesheet>