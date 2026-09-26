# Discourse Chapter 2
# Week 2 - C# Processing Data

## Overview

This week's lesson introduces how to process data in a C# Windows Forms application.

We learned how to:

- Read user input using a TextBox control
- Create and use variables
- Work with string and numeric data types
- Perform arithmetic calculations
- Convert TextBox input into numeric values
- Display and format numeric values
- Handle runtime errors using `try-catch`
- Create named constants
- Declare variables as fields
- Use the `Math` class
- Work with GUI features such as tab order and access keys
- Use the Visual Studio debugger to find logic errors

---

## 1. Reading Input with TextBox Controls

A `TextBox` control is used to accept keyboard input from the user.

The value entered into a TextBox is stored in its `Text` property.

The following example shows how to assign text to a TextBox:

```csharp
textBox1.Text = "Hello";
```

To clear the contents of a TextBox, we can use:

```csharp
textBox1.Text = string.Empty;
```

or:

```csharp
textBox1.Clear();
```

---

## 2. Creating and Using Variables

A variable is a storage location in memory. Before a variable can be used, it must be declared with a data type.

The basic syntax is:

```csharp
DataType VariableName;
```

For example:

```csharp
string fullName;
```

Variable names should be meaningful. They cannot contain spaces and should not use C# keywords.

### String Variables

A `string` variable stores a combination of characters.

```csharp
string productDescription = "Jamhuuriya University";
```

A string can be displayed in a MessageBox:

```csharp
MessageBox.Show(productDescription);
```

### String Concatenation

Concatenation means joining one string to another. The `+` operator is used for concatenation.

```csharp
string firstName = "Ahmed";
string lastName = "Ali";

string fullName = firstName + " " + lastName;
```

The result can then be displayed in a Label:

```csharp
fullNameLabel.Text = fullName;
```

---

## 3. Local Variables and Scope

A local variable belongs to the method in which it is declared.

For example:

```csharp
private void firstButton_Click(object sender, EventArgs e)
{
    string myName;
    myName = nameTextBox.Text;
}
```

The variable `myName` can only be accessed inside that method.

We also learned that a variable must be assigned a value before it is used.

```csharp
string productDescription = "Jamhuuriya University";
MessageBox.Show(productDescription);
```

Multiple variables of the same type can be declared in one statement:

```csharp
string lastName, firstName, middleName;
```

---

## 4. Numeric Data Types

When a program needs to store numbers and perform calculations, numeric data types are used.

The main numeric types covered this week are:

- `int` - stores whole numbers
- `double` - stores real numbers, including fractional values
- `decimal` - stores real numbers with greater precision and is commonly used for financial values

Examples:

```csharp
int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;
```

A decimal literal uses `m` or `M`:

```csharp
decimal price = 28.75m;
```

---

## 5. Type Casting and the `var` Keyword

A cast operator can explicitly convert a value from one numeric type to another.

```csharp
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;
```

The `var` keyword can also be used when declaring and initializing a local variable.

```csharp
var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;
```

The compiler determines the data type from the value assigned to the variable.

---

## 6. Performing Calculations

C# provides arithmetic operators for performing calculations.

| Operator | Operation |
|---|---|
| `+` | Addition |
| `-` | Subtraction |
| `*` | Multiplication |
| `/` | Division |
| `%` | Modulus |

Example:

```csharp
int x = 5;
int y = 4;

int total = x + y;
```

Parentheses can be used to control the order of operations:

```csharp
result = (a + b) / 4;
```

### Integer Division

When two integers are divided, the result is an integer.

```csharp
int x = 7;
int y = 3;

MessageBox.Show((x / y).ToString());
```

The result is `2`.

To get a decimal result, one of the values can be converted to `double`:

```csharp
MessageBox.Show(((double)x / y).ToString());
```

---

## 7. Inputting and Outputting Numeric Values

TextBox input is always treated as a string, even when the user enters a number.

For example, the following input:

```text
25.65
```

is stored as a string in the TextBox.

To use the value in a calculation, it must be converted to a numeric type using a `Parse` method.

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

double temperature = double.Parse(temperatureTextBox.Text);

decimal price = decimal.Parse(priceTextBox.Text);
```

To display a numeric value in a Label or TextBox, the value can be converted to a string using `ToString()`.

```csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();
```

---

## 8. Formatting Numbers with `ToString()`

The `ToString()` method can format numbers so that they appear in a specific way.

Examples of format strings include:

```csharp
value.ToString("N3");
value.ToString("F2");
value.ToString("E3");
value.ToString("C");
value.ToString("P");
```

The main formats covered are:

- `N` - Number format
- `F` - Fixed-point format
- `E` - Exponential format
- `C` - Currency format
- `P` - Percentage format

For example:

```csharp
double value = 12.3;
MessageBox.Show(value.ToString("N3"));
```

---

## 9. Simple Exception Handling

An exception is an unexpected error that happens while a program is running.

Examples include:

- Dividing by zero
- Opening a file that does not exist
- Entering invalid user input

If an exception is not handled, the program can stop unexpectedly.

We learned to use `try-catch` to handle exceptions.

```csharp
try
{
    double miles = double.Parse(milesTextBox.Text);
    double gallons = double.Parse(gallonsTextBox.Text);

    double mpg = miles / gallons;

    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
```

The `try` block contains code that may cause an exception, while the `catch` block contains the code that responds to the exception.

An exception's default message can also be displayed:

```csharp
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

---

## 10. Using Named Constants

A named constant represents a value that cannot be changed while the program is running.

The `const` keyword is used to declare a constant.

```csharp
const double INTEREST_RATE = 0.129;
```

Using uppercase letters for constant names is a traditional naming convention.

---

## 11. Declaring Variables as Fields

A field is a variable declared at the class level.

It is declared inside the class but outside of any method.

```csharp
public partial class Form1 : Form
{
    private string name = "Charles";

    private void showNameButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(name);
    }
}
```

A field can be accessed by methods within the class.

---

## Summary

In Week 2, we learned how to process data in C# Windows Forms.

The main skills covered were:

- Reading input from TextBox controls
- Creating and using variables
- Working with strings and numeric data types
- Performing calculations
- Converting and displaying numeric values
- Formatting numbers
- Handling exceptions with `try-catch`
- Using constants and fields
- Using the `Math` class
- Managing GUI features
- Debugging programs and finding logic errors

These concepts help us build Windows Forms applications that can receive input, process data, display results, and handle errors.
