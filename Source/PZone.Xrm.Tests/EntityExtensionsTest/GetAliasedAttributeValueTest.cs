using System;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;

namespace PZone.Xrm.Tests.EntityExtensionsTest
{
    [TestClass]
    public class GetAliasedAttributeValueTest
    {
        [TestMethod]
        public void ValueTypeNull()
        {
            var entity = new Entity();
            Assert.AreEqual(0, entity.GetAliasedAttributeValue<int>("link.int_value"));
            Assert.AreEqual(false, entity.GetAliasedAttributeValue<bool>("link.bool_value"));
        }


        [TestMethod]
        public void ValueType()
        {
            var entity = new Entity()
            {
                ["link.int_value"] = new AliasedValue("link", "int_value", 5),
                ["link.bool_value"] = new AliasedValue("link", "bool_value", true)
            };
            Assert.AreEqual(5, entity.GetAliasedAttributeValue<int>("link.int_value"));
            Assert.AreEqual(true, entity.GetAliasedAttributeValue<bool>("link.bool_value"));
        }


        [TestMethod]
        public void ObjectType()
        {
            var contactId = Guid.NewGuid();
            var entity = new Entity()
            {
                ["link.osv_value"] = new AliasedValue("link", "osv_value", new OptionSetValue(5)),
                ["link.er_value"] = new AliasedValue("link", "er_value", new EntityReference("contact", contactId))
            };
            Assert.AreEqual(5, entity.GetAliasedAttributeValue<OptionSetValue>("link.osv_value")?.Value);
            Assert.AreEqual(contactId, entity.GetAliasedAttributeValue<EntityReference>("link.er_value")?.Id);
        }
    }
}
