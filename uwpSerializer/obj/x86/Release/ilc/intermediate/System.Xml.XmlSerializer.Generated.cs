namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write5_PurchaseOrder(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cpandl.com";
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"PurchaseOrder", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            Write4_PurchaseOrder(@"PurchaseOrder", namespace1, ((global::uwpSerializer.PurchaseOrder)o), false, false, namespace1, @"http://www.cpandl.com");
        }

        void Write4_PurchaseOrder(string n, string ns, global::uwpSerializer.PurchaseOrder o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::uwpSerializer.PurchaseOrder)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PurchaseOrder", defaultNamespace);
            string namespace2 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            Write2_Address(@"ShipTo", namespace2, ((global::uwpSerializer.Address)o.@ShipTo), false, false, namespace2, @"http://www.cpandl.com");
            string namespace3 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementString(@"OrderDate", namespace3, ((global::System.String)o.@OrderDate));
            string namespace4 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            {
                global::uwpSerializer.OrderedItem[] a = (global::uwpSerializer.OrderedItem[])((global::uwpSerializer.OrderedItem[])o.@OrderedItems);
                if (a != null){
                    WriteStartElement(@"Items", namespace4, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace5 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
                        Write3_OrderedItem(@"OrderedItem", namespace5, ((global::uwpSerializer.OrderedItem)a[ia]), true, false, namespace5, @"http://www.cpandl.com");
                    }
                    WriteEndElement();
                }
            }
            string namespace6 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementStringRaw(@"SubTotal", namespace6, System.Xml.XmlConvert.ToString((global::System.Decimal)((global::System.Decimal)o.@SubTotal)));
            string namespace7 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementStringRaw(@"ShipCost", namespace7, System.Xml.XmlConvert.ToString((global::System.Decimal)((global::System.Decimal)o.@ShipCost)));
            string namespace8 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementStringRaw(@"TotalCost", namespace8, System.Xml.XmlConvert.ToString((global::System.Decimal)((global::System.Decimal)o.@TotalCost)));
            WriteEndElement(o);
        }

        void Write3_OrderedItem(string n, string ns, global::uwpSerializer.OrderedItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::uwpSerializer.OrderedItem)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"OrderedItem", defaultNamespace);
            string namespace9 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementString(@"ItemName", namespace9, ((global::System.String)o.@ItemName));
            string namespace10 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementString(@"Description", namespace10, ((global::System.String)o.@Description));
            string namespace11 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementStringRaw(@"UnitPrice", namespace11, System.Xml.XmlConvert.ToString((global::System.Decimal)((global::System.Decimal)o.@UnitPrice)));
            string namespace12 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementStringRaw(@"Quantity", namespace12, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Quantity)));
            string namespace13 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementStringRaw(@"LineTotal", namespace13, System.Xml.XmlConvert.ToString((global::System.Decimal)((global::System.Decimal)o.@LineTotal)));
            WriteEndElement(o);
        }

        void Write2_Address(string n, string ns, global::uwpSerializer.Address o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::uwpSerializer.Address)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Address", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            string namespace14 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementString(@"Line1", namespace14, ((global::System.String)o.@Line1));
            string namespace15 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementString(@"City", namespace15, ((global::System.String)o.@City));
            string namespace16 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementString(@"State", namespace16, ((global::System.String)o.@State));
            string namespace17 = ( parentCompileTimeNs == @"http://www.cpandl.com" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cpandl.com";
            WriteElementString(@"Zip", namespace17, ((global::System.String)o.@Zip));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read5_PurchaseOrder(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_PurchaseOrder && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                    o = Read4_PurchaseOrder(false, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":PurchaseOrder");
            }
            return (object)o;
        }

        global::uwpSerializer.PurchaseOrder Read4_PurchaseOrder(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_PurchaseOrder && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwcpandlcom))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::uwpSerializer.PurchaseOrder o;
            o = new global::uwpSerializer.PurchaseOrder();
            global::uwpSerializer.OrderedItem[] a_2 = null;
            int ca_2 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id3_ShipTo && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        o.@ShipTo = Read2_Address(false, true, defaultNamespace);
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id4_OrderDate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@OrderDate = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id5_Items && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        if (!ReadNull()) {
                            global::uwpSerializer.OrderedItem[] a_2_0 = null;
                            int ca_2_0 = 0;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations1 = 0;
                                int readerCount1 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id6_OrderedItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                                            a_2_0 = (global::uwpSerializer.OrderedItem[])EnsureArrayIndex(a_2_0, ca_2_0, typeof(global::uwpSerializer.OrderedItem));a_2_0[ca_2_0++] = Read3_OrderedItem(true, true, defaultNamespace);
                                        }
                                        else {
                                            UnknownNode(null, @"http://www.cpandl.com:OrderedItem");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @"http://www.cpandl.com:OrderedItem");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations1, ref readerCount1);
                                }
                            ReadEndElement();
                            }
                            o.@OrderedItems = (global::uwpSerializer.OrderedItem[])ShrinkArray(a_2_0, ca_2_0, typeof(global::uwpSerializer.OrderedItem), false);
                        }
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id7_SubTotal && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@SubTotal = System.Xml.XmlConvert.ToDecimal(Reader.ReadElementContentAsString());
                        }
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id8_ShipCost && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@ShipCost = System.Xml.XmlConvert.ToDecimal(Reader.ReadElementContentAsString());
                        }
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id9_TotalCost && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@TotalCost = System.Xml.XmlConvert.ToDecimal(Reader.ReadElementContentAsString());
                        }
                        paramsRead[5] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.cpandl.com:ShipTo, http://www.cpandl.com:OrderDate, http://www.cpandl.com:Items, http://www.cpandl.com:SubTotal, http://www.cpandl.com:ShipCost, http://www.cpandl.com:TotalCost");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.cpandl.com:ShipTo, http://www.cpandl.com:OrderDate, http://www.cpandl.com:Items, http://www.cpandl.com:SubTotal, http://www.cpandl.com:ShipCost, http://www.cpandl.com:TotalCost");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        global::uwpSerializer.OrderedItem Read3_OrderedItem(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_OrderedItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwcpandlcom))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::uwpSerializer.OrderedItem o;
            o = new global::uwpSerializer.OrderedItem();
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id10_ItemName && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@ItemName = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id11_Description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@Description = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id12_UnitPrice && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@UnitPrice = System.Xml.XmlConvert.ToDecimal(Reader.ReadElementContentAsString());
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id13_Quantity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@Quantity = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                        }
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id14_LineTotal && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@LineTotal = System.Xml.XmlConvert.ToDecimal(Reader.ReadElementContentAsString());
                        }
                        paramsRead[4] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.cpandl.com:ItemName, http://www.cpandl.com:Description, http://www.cpandl.com:UnitPrice, http://www.cpandl.com:Quantity, http://www.cpandl.com:LineTotal");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.cpandl.com:ItemName, http://www.cpandl.com:Description, http://www.cpandl.com:UnitPrice, http://www.cpandl.com:Quantity, http://www.cpandl.com:LineTotal");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            ReadEndElement();
            return o;
        }

        global::uwpSerializer.Address Read2_Address(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_Address && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwcpandlcom))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::uwpSerializer.Address o;
            o = new global::uwpSerializer.Address();
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id16_Name && string.Equals(Reader.NamespaceURI, id17_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Name");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[1] && ((object) Reader.LocalName == (object)id18_Line1 && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@Line1 = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id19_City && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@City = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id20_State && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@State = Reader.ReadElementContentAsString();
                        }
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id21_Zip && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwcpandlcom))) {
                        {
                            o.@Zip = Reader.ReadElementContentAsString();
                        }
                        paramsRead[4] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://www.cpandl.com:Line1, http://www.cpandl.com:City, http://www.cpandl.com:State, http://www.cpandl.com:Zip");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://www.cpandl.com:Line1, http://www.cpandl.com:City, http://www.cpandl.com:State, http://www.cpandl.com:Zip");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id17_Item;
        string id15_Address;
        string id19_City;
        string id18_Line1;
        string id16_Name;
        string id5_Items;
        string id6_OrderedItem;
        string id7_SubTotal;
        string id4_OrderDate;
        string id21_Zip;
        string id8_ShipCost;
        string id10_ItemName;
        string id3_ShipTo;
        string id13_Quantity;
        string id1_PurchaseOrder;
        string id9_TotalCost;
        string id2_httpwwwcpandlcom;
        string id11_Description;
        string id20_State;
        string id14_LineTotal;
        string id12_UnitPrice;

        protected override void InitIDs() {
            id17_Item = Reader.NameTable.Add(@"");
            id15_Address = Reader.NameTable.Add(@"Address");
            id19_City = Reader.NameTable.Add(@"City");
            id18_Line1 = Reader.NameTable.Add(@"Line1");
            id16_Name = Reader.NameTable.Add(@"Name");
            id5_Items = Reader.NameTable.Add(@"Items");
            id6_OrderedItem = Reader.NameTable.Add(@"OrderedItem");
            id7_SubTotal = Reader.NameTable.Add(@"SubTotal");
            id4_OrderDate = Reader.NameTable.Add(@"OrderDate");
            id21_Zip = Reader.NameTable.Add(@"Zip");
            id8_ShipCost = Reader.NameTable.Add(@"ShipCost");
            id10_ItemName = Reader.NameTable.Add(@"ItemName");
            id3_ShipTo = Reader.NameTable.Add(@"ShipTo");
            id13_Quantity = Reader.NameTable.Add(@"Quantity");
            id1_PurchaseOrder = Reader.NameTable.Add(@"PurchaseOrder");
            id9_TotalCost = Reader.NameTable.Add(@"TotalCost");
            id2_httpwwwcpandlcom = Reader.NameTable.Add(@"http://www.cpandl.com");
            id11_Description = Reader.NameTable.Add(@"Description");
            id20_State = Reader.NameTable.Add(@"State");
            id14_LineTotal = Reader.NameTable.Add(@"LineTotal");
            id12_UnitPrice = Reader.NameTable.Add(@"UnitPrice");
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class PurchaseOrderSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"PurchaseOrder", this.DefaultNamespace ?? @"http://www.cpandl.com");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write5_PurchaseOrder(objectToSerialize, this.DefaultNamespace, @"http://www.cpandl.com");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read5_PurchaseOrder(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.IDictionary readMethods = null;
        public override System.Collections.IDictionary ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                    _tmp[@"uwpSerializer.PurchaseOrder:http://www.cpandl.com:PurchaseOrder:False:"] = @"Read5_PurchaseOrder";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.IDictionary writeMethods = null;
        public override System.Collections.IDictionary WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                    _tmp[@"uwpSerializer.PurchaseOrder:http://www.cpandl.com:PurchaseOrder:False:"] = @"Write5_PurchaseOrder";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.IDictionary typedSerializers = null;
        public override System.Collections.IDictionary TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, System.Xml.Serialization.XmlSerializer>();
                    _tmp.Add(@"uwpSerializer.PurchaseOrder:http://www.cpandl.com:PurchaseOrder:False:", new PurchaseOrderSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::uwpSerializer.PurchaseOrder)) return true;
            if (type == typeof(global::System.Reflection.TypeInfo)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::uwpSerializer.PurchaseOrder)) return new PurchaseOrderSerializer();
            return null;
        }
        public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public static class ActivatorHelper {
        public static object CreateInstance(System.Type type) {
            System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                    return ci.Invoke(null);
                }
            }
            return System.Activator.CreateInstance(type);
        }
    }
}
