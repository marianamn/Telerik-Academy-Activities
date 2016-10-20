# XML Basics #

### XML language ###

XML (eXtensible Markup Language) is universal language (notation) for describing structured data using text with tags.It is used to describe other languages (formats) for data representation.XML looks like HTML - text based language, uses tags and attributes.

Well-formatted XML:

* All tags should be closed in the correct order of nesting
* Attributes should always be closed
* The document should contain only one root element
* Tag and attribute names retain certain restrictions

Advantages of XML:

* XML is human readable (unlike binary formats)
* Any kind of structured data can be stored
* Data comes with self-describing meta-data
* Custom XML-based languages can be developed for certain applications
* Information can be exchanged between different systems with ease
* Unicode is fully supported

Disadvantages of XML:

* XML data is bigger (takes more space) than in binary formats
* More memory consumption, more network traffic, more hard-disk space
* Decreased performance
* Need of parsing / constructing the XML tags
* XML is not suitable for all kinds of data - graphics, images and video clips

### Namespaces in the XML documents ###

XML Namespaces provide a method to avoid element name conflicts. In XML, element names are defined by the developer. This often results in a conflict when trying to mix XML documents from different XML applications. The namespace can be defined by an xmlns attribute in the start tag of an element.The namespace declaration has the following syntax. xmlns:prefix="URI".

    <root>
    <h:table xmlns:h="http://www.w3.org/TR/html4/">
      <h:tr>
    <h:td>Apples</h:td>
    <h:td>Bananas</h:td>
      </h:tr>
    </h:table>
    
    <f:table xmlns:f="http://www.w3schools.com/furniture">
      <f:name>African Coffee Table</f:name>
      <f:width>80</f:width>
      <f:length>120</f:length>
    </f:table>
    
    </root>
    

* URI (Uniform Resource Identifier) - is a string of characters used to identify the name of a resource. Such identification enables interaction with representations of the resource over a network, typically the World Wide Web, using specific protocols. Schemes specifying a concrete syntax and associated protocols define each URI. The most common form of URI is the Uniform Resource Locator (URL), frequently referred to informally as a web address. More rarely seen in usage is the Uniform Resource Name (URN), which was designed to complement URLs by providing a mechanism for the identification of resources in particular namespaces.
* URN (Uniform Resource Name)- A URN is a URI that identifies a resource by name in a particular namespace. A URN can be used to talk about a resource without implying its location or how to access it.
The International Standard Book Number (ISBN) system for uniquely identifying books provides a typical example of the use of URNs. ISBN 0-486-27557-4 cites unambiguously a specific edition of Shakespeare's play Romeo and Juliet. The URN for that edition would be urn:isbn:0-486-27557-4. To gain access to this object and read the book, its location is needed, for which a URL would have to be specified.
* URL (Uniform Resource Locator) - is a URI that, in addition to identifying a web resource, specifies the means of acting upon or obtaining the representation of it, i.e. specifying both its primary access mechanism and network location. For example, the URL http://example.org/wiki/Main_Page refers to a resource identified as /wiki/Main_Page whose representation, in the form of HTML and related code, is obtainable via HyperText Transfer Protocol (http) from a network host whose domain name is example.org.