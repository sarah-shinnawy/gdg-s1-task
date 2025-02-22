# GDGHomework
# Simple Calculator in C#

This is a basic console-based **Calculator** application written in **C#**.  
It allows users to perform **addition, subtraction, multiplication, and division**.

## Features
- Supports **four basic arithmetic operations**: `+`, `-`, `*`, `/`
- **Input validation** to ensure only valid numbers are entered
- Prevents **division by zero** errors
- **Looping functionality** to allow multiple calculations
- User can **exit** by pressing `5`

## How to Run
1. Open the project in **Visual Studio**.
2. Press `F5` or click **Start** to run the application.
3. Follow the on-screen instructions:
   - Enter two numbers.
   - Choose an operation (`+`, `-`, `*`, `/`).
   - View the result.
   - Press `5` to exit or any other key to continue.

##  Example Usage
Enter the first number: 10  
Enter the second number: 5  
Enter operation: add (+), subtract (-), multiply (*), divide (/): +  
Result: 15  

Press '5' to exit or any other key to continue.  

##  Code Breakdown
- The main loop (`do-while`) **keeps running** until the user chooses to exit.
- **`int.TryParse()`** ensures the user enters valid numbers.
- A `switch` statement handles **the different operations**.
- **Separate methods** handle each calculation:
  ```csharp
  static int AddNumbers(int num1, int num2) => num1 + num2;
  static int SubtractNumbers(int num1, int num2) => num1 - num2;
  static int MultiplyNumbers(int num1, int num2) => num1 * num2;
  static int DivideNumbers(int num1, int num2) => num1 / num2;

 ## Future Improvements
Add support for floating-point numbers (double instead of int).  
Implement error handling for invalid operations.  
Create a GUI version using WinForms or WPF.  
