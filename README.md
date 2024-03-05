## Lanchester Law Calculator

The Lanchester Law Calculator is a tool for simulating combat scenarios using Lanchester's Laws, which are mathematical models used to predict the outcomes of battles between opposing forces. This application implements three different variants of Lanchester's Laws: Linear, Square, and Universal.

### Features

- **Linear Lanchester Law**: Simulates combat between two forces with linear attrition rates.
- **Square Lanchester Law**: Simulates combat between two forces with quadratic attrition rates.
- **Universal Lanchester Law**: Simulates combat between two forces with asymmetric attrition rates.

### Technologies Used

- C#
- MVVM Pattern
- LiveCharts library for data visualization

### Project Structure

The project consists of several ViewModel classes responsible for managing the application's logic and UI, including:
- `MainViewModel`: Manages navigation between different types of Lanchester Laws.
- `LinearLanchesterLawViewModel`, `SquareLanchesterLawViewModel`, `UniversalLanchesterLawViewModel`: ViewModels for each type of Lanchester Law, handling user inputs and displaying simulation results.
- `ViewModelBase`: Base class for ViewModels, implementing the INotifyPropertyChanged interface.
- `NavigationStore`: Stores the current ViewModel and triggers events when it changes.

### Commands

The application utilizes custom `RelayCommand` classes for handling user interactions and navigation between different views.

### How to Use

1. Clone the repository.
2. Ensure you have the necessary dependencies installed.
3. Build and run the application.
4. Select the desired type of Lanchester Law from the main menu.
5. Enter the required parameters and click the "Calculate" button to simulate the battle.
6. View the results displayed using LiveCharts.

---

Feel free to contribute and enhance this project! If you encounter any issues or have suggestions, please create an issue or submit a pull request.
