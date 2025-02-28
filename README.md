# 🍕 Pizza Ordering System

This is a simple console-based Pizza Ordering System built in C#. It allows customers to order pizzas with customizable size, base, toppings, and cheese. It also manages order details like customer information, order time, and delivery status.

## 📂 Project Structure

```
PizzaOrderingSystem/
|-- Program.cs                  // Main entry point for the application
|-- Pizza.cs                    // Pizza class, representing the pizza properties
|-- Order.cs                    // Order class, managing multiple pizzas and customer details
```

## 🛠 Features

- Add multiple pizzas to an order
- Customize pizza size, base, toppings, and cheese
- Capture customer name, address, and order time
- Calculate total order amount
- Simulate pizza delivery status

## 🖥 How It Works

1. The user is presented with a menu to place an order.
2. The user inputs their name and address.
3. The user selects the pizza size, base, toppings, and cheese type.
4. Orders are added and displayed with all the chosen options.
5. Option to modify load shedding stage (bonus feature).

## 📝 Issues and Improvements

- **Global Variables:** The use of global variables in `Program.cs` can be avoided.
- **Pizza Class:** Redundant properties and constructor parameters can be simplified.
- **Order Class:** `CreateTotal()` method has errors and needs proper implementation.
- **User Flow:** Needs a loop to let the user add more pizzas without re-entering personal details.
- **Error Handling:** Load shedding stage input could use more robust exception handling.

## 🚀 Getting Started

1. Clone the repository
2. Open the project in Visual Studio
3. Build and run the project

## 🧑‍💻 Author
**Gabriel Kyereahene Mensah**

---
Feel free to contribute and improve this project! 🍕

