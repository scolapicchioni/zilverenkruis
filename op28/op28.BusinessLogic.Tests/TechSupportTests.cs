﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace op28.BusinessLogic.Tests {
    public class TechSupportTests {
        [Fact]
        public void GivenNewTechSupportAndPhoneWith3ContactsAndPhoneWithNoContacts_WhenCopyingContacts_ThenTargetPhoneShouldHave3Contacts() {
            //GivenNewTechSupport
            TechSupport techSupport = new TechSupport();
            //AndPhoneWith3Contacts
            Phone source = new Phone() { Brand = "Source", Model = "Phone" };
            ContactsApp sourceContacts = new ContactsApp();

            sourceContacts.Contacts.AddRange(new[] {
                new Contact() { Name="Mario", Surname="Super", PhoneNumber="06123123"},
                new Contact() { Name="Luigi", Surname="Super", PhoneNumber="06123124"},
                new Contact() { Name="Princess", Surname="Peach", PhoneNumber="06765765"}
            });
            source.AppDrawer.Install(sourceContacts);

            //AndPhoneWithNoContacts
            Phone target = new Phone() { Brand = "Target", Model = "Phone" };
            ContactsApp targetContacts = new ContactsApp();
            target.AppDrawer.Install(targetContacts);

            //WhenCopyingContacts
            techSupport.CopyContacts(source, target);

            //ThenTargetPhoneShouldHave3Contacts
            Assert.True(targetContacts.Contacts.Count == 3);
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
            ContactsApp sourceContacts = new ContactsApp();
            sourceContacts.Contacts.AddRange(new[] {s1, s2, s3});
            source.AppDrawer.Install(sourceContacts);

            //AndTargetPhoneWith2Contacts
            Phone target = new Phone() { Brand = "Target", Model = "Phone" };

            Contact t1 = new Contact() { Name = "Spider", Surname = "Man", PhoneNumber = "06555123" };
            Contact t2 = new Contact() { Name = "Bat", Surname = "Man", PhoneNumber = "06999876" };
            ContactsApp targetContacts = new ContactsApp();
            targetContacts.Contacts.AddRange(new[] {t1, t2});
            target.AppDrawer.Install(targetContacts);

            //WhenCopyingContacts
            techSupport.CopyContacts(source, target);

            //ThenTargetPhoneShouldHaveTargetPlusSourceContacts
            Assert.Collection(targetContacts.Contacts,
                item => {
                    Assert.Equal(t1.Name, item.Name);
                    Assert.Equal(t1.Surname, item.Surname);
                    Assert.Equal(t1.PhoneNumber, item.PhoneNumber);
                },
                item => {
                    Assert.Equal(t2.Name, item.Name);
                    Assert.Equal(t2.Surname, item.Surname);
                    Assert.Equal(t2.PhoneNumber, item.PhoneNumber);
                },
                item => {
                    Assert.Equal(s1.Name, item.Name);
                    Assert.Equal(s1.Surname, item.Surname);
                    Assert.Equal(s1.PhoneNumber, item.PhoneNumber);
                },
                item => {
                    Assert.Equal(s2.Name, item.Name);
                    Assert.Equal(s2.Surname, item.Surname);
                    Assert.Equal(s2.PhoneNumber, item.PhoneNumber);
                },
                item => {
                    Assert.Equal(s3.Name, item.Name);
                    Assert.Equal(s3.Surname, item.Surname);
                    Assert.Equal(s3.PhoneNumber, item.PhoneNumber);
                });
        }

        [Fact]
        public void GivenNewTechSupportAndSourcePhoneWithAContactAndTargetPhoneWithAContactWithSameNameAndPhoneNumber_WhenCopyingContacts_ThenTargetPhoneShouldHaveTargetPlusSourceContacts() {
            //GivenNewTechSupport
            TechSupport techSupport = new TechSupport();

            //AndSourcePhoneWithAContacts
            Contact s1 = new Contact() { Name = "Mario", Surname = "Super", PhoneNumber = "06123123" };
            
            Phone source = new Phone() { Brand = "Source", Model = "Phone" };
            ContactsApp sourceContacts = new ContactsApp();
            sourceContacts.Contacts.Add(s1);
            source.AppDrawer.Install(sourceContacts);

            //AndTargetPhoneWith2Contacts
            Phone target = new Phone() { Brand = "Target", Model = "Phone" };

            Contact t1 = new Contact() { Name = "Mario", Surname = "Super", PhoneNumber = "06123123" };
            ContactsApp targetContacts = new ContactsApp();
            targetContacts.Contacts.Add(t1);
            target.AppDrawer.Install(targetContacts);

            //WhenCopyingContacts
            techSupport.CopyContacts(source, target);

            //ThenTargetPhoneShouldHaveTargetPlusSourceContacts
            Assert.Collection(targetContacts.Contacts,
                item => {
                    Assert.Equal(t1.Name, item.Name);
                    Assert.Equal(t1.Surname, item.Surname);
                    Assert.Equal(t1.PhoneNumber, item.PhoneNumber);
                },
                item => {
                    Assert.Equal(s1.Name, item.Name);
                    Assert.Equal(s1.Surname, item.Surname);
                    Assert.Equal(s1.PhoneNumber, item.PhoneNumber);
                });
        }

        [Fact]
        public void GivenNewTechSupportAndSourcePhoneWithAContactAndTargetPhoneWithNoContact_WhenCopyingContacts_ThenContactInTargetShouldNotBeSameReference() {
            //GivenNewTechSupport
            TechSupport techSupport = new TechSupport();

            //AndSourcePhoneWithAContact
            Contact s1 = new Contact() { Name = "Mario", Surname = "Super", PhoneNumber = "06123123" };

            Phone source = new Phone() { Brand = "Source", Model = "Phone" };
            ContactsApp sourceContacts = new ContactsApp();
            sourceContacts.Contacts.Add(s1);
            source.AppDrawer.Install(sourceContacts);

            //AndTargetPhoneWithNoContact
            Phone target = new Phone() { Brand = "Target", Model = "Phone" };
            ContactsApp targetContacts = new ContactsApp();
            target.AppDrawer.Install(targetContacts);

            //WhenCopyingContacts
            techSupport.CopyContacts(source, target);

            //ThenContactInTargetShouldNotBeSameReference
            Assert.NotSame(s1, targetContacts.Contacts[0]);
        }
    }
}
