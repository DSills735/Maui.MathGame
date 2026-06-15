using Maui.MathGame.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Maui.MathGame
{
    public partial class App : Application
    {
        public static GameRepository GameRepository { get; private set; }
        public App(GameRepository gameRepository)
        {
            InitializeComponent();
            GameRepository = gameRepository;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}