# Practice

- As a user I want to bring two phones to the TechSupport so that they Copy the Contacts from one Phone to the other 

- A Contact should have Name, Surname and PhoneNumber
  - A name should never be longer than 50 letters
  - A surname should never be longer than 50 letters
  - A PhoneNumber should accept letters such as `.`, `-`, `(`, `)` and so on

- A Phone should have a list of Contacts
  - The list of contact should have no limitation rather than the memory limit of the device
- The target phone may already have contacts
  - The target contacts should not be deleted
  - The source contacts should be added to the existing contacts
- The target phone may already have a contacts present in the source phone
  - The target phone should then hold both the contacts without mergin them
- After having copied the contacts, changing a contact property in one of the phones should not affect the contacts in the other phone

## Classes

- `Contact`
- `Phone`
- `TechSupport`

### Contact
- `Name`: `string(50)`
- `Surname`: `string(50)`
- `PhoneNumber`: `string`

### Phone
- `Brand`: `string`
- `Model`: `string`
- `Contacts`: `List<Contact>`

### TechSupport
- `CopyContacts(source: Phone, target: Phone): void`
