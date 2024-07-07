public class MainContext {

    public GameContext gameContext;

    public MainContext() {
    }

    public void Inject(GameContext ctx) {
        gameContext = ctx;
    }

}