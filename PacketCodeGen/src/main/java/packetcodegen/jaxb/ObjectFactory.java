//
// This file was generated by the JavaTM Architecture for XML Binding(JAXB) Reference Implementation, v2.2.5-2 
// See <a href="http://java.sun.com/xml/jaxb">http://java.sun.com/xml/jaxb</a> 
// Any modifications to this file will be lost upon recompilation of the source schema. 
// Generated on: 2013.08.04 at 08:30:51 PM EDT 
//


package packetcodegen.jaxb;

import javax.xml.bind.annotation.XmlRegistry;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the packetcodegen.jaxb package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {


    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: packetcodegen.jaxb
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link Templates }
     * 
     */
    public Templates createTemplates() {
        return new Templates();
    }

    /**
     * Create an instance of {@link CommunicationDirection }
     * 
     */
    public CommunicationDirection createCommunicationDirection() {
        return new CommunicationDirection();
    }

    /**
     * Create an instance of {@link FieldType }
     * 
     */
    public FieldType createFieldType() {
        return new FieldType();
    }

    /**
     * Create an instance of {@link MetaInfo }
     * 
     */
    public MetaInfo createMetaInfo() {
        return new MetaInfo();
    }

    /**
     * Create an instance of {@link PacketType }
     * 
     */
    public PacketType createPacketType() {
        return new PacketType();
    }

    /**
     * Create an instance of {@link MetaInfoAttachment }
     * 
     */
    public MetaInfoAttachment createMetaInfoAttachment() {
        return new MetaInfoAttachment();
    }

}
