using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace op15.ConsoleApplication.Tests {
    public class PersonTests {
        [Fact]
        public void GivenANewPerson_WhenSettingSurnameShorterThan50_ThenSurnameShouldBeEqualToOriginalValue() {
            //GivenANewPerson
            Person p1 = new Person();
            string originalValue = "1234567890";
            //WhenSettingSurnameShorterThan50
            p1.Surname = originalValue;
            //ThenSurnameShouldBeEqualToOriginalValue
            Assert.Equal(originalValue, p1.Surname);
        }

        [Fact]
        public void GivenANewPerson_WhenSettingSurnameLongerThan50_ThenSurnameShouldBeEqualToFirst50CharsOfOriginalValue() {
            //GivenANewPerson
            Person p1 = new Person();
            string originalValue = "123456789012345678901234567890123456789012345678901234567890";
            string expected = originalValue.Substring(0, 50);
            //WhenSettingSurnameLongerThan50
            p1.Surname = originalValue;
            //ThenSurnameShouldBeEqualToFirst50CharsOfOriginalValue
            Assert.Equal(expected, p1.Surname);
        }
    }
}
