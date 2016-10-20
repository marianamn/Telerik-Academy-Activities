<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/catalogue">
     <html>
       <head>
         <title>Albums Catalogue</title>
         <style>
            table{
              border-collapse:collapse;
              text-align:center
            }

            table, th, td, tr{
                border: 1px solid black;
            }

            th {
                 background-color: grey
            }
         </style>
       </head>
      <body>
        <h1>Albums Catalogue</h1>

        <table>
          <tr>
            <th>Name</th>
            <th>Artist</th>
            <th>Released yar</th>
            <th>Price</th>
            <th>Songs</th>
          </tr>
          <xsl:for-each select="album">
            <tr>
            <td><xsl:value-of select="name" /></td>
            <td><xsl:value-of select="artist" /></td>
            <td><xsl:value-of select="year" /></td>
            <td><xsl:value-of select="price" /></td>
            <td>
                <xsl:for-each select="songs/song">
                  <div>                    
                    <strong>
                      <xsl:value-of select="title"/>
                    </strong> -
                    <xsl:value-of select="duration"/>
                  </div>
                </xsl:for-each>
            </td>
            </tr>
          </xsl:for-each>
       </table>       
      </body>
     </html>
  </xsl:template>
</xsl:stylesheet>
