# Hangman Console Game

A classic Hangman word-guessing game implemented in C# as a console application.

## 📋 Overview

This is an interactive console-based Hangman game where players guess letters to reveal a hidden word before running out of chances. The game features customizable difficulty levels and word reveal settings.

## 🎮 How to Play

1. Start the game and choose whether to configure settings
2. Select your difficulty level (optional):
   - Different difficulty levels provide words of varying complexity
3. Choose how many letters to have pre-revealed (optional)
4. Guess letters one at a time by typing them
5. Try to reveal the complete word before the hangman is fully drawn
6. Win by guessing the word correctly, or lose when you run out of guesses
7. Play again or exit

## ⚙️ Features

- **Customizable Difficulty Levels**: Choose from different word categories and complexities
- **Adjustable Reveal Settings**: Start with some letters already visible
- **Interactive Gameplay**: Real-time feedback on correct and incorrect guesses
- **Visual Progress Tracking**: See your remaining chances and guessed letters
- **Replay Option**: Play multiple rounds without restarting the application

## 🛠️ Project Structure

```
hangman-console-csharp/
├── Hangman_final/
│   ├── Program.cs           # Main game logic and entry point
│   └── [Additional classes] # Game components
├── Hangman_final.sln        # Visual Studio solution file
├── global.json              # .NET SDK configuration
└── README.md                # This file
```

## 💻 Requirements

- .NET Framework (see `global.json` for version)
- C# compatible IDE (Visual Studio, Visual Studio Code) or .NET CLI

## 🚀 Getting Started

### Clone the Repository
```bash
git clone https://github.com/Abdullah-creator-alt/hangman-console-csharp.git
cd hangman-console-csharp
```

### Build and Run
```bash
# Using .NET CLI
dotnet build
dotnet run --project Hangman_final

# Or open Hangman_final.sln in Visual Studio and run
```

## 📝 License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE](LICENSE) file for details.

## 🤝 Contributing

Contributions are welcome! Feel free to:
- Report bugs by opening an issue
- Suggest improvements or new features
- Submit pull requests with enhancements

## 📧 Contact

For questions or feedback, please reach out through GitHub Issues.

---

**Happy guessing!** 🎯
