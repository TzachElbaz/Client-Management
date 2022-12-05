using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Schema;

namespace client_management
{
    class ClientEditor : IClient
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
        private const string xmlFile = "clients.xml";
        XmlSchemaSet xsdSchema = new XmlSchemaSet();


        public void addClient(Client c)
        {
            xsdSchema.Add("", @"../../../Client_validator.xsd");
            XDocument xdoc = XDocument.Load(xmlFile);

            var targetClient = xdoc.Root.Descendants("Client").FirstOrDefault(cl =>
            cl.Element("phoneNumber").Value == c.phoneNumber);
            if (targetClient != null)
            {
                throw new Exception("This phone number already exists");
            }

            XElement xClient = new XElement("Client");
            List<XElement> childrenElements = new List<XElement>();
            childrenElements.Add(new XElement("firstName", c.firstName));
            childrenElements.Add(new XElement("lastName", c.lastName));
            childrenElements.Add(new XElement("phoneNumber", c.phoneNumber));
            childrenElements.Add(new XElement("emailAddress", c.emailAddress));
            xClient.Add(childrenElements);
            xdoc.Root.Add(xClient);
            xdoc.Validate(xsdSchema, (s, e) =>
             {
                 throw new Exception(e.Message);
             });
            xdoc.Save(xmlFile);
        }

        public void deleteClient(string selectedClient)
        {
            var xdoc = XDocument.Load(xmlFile);
            var targetClient = xdoc.Root.Descendants("Client").FirstOrDefault(c =>
            c.Element("phoneNumber").Value == selectedClient);
            targetClient.Remove();
            xdoc.Save(xmlFile);
        }

        public List<Client> getAllClients()
        {
            FileStream stream = new FileStream(xmlFile, FileMode.Open, FileAccess.Read);
            List<Client> lc = (List<Client>)serializer.Deserialize(stream);
            stream.Close();
            return lc;
        }

        public void updateData(string selectedClient, int indexToUpdate, string newValue)
        {
            xsdSchema.Add("", @"../../../Client_validator.xsd");
            var xdoc = XDocument.Load(xmlFile);
            var targetClient = xdoc.Root.Descendants("Client").FirstOrDefault(c =>
            c.Element("phoneNumber").Value == selectedClient);

            switch (indexToUpdate)
            {
                case 0: // First name
                    var targetFirstName = targetClient.Descendants("firstName").FirstOrDefault();
                    targetFirstName.Value = newValue;
                    xdoc.Save(xmlFile);
                    break;
                case 1: // Last name
                    var targetLastName = targetClient.Descendants("lastName").FirstOrDefault();
                    targetLastName.Value = newValue;
                    xdoc.Save(xmlFile);
                    break;
                case 2: // Phone number
                    var targetPhoneNumber = targetClient.Descendants("phoneNumber").FirstOrDefault();
                    targetPhoneNumber.Value = newValue;
                    xdoc.Validate(xsdSchema, (s, e) =>
                    {
                        throw new Exception(e.Message);
                    });
                    xdoc.Save(xmlFile);
                    break;
                case 3: // Email address
                    var targetEmail = targetClient.Descendants("emailAddress").FirstOrDefault();
                    targetEmail.Value = newValue;
                    xdoc.Validate(xsdSchema, (s, e) =>
                    {
                        throw new Exception(e.Message);
                    });
                    xdoc.Save(xmlFile);
                    break;
            }
        }

    }
}
