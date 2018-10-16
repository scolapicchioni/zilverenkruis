using System;
using Xunit;

namespace op26.BusinessLogic.Tests {
    public class ContactTests {
        [Fact]
        public void GivenNewContact_WhenSettingSurnameShorterThan50_ThenSurnameShouldBeEqualToTheGivenValue() {
            //GivenNewContact
            Contact c = new Contact();
            //WhenSettingSurnameShorterThan50
            string expected = "Simona";
            c.Surname = expected;
            //ThenSurnameShouldBeEqualToTheGivenValue
            Assert.Equal(expected, c.Surname);
        }

        [Fact]
        public void GivenNewContact_WhenSettingSurname50LettersLong_ThenSurnameShouldBeEqualToTheGivenValue() {
            //GivenNewContact
            Contact c = new Contact();
            //WhenSettingSurname50LettersLong
            string expected = "12345678901234567890123456789012345678901234567890";
            c.Surname = expected;
            //ThenSurnameShouldBeEqualToTheGivenValue
            Assert.Equal(expected, c.Surname);
        }

        [Fact]
        public void GivenNewContact_WhenSettingSurnameLongerThan50_ThenSurnameShouldBeEqualToTheFirst50LettersOfGivenValue() {
            //GivenNewContact
            Contact c = new Contact();
            //WhenSettingSurnameLongerThan50
            string given = "123456789012345678901234567890123456789012345678901234567890";
            c.Surname = given;
            //ThenSurnameShouldBeEqualToTheFirst50LettersOfGivenValue
            string expected = given.Substring(0,50);
            Assert.Equal(expected, c.Surname);
        }

        [Fact]
        public void GivenNewContact_WhenSettingNameShorterThan50_ThenNameShouldBeEqualToTheGivenValue() {
            //GivenNewContact
            Contact c = new Contact();
            //WhenSettingNameShorterThan50
            string expected = "Simona";
            c.Name = expected;
            //ThenNameShouldBeEqualToTheGivenValue
            Assert.Equal(expected, c.Name);
        }

        [Fact]
        public void GivenNewContact_WhenSettingName50LettersLong_ThenNameShouldBeEqualToTheGivenValue() {
            //GivenNewContact
            Contact c = new Contact();
            //WhenSettingName50LettersLong
            string expected = "12345678901234567890123456789012345678901234567890";
            c.Name = expected;
            //ThenNameShouldBeEqualToTheGivenValue
            Assert.Equal(expected, c.Name);
        }

        [Fact]
        public void GivenNewContact_WhenSettingNameLongerThan50_ThenNameShouldBeEqualToTheFirst50LettersOfGivenValue() {
            //GivenNewContact
            Contact c = new Contact();
            //WhenSettingNameLongerThan50
            string given = "123456789012345678901234567890123456789012345678901234567890";
            c.Name = given;
            //ThenNameShouldBeEqualToTheFirst50LettersOfGivenValue
            string expected = given.Substring(0, 50);
            Assert.Equal(expected, c.Name);
        }
    }
}
