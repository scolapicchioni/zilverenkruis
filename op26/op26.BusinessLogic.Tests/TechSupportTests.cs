using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace op26.BusinessLogic.Tests {
    public class TechSupportTests {
        [Fact]
        public void GivenNewTechSupportAndPhoneWith3ContactsAndPhoneWithNoContacts_WhenCopyingContacts_ThenTargetPhoneShouldHave3Contacts() {
            //GivenNewTechSupport
            TechSupport techSupport = new TechSupport();
            //AndPhoneWith3Contacts
            Phone source = new Phone() { Brand = "Source", Model = "Phone" };
            source.Contacts.AddRange(new[] {
                new Contact() { Name="Mario", Surname="Super", PhoneNumber="06123123"},
                new Contact() { Name="Luigi", Surname="Super", PhoneNumber="06123124"},
                new Contact() { Name="Princess", Surname="Peach", PhoneNumber="06765765"}
            });

            //AndPhoneWithNoContacts
            Phone target = new Phone() { Brand = "Target", Model = "Phone" };

            //WhenCopyingContacts
            techSupport.CopyContacts(source, target);

            //ThenTargetPhoneShouldHave3Contacts
            Assert.True(target.Contacts.Count == 3);
        }

        [Fact]
        public void GivenNewTechSupportAndSourcePhoneWith3ContactsAndTargetPhoneWith2Contacts_WhenCopyingContacts_ThenTargetPhoneShouldHaveTargetPlusSourceContacts() {
            //GivenNewTechSupport
            TechSupport techSupport = new TechSupport();

            //AndSourcePhoneWith3Contacts
            Contact s1 = new Contact() { Name = "Mario", Surname = "Super", PhoneNumber = "06123123" };
            Contact s2 = new Contact() { Name = "Luigi", Surname = "Super", PhoneNumber = "06123124" };
            Contact s3 = new Contact() { Name = "Princess", Surname = "Peach", PhoneNumber = "06765765" };

            Phone source = new Phone() { Brand = "Source", Model = "Phone" };
            source.Contacts.AddRange(new[] {s1, s2, s3});

            //AndTargetPhoneWith2Contacts
            Phone target = new Phone() { Brand = "Target", Model = "Phone" };

            Contact t1 = new Contact() { Name = "Spider", Surname = "Man", PhoneNumber = "06555123" };
            Contact t2 = new Contact() { Name = "Bat", Surname = "Man", PhoneNumber = "06999876" };

            target.Contacts.AddRange(new[] {t1, t2});
            
            //WhenCopyingContacts
            techSupport.CopyContacts(source, target);

            //ThenTargetPhoneShouldHaveTargetPlusSourceContacts
            Assert.Collection(target.Contacts,
                item => {
                    Assert.Equal(t1, item);
                },
                item => {
                    Assert.Equal(t2, item);
                },
                item => {
                    Assert.Equal(s1, item);
                },
                item => {
                    Assert.Equal(s2, item);
                },
                item => {
                    Assert.Equal(s3, item);
                });
        }

        [Fact]
        public void GivenNewTechSupportAndSourcePhoneWithAContactAndTargetPhoneWithAContactWithSameNameAndPhoneNumber_WhenCopyingContacts_ThenTargetPhoneShouldHaveTargetPlusSourceContacts() {
            //GivenNewTechSupport
            TechSupport techSupport = new TechSupport();

            //AndSourcePhoneWithAContacts
            Contact s1 = new Contact() { Name = "Mario", Surname = "Super", PhoneNumber = "06123123" };
            
            Phone source = new Phone() { Brand = "Source", Model = "Phone" };
            source.Contacts.Add(s1);

            //AndTargetPhoneWith2Contacts
            Phone target = new Phone() { Brand = "Target", Model = "Phone" };

            Contact t1 = new Contact() { Name = "Mario", Surname = "Super", PhoneNumber = "06123123" };

            target.Contacts.Add(t1);

            //WhenCopyingContacts
            techSupport.CopyContacts(source, target);

            //ThenTargetPhoneShouldHaveTargetPlusSourceContacts
            Assert.Collection(target.Contacts,
                item => {
                    Assert.Equal(t1, item);
                },
                item => {
                    Assert.Equal(s1, item);
                });
        }

        [Fact]
        public void GivenNewTechSupportAndSourcePhoneWithAContactAndTargetPhoneWithNoContact_WhenCopyingContacts_ThenContactInTargetShouldNotBeSameReference() {
            //GivenNewTechSupport
            TechSupport techSupport = new TechSupport();

            //AndSourcePhoneWithAContact
            Contact s1 = new Contact() { Name = "Mario", Surname = "Super", PhoneNumber = "06123123" };

            Phone source = new Phone() { Brand = "Source", Model = "Phone" };
            source.Contacts.Add(s1);

            //AndTargetPhoneWithNoContact
            Phone target = new Phone() { Brand = "Target", Model = "Phone" };

            //WhenCopyingContacts
            techSupport.CopyContacts(source, target);

            //ThenContactInTargetShouldNotBeSameReference
            Assert.NotSame(s1, target.Contacts[0]);
        }
    }
}
