# UI Components

A **Form** has a collection of **Control**.

When you ***Draw*** a Form, the form scrolls through all its controls and invokes the ***Draw*** of each control.

A **Control** has a **Top**, **Left**, **Witdh**, **Height**, **BackgroundColor**, **ForegroundColor** and it can ***Draw***.

There are two types of controls: **Label** and **TextBox**.

The ***Draw*** of a **Label** draws a single border around the text.

The ***Draw*** of a **TextBox** draws a double border around the text.

A **TextBox** also has an ***Input*** method, that positions the Console cursor at the beginning of the textbox, waits for the user to type and returns the user input.

```

  ----------------------            ---------------------------------
  |        FORM         |           | CONTROL                       |
  ----------------------            ---------------------------------
  | Controls: Control[] |<>---------| Top: int                      |
  |----------------------           | Left: int                     |
  | Draw(): void        |           | Width: int                    |
  -----------------------           | Height: int                   |
                                    | Text: string                  |
                                    | BackgroundColor: ConsoleColor |
                                    | ForegroundColor: ConsoleColor |
                                    |-------------------------------|
                                    | Draw(): void                  |
                                    ---------------------------------
                                                    /\
                                                   ----
                                                     |
                                         ------------------------
                                         |                       |
                                         |                       |
                           ----------------                 -----------------
                           | LABEL         |               | TEXTBOX         |
                           ----------------                ------------------
                           |               |               |                 |
                           -----------------               ------------------
                           | Draw(): void  |               | Draw(): void    |
                           -----------------               | Input(): string |
                                                           -------------------

``` 